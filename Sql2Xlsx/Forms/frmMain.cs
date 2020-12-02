#region Dependencies
using ICSharpCode.TextEditor.Document;
using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
#endregion

namespace Sql2Xlsx
{
    public partial class frmMain : Form
    {

        #region Fields
        public string SqlConnection { get; set; }
        Thread thread;
        private bool isWorking = false;
        private delegate void BindDataSetToDataGridDelegate(DataSet ds);
        DataTable orderTable;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
            SetSyntax();

            panelPropertyGrid.Visible = false;
            tableMainLayout.Width += panelPropertyGrid.Width;
        }
        #endregion

        #region Functions
        internal void SetSyntax()
        {
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new AppSyntaxModeProvider());
            teSqlQuery.SetHighlighting("SQL");
        }

        private void AsyncFillDataSet()
        {
            try
            {
                DataSet ds = new DataSet("Source");

                SqlDataAdapter da;

                da = new SqlDataAdapter(teSqlQuery.Text, Forms.frmSqlConnect.SqlConnection);
                orderTable = new DataTable("SqlTable");
                da.FillSchema(orderTable, SchemaType.Source);
                da.Fill(orderTable);
                ds.Tables.Add(orderTable);

                AppendCrossThreadControl("DataTable being populated.  Please wait.", txtSqlConsole);
                BeginInvoke(new BindDataSetToDataGridDelegate(BindDataSetToDataGrid), new object[] { ds });

                // Set flag indicating that the async fill is complete.
                isWorking = false;
                AppendCrossThreadControl("", txtSqlConsole);
            }
            catch (Exception ex)
            {
                AppendCrossThreadControl(ex.Message, txtSqlConsole);
                isWorking = false;
                thread.Abort();
            }
        }

        private void BindDataSetToDataGrid(DataSet ds)
        {
            dgvSqlOutput.DataSource = ds.Tables["SqlTable"].DefaultView;
        }

        public void AppendCrossThreadControl(string value, Control control)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string, Control>(AppendCrossThreadControl), new object[] { value, control });
                return;
            }
            control.Text = value + Environment.NewLine;
        }
        #endregion

        #region Events
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Forms.frmSqlConnect sql = new Forms.frmSqlConnect())
            {
                sql.ShowDialog();
            }
        }

        private void hideShowPropertyGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelPropertyGrid.Visible == true)
            {
                panelPropertyGrid.Visible = false;
                tableMainLayout.Width += panelPropertyGrid.Width;
            }
            else
            {
                MessageBox.Show("Note, this is an 'advanced' feature.  Please be careful with the attributes that you change, as it may break the program and require a restart.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelPropertyGrid.Visible = true;
                tableMainLayout.Width -= panelPropertyGrid.Width;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sql2Xlsx is a tool allowing you to export data from Microsoft SQL Server to Microsoft Excel XLSX opposed to using CSV.  Created by Laim McKenzie, https://laim.scot", "About", MessageBoxButtons.OK);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the DataSet is already being filled.
                if (!isWorking)
                {
                    AppendCrossThreadControl(string.Empty, txtSqlConsole);
                    isWorking = true;

                    // Clear the data grid.
                    dgvSqlOutput.DataSource = null;

                    // Create and start a new thread to fill the DataSet.
                    thread = new Thread(new ThreadStart(AsyncFillDataSet));
                    thread.Start();
                }
                else
                {
                    // DataSet already being filled. Display a message.
                    AppendCrossThreadControl("DataSet is already being populated.", txtSqlConsole);
                }

            }
            catch (Exception ex)
            {
                AppendCrossThreadControl(ex.Message, txtSqlConsole);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // create a work book and add the duj data into their own seperate sheets
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage pck = new ExcelPackage(
                    new FileInfo(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDocuments) + @"\Sql2Xlsx\" + Guid.NewGuid().ToString("D") + ".xlsx")
                    ))
                {
                    pck.Workbook.Worksheets.Add("Report").Cells["A1"].LoadFromDataTable(orderTable, true);
                    pck.Workbook.Properties.Author = "Laim McKenzie <me@laim.scot>";
                    pck.Workbook.Properties.Application = "Sql2Xlsx";
                    pck.Workbook.Properties.Company = "https://laim.scot";
                    pck.Save();
                }
                txtSqlConsole.ForeColor = Color.Green;
                AppendCrossThreadControl("Report exported to User Documents.", txtSqlConsole);
                txtSqlConsole.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                AppendCrossThreadControl(ex.Message, txtSqlConsole);
            }
        }

        #endregion

        private void dgvSqlOutput_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            bool Handle;
            if(dgvSqlOutput.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(DBNull.Value))
            {
                Handle = true;
            } else
            {
                Handle = false;
            }
            e.Cancel = Handle;
        }
    }
}

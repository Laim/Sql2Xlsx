#region Dependencies
using Laim;
using System;
using System.Windows.Forms;
#endregion

namespace Sql2Xlsx.Forms
{
    public partial class frmSqlConnect : Form
    {

        #region Fields
        public static string SqlConnection { get; set; }
        #endregion

        #region Constructor
        public frmSqlConnect()
        {
            InitializeComponent();
            GetSqlServers();
        }
        #endregion

        #region Functions
        private void GetSqlServers()
        {
            try
            {
                foreach (var i in MSSqlServer.GetServerList())
                {
                    cbSqlServer.Items.Add(i);
                }
            }
            catch
            {
                // do nothing
            }
        }
        #endregion

        #region Events
        private void cbSqlWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                txtSqlUsername.Enabled = false;
                txtSqlPassword.Enabled = false;
            }
            else
            {
                txtSqlUsername.Enabled = true;
                txtSqlPassword.Enabled = true;
            }
        }

        private void lblMSTrademark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is not created nor endorsed by Microsoft.  Microsoft SQL Server and it's logo are trademarked by Microsoft, Inc. and are being used purely to show which SQL Server is supported with this tool.", "Trademark Notice", MessageBoxButtons.OK);
        }

        private void btnSqlConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSqlServer.Text.Length > 0 || txtSqlPassword.Text.Length > 0 || txtSqlUsername.Text.Length > 0)
                {

                    if (cbSqlWindowsAuth.Checked == true)
                    { SqlConnection = "Data Source=" + cbSqlServer.Text + ";Application Name=Sql2Xlsx;Integrated Security=SSPI"; }
                    else
                    { SqlConnection = "Data Source=" + cbSqlServer.Text + ";Application Name=Sql2Xlsx;User=" + txtSqlUsername.Text + ";Password=" + txtSqlPassword.Text; }

                    if (MSSqlServer.CheckConnnection(SqlConnection) == true)
                    { MessageBox.Show("Connection Successful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
                    else
                    { MessageBox.Show("Connection Unsuccessful", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                else
                {
                    MessageBox.Show("One of the required fields are empty.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}

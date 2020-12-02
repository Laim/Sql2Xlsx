
namespace Sql2Xlsx
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideShowPropertyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSqlOutput = new System.Windows.Forms.DataGridView();
            this.teSqlQuery = new ICSharpCode.TextEditor.TextEditorControl();
            this.txtSqlConsole = new System.Windows.Forms.TextBox();
            this.panelPropertyGrid = new System.Windows.Forms.Panel();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStripMain.SuspendLayout();
            this.tableMainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlOutput)).BeginInit();
            this.panelPropertyGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.runToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.hideShowPropertyGridToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(981, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.runToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.runToolStripMenuItem.Text = "Run (F5)";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.saveAsToolStripMenuItem.Text = "Save (CTRL+S)";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // hideShowPropertyGridToolStripMenuItem
            // 
            this.hideShowPropertyGridToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.hideShowPropertyGridToolStripMenuItem.AutoSize = false;
            this.hideShowPropertyGridToolStripMenuItem.Name = "hideShowPropertyGridToolStripMenuItem";
            this.hideShowPropertyGridToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.hideShowPropertyGridToolStripMenuItem.Text = "Hide/Show Properties";
            this.hideShowPropertyGridToolStripMenuItem.Click += new System.EventHandler(this.hideShowPropertyGridToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableMainLayout
            // 
            this.tableMainLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMainLayout.ColumnCount = 1;
            this.tableMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMainLayout.Controls.Add(this.dgvSqlOutput, 0, 1);
            this.tableMainLayout.Controls.Add(this.teSqlQuery, 0, 0);
            this.tableMainLayout.Controls.Add(this.txtSqlConsole, 0, 2);
            this.tableMainLayout.Location = new System.Drawing.Point(0, 27);
            this.tableMainLayout.Name = "tableMainLayout";
            this.tableMainLayout.RowCount = 3;
            this.tableMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableMainLayout.Size = new System.Drawing.Size(704, 529);
            this.tableMainLayout.TabIndex = 1;
            // 
            // dgvSqlOutput
            // 
            this.dgvSqlOutput.AllowUserToAddRows = false;
            this.dgvSqlOutput.AllowUserToDeleteRows = false;
            this.dgvSqlOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSqlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSqlOutput.EnableHeadersVisualStyles = false;
            this.dgvSqlOutput.Location = new System.Drawing.Point(3, 157);
            this.dgvSqlOutput.Name = "dgvSqlOutput";
            this.dgvSqlOutput.ReadOnly = true;
            this.dgvSqlOutput.ShowCellErrors = false;
            this.dgvSqlOutput.ShowCellToolTips = false;
            this.dgvSqlOutput.ShowEditingIcon = false;
            this.dgvSqlOutput.ShowRowErrors = false;
            this.dgvSqlOutput.Size = new System.Drawing.Size(698, 236);
            this.dgvSqlOutput.TabIndex = 0;
            this.dgvSqlOutput.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSqlOutput_DataError);
            // 
            // teSqlQuery
            // 
            this.teSqlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teSqlQuery.IsReadOnly = false;
            this.teSqlQuery.Location = new System.Drawing.Point(3, 3);
            this.teSqlQuery.Name = "teSqlQuery";
            this.teSqlQuery.ShowVRuler = false;
            this.teSqlQuery.Size = new System.Drawing.Size(698, 148);
            this.teSqlQuery.TabIndex = 1;
            // 
            // txtSqlConsole
            // 
            this.txtSqlConsole.BackColor = System.Drawing.Color.White;
            this.txtSqlConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSqlConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSqlConsole.ForeColor = System.Drawing.Color.Red;
            this.txtSqlConsole.Location = new System.Drawing.Point(3, 399);
            this.txtSqlConsole.Multiline = true;
            this.txtSqlConsole.Name = "txtSqlConsole";
            this.txtSqlConsole.ReadOnly = true;
            this.txtSqlConsole.Size = new System.Drawing.Size(698, 127);
            this.txtSqlConsole.TabIndex = 2;
            // 
            // panelPropertyGrid
            // 
            this.panelPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPropertyGrid.Controls.Add(this.propertyGrid1);
            this.panelPropertyGrid.Location = new System.Drawing.Point(707, 27);
            this.panelPropertyGrid.Name = "panelPropertyGrid";
            this.panelPropertyGrid.Size = new System.Drawing.Size(274, 529);
            this.panelPropertyGrid.TabIndex = 2;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.teSqlQuery;
            this.propertyGrid1.Size = new System.Drawing.Size(274, 529);
            this.propertyGrid1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 581);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelPropertyGrid);
            this.Controls.Add(this.tableMainLayout);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(997, 620);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql2Xlsx";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tableMainLayout.ResumeLayout(false);
            this.tableMainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSqlOutput)).EndInit();
            this.panelPropertyGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableMainLayout;
        private System.Windows.Forms.DataGridView dgvSqlOutput;
        private ICSharpCode.TextEditor.TextEditorControl teSqlQuery;
        private System.Windows.Forms.Panel panelPropertyGrid;
        private System.Windows.Forms.ToolStripMenuItem hideShowPropertyGridToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSqlConsole;
    }
}


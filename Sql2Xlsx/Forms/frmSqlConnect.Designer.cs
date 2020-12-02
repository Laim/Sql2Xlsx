
namespace Sql2Xlsx.Forms
{
    partial class frmSqlConnect
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
            this.lblSqlServer = new System.Windows.Forms.Label();
            this.txtSqlUsername = new System.Windows.Forms.TextBox();
            this.lblSqlUsername = new System.Windows.Forms.Label();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.lblSqlPassword = new System.Windows.Forms.Label();
            this.btnSqlConnect = new System.Windows.Forms.Button();
            this.cbSqlWindowsAuth = new System.Windows.Forms.CheckBox();
            this.pbSqlImage = new System.Windows.Forms.PictureBox();
            this.lblMSTrademark = new System.Windows.Forms.Label();
            this.cbSqlServer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSqlImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSqlServer
            // 
            this.lblSqlServer.AutoSize = true;
            this.lblSqlServer.Location = new System.Drawing.Point(20, 60);
            this.lblSqlServer.Name = "lblSqlServer";
            this.lblSqlServer.Size = new System.Drawing.Size(65, 13);
            this.lblSqlServer.TabIndex = 0;
            this.lblSqlServer.Text = "SQL Server:";
            // 
            // txtSqlUsername
            // 
            this.txtSqlUsername.Location = new System.Drawing.Point(91, 83);
            this.txtSqlUsername.Name = "txtSqlUsername";
            this.txtSqlUsername.Size = new System.Drawing.Size(269, 20);
            this.txtSqlUsername.TabIndex = 2;
            // 
            // lblSqlUsername
            // 
            this.lblSqlUsername.AutoSize = true;
            this.lblSqlUsername.Location = new System.Drawing.Point(27, 86);
            this.lblSqlUsername.Name = "lblSqlUsername";
            this.lblSqlUsername.Size = new System.Drawing.Size(58, 13);
            this.lblSqlUsername.TabIndex = 3;
            this.lblSqlUsername.Text = "Username:";
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(91, 109);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.Size = new System.Drawing.Size(269, 20);
            this.txtSqlPassword.TabIndex = 4;
            this.txtSqlPassword.UseSystemPasswordChar = true;
            // 
            // lblSqlPassword
            // 
            this.lblSqlPassword.AutoSize = true;
            this.lblSqlPassword.Location = new System.Drawing.Point(27, 112);
            this.lblSqlPassword.Name = "lblSqlPassword";
            this.lblSqlPassword.Size = new System.Drawing.Size(56, 13);
            this.lblSqlPassword.TabIndex = 5;
            this.lblSqlPassword.Text = "Password:";
            // 
            // btnSqlConnect
            // 
            this.btnSqlConnect.Location = new System.Drawing.Point(285, 153);
            this.btnSqlConnect.Name = "btnSqlConnect";
            this.btnSqlConnect.Size = new System.Drawing.Size(75, 23);
            this.btnSqlConnect.TabIndex = 6;
            this.btnSqlConnect.Text = "Connect";
            this.btnSqlConnect.UseVisualStyleBackColor = true;
            this.btnSqlConnect.Click += new System.EventHandler(this.btnSqlConnect_Click);
            // 
            // cbSqlWindowsAuth
            // 
            this.cbSqlWindowsAuth.AutoSize = true;
            this.cbSqlWindowsAuth.Location = new System.Drawing.Point(91, 135);
            this.cbSqlWindowsAuth.Name = "cbSqlWindowsAuth";
            this.cbSqlWindowsAuth.Size = new System.Drawing.Size(141, 17);
            this.cbSqlWindowsAuth.TabIndex = 7;
            this.cbSqlWindowsAuth.Text = "Windows Authentication";
            this.cbSqlWindowsAuth.UseVisualStyleBackColor = true;
            this.cbSqlWindowsAuth.CheckedChanged += new System.EventHandler(this.cbSqlWindowsAuth_CheckedChanged);
            // 
            // pbSqlImage
            // 
            this.pbSqlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSqlImage.Image = global::Sql2Xlsx.Properties.Resources.sql;
            this.pbSqlImage.Location = new System.Drawing.Point(0, 0);
            this.pbSqlImage.Name = "pbSqlImage";
            this.pbSqlImage.Size = new System.Drawing.Size(397, 50);
            this.pbSqlImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSqlImage.TabIndex = 8;
            this.pbSqlImage.TabStop = false;
            // 
            // lblMSTrademark
            // 
            this.lblMSTrademark.AutoSize = true;
            this.lblMSTrademark.ForeColor = System.Drawing.Color.Red;
            this.lblMSTrademark.Location = new System.Drawing.Point(293, 19);
            this.lblMSTrademark.Name = "lblMSTrademark";
            this.lblMSTrademark.Size = new System.Drawing.Size(92, 13);
            this.lblMSTrademark.TabIndex = 9;
            this.lblMSTrademark.Text = "Trademark Notice";
            this.lblMSTrademark.Click += new System.EventHandler(this.lblMSTrademark_Click);
            // 
            // cbSqlServer
            // 
            this.cbSqlServer.FormattingEnabled = true;
            this.cbSqlServer.Location = new System.Drawing.Point(91, 57);
            this.cbSqlServer.Name = "cbSqlServer";
            this.cbSqlServer.Size = new System.Drawing.Size(269, 21);
            this.cbSqlServer.TabIndex = 10;
            // 
            // frmSqlConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(397, 198);
            this.Controls.Add(this.cbSqlServer);
            this.Controls.Add(this.lblMSTrademark);
            this.Controls.Add(this.pbSqlImage);
            this.Controls.Add(this.cbSqlWindowsAuth);
            this.Controls.Add(this.btnSqlConnect);
            this.Controls.Add(this.lblSqlPassword);
            this.Controls.Add(this.txtSqlPassword);
            this.Controls.Add(this.lblSqlUsername);
            this.Controls.Add(this.txtSqlUsername);
            this.Controls.Add(this.lblSqlServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSqlConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pbSqlImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSqlServer;
        private System.Windows.Forms.TextBox txtSqlUsername;
        private System.Windows.Forms.Label lblSqlUsername;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.Label lblSqlPassword;
        private System.Windows.Forms.Button btnSqlConnect;
        private System.Windows.Forms.CheckBox cbSqlWindowsAuth;
        private System.Windows.Forms.PictureBox pbSqlImage;
        private System.Windows.Forms.Label lblMSTrademark;
        private System.Windows.Forms.ComboBox cbSqlServer;
    }
}
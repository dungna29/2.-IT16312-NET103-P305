
namespace BAI_1_2_CRUD_ACCOUNT.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lbl_DangKy = new System.Windows.Forms.LinkLabel();
            this.lbl_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Acc = new System.Windows.Forms.TextBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.lbl_fileNamePath = new System.Windows.Forms.Label();
            this.lbl_checkdata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DangKy
            // 
            this.lbl_DangKy.AutoSize = true;
            this.lbl_DangKy.Location = new System.Drawing.Point(279, 160);
            this.lbl_DangKy.Name = "lbl_DangKy";
            this.lbl_DangKy.Size = new System.Drawing.Size(111, 29);
            this.lbl_DangKy.TabIndex = 13;
            this.lbl_DangKy.TabStop = true;
            this.lbl_DangKy.Text = "Đăng ký?";
            this.lbl_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_DangKy_LinkClicked);
            // 
            // lbl_QuenMatKhau
            // 
            this.lbl_QuenMatKhau.AutoSize = true;
            this.lbl_QuenMatKhau.Location = new System.Drawing.Point(205, 131);
            this.lbl_QuenMatKhau.Name = "lbl_QuenMatKhau";
            this.lbl_QuenMatKhau.Size = new System.Drawing.Size(186, 29);
            this.lbl_QuenMatKhau.TabIndex = 12;
            this.lbl_QuenMatKhau.TabStop = true;
            this.lbl_QuenMatKhau.Text = "Quên mật khẩu?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tài khoản: ";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(284, 192);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(106, 42);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_Pass.Location = new System.Drawing.Point(210, 93);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(180, 35);
            this.txt_Pass.TabIndex = 8;
            this.txt_Pass.Text = "1";
            // 
            // txt_Acc
            // 
            this.txt_Acc.Location = new System.Drawing.Point(210, 52);
            this.txt_Acc.Name = "txt_Acc";
            this.txt_Acc.Size = new System.Drawing.Size(180, 35);
            this.txt_Acc.TabIndex = 7;
            this.txt_Acc.Text = "dungna";
            this.txt_Acc.TextChanged += new System.EventHandler(this.txt_Acc_TextChanged);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(12, 270);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(133, 42);
            this.btn_OpenFile.TabIndex = 14;
            this.btn_OpenFile.Text = "Mở data";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // lbl_fileNamePath
            // 
            this.lbl_fileNamePath.AutoSize = true;
            this.lbl_fileNamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fileNamePath.Location = new System.Drawing.Point(12, 315);
            this.lbl_fileNamePath.Name = "lbl_fileNamePath";
            this.lbl_fileNamePath.Size = new System.Drawing.Size(51, 20);
            this.lbl_fileNamePath.TabIndex = 15;
            this.lbl_fileNamePath.Text = "label3";
            // 
            // lbl_checkdata
            // 
            this.lbl_checkdata.AutoSize = true;
            this.lbl_checkdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_checkdata.Location = new System.Drawing.Point(12, 344);
            this.lbl_checkdata.Name = "lbl_checkdata";
            this.lbl_checkdata.Size = new System.Drawing.Size(51, 20);
            this.lbl_checkdata.TabIndex = 16;
            this.lbl_checkdata.Text = "label3";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 373);
            this.Controls.Add(this.lbl_checkdata);
            this.Controls.Add(this.lbl_fileNamePath);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.lbl_DangKy);
            this.Controls.Add(this.lbl_QuenMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Acc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(559, 500);
            this.MinimumSize = new System.Drawing.Size(559, 300);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_DangKy;
        private System.Windows.Forms.LinkLabel lbl_QuenMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Acc;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label lbl_fileNamePath;
        private System.Windows.Forms.Label lbl_checkdata;
    }
}
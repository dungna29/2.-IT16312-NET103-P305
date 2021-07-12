
namespace BAI_1_2_CRUD_ACCOUNT.Views
{
    partial class frmRegister
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TaoTaiKhoan = new System.Windows.Forms.Button();
            this.cmbNamSinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.btnTuSinhMk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TaoTaiKhoan);
            this.groupBox1.Controls.Add(this.cmbNamSinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtnNu);
            this.groupBox1.Controls.Add(this.rbtnNam);
            this.groupBox1.Controls.Add(this.btnTuSinhMk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAcc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(664, 304);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo tài khoản";
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.Location = new System.Drawing.Point(234, 248);
            this.btn_TaoTaiKhoan.Margin = new System.Windows.Forms.Padding(6);
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            this.btn_TaoTaiKhoan.Size = new System.Drawing.Size(220, 44);
            this.btn_TaoTaiKhoan.TabIndex = 13;
            this.btn_TaoTaiKhoan.Text = "Tạo tài khoản";
            this.btn_TaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_TaoTaiKhoan.Click += new System.EventHandler(this.btn_TaoTaiKhoan_Click);
            // 
            // cmbNamSinh
            // 
            this.cmbNamSinh.FormattingEnabled = true;
            this.cmbNamSinh.Location = new System.Drawing.Point(152, 177);
            this.cmbNamSinh.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNamSinh.Name = "cmbNamSinh";
            this.cmbNamSinh.Size = new System.Drawing.Size(264, 33);
            this.cmbNamSinh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Năm Sinh:";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(258, 135);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(6);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(57, 29);
            this.rbtnNu.TabIndex = 9;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(152, 135);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(6);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(74, 29);
            this.rbtnNam.TabIndex = 8;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // btnTuSinhMk
            // 
            this.btnTuSinhMk.Location = new System.Drawing.Point(432, 83);
            this.btnTuSinhMk.Margin = new System.Windows.Forms.Padding(6);
            this.btnTuSinhMk.Name = "btnTuSinhMk";
            this.btnTuSinhMk.Size = new System.Drawing.Size(220, 44);
            this.btnTuSinhMk.TabIndex = 3;
            this.btnTuSinhMk.Text = "Tự sinh mật khẩu";
            this.btnTuSinhMk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(152, 90);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(264, 31);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(152, 37);
            this.txtAcc.Margin = new System.Windows.Forms.Padding(6);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(264, 31);
            this.txtAcc.TabIndex = 4;
            this.txtAcc.Text = "dungna";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản: ";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 350);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRegister";
            this.Text = "Đăng ký tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TaoTaiKhoan;
        private System.Windows.Forms.ComboBox cmbNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Button btnTuSinhMk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label label1;
    }
}
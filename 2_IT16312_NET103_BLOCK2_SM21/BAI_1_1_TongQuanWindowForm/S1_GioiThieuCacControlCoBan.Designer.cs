
namespace BAI_1_1_TongQuanWindowForm
{
    partial class S1_GioiThieuCacControlCoBan
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ClickVaoDay = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lbl_Ten);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Label = lbl + tên";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(35, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(32, 20);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(35, 13);
            this.lbl_Ten.TabIndex = 0;
            this.lbl_Ten.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ClickVaoDay);
            this.groupBox2.Location = new System.Drawing.Point(240, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button = btn + ten";
            // 
            // btn_ClickVaoDay
            // 
            this.btn_ClickVaoDay.Location = new System.Drawing.Point(45, 39);
            this.btn_ClickVaoDay.Name = "btn_ClickVaoDay";
            this.btn_ClickVaoDay.Size = new System.Drawing.Size(104, 23);
            this.btn_ClickVaoDay.TabIndex = 0;
            this.btn_ClickVaoDay.Text = "Click vào đây";
            this.btn_ClickVaoDay.UseVisualStyleBackColor = true;
            this.btn_ClickVaoDay.Click += new System.EventHandler(this.btn_ClickVaoDay_Click);
            this.btn_ClickVaoDay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ClickVaoDay_MouseDown);
            this.btn_ClickVaoDay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ClickVaoDay_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Label = lbl + tên";
            // 
            // S1_GioiThieuCacControlCoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 688);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "S1_GioiThieuCacControlCoBan";
            this.Text = "Giới thiệu các Control Cơ bản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ClickVaoDay;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
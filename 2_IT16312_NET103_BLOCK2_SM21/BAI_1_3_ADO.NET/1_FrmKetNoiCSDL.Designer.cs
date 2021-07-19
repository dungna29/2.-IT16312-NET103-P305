
namespace BAI_1_3_ADO.NET
{
    partial class frmKetNoiCSDL
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
            this.btn_KetNoiDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KetNoiDB
            // 
            this.btn_KetNoiDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KetNoiDB.Location = new System.Drawing.Point(233, 12);
            this.btn_KetNoiDB.Name = "btn_KetNoiDB";
            this.btn_KetNoiDB.Size = new System.Drawing.Size(260, 115);
            this.btn_KetNoiDB.TabIndex = 0;
            this.btn_KetNoiDB.Text = "Kết Nối DB";
            this.btn_KetNoiDB.UseVisualStyleBackColor = true;
            this.btn_KetNoiDB.Click += new System.EventHandler(this.btn_KetNoiDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // frmKetNoiCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_KetNoiDB);
            this.Name = "frmKetNoiCSDL";
            this.Text = "1_FrmKetNoiCSDL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KetNoiDB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
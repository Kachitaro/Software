namespace Doancuoiki
{
    partial class fStatistical
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
            this.btnThongKeImport = new System.Windows.Forms.Button();
            this.dtgvStatical = new System.Windows.Forms.DataGridView();
            this.dtpkImport = new System.Windows.Forms.DateTimePicker();
            this.dtpkExport = new System.Windows.Forms.DateTimePicker();
            this.btnThongKeExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatical)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKeImport
            // 
            this.btnThongKeImport.Location = new System.Drawing.Point(84, 12);
            this.btnThongKeImport.Name = "btnThongKeImport";
            this.btnThongKeImport.Size = new System.Drawing.Size(105, 24);
            this.btnThongKeImport.TabIndex = 0;
            this.btnThongKeImport.Text = "Thống kê nhập";
            this.btnThongKeImport.UseVisualStyleBackColor = true;
            this.btnThongKeImport.Click += new System.EventHandler(this.btnThongKeImport_Click);
            // 
            // dtgvStatical
            // 
            this.dtgvStatical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatical.Location = new System.Drawing.Point(55, 45);
            this.dtgvStatical.Name = "dtgvStatical";
            this.dtgvStatical.Size = new System.Drawing.Size(342, 181);
            this.dtgvStatical.TabIndex = 1;
            // 
            // dtpkImport
            // 
            this.dtpkImport.Location = new System.Drawing.Point(12, 14);
            this.dtpkImport.Name = "dtpkImport";
            this.dtpkImport.Size = new System.Drawing.Size(66, 20);
            this.dtpkImport.TabIndex = 2;
            // 
            // dtpkExport
            // 
            this.dtpkExport.Location = new System.Drawing.Point(353, 14);
            this.dtpkExport.Name = "dtpkExport";
            this.dtpkExport.Size = new System.Drawing.Size(70, 20);
            this.dtpkExport.TabIndex = 3;
            // 
            // btnThongKeExport
            // 
            this.btnThongKeExport.Location = new System.Drawing.Point(242, 12);
            this.btnThongKeExport.Name = "btnThongKeExport";
            this.btnThongKeExport.Size = new System.Drawing.Size(105, 24);
            this.btnThongKeExport.TabIndex = 4;
            this.btnThongKeExport.Text = "Thống kê xuất";
            this.btnThongKeExport.UseVisualStyleBackColor = true;
            this.btnThongKeExport.Click += new System.EventHandler(this.btnThongKeExport_Click);
            // 
            // fStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.btnThongKeExport);
            this.Controls.Add(this.dtpkExport);
            this.Controls.Add(this.dtpkImport);
            this.Controls.Add(this.dtgvStatical);
            this.Controls.Add(this.btnThongKeImport);
            this.Name = "fStatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical";
            this.Load += new System.EventHandler(this.fStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThongKeImport;
        private System.Windows.Forms.DataGridView dtgvStatical;
        private System.Windows.Forms.DateTimePicker dtpkImport;
        private System.Windows.Forms.DateTimePicker dtpkExport;
        private System.Windows.Forms.Button btnThongKeExport;
    }
}
﻿namespace Doancuoiki
{
    partial class fExport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.tbMove = new System.Windows.Forms.TextBox();
            this.btnUMove = new System.Windows.Forms.Button();
            this.tbCheckOut = new System.Windows.Forms.TextBox();
            this.tbIdOrther = new System.Windows.Forms.TextBox();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu Xuất";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvPhieuXuat
            // 
            this.dtgvPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuXuat.Location = new System.Drawing.Point(349, 70);
            this.dtgvPhieuXuat.Name = "dtgvPhieuXuat";
            this.dtgvPhieuXuat.Size = new System.Drawing.Size(458, 200);
            this.dtgvPhieuXuat.TabIndex = 0;
            // 
            // tbMove
            // 
            this.tbMove.Location = new System.Drawing.Point(155, 198);
            this.tbMove.Name = "tbMove";
            this.tbMove.ReadOnly = true;
            this.tbMove.Size = new System.Drawing.Size(107, 20);
            this.tbMove.TabIndex = 2;
            this.tbMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUMove
            // 
            this.btnUMove.Location = new System.Drawing.Point(155, 243);
            this.btnUMove.Name = "btnUMove";
            this.btnUMove.Size = new System.Drawing.Size(107, 27);
            this.btnUMove.TabIndex = 3;
            this.btnUMove.Text = "Cập nhật tình trạng";
            this.btnUMove.UseVisualStyleBackColor = true;
            this.btnUMove.Click += new System.EventHandler(this.btnUMove_Click);
            // 
            // tbCheckOut
            // 
            this.tbCheckOut.Location = new System.Drawing.Point(155, 70);
            this.tbCheckOut.Name = "tbCheckOut";
            this.tbCheckOut.ReadOnly = true;
            this.tbCheckOut.Size = new System.Drawing.Size(107, 20);
            this.tbCheckOut.TabIndex = 4;
            // 
            // tbIdOrther
            // 
            this.tbIdOrther.Location = new System.Drawing.Point(154, 155);
            this.tbIdOrther.Name = "tbIdOrther";
            this.tbIdOrther.ReadOnly = true;
            this.tbIdOrther.Size = new System.Drawing.Size(108, 20);
            this.tbIdOrther.TabIndex = 5;
            this.tbIdOrther.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPhieuXuat
            // 
            this.btnPhieuXuat.Location = new System.Drawing.Point(268, 243);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Size = new System.Drawing.Size(75, 27);
            this.btnPhieuXuat.TabIndex = 6;
            this.btnPhieuXuat.Text = "In Phiếu";
            this.btnPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(155, 114);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(107, 20);
            this.tbName.TabIndex = 7;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tình trạng";
            // 
            // fExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnPhieuXuat);
            this.Controls.Add(this.tbIdOrther);
            this.Controls.Add(this.tbCheckOut);
            this.Controls.Add(this.btnUMove);
            this.Controls.Add(this.tbMove);
            this.Controls.Add(this.dtgvPhieuXuat);
            this.Controls.Add(this.label1);
            this.Name = "fExport";
            this.Text = "fExport";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPhieuXuat;
        private System.Windows.Forms.TextBox tbMove;
        private System.Windows.Forms.Button btnUMove;
        private System.Windows.Forms.TextBox tbCheckOut;
        private System.Windows.Forms.TextBox tbIdOrther;
        private System.Windows.Forms.Button btnPhieuXuat;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
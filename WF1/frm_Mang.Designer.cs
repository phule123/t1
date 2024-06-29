namespace WF1
{
    partial class frm_Mang
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
            this.txt_mangA = new System.Windows.Forms.TextBox();
            this.txt_tongChan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongLe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongfull = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A:";
            // 
            // txt_mangA
            // 
            this.txt_mangA.Location = new System.Drawing.Point(474, 94);
            this.txt_mangA.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_mangA.Name = "txt_mangA";
            this.txt_mangA.Size = new System.Drawing.Size(342, 30);
            this.txt_mangA.TabIndex = 1;
            this.txt_mangA.TextChanged += new System.EventHandler(this.txt_mangA_TextChanged);
            // 
            // txt_tongChan
            // 
            this.txt_tongChan.Location = new System.Drawing.Point(474, 203);
            this.txt_tongChan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tongChan.Name = "txt_tongChan";
            this.txt_tongChan.Size = new System.Drawing.Size(342, 30);
            this.txt_tongChan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng các số chẵn:";
            // 
            // txt_tongLe
            // 
            this.txt_tongLe.Location = new System.Drawing.Point(474, 278);
            this.txt_tongLe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tongLe.Name = "txt_tongLe";
            this.txt_tongLe.Size = new System.Drawing.Size(342, 30);
            this.txt_tongLe.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 8;
            // 
            // txt_tongfull
            // 
            this.txt_tongfull.Location = new System.Drawing.Point(474, 362);
            this.txt_tongfull.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_tongfull.Name = "txt_tongfull";
            this.txt_tongfull.Size = new System.Drawing.Size(342, 30);
            this.txt_tongfull.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng các số mảng A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tổng các số lẻ:";
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(363, 438);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(121, 30);
            this.btn_tinh.TabIndex = 13;
            this.btn_tinh.Text = "Tính Toán";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(542, 438);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(121, 30);
            this.btn_lammoi.TabIndex = 14;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(740, 438);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(121, 30);
            this.btn_thoat.TabIndex = 15;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_Mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 494);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tongfull);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tongLe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tongChan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mangA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_Mang";
            this.Text = "Form Mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mangA;
        private System.Windows.Forms.TextBox txt_tongChan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tongLe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tongfull;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_thoat;
    }
}
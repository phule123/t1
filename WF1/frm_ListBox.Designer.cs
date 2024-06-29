namespace WF1
{
    partial class frm_ListBox
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
            this.Lib_A = new System.Windows.Forms.ListBox();
            this.Lib_B = new System.Windows.Forms.ListBox();
            this.btn_c1 = new System.Windows.Forms.Button();
            this.btn_c2 = new System.Windows.Forms.Button();
            this.btn_b1 = new System.Windows.Forms.Button();
            this.btn_b2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lib_A
            // 
            this.Lib_A.FormattingEnabled = true;
            this.Lib_A.ItemHeight = 16;
            this.Lib_A.Location = new System.Drawing.Point(87, 118);
            this.Lib_A.Name = "Lib_A";
            this.Lib_A.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_A.Size = new System.Drawing.Size(213, 228);
            this.Lib_A.Sorted = true;
            this.Lib_A.TabIndex = 0;
            // 
            // Lib_B
            // 
            this.Lib_B.FormattingEnabled = true;
            this.Lib_B.ItemHeight = 16;
            this.Lib_B.Location = new System.Drawing.Point(516, 118);
            this.Lib_B.Name = "Lib_B";
            this.Lib_B.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Lib_B.Size = new System.Drawing.Size(225, 276);
            this.Lib_B.Sorted = true;
            this.Lib_B.TabIndex = 1;
            // 
            // btn_c1
            // 
            this.btn_c1.Location = new System.Drawing.Point(338, 118);
            this.btn_c1.Name = "btn_c1";
            this.btn_c1.Size = new System.Drawing.Size(75, 23);
            this.btn_c1.TabIndex = 2;
            this.btn_c1.Text = ">";
            this.btn_c1.UseVisualStyleBackColor = true;
            this.btn_c1.Click += new System.EventHandler(this.btn_c1_Click);
            // 
            // btn_c2
            // 
            this.btn_c2.Location = new System.Drawing.Point(338, 184);
            this.btn_c2.Name = "btn_c2";
            this.btn_c2.Size = new System.Drawing.Size(75, 23);
            this.btn_c2.TabIndex = 3;
            this.btn_c2.Text = ">>";
            this.btn_c2.UseVisualStyleBackColor = true;
            this.btn_c2.Click += new System.EventHandler(this.btn_c2_Click);
            // 
            // btn_b1
            // 
            this.btn_b1.Location = new System.Drawing.Point(338, 262);
            this.btn_b1.Name = "btn_b1";
            this.btn_b1.Size = new System.Drawing.Size(75, 23);
            this.btn_b1.TabIndex = 4;
            this.btn_b1.Text = "<";
            this.btn_b1.UseVisualStyleBackColor = true;
            this.btn_b1.Click += new System.EventHandler(this.btn_b1_Click);
            // 
            // btn_b2
            // 
            this.btn_b2.Location = new System.Drawing.Point(338, 326);
            this.btn_b2.Name = "btn_b2";
            this.btn_b2.Size = new System.Drawing.Size(75, 23);
            this.btn_b2.TabIndex = 5;
            this.btn_b2.Text = "<<";
            this.btn_b2.UseVisualStyleBackColor = true;
            this.btn_b2.Click += new System.EventHandler(this.btn_b2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ Tên";
            // 
            // frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_b2);
            this.Controls.Add(this.btn_b1);
            this.Controls.Add(this.btn_c2);
            this.Controls.Add(this.btn_c1);
            this.Controls.Add(this.Lib_B);
            this.Controls.Add(this.Lib_A);
            this.Name = "frm_ListBox";
            this.Text = "frm_ListBox";
            this.Load += new System.EventHandler(this.frm_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lib_A;
        private System.Windows.Forms.ListBox Lib_B;
        private System.Windows.Forms.Button btn_c1;
        private System.Windows.Forms.Button btn_c2;
        private System.Windows.Forms.Button btn_b1;
        private System.Windows.Forms.Button btn_b2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
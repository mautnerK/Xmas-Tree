namespace XmasTree
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_rowCount = new System.Windows.Forms.TextBox();
            this.textBox_header = new System.Windows.Forms.TextBox();
            this.textBox_footer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_tree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_rowCount
            // 
            this.textBox_rowCount.Location = new System.Drawing.Point(157, 86);
            this.textBox_rowCount.Name = "textBox_rowCount";
            this.textBox_rowCount.Size = new System.Drawing.Size(100, 23);
            this.textBox_rowCount.TabIndex = 0;
            this.textBox_rowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_header
            // 
            this.textBox_header.Location = new System.Drawing.Point(321, 86);
            this.textBox_header.Name = "textBox_header";
            this.textBox_header.Size = new System.Drawing.Size(100, 23);
            this.textBox_header.TabIndex = 1;
            this.textBox_header.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_footer
            // 
            this.textBox_footer.Location = new System.Drawing.Point(493, 86);
            this.textBox_footer.Name = "textBox_footer";
            this.textBox_footer.Size = new System.Drawing.Size(100, 23);
            this.textBox_footer.TabIndex = 2;
            this.textBox_footer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Row count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Header";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(507, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Footer";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(321, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_tree
            // 
            this.label_tree.AutoSize = true;
            this.label_tree.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_tree.Location = new System.Drawing.Point(337, 259);
            this.label_tree.Name = "label_tree";
            this.label_tree.Size = new System.Drawing.Size(31, 13);
            this.label_tree.TabIndex = 8;
            this.label_tree.Text = "tree";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_tree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_footer);
            this.Controls.Add(this.textBox_header);
            this.Controls.Add(this.textBox_rowCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_rowCount;
        private TextBox textBox_header;
        private TextBox textBox_footer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label_tree;
    }
}
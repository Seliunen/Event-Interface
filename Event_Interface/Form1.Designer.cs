namespace Event_Interface
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
            this.Zimti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Außen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Zimti
            // 
            this.Zimti.AutoSize = true;
            this.Zimti.Location = new System.Drawing.Point(210, 56);
            this.Zimti.Name = "Zimti";
            this.Zimti.Size = new System.Drawing.Size(35, 15);
            this.Zimti.TabIndex = 0;
            this.Zimti.Text = "Zimti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Außen
            // 
            this.Außen.AutoSize = true;
            this.Außen.Location = new System.Drawing.Point(97, 56);
            this.Außen.Name = "Außen";
            this.Außen.Size = new System.Drawing.Size(42, 15);
            this.Außen.TabIndex = 2;
            this.Außen.Text = "Außen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Außen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zimti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Zimti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Außen;
    }
}


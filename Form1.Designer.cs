namespace XMLSchreiber
{
    partial class Form1
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
            this.EingabeFeld = new System.Windows.Forms.ListBox();
            this.Übernehmen_button1 = new System.Windows.Forms.Button();
            this.Speichern_button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EingabeFeld
            // 
            this.EingabeFeld.FormattingEnabled = true;
            this.EingabeFeld.Location = new System.Drawing.Point(12, 9);
            this.EingabeFeld.Name = "EingabeFeld";
            this.EingabeFeld.Size = new System.Drawing.Size(149, 329);
            this.EingabeFeld.TabIndex = 0;
            // 
            // Übernehmen_button1
            // 
            this.Übernehmen_button1.Location = new System.Drawing.Point(168, 55);
            this.Übernehmen_button1.Name = "Übernehmen_button1";
            this.Übernehmen_button1.Size = new System.Drawing.Size(148, 23);
            this.Übernehmen_button1.TabIndex = 1;
            this.Übernehmen_button1.Text = "Übernehmen";
            this.Übernehmen_button1.UseVisualStyleBackColor = true;
            this.Übernehmen_button1.Click += new System.EventHandler(this.Übernehmen_button1_Click);
            // 
            // Speichern_button2
            // 
            this.Speichern_button2.Location = new System.Drawing.Point(168, 84);
            this.Speichern_button2.Name = "Speichern_button2";
            this.Speichern_button2.Size = new System.Drawing.Size(148, 23);
            this.Speichern_button2.TabIndex = 2;
            this.Speichern_button2.Text = "Speichern";
            this.Speichern_button2.UseVisualStyleBackColor = true;
            this.Speichern_button2.Click += new System.EventHandler(this.Speichern_button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 345);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Speichern_button2);
            this.Controls.Add(this.Übernehmen_button1);
            this.Controls.Add(this.EingabeFeld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EingabeFeld;
        private System.Windows.Forms.Button Übernehmen_button1;
        private System.Windows.Forms.Button Speichern_button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


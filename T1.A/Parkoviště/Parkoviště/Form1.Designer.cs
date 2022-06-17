
namespace Parkoviště
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
            this.Zaparkuj = new System.Windows.Forms.Button();
            this.Debug_OutPut = new System.Windows.Forms.Label();
            this.Vyparkuj = new System.Windows.Forms.Button();
            this.Reset_Parkoviste = new System.Windows.Forms.Button();
            this.Velikost_Parkoviste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Zaparkuj
            // 
            this.Zaparkuj.Location = new System.Drawing.Point(418, 160);
            this.Zaparkuj.Name = "Zaparkuj";
            this.Zaparkuj.Size = new System.Drawing.Size(75, 23);
            this.Zaparkuj.TabIndex = 0;
            this.Zaparkuj.Text = "Zaparkuj";
            this.Zaparkuj.UseVisualStyleBackColor = true;
            this.Zaparkuj.Click += new System.EventHandler(this.Zaparkuj_Click);
            // 
            // Debug_OutPut
            // 
            this.Debug_OutPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Debug_OutPut.Location = new System.Drawing.Point(418, 38);
            this.Debug_OutPut.Name = "Debug_OutPut";
            this.Debug_OutPut.Size = new System.Drawing.Size(268, 91);
            this.Debug_OutPut.TabIndex = 1;
            this.Debug_OutPut.Click += new System.EventHandler(this.Debug_OutPut_Click);
            // 
            // Vyparkuj
            // 
            this.Vyparkuj.Location = new System.Drawing.Point(611, 160);
            this.Vyparkuj.Name = "Vyparkuj";
            this.Vyparkuj.Size = new System.Drawing.Size(75, 23);
            this.Vyparkuj.TabIndex = 2;
            this.Vyparkuj.Text = "Vyparkuj";
            this.Vyparkuj.UseVisualStyleBackColor = true;
            this.Vyparkuj.Click += new System.EventHandler(this.Vyparkuj_Click);
            // 
            // Reset_Parkoviste
            // 
            this.Reset_Parkoviste.Location = new System.Drawing.Point(12, 7);
            this.Reset_Parkoviste.Name = "Reset_Parkoviste";
            this.Reset_Parkoviste.Size = new System.Drawing.Size(101, 28);
            this.Reset_Parkoviste.TabIndex = 4;
            this.Reset_Parkoviste.Text = "Reset parkoviště";
            this.Reset_Parkoviste.UseVisualStyleBackColor = true;
            this.Reset_Parkoviste.Click += new System.EventHandler(this.Reset_Parkoviste_Click);
            // 
            // Velikost_Parkoviste
            // 
            this.Velikost_Parkoviste.Location = new System.Drawing.Point(119, 6);
            this.Velikost_Parkoviste.Name = "Velikost_Parkoviste";
            this.Velikost_Parkoviste.Size = new System.Drawing.Size(180, 23);
            this.Velikost_Parkoviste.TabIndex = 3;
            this.Velikost_Parkoviste.TextChanged += new System.EventHandler(this.Velikost_Parkoviste_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset_Parkoviste);
            this.Controls.Add(this.Velikost_Parkoviste);
            this.Controls.Add(this.Vyparkuj);
            this.Controls.Add(this.Debug_OutPut);
            this.Controls.Add(this.Zaparkuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zaparkuj;
        private System.Windows.Forms.Label Debug_OutPut;
        private System.Windows.Forms.Button Vyparkuj;
        private System.Windows.Forms.Button Reset_Parkoviste;
        private System.Windows.Forms.TextBox Velikost_Parkoviste;
    }
}


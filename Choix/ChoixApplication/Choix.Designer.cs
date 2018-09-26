namespace WindowsFormsApplication1
{
    partial class Choix
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
            this.textBoxChoix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxChoix
            // 
            this.textBoxChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChoix.Location = new System.Drawing.Point(32, 41);
            this.textBoxChoix.Name = "textBoxChoix";
            this.textBoxChoix.Size = new System.Drawing.Size(1097, 29);
            this.textBoxChoix.TabIndex = 0;
            this.textBoxChoix.Text = "Choix";
            // 
            // Choix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 89);
            this.Controls.Add(this.textBoxChoix);
            this.Name = "Choix";
            this.Text = "Choix";
            this.Load += new System.EventHandler(this.Choix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChoix;
    }
}


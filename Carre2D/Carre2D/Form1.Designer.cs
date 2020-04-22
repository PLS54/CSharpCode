namespace WindowsFormsApplication3
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
            this.set1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownNumeroCouple = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.set1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroCouple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // set1
            // 
            this.set1.Location = new System.Drawing.Point(-1, -2);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(400, 400);
            this.set1.TabIndex = 0;
            this.set1.TabStop = false;
            this.set1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.set1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownNumeroCouple
            // 
            this.numericUpDownNumeroCouple.Location = new System.Drawing.Point(431, 124);
            this.numericUpDownNumeroCouple.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumeroCouple.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumeroCouple.Name = "numericUpDownNumeroCouple";
            this.numericUpDownNumeroCouple.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownNumeroCouple.TabIndex = 2;
            this.numericUpDownNumeroCouple.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(431, 173);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAngle.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 747);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.numericUpDownNumeroCouple);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.set1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.set1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroCouple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox set1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroCouple;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
    }
}


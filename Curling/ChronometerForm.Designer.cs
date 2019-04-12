namespace PLS.Curling {
	partial class ChronometerForm {
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
			if (disposing && (components != null)) {
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
			this.textBoxTimeLeft = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// textBoxTimeLeft
			// 
			this.textBoxTimeLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.textBoxTimeLeft.Font = new System.Drawing.Font("Arial", 110F, System.Drawing.FontStyle.Bold);
			this.textBoxTimeLeft.Location = new System.Drawing.Point(5, 5);
			this.textBoxTimeLeft.Name = "textBoxTimeLeft";
			this.textBoxTimeLeft.ReadOnly = true;
			this.textBoxTimeLeft.Size = new System.Drawing.Size(382, 176);
			this.textBoxTimeLeft.TabIndex = 1;
			this.textBoxTimeLeft.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(126, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 43);
			this.button1.TabIndex = 3;
			this.button1.Text = "Time &In";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.WorkerSupportsCancellation = true;
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(392, 186);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(121, 201);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(134, 53);
			this.panel2.TabIndex = 2;
			// 
			// ChronometerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 267);
			this.ControlBox = false;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxTimeLeft);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChronometerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ChronometerForm";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.SystemColors.Control;
			this.Load += new System.EventHandler(this.ChronometerForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTimeLeft;
		private System.Windows.Forms.Button button1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}
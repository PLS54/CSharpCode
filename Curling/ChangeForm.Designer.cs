namespace PLS.Curling {
	partial class ChangeForm {
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
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.numericUpDownEnds = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownRocks = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRocks)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(76, 201);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(68, 39);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "&OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(161, 201);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(68, 39);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// numericUpDownEnds
			// 
			this.numericUpDownEnds.Location = new System.Drawing.Point(101, 41);
			this.numericUpDownEnds.Name = "numericUpDownEnds";
			this.numericUpDownEnds.Size = new System.Drawing.Size(43, 20);
			this.numericUpDownEnds.TabIndex = 6;
			// 
			// numericUpDownRocks
			// 
			this.numericUpDownRocks.Location = new System.Drawing.Point(102, 90);
			this.numericUpDownRocks.Name = "numericUpDownRocks";
			this.numericUpDownRocks.Size = new System.Drawing.Size(41, 20);
			this.numericUpDownRocks.TabIndex = 7;
			// 
			// ChangeForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.numericUpDownRocks);
			this.Controls.Add(this.numericUpDownEnds);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChangeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangeForm";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRocks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.NumericUpDown numericUpDownEnds;
		private System.Windows.Forms.NumericUpDown numericUpDownRocks;

	}
}
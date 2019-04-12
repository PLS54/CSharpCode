namespace PLS.Curling {
	partial class ExtraEndRequiredForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraEndRequiredForm));
			this.radioButtonNo = new System.Windows.Forms.RadioButton();
			this.radioButtonYes = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButtonNo
			// 
			this.radioButtonNo.AutoSize = true;
			this.radioButtonNo.Checked = true;
			this.radioButtonNo.Location = new System.Drawing.Point(39, 34);
			this.radioButtonNo.Name = "radioButtonNo";
			this.radioButtonNo.Size = new System.Drawing.Size(47, 24);
			this.radioButtonNo.TabIndex = 0;
			this.radioButtonNo.TabStop = true;
			this.radioButtonNo.Text = "No";
			this.radioButtonNo.UseVisualStyleBackColor = true;
			// 
			// radioButtonYes
			// 
			this.radioButtonYes.AutoSize = true;
			this.radioButtonYes.Location = new System.Drawing.Point(39, 57);
			this.radioButtonYes.Name = "radioButtonYes";
			this.radioButtonYes.Size = new System.Drawing.Size(55, 24);
			this.radioButtonYes.TabIndex = 1;
			this.radioButtonYes.Text = "Yes";
			this.radioButtonYes.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonYes);
			this.groupBox1.Controls.Add(this.radioButtonNo);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(38, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 98);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Extra End Required";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(77, 150);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 33);
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ExtraEndRequiredForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(269, 209);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExtraEndRequiredForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Extra End";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonNo;
		private System.Windows.Forms.RadioButton radioButtonYes;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
	}
}
namespace CheckMD5Signature {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.buttonMD5 = new System.Windows.Forms.Button();
			this.textBoxCalMd5 = new System.Windows.Forms.TextBox();
			this.textBoxMD5Compare = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxSHA1Compare = new System.Windows.Forms.TextBox();
			this.textBoxSHACalc = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(365, 12);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(24, 20);
			this.buttonBrowse.TabIndex = 0;
			this.buttonBrowse.Text = "...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Location = new System.Drawing.Point(65, 12);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.Size = new System.Drawing.Size(294, 20);
			this.textBoxFileName.TabIndex = 1;
			// 
			// buttonMD5
			// 
			this.buttonMD5.Location = new System.Drawing.Point(181, 181);
			this.buttonMD5.Name = "buttonMD5";
			this.buttonMD5.Size = new System.Drawing.Size(64, 37);
			this.buttonMD5.TabIndex = 2;
			this.buttonMD5.Text = "Calculate";
			this.buttonMD5.UseVisualStyleBackColor = true;
			this.buttonMD5.Click += new System.EventHandler(this.buttonMD5_Click);
			// 
			// textBoxCalMd5
			// 
			this.textBoxCalMd5.Location = new System.Drawing.Point(105, 39);
			this.textBoxCalMd5.Name = "textBoxCalMd5";
			this.textBoxCalMd5.ReadOnly = true;
			this.textBoxCalMd5.Size = new System.Drawing.Size(216, 20);
			this.textBoxCalMd5.TabIndex = 3;
			// 
			// textBoxMD5Compare
			// 
			this.textBoxMD5Compare.Location = new System.Drawing.Point(105, 71);
			this.textBoxMD5Compare.Name = "textBoxMD5Compare";
			this.textBoxMD5Compare.Size = new System.Drawing.Size(216, 20);
			this.textBoxMD5Compare.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Calculated MD5";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "MD5 for compare";
			// 
			// textBoxResult
			// 
			this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxResult.Location = new System.Drawing.Point(94, 162);
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ReadOnly = true;
			this.textBoxResult.Size = new System.Drawing.Size(105, 13);
			this.textBoxResult.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Filename:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "SHA1 for compare";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Calculated SHA1";
			// 
			// textBoxSHA1Compare
			// 
			this.textBoxSHA1Compare.Location = new System.Drawing.Point(107, 139);
			this.textBoxSHA1Compare.Name = "textBoxSHA1Compare";
			this.textBoxSHA1Compare.Size = new System.Drawing.Size(282, 20);
			this.textBoxSHA1Compare.TabIndex = 10;
			this.textBoxSHA1Compare.TextChanged += new System.EventHandler(this.textBoxSHACompare_TextChanged);
			// 
			// textBoxSHACalc
			// 
			this.textBoxSHACalc.Location = new System.Drawing.Point(107, 107);
			this.textBoxSHACalc.Name = "textBoxSHACalc";
			this.textBoxSHACalc.ReadOnly = true;
			this.textBoxSHACalc.Size = new System.Drawing.Size(282, 20);
			this.textBoxSHACalc.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 237);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSHA1Compare);
			this.Controls.Add(this.textBoxSHACalc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxMD5Compare);
			this.Controls.Add(this.textBoxCalMd5);
			this.Controls.Add(this.buttonMD5);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.buttonBrowse);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Button buttonMD5;
		private System.Windows.Forms.TextBox textBoxCalMd5;
		private System.Windows.Forms.TextBox textBoxMD5Compare;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxSHA1Compare;
		private System.Windows.Forms.TextBox textBoxSHACalc;
	}
}


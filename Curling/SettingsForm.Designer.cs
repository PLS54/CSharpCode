namespace PLS.Curling {
	partial class SettingsForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxEnds = new System.Windows.Forms.ComboBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonColorTeam2 = new System.Windows.Forms.Button();
			this.buttonColorTeam1 = new System.Windows.Forms.Button();
			this.checkBoxSound = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(49, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Number of &Ends:";
			// 
			// comboBoxEnds
			// 
			this.comboBoxEnds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxEnds.FormattingEnabled = true;
			this.comboBoxEnds.Items.AddRange(new object[] {
            "8 ender",
            "10 ender"});
			this.comboBoxEnds.Location = new System.Drawing.Point(139, 15);
			this.comboBoxEnds.Name = "comboBoxEnds";
			this.comboBoxEnds.Size = new System.Drawing.Size(106, 26);
			this.comboBoxEnds.TabIndex = 1;
			this.comboBoxEnds.Text = "8 ender";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(154, 179);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(68, 39);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(69, 179);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(68, 39);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "&OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Team 2:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonColorTeam2);
			this.groupBox1.Controls.Add(this.buttonColorTeam1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(26, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 65);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rock color";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Team 1:";
			// 
			// buttonColorTeam2
			// 
			this.buttonColorTeam2.BackColor = global::PLS.Curling.Properties.Settings.Default.Team2RockColor;
			this.buttonColorTeam2.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::PLS.Curling.Properties.Settings.Default, "Team2RockColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.buttonColorTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonColorTeam2.Location = new System.Drawing.Point(190, 22);
			this.buttonColorTeam2.Name = "buttonColorTeam2";
			this.buttonColorTeam2.Size = new System.Drawing.Size(27, 25);
			this.buttonColorTeam2.TabIndex = 8;
			this.buttonColorTeam2.Text = "...";
			this.buttonColorTeam2.UseVisualStyleBackColor = false;
			this.buttonColorTeam2.Click += new System.EventHandler(this.buttonColorTeam2_Click);
			// 
			// buttonColorTeam1
			// 
			this.buttonColorTeam1.BackColor = global::PLS.Curling.Properties.Settings.Default.Team1RockColor;
			this.buttonColorTeam1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::PLS.Curling.Properties.Settings.Default, "Team1RockColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.buttonColorTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonColorTeam1.Location = new System.Drawing.Point(61, 22);
			this.buttonColorTeam1.Name = "buttonColorTeam1";
			this.buttonColorTeam1.Size = new System.Drawing.Size(27, 25);
			this.buttonColorTeam1.TabIndex = 7;
			this.buttonColorTeam1.Text = "...";
			this.buttonColorTeam1.UseVisualStyleBackColor = false;
			this.buttonColorTeam1.Click += new System.EventHandler(this.buttonColorTeam1_Click_1);
			// 
			// checkBoxSound
			// 
			this.checkBoxSound.AutoSize = true;
			this.checkBoxSound.Checked = global::PLS.Curling.Properties.Settings.Default.Sound;
			this.checkBoxSound.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PLS.Curling.Properties.Settings.Default, "Sound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBoxSound.Location = new System.Drawing.Point(98, 61);
			this.checkBoxSound.Name = "checkBoxSound";
			this.checkBoxSound.Size = new System.Drawing.Size(93, 17);
			this.checkBoxSound.TabIndex = 4;
			this.checkBoxSound.Text = "Enable &Sound";
			this.checkBoxSound.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(292, 236);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.checkBoxSound);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxEnds);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsForm";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxEnds;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.CheckBox checkBoxSound;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonColorTeam2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonColorTeam1;
	}
}
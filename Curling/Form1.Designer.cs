namespace PLS.Curling
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
            this.textBoxTeam2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            this.radioButtonTeam1 = new System.Windows.Forms.RadioButton();
            this.radioButtonTeam2 = new System.Windows.Forms.RadioButton();
            this.textBoxRocksLeftTeam1 = new System.Windows.Forms.TextBox();
            this.textBoxRocksLeftTeam2 = new System.Windows.Forms.TextBox();
            this.textBoxTeam1 = new System.Windows.Forms.TextBox();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDummy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTOLeftTeam2 = new System.Windows.Forms.TextBox();
            this.textBoxTOLeftTeam1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTimigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTimingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pbTeam1Status = new System.Windows.Forms.PictureBox();
            this.pbTeam2Status = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2Status)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTeam2
            // 
            this.textBoxTeam2.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTeam2.Font = new System.Drawing.Font("Arial", 110F, System.Drawing.FontStyle.Bold);
            this.textBoxTeam2.Location = new System.Drawing.Point(396, 66);
            this.textBoxTeam2.Name = "textBoxTeam2";
            this.textBoxTeam2.ReadOnly = true;
            this.textBoxTeam2.Size = new System.Drawing.Size(382, 176);
            this.textBoxTeam2.TabIndex = 8;
            this.textBoxTeam2.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.Enabled = false;
            this.buttonTimeOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOut.Location = new System.Drawing.Point(396, 248);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(110, 46);
            this.buttonTimeOut.TabIndex = 14;
            this.buttonTimeOut.Text = "Time-&Out (Ctrl + O)";
            this.buttonTimeOut.UseVisualStyleBackColor = true;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click);
            // 
            // radioButtonTeam1
            // 
            this.radioButtonTeam1.AutoSize = true;
            this.radioButtonTeam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTeam1.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonTeam1.Image")));
            this.radioButtonTeam1.Location = new System.Drawing.Point(34, 249);
            this.radioButtonTeam1.Name = "radioButtonTeam1";
            this.radioButtonTeam1.Size = new System.Drawing.Size(54, 41);
            this.radioButtonTeam1.TabIndex = 9;
            this.radioButtonTeam1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeam2
            // 
            this.radioButtonTeam2.AutoSize = true;
            this.radioButtonTeam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTeam2.Image = ((System.Drawing.Image)(resources.GetObject("radioButtonTeam2.Image")));
            this.radioButtonTeam2.Location = new System.Drawing.Point(689, 249);
            this.radioButtonTeam2.Name = "radioButtonTeam2";
            this.radioButtonTeam2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonTeam2.Size = new System.Drawing.Size(54, 41);
            this.radioButtonTeam2.TabIndex = 10;
            this.radioButtonTeam2.UseVisualStyleBackColor = true;
            // 
            // textBoxRocksLeftTeam1
            // 
            this.textBoxRocksLeftTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxRocksLeftTeam1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRocksLeftTeam1.Location = new System.Drawing.Point(162, 291);
            this.textBoxRocksLeftTeam1.Name = "textBoxRocksLeftTeam1";
            this.textBoxRocksLeftTeam1.ReadOnly = true;
            this.textBoxRocksLeftTeam1.Size = new System.Drawing.Size(25, 32);
            this.textBoxRocksLeftTeam1.TabIndex = 16;
            this.textBoxRocksLeftTeam1.TabStop = false;
            this.textBoxRocksLeftTeam1.Text = "8";
            // 
            // textBoxRocksLeftTeam2
            // 
            this.textBoxRocksLeftTeam2.BackColor = System.Drawing.Color.Yellow;
            this.textBoxRocksLeftTeam2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRocksLeftTeam2.Location = new System.Drawing.Point(658, 291);
            this.textBoxRocksLeftTeam2.Name = "textBoxRocksLeftTeam2";
            this.textBoxRocksLeftTeam2.ReadOnly = true;
            this.textBoxRocksLeftTeam2.Size = new System.Drawing.Size(25, 32);
            this.textBoxRocksLeftTeam2.TabIndex = 20;
            this.textBoxRocksLeftTeam2.TabStop = false;
            this.textBoxRocksLeftTeam2.Text = "8";
            // 
            // textBoxTeam1
            // 
            this.textBoxTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxTeam1.Font = new System.Drawing.Font("Arial", 110F, System.Drawing.FontStyle.Bold);
            this.textBoxTeam1.Location = new System.Drawing.Point(6, 66);
            this.textBoxTeam1.Name = "textBoxTeam1";
            this.textBoxTeam1.ReadOnly = true;
            this.textBoxTeam1.Size = new System.Drawing.Size(382, 176);
            this.textBoxTeam1.TabIndex = 7;
            this.textBoxTeam1.TabStop = false;
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeIn.Location = new System.Drawing.Point(272, 248);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(116, 46);
            this.buttonTimeIn.TabIndex = 12;
            this.buttonTimeIn.Text = "Time &In";
            this.buttonTimeIn.UseVisualStyleBackColor = true;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(287, 254);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 36);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Time";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Rocks remaining:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rocks remaining:";
            // 
            // textBoxCurrentEnd
            // 
            this.textBoxCurrentEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrentEnd.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentEnd.Location = new System.Drawing.Point(426, 27);
            this.textBoxCurrentEnd.Name = "textBoxCurrentEnd";
            this.textBoxCurrentEnd.ReadOnly = true;
            this.textBoxCurrentEnd.Size = new System.Drawing.Size(23, 37);
            this.textBoxCurrentEnd.TabIndex = 4;
            this.textBoxCurrentEnd.TabStop = false;
            this.textBoxCurrentEnd.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current end:";
            // 
            // buttonDummy
            // 
            this.buttonDummy.Location = new System.Drawing.Point(365, 302);
            this.buttonDummy.Name = "buttonDummy";
            this.buttonDummy.Size = new System.Drawing.Size(32, 21);
            this.buttonDummy.TabIndex = 18;
            this.buttonDummy.Text = "button1";
            this.buttonDummy.UseVisualStyleBackColor = true;
            this.buttonDummy.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Time out left:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time out left:";
            // 
            // textBoxTOLeftTeam2
            // 
            this.textBoxTOLeftTeam2.BackColor = System.Drawing.Color.Yellow;
            this.textBoxTOLeftTeam2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTOLeftTeam2.Location = new System.Drawing.Point(689, 26);
            this.textBoxTOLeftTeam2.Name = "textBoxTOLeftTeam2";
            this.textBoxTOLeftTeam2.ReadOnly = true;
            this.textBoxTOLeftTeam2.Size = new System.Drawing.Size(25, 32);
            this.textBoxTOLeftTeam2.TabIndex = 6;
            this.textBoxTOLeftTeam2.TabStop = false;
            this.textBoxTOLeftTeam2.Text = "2";
            // 
            // textBoxTOLeftTeam1
            // 
            this.textBoxTOLeftTeam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBoxTOLeftTeam1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTOLeftTeam1.Location = new System.Drawing.Point(193, 26);
            this.textBoxTOLeftTeam1.Name = "textBoxTOLeftTeam1";
            this.textBoxTOLeftTeam1.ReadOnly = true;
            this.textBoxTOLeftTeam1.Size = new System.Drawing.Size(25, 32);
            this.textBoxTOLeftTeam1.TabIndex = 2;
            this.textBoxTOLeftTeam1.TabStop = false;
            this.textBoxTOLeftTeam1.Text = "2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem1,
            this.changeTimigToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.timeOutToolStripMenuItem,
            this.stopTimingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.settingsToolStripMenuItem.Text = "&Tools";
            // 
            // historyToolStripMenuItem1
            // 
            this.historyToolStripMenuItem1.Name = "historyToolStripMenuItem1";
            this.historyToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.historyToolStripMenuItem1.Text = "&History...";
            this.historyToolStripMenuItem1.Click += new System.EventHandler(this.historyToolStripMenuItem1_Click);
            // 
            // changeTimigToolStripMenuItem
            // 
            this.changeTimigToolStripMenuItem.Name = "changeTimigToolStripMenuItem";
            this.changeTimigToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.changeTimigToolStripMenuItem.Text = "&Change Timing...";
            this.changeTimigToolStripMenuItem.Click += new System.EventHandler(this.changeTimigToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // timeOutToolStripMenuItem
            // 
            this.timeOutToolStripMenuItem.Name = "timeOutToolStripMenuItem";
            this.timeOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.timeOutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.timeOutToolStripMenuItem.Text = "&Time-Out";
            this.timeOutToolStripMenuItem.Visible = false;
            this.timeOutToolStripMenuItem.Click += new System.EventHandler(this.buttonTimeOut_Click);
            // 
            // stopTimingToolStripMenuItem
            // 
            this.stopTimingToolStripMenuItem.Enabled = false;
            this.stopTimingToolStripMenuItem.Name = "stopTimingToolStripMenuItem";
            this.stopTimingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stopTimingToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.stopTimingToolStripMenuItem.Text = "&Stop Timing";
            this.stopTimingToolStripMenuItem.Click += new System.EventHandler(this.stopTimingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // pbTeam1Status
            // 
            this.pbTeam1Status.Image = global::PLS.Curling.Properties.Resources.YellowDot;
            this.pbTeam1Status.Location = new System.Drawing.Point(162, 254);
            this.pbTeam1Status.Name = "pbTeam1Status";
            this.pbTeam1Status.Size = new System.Drawing.Size(17, 19);
            this.pbTeam1Status.TabIndex = 21;
            this.pbTeam1Status.TabStop = false;
            // 
            // pbTeam2Status
            // 
            this.pbTeam2Status.Image = global::PLS.Curling.Properties.Resources.YellowDot;
            this.pbTeam2Status.Location = new System.Drawing.Point(591, 254);
            this.pbTeam2Status.Name = "pbTeam2Status";
            this.pbTeam2Status.Size = new System.Drawing.Size(17, 19);
            this.pbTeam2Status.TabIndex = 22;
            this.pbTeam2Status.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 343);
            this.ControlBox = false;
            this.Controls.Add(this.pbTeam2Status);
            this.Controls.Add(this.pbTeam1Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTOLeftTeam2);
            this.Controls.Add(this.textBoxTOLeftTeam1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTimeIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCurrentEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeam1);
            this.Controls.Add(this.textBoxRocksLeftTeam2);
            this.Controls.Add(this.textBoxRocksLeftTeam1);
            this.Controls.Add(this.radioButtonTeam2);
            this.Controls.Add(this.radioButtonTeam1);
            this.Controls.Add(this.buttonTimeOut);
            this.Controls.Add(this.textBoxTeam2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonDummy);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competitive Curling Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2Status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxTeam2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button buttonTimeOut;
		private System.Windows.Forms.RadioButton radioButtonTeam1;
		private System.Windows.Forms.RadioButton radioButtonTeam2;
		private System.Windows.Forms.TextBox textBoxRocksLeftTeam1;
		private System.Windows.Forms.TextBox textBoxRocksLeftTeam2;
		private System.Windows.Forms.TextBox textBoxTeam1;
		private System.Windows.Forms.Button buttonTimeIn;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCurrentEnd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonDummy;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxTOLeftTeam2;
		private System.Windows.Forms.TextBox textBoxTOLeftTeam1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeTimigToolStripMenuItem;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.ToolStripMenuItem timeOutToolStripMenuItem;
		private System.Windows.Forms.PictureBox pbTeam1Status;
		private System.Windows.Forms.PictureBox pbTeam2Status;
		private System.Windows.Forms.ToolStripMenuItem stopTimingToolStripMenuItem;
	}
}


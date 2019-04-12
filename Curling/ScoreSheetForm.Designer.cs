namespace PLS.Curling {
	partial class ScoreSheetForm {
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Team1TimeUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Team1TimeOutUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time2TimeUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Time2TimeOutUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.End,
            this.Team1TimeUsed,
            this.Team1TimeOutUsed,
            this.Time2TimeUsed,
            this.Time2TimeOutUsed});
			this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(296, 212);
			this.dataGridView1.TabIndex = 0;
			// 
			// End
			// 
			this.End.HeaderText = "End";
			this.End.Name = "End";
			this.End.ReadOnly = true;
			this.End.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.End.Width = 30;
			// 
			// Team1TimeUsed
			// 
			this.Team1TimeUsed.HeaderText = "Time Used Team 1";
			this.Team1TimeUsed.Name = "Team1TimeUsed";
			this.Team1TimeUsed.ReadOnly = true;
			this.Team1TimeUsed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Team1TimeUsed.Width = 60;
			// 
			// Team1TimeOutUsed
			// 
			this.Team1TimeOutUsed.HeaderText = "Timeout Used Team 1";
			this.Team1TimeOutUsed.Name = "Team1TimeOutUsed";
			this.Team1TimeOutUsed.ReadOnly = true;
			this.Team1TimeOutUsed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Team1TimeOutUsed.Width = 50;
			// 
			// Time2TimeUsed
			// 
			this.Time2TimeUsed.HeaderText = "Time Used Team 2";
			this.Time2TimeUsed.Name = "Time2TimeUsed";
			this.Time2TimeUsed.ReadOnly = true;
			this.Time2TimeUsed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Time2TimeUsed.Width = 60;
			// 
			// Time2TimeOutUsed
			// 
			this.Time2TimeOutUsed.HeaderText = "Timeout Used Team 2";
			this.Time2TimeOutUsed.Name = "Time2TimeOutUsed";
			this.Time2TimeOutUsed.ReadOnly = true;
			this.Time2TimeOutUsed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Time2TimeOutUsed.Width = 50;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 29);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ScoreSheetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(288, 266);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScoreSheetForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ScoreSheetForm";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn End;
		private System.Windows.Forms.DataGridViewTextBoxColumn Team1TimeUsed;
		private System.Windows.Forms.DataGridViewTextBoxColumn Team1TimeOutUsed;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time2TimeUsed;
		private System.Windows.Forms.DataGridViewTextBoxColumn Time2TimeOutUsed;
	}
}
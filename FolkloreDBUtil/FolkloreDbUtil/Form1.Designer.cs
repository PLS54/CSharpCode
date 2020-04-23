namespace SimpleCsharpCRUD {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAdresseLigne2Ville = new System.Windows.Forms.TextBox();
            this.numericUpDownNoEnfants = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChoixCourriel = new System.Windows.Forms.ComboBox();
            this.comboBoxStatusMembre = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeDeMembership = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNoEnfants = new System.Windows.Forms.Label();
            this.labelNomConjoint = new System.Windows.Forms.Label();
            this.textBoxNomConjoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSansNoMembre = new System.Windows.Forms.CheckBox();
            this.checkBoxAvecNoMembres = new System.Windows.Forms.CheckBox();
            this.checkBoxActives = new System.Windows.Forms.CheckBox();
            this.checkBoxEchue = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxWhereClause = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNoMembre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dateTimeRenouvellemt = new System.Windows.Forms.DateTimePicker();
            this.buttonAjout1An = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBoxAdresseLigne2CodePostal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxProvinces = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoEnfants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProvinces);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxAdresseLigne2CodePostal);
            this.groupBox1.Controls.Add(this.buttonAjout1An);
            this.groupBox1.Controls.Add(this.dateTimeRenouvellemt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxAdresseLigne2Ville);
            this.groupBox1.Controls.Add(this.numericUpDownNoEnfants);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxChoixCourriel);
            this.groupBox1.Controls.Add(this.textBoxNoMembre);
            this.groupBox1.Controls.Add(this.comboBoxStatusMembre);
            this.groupBox1.Controls.Add(this.comboBoxTypeDeMembership);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.labelNoEnfants);
            this.groupBox1.Controls.Add(this.labelNomConjoint);
            this.groupBox1.Controls.Add(this.textBoxNomConjoint);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAdresse);
            this.groupBox1.Controls.Add(this.textBoxCourriel);
            this.groupBox1.Controls.Add(this.textBoxPrenom);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membre";
            // 
            // textBoxAdresseLigne2Ville
            // 
            this.textBoxAdresseLigne2Ville.Location = new System.Drawing.Point(330, 119);
            this.textBoxAdresseLigne2Ville.Name = "textBoxAdresseLigne2Ville";
            this.textBoxAdresseLigne2Ville.Size = new System.Drawing.Size(144, 20);
            this.textBoxAdresseLigne2Ville.TabIndex = 18;
            this.textBoxAdresseLigne2Ville.TextChanged += new System.EventHandler(this.ChampAdresseChange);
            // 
            // numericUpDownNoEnfants
            // 
            this.numericUpDownNoEnfants.Location = new System.Drawing.Point(550, 147);
            this.numericUpDownNoEnfants.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNoEnfants.Name = "numericUpDownNoEnfants";
            this.numericUpDownNoEnfants.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownNoEnfants.TabIndex = 28;
            this.numericUpDownNoEnfants.ValueChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // comboBoxChoixCourriel
            // 
            this.comboBoxChoixCourriel.FormattingEnabled = true;
            this.comboBoxChoixCourriel.Location = new System.Drawing.Point(521, 93);
            this.comboBoxChoixCourriel.Name = "comboBoxChoixCourriel";
            this.comboBoxChoixCourriel.Size = new System.Drawing.Size(166, 21);
            this.comboBoxChoixCourriel.TabIndex = 14;
            this.comboBoxChoixCourriel.SelectedIndexChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // comboBoxStatusMembre
            // 
            this.comboBoxStatusMembre.FormattingEnabled = true;
            this.comboBoxStatusMembre.Location = new System.Drawing.Point(522, 68);
            this.comboBoxStatusMembre.Name = "comboBoxStatusMembre";
            this.comboBoxStatusMembre.Size = new System.Drawing.Size(165, 21);
            this.comboBoxStatusMembre.TabIndex = 10;
            this.comboBoxStatusMembre.SelectedIndexChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // comboBoxTypeDeMembership
            // 
            this.comboBoxTypeDeMembership.FormattingEnabled = true;
            this.comboBoxTypeDeMembership.Location = new System.Drawing.Point(89, 146);
            this.comboBoxTypeDeMembership.Name = "comboBoxTypeDeMembership";
            this.comboBoxTypeDeMembership.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeDeMembership.TabIndex = 24;
            this.comboBoxTypeDeMembership.SelectedIndexChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(436, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Choix courriel";
            // 
            // labelNoEnfants
            // 
            this.labelNoEnfants.AutoSize = true;
            this.labelNoEnfants.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoEnfants.Location = new System.Drawing.Point(475, 146);
            this.labelNoEnfants.Name = "labelNoEnfants";
            this.labelNoEnfants.Size = new System.Drawing.Size(69, 16);
            this.labelNoEnfants.TabIndex = 27;
            this.labelNoEnfants.Text = "No. Enfants";
            // 
            // labelNomConjoint
            // 
            this.labelNomConjoint.AutoSize = true;
            this.labelNomConjoint.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomConjoint.Location = new System.Drawing.Point(229, 145);
            this.labelNomConjoint.Name = "labelNomConjoint";
            this.labelNomConjoint.Size = new System.Drawing.Size(80, 16);
            this.labelNomConjoint.TabIndex = 25;
            this.labelNomConjoint.Text = "Nom conjoint";
            // 
            // textBoxNomConjoint
            // 
            this.textBoxNomConjoint.Location = new System.Drawing.Point(325, 144);
            this.textBoxNomConjoint.Name = "textBoxNomConjoint";
            this.textBoxNomConjoint.Size = new System.Drawing.Size(139, 20);
            this.textBoxNomConjoint.TabIndex = 26;
            this.textBoxNomConjoint.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adresse Ligne 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Courriel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de Famille";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(123, 119);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(165, 20);
            this.textBoxAdresse.TabIndex = 16;
            this.textBoxAdresse.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxCourriel.Location = new System.Drawing.Point(88, 93);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(332, 20);
            this.textBoxCourriel.TabIndex = 12;
            this.textBoxCourriel.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            this.textBoxCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCourriel_Validating);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(89, 70);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(106, 20);
            this.textBoxPrenom.TabIndex = 6;
            this.textBoxPrenom.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(314, 71);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(106, 20);
            this.textBoxNom.TabIndex = 8;
            this.textBoxNom.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1111, 263);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSelectionOccured);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.checkBoxSansNoMembre);
            this.panel1.Controls.Add(this.checkBoxAvecNoMembres);
            this.panel1.Controls.Add(this.checkBoxActives);
            this.panel1.Controls.Add(this.checkBoxEchue);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBoxWhereClause);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-6, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 50);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxSansNoMembre
            // 
            this.checkBoxSansNoMembre.AutoSize = true;
            this.checkBoxSansNoMembre.Checked = true;
            this.checkBoxSansNoMembre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSansNoMembre.Location = new System.Drawing.Point(583, 28);
            this.checkBoxSansNoMembre.Name = "checkBoxSansNoMembre";
            this.checkBoxSansNoMembre.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSansNoMembre.TabIndex = 8;
            this.checkBoxSansNoMembre.Text = "Sans no. membre";
            this.checkBoxSansNoMembre.UseVisualStyleBackColor = true;
            this.checkBoxSansNoMembre.CheckedChanged += new System.EventHandler(this.controlSearhChanged);
            // 
            // checkBoxAvecNoMembres
            // 
            this.checkBoxAvecNoMembres.AutoSize = true;
            this.checkBoxAvecNoMembres.Checked = true;
            this.checkBoxAvecNoMembres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAvecNoMembres.Location = new System.Drawing.Point(583, 10);
            this.checkBoxAvecNoMembres.Name = "checkBoxAvecNoMembres";
            this.checkBoxAvecNoMembres.Size = new System.Drawing.Size(109, 17);
            this.checkBoxAvecNoMembres.TabIndex = 7;
            this.checkBoxAvecNoMembres.Text = "Avec no. membre";
            this.checkBoxAvecNoMembres.UseVisualStyleBackColor = true;
            this.checkBoxAvecNoMembres.CheckStateChanged += new System.EventHandler(this.controlSearhChanged);
            // 
            // checkBoxActives
            // 
            this.checkBoxActives.AutoSize = true;
            this.checkBoxActives.Checked = true;
            this.checkBoxActives.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActives.Location = new System.Drawing.Point(515, 12);
            this.checkBoxActives.Name = "checkBoxActives";
            this.checkBoxActives.Size = new System.Drawing.Size(61, 17);
            this.checkBoxActives.TabIndex = 5;
            this.checkBoxActives.Text = "Actives";
            this.checkBoxActives.UseVisualStyleBackColor = true;
            this.checkBoxActives.CheckStateChanged += new System.EventHandler(this.controlSearhChanged);
            // 
            // checkBoxEchue
            // 
            this.checkBoxEchue.AutoSize = true;
            this.checkBoxEchue.Checked = true;
            this.checkBoxEchue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEchue.Location = new System.Drawing.Point(515, 26);
            this.checkBoxEchue.Name = "checkBoxEchue";
            this.checkBoxEchue.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEchue.TabIndex = 6;
            this.checkBoxEchue.Text = "Echues";
            this.checkBoxEchue.UseVisualStyleBackColor = true;
            this.checkBoxEchue.CheckStateChanged += new System.EventHandler(this.controlSearhChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(357, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nom";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(1032, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "&Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxWhereClause
            // 
            this.textBoxWhereClause.Location = new System.Drawing.Point(397, 17);
            this.textBoxWhereClause.Name = "textBoxWhereClause";
            this.textBoxWhereClause.Size = new System.Drawing.Size(106, 20);
            this.textBoxWhereClause.TabIndex = 4;
            this.textBoxWhereClause.TextChanged += new System.EventHandler(this.controlSearhChanged);
            this.textBoxWhereClause.Leave += new System.EventHandler(this.controlSearhChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(209, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "&Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Location = new System.Drawing.Point(118, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 29);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "&New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "No. Membre";
            // 
            // textBoxNoMembre
            // 
            this.textBoxNoMembre.Location = new System.Drawing.Point(208, 28);
            this.textBoxNoMembre.MaxLength = 4;
            this.textBoxNoMembre.Name = "textBoxNoMembre";
            this.textBoxNoMembre.Size = new System.Drawing.Size(38, 20);
            this.textBoxNoMembre.TabIndex = 1;
            this.textBoxNoMembre.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            this.textBoxNoMembre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoMembre_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date de renouvellement";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(959, 24);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(36, 20);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.Visible = false;
            this.textBoxID.TextChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // dateTimeRenouvellemt
            // 
            this.dateTimeRenouvellemt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeRenouvellemt.Location = new System.Drawing.Point(423, 25);
            this.dateTimeRenouvellemt.Name = "dateTimeRenouvellemt";
            this.dateTimeRenouvellemt.Size = new System.Drawing.Size(108, 20);
            this.dateTimeRenouvellemt.TabIndex = 3;
            this.dateTimeRenouvellemt.ValueChanged += new System.EventHandler(this.ValeurChampModifier);
            // 
            // buttonAjout1An
            // 
            this.buttonAjout1An.Location = new System.Drawing.Point(543, 25);
            this.buttonAjout1An.Name = "buttonAjout1An";
            this.buttonAjout1An.Size = new System.Drawing.Size(32, 19);
            this.buttonAjout1An.TabIndex = 4;
            this.buttonAjout1An.Text = "+1";
            this.buttonAjout1An.UseVisualStyleBackColor = true;
            this.buttonAjout1An.Click += new System.EventHandler(this.buttonAjout1An_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(40, 128);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(51, 20);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "label8";
            // 
            // textBoxAdresseLigne2CodePostal
            // 
            this.textBoxAdresseLigne2CodePostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxAdresseLigne2CodePostal.Location = new System.Drawing.Point(638, 119);
            this.textBoxAdresseLigne2CodePostal.MaxLength = 7;
            this.textBoxAdresseLigne2CodePostal.Name = "textBoxAdresseLigne2CodePostal";
            this.textBoxAdresseLigne2CodePostal.Size = new System.Drawing.Size(49, 20);
            this.textBoxAdresseLigne2CodePostal.TabIndex = 22;
            this.textBoxAdresseLigne2CodePostal.WordWrap = false;
            this.textBoxAdresseLigne2CodePostal.TextChanged += new System.EventHandler(this.ChampAdresseChange);
            this.textBoxAdresseLigne2CodePostal.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdresseLigne2CodePostal_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ville";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Prov.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Code Postal";
            // 
            // comboBoxProvinces
            // 
            this.comboBoxProvinces.FormattingEnabled = true;
            this.comboBoxProvinces.Location = new System.Drawing.Point(521, 118);
            this.comboBoxProvinces.Name = "comboBoxProvinces";
            this.comboBoxProvinces.Size = new System.Drawing.Size(41, 21);
            this.comboBoxProvinces.TabIndex = 20;
            this.comboBoxProvinces.SelectedIndexChanged += new System.EventHandler(this.ChampAdresseChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 545);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Adhésions Folklore Outaouais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoEnfants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxNoMembre;
		private System.Windows.Forms.Label labelNoEnfants;
		private System.Windows.Forms.Label labelNomConjoint;
		private System.Windows.Forms.TextBox textBoxNomConjoint;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxWhereClause;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.ComboBox comboBoxStatusMembre;
		private System.Windows.Forms.ComboBox comboBoxChoixCourriel;
		private System.Windows.Forms.ComboBox comboBoxTypeDeMembership;
		private System.Windows.Forms.DateTimePicker dateTimeRenouvellemt;
		private System.Windows.Forms.Button buttonAjout1An;
		private System.Windows.Forms.CheckBox checkBoxActives;
		private System.Windows.Forms.CheckBox checkBoxEchue;
		private System.Windows.Forms.CheckBox checkBoxAvecNoMembres;
		private System.Windows.Forms.CheckBox checkBoxSansNoMembre;
		private System.Windows.Forms.NumericUpDown numericUpDownNoEnfants;
		private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxAdresseLigne2Ville;
        private System.Windows.Forms.TextBox textBoxAdresseLigne2CodePostal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProvinces;
    }
}


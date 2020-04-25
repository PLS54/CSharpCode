using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Text.RegularExpressions;

namespace SimpleCsharpCRUD
{

    public partial class Form1 : Form
    {
        private int ID { get; set; }
        private List<Control> EditControls { get; set; }
        private Boolean NewData { get; set; }
        //
        private SqlConnection Connection = new SqlConnection($"Data Source={ConfigurationManager.AppSettings["DataSource"]};Initial Catalog=FolkloreOAdhesions;Integrated Security=true;");
        public Form1()
        {
            ID = -1;
            InitializeComponent();
            labelVersion.Text = $"Version : {typeof(Form1).Assembly.GetName().Version}";
            InitializeEditControlList();
            InitializeComboBoxes();
        }
        private void InitializeEditControlList()
        {
            EditControls = new List<Control>();
            textBoxID.Tag = new DescriptionControl("ID");
            textBoxAdresse.Tag = new DescriptionControl("Adresse");
            textBoxCourriel.Tag = new DescriptionControl("Courriel");
            comboBoxChoixCourriel.Tag = new DescriptionControl("Choix", "ChoixCourriel");
            textBoxNom.Tag = new DescriptionControl("Nom", "NomFamille");
            textBoxPrenom.Tag = new DescriptionControl("Prénom");
            comboBoxStatusMembre.Tag = new DescriptionControl("Status", "StatusMembre");
            textBoxNoMembre.Tag = new DescriptionControl("No Membre", "NoMembre", typeof(int));
            dateTimeRenouvellemt.Tag = new DescriptionControl("Date renouv.", "DateRenouvellement");
            comboBoxTypeDeMembership.Tag = new DescriptionControl("Type de membre", "TypeDeMembre");
            textBoxNomConjoint.Tag = new DescriptionControl("Nom conjoint", "Conjoint");
            numericUpDownNoEnfants.Tag = new DescriptionControl("No. enfants", "NombresEnfants");
            //
            EditControls.Add(textBoxID);
            EditControls.Add(textBoxNom);
            EditControls.Add(textBoxPrenom);
            EditControls.Add(comboBoxStatusMembre);
            EditControls.Add(textBoxCourriel);
            EditControls.Add(comboBoxChoixCourriel);
            EditControls.Add(textBoxAdresse);
            EditControls.Add(textBoxNoMembre);
            EditControls.Add(dateTimeRenouvellemt);
            EditControls.Add(comboBoxTypeDeMembership);
            EditControls.Add(textBoxNomConjoint);
            EditControls.Add(numericUpDownNoEnfants);
        }
        private void InitializeComboBoxes()
        {
            InitComboWithDB(comboBoxStatusMembre, "StatusMembre", "CodeDeStatus", "Description");
            InitComboWithDB(comboBoxChoixCourriel, "ChoixCourriel", "CodeDeChoix", "Description");
            InitComboWithDB(comboBoxTypeDeMembership, "TypeDeMembre", "TypeDeMembre", "Description");
            InitComboWithDB(comboBoxProvinces, "Provinces", "CodeProv", "DescProv");
        }
        private void InitComboWithDB(ComboBox combo, string tableName, string code, string description)
        {
            try {
                string s = $"SELECT {code}, {description} FROM {tableName}";
                SqlCommand sqlCommand = new SqlCommand($"SELECT {code}, {description} FROM {tableName}", Connection);
                if (Connection.State == ConnectionState.Closed) {
                    Connection.Open();
                }
                using (SqlDataReader sqlReader = sqlCommand.ExecuteReader()) {
                    ArrayList statusMembres = new ArrayList();
                    while (sqlReader.Read()) {
                        statusMembres.Add(new StatusMembre((string)sqlReader[code], (string)sqlReader[description].ToString().TrimEnd(' ')));
                    }
                    combo.DataSource = statusMembres;
                    combo.ValueMember = "CodeDeStatus";
                    combo.DisplayMember = description;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(1);
            } finally {
                //Connection.Close();
            }
        }
        private void LoadData()
        {
            List<string> updates = new List<string>();
            string sqlCommand = "SELECT ";
            foreach (Control control in EditControls) {
                DescriptionControl dc = control.Tag as DescriptionControl;
                sqlCommand += $"{dc.AliasDuChamp} as '{dc.NomDuChamps}', ";
            }
            sqlCommand = sqlCommand.Substring(0, sqlCommand.Length - 2);
            sqlCommand += $" FROM Membership ";
            sqlCommand += $"WHERE NomFamille LIKE '{textBoxWhereClause.Text}%'";
            DateTime refDate = DateTime.Now;
            if (checkBoxActives.Checked || checkBoxEchue.Checked) {
                if (!(checkBoxActives.Checked && checkBoxEchue.Checked)) {
                    if (checkBoxEchue.Checked) {
                        sqlCommand += " AND ";
                        sqlCommand += $"DateRenouvellement < '{refDate.ToShortDateString()}'";
                    }
                    if (checkBoxActives.Checked) {
                        sqlCommand += " AND ";
                        sqlCommand += $"DateRenouvellement >= '{refDate.ToShortDateString()}'";
                    }
                }
            } else {
                sqlCommand += " AND ";
                sqlCommand += $"DateRenouvellement = '{new DateTime(2000, 1, 1).ToShortDateString()}'";
            }
            if (checkBoxAvecNoMembres.Checked || checkBoxSansNoMembre.Checked) {
                if (!(checkBoxAvecNoMembres.Checked && checkBoxSansNoMembre.Checked)) {
                    if (checkBoxSansNoMembre.Checked) {
                        sqlCommand += " AND ";
                        sqlCommand += "NoMembre IS NULL";
                    }
                    if (checkBoxAvecNoMembres.Checked) {
                        sqlCommand += " AND ";
                        sqlCommand += "NoMembre IS NOT NULL";
                    }
                }
            } else {
                sqlCommand += " AND ";
                sqlCommand += $"DateRenouvellement = '{new DateTime(2000, 1, 1).ToShortDateString()}'";
            }
            sqlCommand += " ORDER BY NomFamille";
            if (checkBoxActives.Checked || checkBoxEchue.Checked) {

            }
            try {
                if (Connection.State == ConnectionState.Closed) {
                    Connection.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter(sqlCommand, Connection)) {
                    using (DataTable dt = new DataTable()) {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                dataGridView1.Rows[0].Selected = true;
            } finally { 
                //Connection.Close();
            }
        }
        private void UpdateData(string sql)
        {
            try {
                if (Connection.State == ConnectionState.Closed) {
                    Connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = Connection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                ClearFieldNeedsUpdate();
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            } finally {
                //Connection.Close();
            }
        }
        private void ClearText()
        {
            textBoxAdresseLigne2CodePostal.Text = string.Empty;
            comboBoxProvinces.SelectedIndex = 0;
            textBoxAdresseLigne2Ville.Text = string.Empty;
            foreach (Control control in EditControls) {
                if (control is ComboBox) {
                    ComboBox cb = control as ComboBox;
                    cb.SelectedIndex = 0;
                } else {
                    control.Text = string.Empty;
                }
            }
        }
        private void ClearFieldNeedsUpdate()
        {
            textBoxAdresseLigne2Ville.ForeColor = Color.Black;
            comboBoxProvinces.ForeColor = Color.Black;
            textBoxAdresseLigne2CodePostal.ForeColor = Color.Black;
            errorProvider.Clear();
            buttonSave.Enabled = true;
            foreach (Control c in EditControls) {
                DescriptionControl dc = c.Tag as DescriptionControl;
                dc.ChampEdite = false;
                c.ForeColor = Color.Black;
            }
        }
        private void ShowHideFamiliale()
        {
            StatusMembre sm = comboBoxTypeDeMembership.SelectedItem as StatusMembre;
            if (sm == null) {
                return;
            }
            textBoxNomConjoint.Visible = true;
            numericUpDownNoEnfants.Visible = true;
            labelNomConjoint.Visible = true;
            labelNoEnfants.Visible = true;
            if (sm.CodeDeStatus == "I") {
                textBoxNomConjoint.Visible = false;
                textBoxNomConjoint.Text = string.Empty;
                numericUpDownNoEnfants.Visible = false;
                numericUpDownNoEnfants.Text = "0";
                labelNomConjoint.Visible = false;
                labelNoEnfants.Visible = false;
            }
        }
        private void SetControlDBValue(Control control, string value)
        {
            ComboBox combo = control as ComboBox;
            DateTimePicker dtp = control as DateTimePicker;
            if (combo != null) {
                combo.SelectedValue = value.TrimEnd(' ');
            } else if (dtp != null) {
                dtp.Value = DateTime.Parse(value);
            } else {
                if (control == textBoxAdresse) {
                    string[] lines = value.TrimEnd(' ').Split(',');
                    control.Text = lines[0];
                    if (lines.Length > 1) {
                        textBoxAdresseLigne2Ville.Text = lines[1].Substring(1, lines[1].Length - 12);
                        string villeEtZip = lines[1].Substring(lines[1].Length - 10);
                        comboBoxProvinces.Text = villeEtZip.Substring(0, villeEtZip.Length - 8);
                        textBoxAdresseLigne2CodePostal.Text = villeEtZip.Substring(villeEtZip.Length - 7);
                    }
                } else {
                    control.Text = value.TrimEnd(' ');
                }
            }
        }
        private string GetControlDBValue(Control control)
        {
            ComboBox combo = control as ComboBox;
            DateTimePicker dtp = control as DateTimePicker;
            if (combo != null) {
                return combo.SelectedValue.ToString();
            } else if (dtp != null) {
                return dtp.Value.ToShortDateString();
            }
            string textToUpdate = control.Text.Replace("'", "''");
            if (control == textBoxAdresse) {
                textToUpdate = $"{textBoxAdresse.Text.Replace("'", "''")}, {textBoxAdresseLigne2Ville.Text.Replace("'", "''")} {comboBoxProvinces.Text.Replace("'", "''")} {textBoxAdresseLigne2CodePostal.Text.Replace("'", "''")}";
            }
            return textToUpdate;
        }
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            NewData = true;
            LoadData();
        }
        private void dataGridViewSelectionOccured(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
            ID = (int)rows.Cells["ID"].Value;
            foreach (Control control in EditControls) {
                DescriptionControl dc = control.Tag as DescriptionControl;
                SetControlDBValue(control, rows.Cells[dc.NomDuChamps].Value.ToString());
            }
            NewData = false;
            ClearFieldNeedsUpdate();
            ShowHideFamiliale();
            buttonAjout1An.Enabled = true;
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            // its method for add new data,
            // we will declaration NewData to true if we want to add new data
            // if newdata= false, so we will Update while eksisting data
            NewData = true;
            ClearText();
            comboBoxStatusMembre.SelectedValue = "R";
            comboBoxChoixCourriel.SelectedValue = "O";
            comboBoxTypeDeMembership.SelectedValue = "I";
            dateTimeRenouvellemt.Value = DateTime.Now + new TimeSpan(DaysInNextYear(DateTime.Now), 0, 0, 0);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(errorProvider.GetError(textBoxCourriel))) {
                return;
            }
            DialogResult Message;
            string sqlCommand = "";
            if (NewData == true) {
                Message = MessageBox.Show("Are you sure to add new data into database?", "Informations", MessageBoxButtons.YesNo);
                if (Message == DialogResult.No) {
                    return;
                }
                List<string> fields = new List<string>();
                List<string> values = new List<string>();
                foreach (Control control in EditControls) {
                    DescriptionControl dc = control.Tag as DescriptionControl;
                    if (string.Compare(dc.AliasDuChamp, "ID", StringComparison.InvariantCultureIgnoreCase) != 0) {
                        fields.Add($"{dc.AliasDuChamp}, ");
                        if (dc.TypeOf == typeof(string)) {
                            values.Add($"'{GetControlDBValue(control)}', ");
                        } else if (dc.TypeOf == typeof(int)) {
                            string text = string.IsNullOrWhiteSpace(control.Text) ? "NULL, " : $"{control.Text}, ";
                            values.Add(string.IsNullOrWhiteSpace(control.Text) ? "NULL, " : $"{control.Text}, ");
                        }
                    }
                }
                sqlCommand = $"INSERT INTO Membership ({ConcatanateListOfString(fields)}) VALUES ({ConcatanateListOfString(values)})";
            } else {
                // UPDATE DATA
                List<string> updates = new List<string>();
                foreach (Control control in EditControls) {
                    DescriptionControl dc = control.Tag as DescriptionControl;
                    if (dc.ChampEdite) {
                        if (dc.TypeOf == typeof(string)) {
                            updates.Add($"{dc.AliasDuChamp}='{GetControlDBValue(control)}', ");
                        } else if (dc.TypeOf == typeof(int)) {
                            updates.Add($"{dc.AliasDuChamp}={GetControlDBValue(control)}, ");
                        }
                    }
                }
                if (updates.Count < 1) {
                    return;
                }
                sqlCommand = $"UPDATE Membership SET {ConcatanateListOfString(updates)} WHERE ID={ID}";
            }
            UpdateData(sqlCommand);
            LoadData();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DialogResult Message;
            string delete = "";
            Message = MessageBox.Show("Are you sure to delete this data?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No) {
                // if users click "NO" dialog, will exit the method and do nothing
                return;
            } else {
                // else, we will delete all data from selected id in TextBox1
                delete = $"DELETE from Membership WHERE id={ID}";
                // call functions update data to execute the string query
                UpdateData(delete);
                LoadData();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ValeurChampModifier(object sender, EventArgs e)
        {
            ((sender as Control).Tag as DescriptionControl).ChampEdite = true;
            (sender as Control).ForeColor = Color.Red;
            if (sender as Control == textBoxAdresse) {
                textBoxAdresseLigne2Ville.ForeColor = Color.Red;
                comboBoxProvinces.ForeColor = Color.Red;
                textBoxAdresseLigne2CodePostal.ForeColor = Color.Red;
            }
            ShowHideFamiliale();
        }
        private void ChampAdresseChange(object sender, EventArgs e)
        {
            (textBoxAdresse.Tag as DescriptionControl).ChampEdite = true;
            textBoxAdresse.ForeColor = Color.Red;
            textBoxAdresseLigne2Ville.ForeColor = Color.Red;
            comboBoxProvinces.ForeColor = Color.Red;
            textBoxAdresseLigne2CodePostal.ForeColor = Color.Red;
        }
        private void controlSearhChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void textBoxCourriel_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidEmail((sender as Control).Text);
            if (e.Cancel) {
                buttonSave.Enabled = false;
                errorProvider.SetError(sender as Control, "Couuriel non valide");
            } else {
                buttonSave.Enabled = true;
                errorProvider.Clear();
            }

        }
        private void textBoxAdresseLigne2CodePostal_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsCodePostalValide((sender as Control).Text);
            if (e.Cancel) {
                buttonSave.Enabled = false;
                errorProvider.SetError(sender as Control, "Code postal non valide");
            } else {
                buttonSave.Enabled = true;
                errorProvider.Clear();
            }
        }
        private void buttonAjout1An_Click(object sender, EventArgs e)
        {
            buttonAjout1An.Enabled = false;
            dateTimeRenouvellemt.Value += new TimeSpan(DaysInNextYear(dateTimeRenouvellemt.Value), 0, 0, 0);
            comboBoxStatusMembre.SelectedValue = "R";
        }
        private void textBoxNoMembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Connection.Close();
        }
        #endregion
        #region Statics
        private static int DaysInNextYear(DateTime from)
        {
            int daysToAdd = 365;
            if (from.Month >= 3 && DateTime.IsLeapYear(from.Year + 1)) {
                daysToAdd = 366;
            }
            if (from.Month < 3 && DateTime.IsLeapYear(from.Year)) {
                daysToAdd = 366;
            }
            return daysToAdd;
        }
        private static string ConcatanateListOfString(List<string> list)
        {
            string retString = string.Empty;
            foreach (string s in list) {
                retString += s;
            }
            return retString.Substring(0, retString.Length - 2);
        }
        private static bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            } catch {
                return false;
            }
        }
        private static bool IsCodePostalValide(string codePostal)
        {
            if (codePostal[3] != ' ') {
                return false;
            }
            return Regex.IsMatch(codePostal, "\\A[ABCEGHJKLMNPRSTVXY]\\d[A-Z] ?\\d[A-Z]\\d\\z");
        }
        #endregion
    }
    internal class DescriptionControl
    {
        internal string NomDuChamps { get; set; }
        internal string AliasDuChamp { get; set; }
        internal bool ChampEdite { get; set; }
        internal Type TypeOf { get; set; }
        internal DescriptionControl(string nomDuChamps, string alias)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = alias;
            ChampEdite = false;
            TypeOf = typeof(string);
        }
        internal DescriptionControl(string nomDuChamps, string alias, Type type)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = alias;
            ChampEdite = false;
            TypeOf = type;
        }
        internal DescriptionControl(string nomDuChamps)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = nomDuChamps;
            ChampEdite = false;
            TypeOf = typeof(string);
        }
        internal DescriptionControl(string nomDuChamps, Type type)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = nomDuChamps;
            ChampEdite = false;
            TypeOf = type;
        }
    }
    public class StatusMembre
    {
        public string CodeDeStatus { get; private set; }
        public string Description { get; private set; }
        internal StatusMembre()
        {
        }
        internal StatusMembre(string codeDeStatus, string description)
        {
            CodeDeStatus = codeDeStatus;
            Description = description;
        }
        public override string ToString()
        {
            return Description;
        }
    }
}

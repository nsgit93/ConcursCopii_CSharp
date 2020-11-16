using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistence;
using Services;
using Domain;
using Domain.Validator;

namespace Client
{
    public partial class AppGUI : Form
    {
        private Controller controller;

        public AppGUI(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            CustomizeComponents();
        }

        private void dataGridViewParticipanti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DataGridViewParticipanti_SelectionChanged(object sender, System.EventArgs e)
        {
            if (this.dataGridViewParticipanti.SelectedRows.Count != 0)
            {
                this.textBoxMainNume.Text = this.dataGridViewParticipanti.SelectedCells[1].Value.ToString();
                this.numericUpDownVarsta.Value = decimal.Parse(this.dataGridViewParticipanti.SelectedCells[2].Value.ToString());                
            }

        }

        private void loadDataGridViewParticipanti(IEnumerable<Participant> participanti)
        {
            dataGridViewParticipanti.Rows.Clear();
            foreach (Participant elem in participanti)
            {
                string[] line = { elem.ID.ToString(), elem.Nume, elem.Varsta.ToString(), elem.NumarParticipari.ToString() };
                this.dataGridViewParticipanti.Rows.Add(line);
            }
        }

        private void loadDataGridViewParticipari(IEnumerable<Participare> participari)
        {
            dataGridViewParticipari.Rows.Clear();
            foreach (Participare elem in participari)
            {
                string[] line = { elem.ID.ToString(), elem.IdParticipant.ToString(), elem.Proba, elem.CategorieVarsta };
                this.dataGridViewParticipari.Rows.Add(line);
            }
        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        public void Update(object sender, ChatUserEventArgs e)
        {
            if (e.UserEventType == ChatUserEvent.ParticipantAdaugat)
            {
                Participant participant = (Participant)e.Data;
                participantAdaugat(participant);
            }
            if (e.UserEventType == ChatUserEvent.ParticipareAdaugata)
            {
                ParticipareAdaugataInfo updateInfo = (ParticipareAdaugataInfo)e.Data;
                Participare participare = updateInfo.participare;
                Participant participant = updateInfo.participant;
                int nrComoara = updateInfo.nrComoara;
                int nrDesen = updateInfo.nrDesen;
                int nrPoezie = updateInfo.nrPoezie;
                participareAdaugata(participare, participant, nrComoara, nrDesen, nrPoezie);
            }
        }


        private void buttonJumpToMain_Click(object sender, EventArgs e)
        {
            string userName = textBoxLoginUser.Text;
            string parola = textBoxLoginPassword.Text;
            try
            {
                this.controller.Login(userName,parola);
                controller.updateEvent += Update;
                loadDataGridViewParticipanti(this.controller.GetParticipanti());
                loadDataGridViewParticipari(this.controller.GetParticipari());
                textBoxLoginPassword.Text = "";
                textBoxLoginUser.Text = "";
                labelLoginError.Text = "";
                tabControl.SelectedTab = tabPageMain;
            }

            catch(Exception se)
            {
                MessageBox.Show(this, "Login Error " + se.Message + se.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelLoginError.Text=se.Message;
                textBoxLoginPassword.Text = "";
                textBoxLoginUser.Text = "";
            }
            //tabControl.SelectedTab = tabPageMain;
        }

        private void buttonJumpToExit_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Logout();
                controller.updateEvent -= Update;

            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
            tabControl.SelectedTab = tabPageExit;
        }

        private void buttonJumpToLogin_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageLogin;
        }

        private void numericUpDownVarsta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMainNume_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxMainNume.Text.Equals(""))
            {
                buttonMainAdaugaParticipant.Enabled = true;
                if (comboBoxMainProba.SelectedItem != null)
                    buttonMainAdaugaParticipare.Enabled = true;
            }
            else
                buttonMainAdaugaParticipant.Enabled = false;
        }

        private void comboBoxProba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMainProba.SelectedItem != null)
                buttonMainAdaugaParticipare.Enabled = true;
            else
                buttonMainAdaugaParticipare.Enabled = false;

        }

        private void checkBoxMainProba_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMainProba.Checked)
            {
                comboBoxMainProbaFiltrare.Enabled = false;
                comboBoxMainProbaFiltrare.SelectedItem = null;
            }
            else
            {
                comboBoxMainProbaFiltrare.Enabled = true;
            }
        }

        private void checkBoxMainVarsta_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxMainVarsta.Checked)
            {
                comboBoxMainVarstaFiltrare.Enabled = false;
                comboBoxMainVarstaFiltrare.SelectedItem = null;
            }
            else
            {
                comboBoxMainVarstaFiltrare.Enabled = true;
            }
        }

        private void comboBoxMainProbaFiltrare_SelectedIndexChanged(object sender, EventArgs e)
        {
            String proba = comboBoxMainProbaFiltrare.GetItemText(comboBoxMainProbaFiltrare.SelectedItem);
            if (proba != "")
            {
                if (checkBoxMainVarsta.Checked)
                {
                    String categorieVarsta = comboBoxMainVarstaFiltrare.GetItemText(comboBoxMainVarstaFiltrare.SelectedItem);
                    if (categorieVarsta != "")
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti (this.controller.GetParticipantiByProba_Varsta(proba, categorieVarsta));
                    }
                    else
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipantiByProba(proba));
                    }
                }
                else
                {
                    dataGridViewParticipanti.Rows.Clear();
                    this.loadDataGridViewParticipanti(this.controller.GetParticipantiByProba(proba));
                }
            }
            else
            {
                if (checkBoxMainVarsta.Checked)
                {
                    String categorieVarsta = comboBoxMainVarstaFiltrare.GetItemText(comboBoxMainVarstaFiltrare.SelectedItem);
                    if (categorieVarsta != "")
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipantiByVarsta(categorieVarsta));
                    }
                    else
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipanti());
                    }
                }
                else
                {
                    dataGridViewParticipanti.Rows.Clear();
                    this.loadDataGridViewParticipanti(this.controller.GetParticipanti());
                }
            }
        }

        private void comboBoxMainVarstaFiltrare_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categorieVarsta = comboBoxMainVarstaFiltrare.GetItemText(comboBoxMainVarstaFiltrare.SelectedItem);
            if (categorieVarsta != "")
            {
                if (checkBoxMainProba.Checked)
                {
                    string proba = comboBoxMainProbaFiltrare.GetItemText(comboBoxMainProbaFiltrare.SelectedItem);
                    if (proba != "")
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipantiByProba_Varsta(proba,categorieVarsta));
                    }
                    else
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipantiByVarsta(categorieVarsta));
                    }
                }
                else
                {
                    dataGridViewParticipanti.Rows.Clear();
                    this.loadDataGridViewParticipanti(this.controller.GetParticipantiByVarsta(categorieVarsta));
                }
            }
            else
            {
                if (checkBoxMainProba.Checked)
                {
                    string proba = comboBoxMainProbaFiltrare.GetItemText(comboBoxMainProbaFiltrare.SelectedItem);
                    
                    if (proba != "")
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipantiByProba(proba));

                    }
                    else
                    {
                        dataGridViewParticipanti.Rows.Clear();
                        this.loadDataGridViewParticipanti(this.controller.GetParticipanti());
                    }
                }
                else
                {
                    dataGridViewParticipanti.Rows.Clear();
                    this.loadDataGridViewParticipanti(this.controller.GetParticipanti());
                }
            }
        }

        private void comboBoxMainProbaNrPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            String proba = comboBoxMainProbaNrPart.GetItemText(comboBoxMainProbaNrPart.SelectedItem);
            if (proba != "")
            {
                int numar = controller.NumarParticipariProba(proba);
                textBoxMainNrPartic.Text = numar.ToString();
            }
            else
            {
                textBoxMainNrPartic.Text = "";
            }
        }

        private void buttonMainAdaugaParticipant_Click(object sender, EventArgs e)
        {
            string nume = textBoxMainNume.Text;
            int varsta = Int32.Parse(numericUpDownVarsta.Value.ToString());
            Participant participant = new Participant(1, nume, varsta, 0);
            try
            {
                controller.AdaugaParticipant(participant);
                MessageBox.Show("Participant adaugat cu succes!");
                
            }
            catch (ValidationException ve)
            {
                MessageBox.Show(ve.Message);
            }
            buttonMainAdaugaParticipant.Enabled = false;
            buttonMainAdaugaParticipare.Enabled = false;
            textBoxMainNume.Text = "";
            dataGridViewParticipanti.Invoke(new Action(() => dataGridViewParticipanti.ClearSelection()));
            comboBoxMainProba.SelectedItem = null;
            comboBoxMainProba.SelectedItem = null;
        }

        private void buttonMainAdaugaParticipare_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dataGridViewParticipanti.SelectedCells[0].Value.ToString());
            string nume = textBoxMainNume.Text;
            int varsta = Int32.Parse(numericUpDownVarsta.Value.ToString());
            int nrParticipari = Int32.Parse(dataGridViewParticipanti.SelectedCells[3].Value.ToString());
            Participant participant = new Participant(id, nume, varsta, nrParticipari);
            String proba = comboBoxMainProba.GetItemText(comboBoxMainProba.SelectedItem);
            try
            {
                controller.AdaugaParticipare(participant, proba);
                MessageBox.Show("Participare adaugata cu succes!");
            }
            catch(ServiceException se)
            {
                MessageBox.Show(se.Message);
            }
            comboBoxMainProba.SelectedItem = null;
            buttonMainAdaugaParticipant.Enabled = false;
            buttonMainAdaugaParticipare.Enabled = false;
            comboBoxMainProba.SelectedItem = null;
            dataGridViewParticipanti.Invoke(new Action(()=>dataGridViewParticipanti.ClearSelection()));
            textBoxMainNume.Text = "";
        }

        public void participantAdaugat(Participant participant)
        {
            Console.WriteLine("Controller: Participant Adaugat.");
            string[] line = { participant.ID.ToString(), participant.Nume,participant.Varsta.ToString(), participant.NumarParticipari.ToString() };
            Console.WriteLine("Line to add:" + line[0] + "-" + line[1] + "-" + line[2] + "-" + line[3]);
            this.dataGridViewParticipanti.Invoke(new Action(() => { this.dataGridViewParticipanti.Rows.Add(line); }));
        }

        public void participareAdaugata(Participare participare, Participant updatedParticipant, int nrComoara, int nrDesen, int nrPoezie)
        {
            Console.WriteLine("Controller: Participare Adaugata.");
            string[] lineParticipare = { participare.ID.ToString(), participare.IdParticipant.ToString(), 
                participare.Proba, participare.CategorieVarsta };
            /*string[] lineParticipant = { updatedParticipant.ID.ToString(), updatedParticipant.Nume,
                updatedParticipant.Varsta.ToString(), updatedParticipant.NumarParticipari.ToString() };*/
            this.dataGridViewParticipari.Invoke(new Action(() => { this.dataGridViewParticipari.Rows.Add(lineParticipare); }));
            for (int i = 0; i < dataGridViewParticipanti.Rows.Count; i++)
            {
                if (dataGridViewParticipanti.Rows[i].Cells[0].Value.ToString().Equals(participare.IdParticipant.ToString()))
                {
                    //this.dataGridViewParticipanti.Invoke(new Action(() => { dataGridViewParticipanti.Rows.RemoveAt(i); }));
                    //this.dataGridViewParticipanti.Invoke(new Action(() => { dataGridViewParticipanti.Rows.Insert(i, lineParticipant); }));
                    dataGridViewParticipanti.Invoke(new Action(() => { dataGridViewParticipanti.Rows[i].Cells[3].Value = updatedParticipant.NumarParticipari.ToString(); }));
                    break;
                }
            }

            //loadDataGridViewParticipari(Service.GetParticipari());
            string probaNr = null;
            comboBoxMainProbaNrPart.Invoke(
                new Action(() => { probaNr = comboBoxMainProbaNrPart.GetItemText(comboBoxMainProbaNrPart.SelectedItem); }));
            //Console.WriteLine(probaNr + "-Comoara:" + nrComoara + "-Poezie:" + nrPoezie + "-Desen:" + nrDesen);
            if (probaNr != null && probaNr.Equals(participare.Proba))
            {
                switch (probaNr)
                {
                    case "Cautare comoara":
                        //textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.Text = nrComoara.ToString()));
                        signalNrParticipariField(nrComoara);
                        break;
                    case "Poezie":
                        //textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.Text = nrPoezie.ToString()));
                        signalNrParticipariField(nrPoezie);
                        break;
                    case "Desen":
                        //textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.Text = nrDesen.ToString()));
                        signalNrParticipariField(nrDesen);
                        break;
                }
            }
        }


        private void signalNrParticipariField(int numar)
        {
            try {
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.Text = numar.ToString()));
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Red));
                System.Threading.Thread.Sleep(500);
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Black));
                System.Threading.Thread.Sleep(500);
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Red));
                System.Threading.Thread.Sleep(500);
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Black));
                System.Threading.Thread.Sleep(500);
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Red));
                System.Threading.Thread.Sleep(500);
                textBoxMainNrPartic.Invoke(new Action(() => textBoxMainNrPartic.ForeColor = Color.Black));
            }
            catch (Exception ignored) { }
        }
    }

    
}

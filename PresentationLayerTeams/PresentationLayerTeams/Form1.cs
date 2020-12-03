using BussinesLayerTeams;
using DataLayerTeams.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerTeams
{
    public partial class Form1 : Form
    {

        private readonly TeamsBussiness teamsBussiness;
        public Form1()
        {
            this.teamsBussiness = new TeamsBussiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList();
        }

        private void FillList()
        {
            listBoxIspis.Items.Clear();


            List<Team> teams = this.teamsBussiness.GetallTeam();

            foreach (Team t in teams)
            {
                listBoxIspis.Items.Add(t.Id + "." + t.Name + "," + t.Couch + "," + t.Points + " ");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Team t = new Team();
            t.Name = textBoxName.Text;
            t.Couch = textBoxCOACH.Text;
            t.Points = Convert.ToInt32(textBoxpOINTS.Text);

            bool result = this.teamsBussiness.InsertTeam(t);

            if (result)
            {
                FillList();
                MessageBox.Show("Uspesan unos!");

            }
            else
            {
                MessageBox.Show("Neuspesan unos!");
            }
        }
    }
}

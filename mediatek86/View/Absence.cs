using mediatek86.controler;
using mediatek86.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.View
{
    public partial class Absence : Form
    {

        mediatekControler mediacontrl = new mediatekControler();

        personnel personnel;
        public Absence(personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
        }

        private void Absence_Load(object sender, EventArgs e)
        {
            lblTitre.Text = "Absences de " + personnel.prenom + " " + personnel.nom;
            var absences = mediacontrl.GetAbsence(personnel);
            var motifs = mediacontrl.GetMotifs();
            var absencesAvecLibelle = absences.Select(abs => new
            {
                abs.idpersonnel,
                abs.datedebut,
                abs.datefin,
                LibelleMotif = motifs.FirstOrDefault(m => m.idmotif == abs.idmotif)?.libelle
            }).ToList();


            cbMotif.DataSource = motifs;
            dataGridView1.DataSource = absencesAvecLibelle;
            dataGridView1.Columns["idpersonnel"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            cbAbsence.DataSource = mediacontrl.GetAbsence(personnel);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            absence absence = (absence)cbAbsence.SelectedItem;
            if (absence != null)
            {
                mediacontrl.DelAbsence(absence);

                var absences = mediacontrl.GetAbsence(personnel);
                var motifs = mediacontrl.GetMotifs();
                var absencesAvecLibelle = absences.Select(abs => new
                {
                    abs.idpersonnel,
                    abs.datedebut,
                    abs.datefin,
                    LibelleMotif = motifs.FirstOrDefault(m => m.idmotif == abs.idmotif).libelle
                }).ToList();
                cbAbsence.DataSource = mediacontrl.GetAbsence(personnel);



                dataGridView1.DataSource = absencesAvecLibelle;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GererPersonnel gererPersonnel = new GererPersonnel();
            gererPersonnel.ShowDialog();
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string dateDebutStr = txtDebut.Text;
            string dateFinStr = txtFin.Text;

            var dateDebut = DateTime.Parse(dateDebutStr);
            var dateFin = DateTime.Parse(dateFinStr);


            absence absence = new absence(personnel.idpersonnel, dateDebut, dateFin, cbMotif.SelectedIndex + 1);
            mediacontrl.AddAbsence(absence);
            txtDebut.Clear();
            txtFin.Clear();

            var absences = mediacontrl.GetAbsence(personnel);
            var motifs = mediacontrl.GetMotifs();
            var absencesAvecLibelle = absences.Select(abs => new
            {
                abs.idpersonnel,
                abs.datedebut,
                abs.datefin,
                LibelleMotif = motifs.FirstOrDefault(m => m.idmotif == abs.idmotif).libelle
            }).ToList();
            cbAbsence.DataSource = mediacontrl.GetAbsence(personnel);
            dataGridView1.DataSource = absencesAvecLibelle;



        }

        private void modifbutton_Click(object sender, EventArgs e)
        {
            modifierAbsence modifierAbsence =  new modifierAbsence(personnel);
            this.Hide();
            modifierAbsence.ShowDialog();
            this.Close();



        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.controler;
using mediatek86.Model;

namespace mediatek86.View
{
    public partial class modifierAbsence : Form
    {
        mediatekControler mediacontrl = new mediatekControler();

        private personnel personnel;

        public modifierAbsence(personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;

        }

        private void modifierAbsence_Load(object sender, EventArgs e)
        {
            cbMotif.DataSource = mediacontrl.GetMotifs();
            cbAbsence.DataSource = mediacontrl.GetAbsence(personnel);
            

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
                absence absence = (absence)cbAbsence.SelectedItem;
                absence.datedebut = DateTime.Parse(txtDebut.Text);
                absence.datefin = DateTime.Parse(txtFin.Text);
                absence.idmotif = ((motif)cbMotif.SelectedItem).idmotif;
                mediacontrl.UpdateAbsence(absence);
                txtDebut.Clear();
                txtFin.Clear();
            Absence Absence = new Absence(personnel);
                this.Hide();
                this.Close();
                Absence.ShowDialog();

            

        }

        private void cbAbsence_SelectedIndexChanged(object sender, EventArgs e)
        {
            absence absence = (absence)cbAbsence.SelectedItem;
            int idMotif = absence.idmotif;
            txtDebut.Text = absence.datedebut.ToString("yyyy-MM-dd");
            txtFin.Text = absence.datefin.ToString("yyyy-MM-dd");
            cbMotif.SelectedIndex = idMotif;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show("voulez-vous vraiment annuler la modification de cette absence ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Absence Absence = new Absence(personnel);
                Absence.ShowDialog();
                this.Close();
            }
           

        }
    }
}

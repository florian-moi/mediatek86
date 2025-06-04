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
using mediatek86.controler;
using MySqlX.XDevAPI.Common;

namespace mediatek86.View
{
    public partial class ModifierPersonne : Form
    {
        
        private mediatekControler mediacontrl = new mediatekControler();
        // Variable pour stocker la personne à modifier
        private personnel personne;
        public ModifierPersonne(personnel personne)
        {
            InitializeComponent();
           this.personne = personne;
        }

        private void ModifierPersonne_Load(object sender, EventArgs e)
        {
            lblTitre.Text = "Modifier les informations de " + personne.prenom + " " + personne.nom;
            txtNom.Text = personne.nom;
            txtPrenom.Text = personne.prenom;
            txtTel.Text = personne.telephone;
            txtMail.Text = personne.email;
            cbService.DataSource = mediacontrl.GetServices();
            cbService.SelectedIndex = personne.service.idservice - 1;



        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtTel.Text != "" && txtMail.Text != "" && cbService.SelectedItem != null)
            {
                personne.nom = txtNom.Text;
                personne.prenom = txtPrenom.Text;
                personne.telephone = txtTel.Text;
                personne.email = txtMail.Text;
                personne.service = (service)cbService.SelectedItem;
                mediacontrl.Updatepersonnel(personne);
                txtNom.Clear();
                txtPrenom.Clear();
                txtTel.Clear();
                txtMail.Clear();
                GererPersonnel gererPersonnel = new GererPersonnel();
                this.Hide();
                this.Close();
                gererPersonnel.ShowDialog();
            }

            

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Voulez-vous vraiment annuler l'ajout/modification en cours ?",
                 "Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );
            if ((result == DialogResult.Yes))
            {
                txtNom.Clear();
                txtPrenom.Clear();
                txtTel.Clear();
                txtMail.Clear();
                GererPersonnel gererPersonnel = new GererPersonnel();
                this.Hide();
                this.Close();
                gererPersonnel.ShowDialog();

            }
            
        }
        
    }
}

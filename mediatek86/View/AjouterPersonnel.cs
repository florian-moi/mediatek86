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
    public partial class AjouterPersonnel : Form
    {
        mediatekControler mediacontrl = new mediatekControler();
        public AjouterPersonnel()
        {
            InitializeComponent();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxTel.Text != "" && textBoxMail.Text != "" && comboBoxService.SelectedItem != null)
            {
                personnel newPersonnel = new personnel(0, textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text, (service)comboBoxService.SelectedItem);
                mediacontrl.AddPersonnel(newPersonnel);
                GererPersonnel com = new GererPersonnel();
                this.Hide();
                com.ShowDialog();



            }
        }

        private void AjouterPersonnel_Load(object sender, EventArgs e)
        {
            comboBoxService.DataSource = mediacontrl.GetServices();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous vraiment annuler l'ajout de ce personnel ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                GererPersonnel gererPersonnel = new GererPersonnel();
                gererPersonnel.ShowDialog();
                this.Close();
            }
        }
    }
}

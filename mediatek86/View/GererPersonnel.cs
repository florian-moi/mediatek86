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
    public partial class GererPersonnel : Form
    {
        mediatekControler mediacontrl = new mediatekControler();
        public GererPersonnel()
        {
            InitializeComponent();
        }

        private void comboBoxPersonnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GererPersonnel_Load(object sender, EventArgs e)
        {
            List<personnel> personnels = mediacontrl.GetPersonnels();
            
            comboBoxPersonnel.DataSource = mediacontrl.GetPersonnels();

            labelHeader.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AjouterPersonnel ajouterPersonnel = new AjouterPersonnel();
            this.Hide();
            ajouterPersonnel.ShowDialog();
            this.Close();
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(comboBoxPersonnel.SelectedItem != null)
            {
                personnel selectedPersonnel = (personnel)comboBoxPersonnel.SelectedItem;
                var result = MessageBox.Show("Voulez-vous vraiment supprimer cette personne"+ " "+ selectedPersonnel,
                   "Confirmer",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
               if(result == DialogResult.Yes)
                {
                    
                    mediacontrl.DelPersonnel(selectedPersonnel);
                    comboBoxPersonnel.DataSource = mediacontrl.GetPersonnels();
                }

                  
            }
            
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            personnel personnel = (personnel)comboBoxPersonnel.SelectedItem;
            ModifierPersonne modifierpersonne = new ModifierPersonne(personnel);
            this.Hide();
            modifierpersonne.ShowDialog();
            this.Close();
            
        }

        private void buttonAbsences_Click(object sender, EventArgs e)
        {
            personnel personnel = (personnel)comboBoxPersonnel.SelectedItem;
            Absence absence = new Absence(personnel);
            this.Hide();
            absence.ShowDialog();
            this.Close();
        }
    }
}
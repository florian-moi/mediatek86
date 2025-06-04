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
    public partial class PageConnection : Form
    {
        mediatekControler mediacontrl = new mediatekControler();
        public PageConnection()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text != "" && textBoxPassword.Text != "")
            { 
                string nplogin = textBoxLogin.Text;
                string npmdp = textBoxPassword.Text;

                responsable resp = new responsable(nplogin, npmdp);
                mediacontrl.ControleConnection(resp);
                if (mediacontrl.ControleConnection(resp)){
                    GererPersonnel gererPersonnel = new GererPersonnel();
                    this.Hide();
                    gererPersonnel.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mediatek86.View
{
    partial class Absence : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.groupNouvelleAbs = new System.Windows.Forms.GroupBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupSupprAbs = new System.Windows.Forms.GroupBox();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.cbAbsence = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.modifbutton = new System.Windows.Forms.Button();
            this.groupNouvelleAbs.SuspendLayout();
            this.groupSupprAbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1028, 156);
            this.panelHeader.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 679);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1028, 52);
            this.panelFooter.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.lblTitre.Location = new System.Drawing.Point(366, 159);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(331, 41);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Absences de : PRÉNOM";
            // 
            // groupNouvelleAbs
            // 
            this.groupNouvelleAbs.Controls.Add(this.lblDebut);
            this.groupNouvelleAbs.Controls.Add(this.txtDebut);
            this.groupNouvelleAbs.Controls.Add(this.lblFin);
            this.groupNouvelleAbs.Controls.Add(this.txtFin);
            this.groupNouvelleAbs.Controls.Add(this.lblMotif);
            this.groupNouvelleAbs.Controls.Add(this.cbMotif);
            this.groupNouvelleAbs.Controls.Add(this.btnAjouter);
            this.groupNouvelleAbs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupNouvelleAbs.Location = new System.Drawing.Point(122, 416);
            this.groupNouvelleAbs.Name = "groupNouvelleAbs";
            this.groupNouvelleAbs.Size = new System.Drawing.Size(300, 217);
            this.groupNouvelleAbs.TabIndex = 3;
            this.groupNouvelleAbs.TabStop = false;
            this.groupNouvelleAbs.Text = "Nouvelle absence";
            // 
            // lblDebut
            // 
            this.lblDebut.Location = new System.Drawing.Point(13, 35);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(86, 22);
            this.lblDebut.TabIndex = 0;
            this.lblDebut.Text = "Date début :";
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(103, 35);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(172, 29);
            this.txtDebut.TabIndex = 1;
            // 
            // lblFin
            // 
            this.lblFin.Location = new System.Drawing.Point(13, 69);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(86, 22);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Date fin :";
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(103, 69);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(172, 29);
            this.txtFin.TabIndex = 3;
            // 
            // lblMotif
            // 
            this.lblMotif.Location = new System.Drawing.Point(13, 104);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(86, 22);
            this.lblMotif.TabIndex = 4;
            this.lblMotif.Text = "Motif :";
            // 
            // cbMotif
            // 
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.Items.AddRange(new object[] {
            "Sélection du motif"});
            this.cbMotif.Location = new System.Drawing.Point(103, 104);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(172, 29);
            this.cbMotif.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(103, 147);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 31);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupSupprAbs
            // 
            this.groupSupprAbs.Controls.Add(this.lblAbsence);
            this.groupSupprAbs.Controls.Add(this.cbAbsence);
            this.groupSupprAbs.Controls.Add(this.btnSupprimer);
            this.groupSupprAbs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupSupprAbs.Location = new System.Drawing.Point(519, 416);
            this.groupSupprAbs.Name = "groupSupprAbs";
            this.groupSupprAbs.Size = new System.Drawing.Size(446, 112);
            this.groupSupprAbs.TabIndex = 4;
            this.groupSupprAbs.TabStop = false;
            this.groupSupprAbs.Text = "Supprimer absence";
            // 
            // lblAbsence
            // 
            this.lblAbsence.Location = new System.Drawing.Point(4, 31);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(86, 22);
            this.lblAbsence.TabIndex = 0;
            this.lblAbsence.Text = "Absence :";
            // 
            // cbAbsence
            // 
            this.cbAbsence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbsence.Items.AddRange(new object[] {
            "Absence"});
            this.cbAbsence.Location = new System.Drawing.Point(86, 28);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new System.Drawing.Size(354, 29);
            this.cbAbsence.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(8, 69);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 32);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 207);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifbutton
            // 
            this.modifbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.modifbutton.Location = new System.Drawing.Point(519, 546);
            this.modifbutton.Name = "modifbutton";
            this.modifbutton.Size = new System.Drawing.Size(155, 32);
            this.modifbutton.TabIndex = 7;
            this.modifbutton.Text = "modifier une absence";
            this.modifbutton.UseVisualStyleBackColor = true;
            this.modifbutton.Click += new System.EventHandler(this.modifbutton_Click);
            // 
            // Absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 731);
            this.Controls.Add(this.modifbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.groupNouvelleAbs);
            this.Controls.Add(this.groupSupprAbs);
            this.Name = "Absence";
            this.Text = "Absence";
            this.Load += new System.EventHandler(this.Absence_Load);
            this.groupNouvelleAbs.ResumeLayout(false);
            this.groupNouvelleAbs.PerformLayout();
            this.groupSupprAbs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private Panel panelFooter;
        private Label lblTitre;
        private GroupBox groupNouvelleAbs;
        private Label lblDebut;
        private TextBox txtDebut;
        private Label lblFin;
        private TextBox txtFin;
        private Label lblMotif;
        private ComboBox cbMotif;
        private Button btnAjouter;
        private GroupBox groupSupprAbs;
        private Label lblAbsence;
        private ComboBox cbAbsence;
        private Button btnSupprimer;
        private DataGridView dataGridView1;
        private Button button1;
        private Button modifbutton;
    }
}
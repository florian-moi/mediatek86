using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mediatek86.View
{
    partial class ModifierPersonne : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            panelFooter = new Panel();
            lblTitre = new Label();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            lblService = new Label();
            cbService = new ComboBox();
            btnConfirmer = new Button();
            btnAnnuler = new Button();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 180);
            panelHeader.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.SteelBlue;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 658);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 180);
            panelFooter.TabIndex = 1;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 28F);
            lblTitre.Location = new Point(180, 200);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(350, 51);
            lblTitre.TabIndex = 2;
            lblTitre.Text = "Modifier : PRÉNOM";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 16F);
            lblNom.Location = new Point(40, 270);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(72, 30);
            lblNom.TabIndex = 3;
            lblNom.Text = "Nom :";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            txtNom.Location = new Point(200, 275);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(220, 25);
            txtNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI", 16F);
            lblPrenom.Location = new Point(40, 320);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(100, 30);
            lblPrenom.TabIndex = 5;
            lblPrenom.Text = "Prénom :";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            txtPrenom.Location = new Point(200, 325);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(220, 25);
            txtPrenom.TabIndex = 6;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 16F);
            lblTel.Location = new Point(40, 370);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(51, 30);
            lblTel.TabIndex = 7;
            lblTel.Text = "Tél :";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            txtTel.Location = new Point(200, 375);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(220, 25);
            txtTel.TabIndex = 8;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 16F);
            lblMail.Location = new Point(40, 420);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(65, 30);
            lblMail.TabIndex = 9;
            lblMail.Text = "Mail :";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            txtMail.Location = new Point(200, 425);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(220, 25);
            txtMail.TabIndex = 10;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Font = new Font("Segoe UI", 16F);
            lblService.Location = new Point(40, 470);
            lblService.Name = "lblService";
            lblService.Size = new Size(94, 30);
            lblService.TabIndex = 11;
            lblService.Text = "Service :";
            // 
            // cbService
            // 
            cbService.DropDownStyle = ComboBoxStyle.DropDownList;
            cbService.Font = new Font("Segoe UI", 10F);
            cbService.Location = new Point(200, 475);
            cbService.Name = "cbService";
            cbService.Size = new Size(220, 25);
            cbService.TabIndex = 12;
            // 
            // btnConfirmer
            // 
            btnConfirmer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmer.Location = new Point(40, 530);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(120, 28);
            btnConfirmer.TabIndex = 13;
            btnConfirmer.Text = "CONFIRMER";
            // 
            // btnAnnuler
            // 
            btnAnnuler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnnuler.Location = new Point(180, 530);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(120, 28);
            btnAnnuler.TabIndex = 14;
            btnAnnuler.Text = "Annuler";
            // 
            // ModifierPersonne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 838);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Controls.Add(lblTitre);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(lblPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(lblTel);
            Controls.Add(txtTel);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(lblService);
            Controls.Add(cbService);
            Controls.Add(btnConfirmer);
            Controls.Add(btnAnnuler);
            Name = "ModifierPersonne";
            Text = "ModifierPersonne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Panel panelFooter;
        private Label lblTitre;
        private Label lblNom;
        private TextBox txtNom;
        private Label lblPrenom;
        private TextBox txtPrenom;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblService;
        private ComboBox cbService;
        private Button btnConfirmer;
        private Button btnAnnuler;
    }
}
namespace mediatek86.View
{
    partial class AjouterPersonnel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 150);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelTitle.Location = new System.Drawing.Point(200, 170);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(329, 45);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Ajouter une personne";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelNom.Location = new System.Drawing.Point(60, 240);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(62, 25);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelPrenom.Location = new System.Drawing.Point(60, 280);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(87, 25);
            this.labelPrenom.TabIndex = 4;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelTel.Location = new System.Drawing.Point(60, 320);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(44, 25);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Tél :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelMail.Location = new System.Drawing.Point(60, 360);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(58, 25);
            this.labelMail.TabIndex = 8;
            this.labelMail.Text = "Mail :";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelService.Location = new System.Drawing.Point(60, 400);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(81, 25);
            this.labelService.TabIndex = 10;
            this.labelService.Text = "Service :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxNom.Location = new System.Drawing.Point(200, 240);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(250, 25);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxPrenom.Location = new System.Drawing.Point(200, 280);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(250, 25);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTel.Location = new System.Drawing.Point(200, 320);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(250, 25);
            this.textBoxTel.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxMail.Location = new System.Drawing.Point(200, 360);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(250, 25);
            this.textBoxMail.TabIndex = 9;
            // 
            // comboBoxService
            // 
            this.comboBoxService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxService.Location = new System.Drawing.Point(200, 400);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(250, 25);
            this.comboBoxService.TabIndex = 11;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAjouter.Location = new System.Drawing.Point(65, 450);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(120, 30);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonAnnuler.Location = new System.Drawing.Point(208, 450);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(120, 30);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // AjouterPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonAnnuler);
            this.Name = "AjouterPersonnel";
            this.Text = "Ajouter une personne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
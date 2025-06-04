namespace mediatek86.View
{
    partial class modifierAbsence
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChoisirAbs;
        private System.Windows.Forms.ComboBox cbAbsence;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.Button btnModifier;

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChoisirAbs = new System.Windows.Forms.Label();
            this.cbAbsence = new System.Windows.Forms.ComboBox();
            this.lblDebut = new System.Windows.Forms.Label();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 120);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitle.Location = new System.Drawing.Point(250, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Modifier absence";
            // 
            // lblChoisirAbs
            // 
            this.lblChoisirAbs.AutoSize = true;
            this.lblChoisirAbs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblChoisirAbs.Location = new System.Drawing.Point(100, 210);
            this.lblChoisirAbs.Name = "lblChoisirAbs";
            this.lblChoisirAbs.Size = new System.Drawing.Size(124, 21);
            this.lblChoisirAbs.TabIndex = 2;
            this.lblChoisirAbs.Text = "Choisir absence :";
            // 
            // cbAbsence
            // 
            this.cbAbsence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAbsence.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.cbAbsence.Location = new System.Drawing.Point(250, 210);
            this.cbAbsence.Name = "cbAbsence";
            this.cbAbsence.Size = new System.Drawing.Size(200, 25);
            this.cbAbsence.TabIndex = 3;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDebut.Location = new System.Drawing.Point(100, 260);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(92, 21);
            this.lblDebut.TabIndex = 4;
            this.lblDebut.Text = "Date début :";
            // 
            // txtDebut
            // 
            this.txtDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtDebut.Location = new System.Drawing.Point(250, 260);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(200, 25);
            this.txtDebut.TabIndex = 5;
           // this.txtDebut.PlaceholderText = "dd-MM-YYYY";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFin.Location = new System.Drawing.Point(100, 310);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(75, 21);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "Date fin :";
            // 
            // txtFin
            // 
            this.txtFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.txtFin.Location = new System.Drawing.Point(250, 310);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(200, 25);
            this.txtFin.TabIndex = 7;
            //this.txtFin.PlaceholderText = "dd-MM-YYYY";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMotif.Location = new System.Drawing.Point(100, 360);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(54, 21);
            this.lblMotif.TabIndex = 8;
            this.lblMotif.Text = "Motif :";
            // 
            // cbMotif
            // 
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.cbMotif.Location = new System.Drawing.Point(250, 360);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(200, 25);
            this.cbMotif.TabIndex = 9;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifier.Location = new System.Drawing.Point(250, 410);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 30);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            // 
            // modifierAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblChoisirAbs);
            this.Controls.Add(this.cbAbsence);
            this.Controls.Add(this.lblDebut);
            this.Controls.Add(this.txtDebut);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.btnModifier);
            this.Name = "modifierAbsence";
            this.Text = "Modifier absence";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
    #endregion
}
using System.Windows.Forms;

namespace mediatek86.View
{
    partial class GererPersonnel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ComboBox comboBoxPersonnel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAbsences;

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
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.comboBoxPersonnel = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAbsences = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 151);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelHeader.ForeColor = System.Drawing.Color.Black;
            this.labelHeader.Location = new System.Drawing.Point(350, 60);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(107, 21);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "PAS LA MÊME";
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.labelTitle);
            this.panelContent.Controls.Add(this.labelList);
            this.panelContent.Controls.Add(this.comboBoxPersonnel);
            this.panelContent.Controls.Add(this.buttonAdd);
            this.panelContent.Controls.Add(this.buttonDelete);
            this.panelContent.Controls.Add(this.buttonEdit);
            this.panelContent.Controls.Add(this.buttonAbsences);
            this.panelContent.Location = new System.Drawing.Point(0, 150);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 350);
            this.panelContent.TabIndex = 1;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.labelTitle.Location = new System.Drawing.Point(238, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(282, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Gérer le personnel";
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelList.Location = new System.Drawing.Point(281, 77);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(189, 30);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Liste du personnel";
            // 
            // comboBoxPersonnel
            // 
            this.comboBoxPersonnel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPersonnel.Location = new System.Drawing.Point(275, 127);
            this.comboBoxPersonnel.Name = "comboBoxPersonnel";
            this.comboBoxPersonnel.Size = new System.Drawing.Size(220, 25);
            this.comboBoxPersonnel.TabIndex = 2;
            this.comboBoxPersonnel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonnel_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(204, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter une personne";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(204, 220);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Supprimer la personne";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(404, 220);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 30);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Modifier personne";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.Location = new System.Drawing.Point(404, 170);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(150, 30);
            this.buttonAbsences.TabIndex = 6;
            this.buttonAbsences.Text = "Gérer les absences";
            this.buttonAbsences.Click += new System.EventHandler(this.buttonAbsences_Click);
            // 
            // GererPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContent);
            this.Name = "GererPersonnel";
            this.Text = "Gérer le personnel";
            this.Load += new System.EventHandler(this.GererPersonnel_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
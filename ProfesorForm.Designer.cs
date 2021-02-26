namespace Centralizare_absente
{
    partial class ProfesorForm
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
        private void InitializeComponent()
        {
            this.btnAdaugaStudent = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblFacultate = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbFacultate = new System.Windows.Forms.TextBox();
            this.btnAfisareStudenti = new System.Windows.Forms.Button();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.rtbStudenti = new System.Windows.Forms.RichTextBox();
            this.lblStudenti = new System.Windows.Forms.Label();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblAdaugareStudent = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblActivitate = new System.Windows.Forms.Label();
            this.tbActivitate = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaAbsenta = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdaugaStudent
            // 
            this.btnAdaugaStudent.Location = new System.Drawing.Point(17, 131);
            this.btnAdaugaStudent.Name = "btnAdaugaStudent";
            this.btnAdaugaStudent.Size = new System.Drawing.Size(152, 29);
            this.btnAdaugaStudent.TabIndex = 0;
            this.btnAdaugaStudent.Text = "Adauga student";
            this.btnAdaugaStudent.UseVisualStyleBackColor = true;
            this.btnAdaugaStudent.Click += new System.EventHandler(this.btnAdaugaStudent_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(14, 30);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(14, 56);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 2;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblFacultate
            // 
            this.lblFacultate.AutoSize = true;
            this.lblFacultate.Location = new System.Drawing.Point(14, 82);
            this.lblFacultate.Name = "lblFacultate";
            this.lblFacultate.Size = new System.Drawing.Size(51, 13);
            this.lblFacultate.TabIndex = 3;
            this.lblFacultate.Text = "Facultate";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(69, 27);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 4;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(69, 53);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 20);
            this.tbPrenume.TabIndex = 5;
            // 
            // tbFacultate
            // 
            this.tbFacultate.Location = new System.Drawing.Point(69, 79);
            this.tbFacultate.Name = "tbFacultate";
            this.tbFacultate.Size = new System.Drawing.Size(100, 20);
            this.tbFacultate.TabIndex = 6;
            // 
            // btnAfisareStudenti
            // 
            this.btnAfisareStudenti.Location = new System.Drawing.Point(17, 166);
            this.btnAfisareStudenti.Name = "btnAfisareStudenti";
            this.btnAfisareStudenti.Size = new System.Drawing.Size(152, 29);
            this.btnAfisareStudenti.TabIndex = 7;
            this.btnAfisareStudenti.Text = "Afisare studenti";
            this.btnAfisareStudenti.UseVisualStyleBackColor = true;
            this.btnAfisareStudenti.Click += new System.EventHandler(this.btnAfisareStudenti_Click);
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(69, 105);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 20);
            this.tbCNP.TabIndex = 9;
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(14, 108);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 8;
            this.lblCNP.Text = "CNP";
            // 
            // rtbStudenti
            // 
            this.rtbStudenti.Location = new System.Drawing.Point(197, 53);
            this.rtbStudenti.Name = "rtbStudenti";
            this.rtbStudenti.ReadOnly = true;
            this.rtbStudenti.Size = new System.Drawing.Size(299, 142);
            this.rtbStudenti.TabIndex = 10;
            this.rtbStudenti.Text = "";
            // 
            // lblStudenti
            // 
            this.lblStudenti.AutoSize = true;
            this.lblStudenti.Location = new System.Drawing.Point(194, 30);
            this.lblStudenti.Name = "lblStudenti";
            this.lblStudenti.Size = new System.Drawing.Size(46, 13);
            this.lblStudenti.TabIndex = 11;
            this.lblStudenti.Text = "Studenti";
            // 
            // lbStudenti
            // 
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.Location = new System.Drawing.Point(17, 250);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(159, 147);
            this.lbStudenti.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adaugare absenta";
            // 
            // lblLine
            // 
            this.lblLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblLine.Location = new System.Drawing.Point(18, 198);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(478, 25);
            this.lblLine.TabIndex = 14;
            this.lblLine.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_";
            // 
            // lblAdaugareStudent
            // 
            this.lblAdaugareStudent.AutoSize = true;
            this.lblAdaugareStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdaugareStudent.Location = new System.Drawing.Point(389, 9);
            this.lblAdaugareStudent.Name = "lblAdaugareStudent";
            this.lblAdaugareStudent.Size = new System.Drawing.Size(107, 13);
            this.lblAdaugareStudent.TabIndex = 15;
            this.lblAdaugareStudent.Text = "Adaugare student";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(14, 234);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(44, 13);
            this.lblStudent.TabIndex = 16;
            this.lblStudent.Text = "Student";
            // 
            // lblActivitate
            // 
            this.lblActivitate.AutoSize = true;
            this.lblActivitate.Location = new System.Drawing.Point(194, 234);
            this.lblActivitate.Name = "lblActivitate";
            this.lblActivitate.Size = new System.Drawing.Size(51, 13);
            this.lblActivitate.TabIndex = 17;
            this.lblActivitate.Text = "Activitate";
            // 
            // tbActivitate
            // 
            this.tbActivitate.Location = new System.Drawing.Point(197, 250);
            this.tbActivitate.Name = "tbActivitate";
            this.tbActivitate.Size = new System.Drawing.Size(100, 20);
            this.tbActivitate.TabIndex = 18;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(194, 273);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd.MM.yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(197, 289);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(100, 20);
            this.dtpData.TabIndex = 20;
            // 
            // btnAdaugaAbsenta
            // 
            this.btnAdaugaAbsenta.Location = new System.Drawing.Point(197, 342);
            this.btnAdaugaAbsenta.Name = "btnAdaugaAbsenta";
            this.btnAdaugaAbsenta.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaAbsenta.TabIndex = 21;
            this.btnAdaugaAbsenta.Text = "Adauga Absenta";
            this.btnAdaugaAbsenta.UseVisualStyleBackColor = true;
            this.btnAdaugaAbsenta.Click += new System.EventHandler(this.btnAdaugaAbsenta_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Red;
            this.btnInapoi.Location = new System.Drawing.Point(421, 374);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 22;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // ProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnAdaugaAbsenta);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbActivitate);
            this.Controls.Add(this.lblActivitate);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblAdaugareStudent);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStudenti);
            this.Controls.Add(this.lblStudenti);
            this.Controls.Add(this.rtbStudenti);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.btnAfisareStudenti);
            this.Controls.Add(this.tbFacultate);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblFacultate);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnAdaugaStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProfesorForm";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.ProfesorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaStudent;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblFacultate;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbFacultate;
        private System.Windows.Forms.Button btnAfisareStudenti;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.RichTextBox rtbStudenti;
        private System.Windows.Forms.Label lblStudenti;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblAdaugareStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblActivitate;
        private System.Windows.Forms.TextBox tbActivitate;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnAdaugaAbsenta;
        private System.Windows.Forms.Button btnInapoi;
    }
}
namespace Centralizare_absente
{
    partial class StudentForm
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
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblIdentificator = new System.Windows.Forms.Label();
            this.tbIdentificator = new System.Windows.Forms.TextBox();
            this.btnAfiseazaAbsente = new System.Windows.Forms.Button();
            this.lblIdInexistent = new System.Windows.Forms.Label();
            this.rtbAfisareAbsente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.Color.Red;
            this.btnInapoi.Location = new System.Drawing.Point(422, 114);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 23;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblIdentificator
            // 
            this.lblIdentificator.AutoSize = true;
            this.lblIdentificator.Location = new System.Drawing.Point(12, 15);
            this.lblIdentificator.Name = "lblIdentificator";
            this.lblIdentificator.Size = new System.Drawing.Size(62, 13);
            this.lblIdentificator.TabIndex = 24;
            this.lblIdentificator.Text = "Identificator";
            // 
            // tbIdentificator
            // 
            this.tbIdentificator.Location = new System.Drawing.Point(80, 12);
            this.tbIdentificator.Name = "tbIdentificator";
            this.tbIdentificator.Size = new System.Drawing.Size(100, 20);
            this.tbIdentificator.TabIndex = 25;
            // 
            // btnAfiseazaAbsente
            // 
            this.btnAfiseazaAbsente.Location = new System.Drawing.Point(12, 38);
            this.btnAfiseazaAbsente.Name = "btnAfiseazaAbsente";
            this.btnAfiseazaAbsente.Size = new System.Drawing.Size(168, 23);
            this.btnAfiseazaAbsente.TabIndex = 26;
            this.btnAfiseazaAbsente.Text = "Afiseaza absente";
            this.btnAfiseazaAbsente.UseVisualStyleBackColor = true;
            this.btnAfiseazaAbsente.Click += new System.EventHandler(this.btnAfiseazaAbsente_Click);
            // 
            // lblIdInexistent
            // 
            this.lblIdInexistent.AutoSize = true;
            this.lblIdInexistent.ForeColor = System.Drawing.Color.Red;
            this.lblIdInexistent.Location = new System.Drawing.Point(12, 64);
            this.lblIdInexistent.Name = "lblIdInexistent";
            this.lblIdInexistent.Size = new System.Drawing.Size(109, 13);
            this.lblIdInexistent.TabIndex = 28;
            this.lblIdInexistent.Text = "Identificator inexistent";
            this.lblIdInexistent.Visible = false;
            // 
            // rtbAfisareAbsente
            // 
            this.rtbAfisareAbsente.Location = new System.Drawing.Point(186, 12);
            this.rtbAfisareAbsente.Name = "rtbAfisareAbsente";
            this.rtbAfisareAbsente.Size = new System.Drawing.Size(311, 96);
            this.rtbAfisareAbsente.TabIndex = 29;
            this.rtbAfisareAbsente.Text = "";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 149);
            this.Controls.Add(this.rtbAfisareAbsente);
            this.Controls.Add(this.lblIdInexistent);
            this.Controls.Add(this.btnAfiseazaAbsente);
            this.Controls.Add(this.tbIdentificator);
            this.Controls.Add(this.lblIdentificator);
            this.Controls.Add(this.btnInapoi);
            this.Name = "StudentForm";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblIdentificator;
        private System.Windows.Forms.TextBox tbIdentificator;
        private System.Windows.Forms.Button btnAfiseazaAbsente;
        private System.Windows.Forms.Label lblIdInexistent;
        private System.Windows.Forms.RichTextBox rtbAfisareAbsente;
    }
}
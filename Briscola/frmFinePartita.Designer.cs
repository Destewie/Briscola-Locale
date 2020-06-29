namespace Briscola
{
    partial class frmFinePartita
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
            this.lblVincitore = new System.Windows.Forms.Label();
            this.lblVinceLaPartita = new System.Windows.Forms.Label();
            this.lblPuntiVincitore = new System.Windows.Forms.Label();
            this.lblPuntiPerdente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVincitore
            // 
            this.lblVincitore.AutoSize = true;
            this.lblVincitore.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVincitore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVincitore.Location = new System.Drawing.Point(183, 135);
            this.lblVincitore.Name = "lblVincitore";
            this.lblVincitore.Size = new System.Drawing.Size(331, 75);
            this.lblVincitore.TabIndex = 0;
            this.lblVincitore.Text = "Vincitore";
            this.lblVincitore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVinceLaPartita
            // 
            this.lblVinceLaPartita.AutoSize = true;
            this.lblVinceLaPartita.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinceLaPartita.Location = new System.Drawing.Point(97, 227);
            this.lblVinceLaPartita.Name = "lblVinceLaPartita";
            this.lblVinceLaPartita.Size = new System.Drawing.Size(528, 75);
            this.lblVinceLaPartita.TabIndex = 1;
            this.lblVinceLaPartita.Text = "Vince la partita";
            // 
            // lblPuntiVincitore
            // 
            this.lblPuntiVincitore.AutoSize = true;
            this.lblPuntiVincitore.Font = new System.Drawing.Font("Juice ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntiVincitore.Location = new System.Drawing.Point(16, 9);
            this.lblPuntiVincitore.Name = "lblPuntiVincitore";
            this.lblPuntiVincitore.Size = new System.Drawing.Size(120, 27);
            this.lblPuntiVincitore.TabIndex = 2;
            this.lblPuntiVincitore.Text = "Punti vincitore";
            // 
            // lblPuntiPerdente
            // 
            this.lblPuntiPerdente.AutoSize = true;
            this.lblPuntiPerdente.Font = new System.Drawing.Font("Juice ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntiPerdente.Location = new System.Drawing.Point(17, 46);
            this.lblPuntiPerdente.Name = "lblPuntiPerdente";
            this.lblPuntiPerdente.Size = new System.Drawing.Size(120, 27);
            this.lblPuntiPerdente.TabIndex = 4;
            this.lblPuntiPerdente.Text = "Punti perdente";
            // 
            // frmFinePartita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(710, 387);
            this.Controls.Add(this.lblPuntiPerdente);
            this.Controls.Add(this.lblPuntiVincitore);
            this.Controls.Add(this.lblVinceLaPartita);
            this.Controls.Add(this.lblVincitore);
            this.Name = "frmFinePartita";
            this.Text = "frmFinePartita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVincitore;
        private System.Windows.Forms.Label lblVinceLaPartita;
        private System.Windows.Forms.Label lblPuntiVincitore;
        private System.Windows.Forms.Label lblPuntiPerdente;
    }
}
namespace Briscola
{
    partial class frmTavolo
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTavolo));
            this.lblNCarte = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblBriscola = new System.Windows.Forms.Label();
            this.lblMazzo = new System.Windows.Forms.Label();
            this.picMazzo = new System.Windows.Forms.PictureBox();
            this.pnlCambioPlayer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCambioGiocatore1 = new System.Windows.Forms.Label();
            this.pnlMano = new System.Windows.Forms.Panel();
            this.grbMano = new System.Windows.Forms.GroupBox();
            this.btnCarta3 = new System.Windows.Forms.Button();
            this.btnCarta2 = new System.Windows.Forms.Button();
            this.btnCarta1 = new System.Windows.Forms.Button();
            this.lblCarta1 = new System.Windows.Forms.Label();
            this.lblCarta2 = new System.Windows.Forms.Label();
            this.lblCarta3 = new System.Windows.Forms.Label();
            this.grbTavolo = new System.Windows.Forms.GroupBox();
            this.lblNomeGiocatoreSecondaCarta = new System.Windows.Forms.Label();
            this.lblNomeGiocatorePrimaCarta = new System.Windows.Forms.Label();
            this.lblChiHaPreso = new System.Windows.Forms.Label();
            this.lblCartaTavolo1 = new System.Windows.Forms.Label();
            this.lblCartaTavolo2 = new System.Windows.Forms.Label();
            this.lblCarte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMazzo)).BeginInit();
            this.pnlCambioPlayer.SuspendLayout();
            this.pnlMano.SuspendLayout();
            this.grbMano.SuspendLayout();
            this.grbTavolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNCarte
            // 
            this.lblNCarte.AutoSize = true;
            this.lblNCarte.BackColor = System.Drawing.Color.White;
            this.lblNCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCarte.Location = new System.Drawing.Point(721, 276);
            this.lblNCarte.Name = "lblNCarte";
            this.lblNCarte.Size = new System.Drawing.Size(268, 73);
            this.lblNCarte.TabIndex = 6;
            this.lblNCarte.Text = "n. Carte";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(12, 9);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(121, 42);
            this.lblTurno.TabIndex = 9;
            this.lblTurno.Text = "Turno";
            // 
            // lblBriscola
            // 
            this.lblBriscola.AutoSize = true;
            this.lblBriscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBriscola.Location = new System.Drawing.Point(541, 9);
            this.lblBriscola.Name = "lblBriscola";
            this.lblBriscola.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBriscola.Size = new System.Drawing.Size(195, 37);
            this.lblBriscola.TabIndex = 10;
            this.lblBriscola.Text = "BRISCOLA:";
            // 
            // lblMazzo
            // 
            this.lblMazzo.AutoSize = true;
            this.lblMazzo.BackColor = System.Drawing.Color.White;
            this.lblMazzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMazzo.Location = new System.Drawing.Point(727, 147);
            this.lblMazzo.Name = "lblMazzo";
            this.lblMazzo.Size = new System.Drawing.Size(117, 37);
            this.lblMazzo.TabIndex = 11;
            this.lblMazzo.Text = "mazzo";
            // 
            // picMazzo
            // 
            this.picMazzo.BackColor = System.Drawing.Color.White;
            this.picMazzo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMazzo.InitialImage")));
            this.picMazzo.Location = new System.Drawing.Point(704, 127);
            this.picMazzo.Name = "picMazzo";
            this.picMazzo.Size = new System.Drawing.Size(154, 255);
            this.picMazzo.TabIndex = 0;
            this.picMazzo.TabStop = false;
            // 
            // pnlCambioPlayer
            // 
            this.pnlCambioPlayer.Controls.Add(this.lblTimer);
            this.pnlCambioPlayer.Controls.Add(this.lblCambioGiocatore1);
            this.pnlCambioPlayer.Location = new System.Drawing.Point(70, 310);
            this.pnlCambioPlayer.Name = "pnlCambioPlayer";
            this.pnlCambioPlayer.Size = new System.Drawing.Size(518, 223);
            this.pnlCambioPlayer.TabIndex = 13;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(213, 108);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(200, 73);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Timer";
            // 
            // lblCambioGiocatore1
            // 
            this.lblCambioGiocatore1.AutoSize = true;
            this.lblCambioGiocatore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioGiocatore1.Location = new System.Drawing.Point(18, 14);
            this.lblCambioGiocatore1.Name = "lblCambioGiocatore1";
            this.lblCambioGiocatore1.Size = new System.Drawing.Size(338, 39);
            this.lblCambioGiocatore1.TabIndex = 0;
            this.lblCambioGiocatore1.Text = "Cambio giocatore...";
            // 
            // pnlMano
            // 
            this.pnlMano.Controls.Add(this.grbMano);
            this.pnlMano.Location = new System.Drawing.Point(67, 307);
            this.pnlMano.Name = "pnlMano";
            this.pnlMano.Size = new System.Drawing.Size(521, 227);
            this.pnlMano.TabIndex = 12;
            // 
            // grbMano
            // 
            this.grbMano.Controls.Add(this.btnCarta3);
            this.grbMano.Controls.Add(this.btnCarta2);
            this.grbMano.Controls.Add(this.btnCarta1);
            this.grbMano.Controls.Add(this.lblCarta1);
            this.grbMano.Controls.Add(this.lblCarta2);
            this.grbMano.Controls.Add(this.lblCarta3);
            this.grbMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMano.ForeColor = System.Drawing.Color.Black;
            this.grbMano.Location = new System.Drawing.Point(74, 17);
            this.grbMano.Name = "grbMano";
            this.grbMano.Size = new System.Drawing.Size(370, 172);
            this.grbMano.TabIndex = 7;
            this.grbMano.TabStop = false;
            this.grbMano.Text = "Mano";
            // 
            // btnCarta3
            // 
            this.btnCarta3.BackColor = System.Drawing.Color.OldLace;
            this.btnCarta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarta3.Location = new System.Drawing.Point(264, 127);
            this.btnCarta3.Name = "btnCarta3";
            this.btnCarta3.Size = new System.Drawing.Size(75, 23);
            this.btnCarta3.TabIndex = 7;
            this.btnCarta3.Text = "<--";
            this.btnCarta3.UseVisualStyleBackColor = false;
            this.btnCarta3.Click += new System.EventHandler(this.btnCarta3_Click);
            // 
            // btnCarta2
            // 
            this.btnCarta2.BackColor = System.Drawing.Color.OldLace;
            this.btnCarta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarta2.Location = new System.Drawing.Point(264, 93);
            this.btnCarta2.Name = "btnCarta2";
            this.btnCarta2.Size = new System.Drawing.Size(75, 23);
            this.btnCarta2.TabIndex = 6;
            this.btnCarta2.Text = "<--";
            this.btnCarta2.UseVisualStyleBackColor = false;
            this.btnCarta2.Click += new System.EventHandler(this.btnCarta2_Click);
            // 
            // btnCarta1
            // 
            this.btnCarta1.BackColor = System.Drawing.Color.OldLace;
            this.btnCarta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarta1.Location = new System.Drawing.Point(264, 56);
            this.btnCarta1.Name = "btnCarta1";
            this.btnCarta1.Size = new System.Drawing.Size(75, 23);
            this.btnCarta1.TabIndex = 5;
            this.btnCarta1.Text = "<--";
            this.btnCarta1.UseVisualStyleBackColor = false;
            this.btnCarta1.Click += new System.EventHandler(this.btnCarta1_Click);
            // 
            // lblCarta1
            // 
            this.lblCarta1.AutoSize = true;
            this.lblCarta1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarta1.Location = new System.Drawing.Point(24, 54);
            this.lblCarta1.Name = "lblCarta1";
            this.lblCarta1.Size = new System.Drawing.Size(90, 25);
            this.lblCarta1.TabIndex = 4;
            this.lblCarta1.Text = "Carta 1";
            // 
            // lblCarta2
            // 
            this.lblCarta2.AutoSize = true;
            this.lblCarta2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarta2.Location = new System.Drawing.Point(24, 88);
            this.lblCarta2.Name = "lblCarta2";
            this.lblCarta2.Size = new System.Drawing.Size(90, 25);
            this.lblCarta2.TabIndex = 3;
            this.lblCarta2.Text = "Carta 2";
            // 
            // lblCarta3
            // 
            this.lblCarta3.AutoSize = true;
            this.lblCarta3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarta3.Location = new System.Drawing.Point(24, 122);
            this.lblCarta3.Name = "lblCarta3";
            this.lblCarta3.Size = new System.Drawing.Size(90, 25);
            this.lblCarta3.TabIndex = 2;
            this.lblCarta3.Text = "Carta 3";
            // 
            // grbTavolo
            // 
            this.grbTavolo.Controls.Add(this.lblNomeGiocatoreSecondaCarta);
            this.grbTavolo.Controls.Add(this.lblNomeGiocatorePrimaCarta);
            this.grbTavolo.Controls.Add(this.lblChiHaPreso);
            this.grbTavolo.Controls.Add(this.lblCartaTavolo1);
            this.grbTavolo.Controls.Add(this.lblCartaTavolo2);
            this.grbTavolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTavolo.ForeColor = System.Drawing.Color.Black;
            this.grbTavolo.Location = new System.Drawing.Point(67, 97);
            this.grbTavolo.Name = "grbTavolo";
            this.grbTavolo.Size = new System.Drawing.Size(521, 167);
            this.grbTavolo.TabIndex = 8;
            this.grbTavolo.TabStop = false;
            this.grbTavolo.Text = "Tavolo";
            // 
            // lblNomeGiocatoreSecondaCarta
            // 
            this.lblNomeGiocatoreSecondaCarta.AutoSize = true;
            this.lblNomeGiocatoreSecondaCarta.Font = new System.Drawing.Font("Juice ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGiocatoreSecondaCarta.Location = new System.Drawing.Point(267, 44);
            this.lblNomeGiocatoreSecondaCarta.Name = "lblNomeGiocatoreSecondaCarta";
            this.lblNomeGiocatoreSecondaCarta.Size = new System.Drawing.Size(231, 27);
            this.lblNomeGiocatoreSecondaCarta.TabIndex = 16;
            this.lblNomeGiocatoreSecondaCarta.Text = "Nome giocatore seconda carta";
            // 
            // lblNomeGiocatorePrimaCarta
            // 
            this.lblNomeGiocatorePrimaCarta.AutoSize = true;
            this.lblNomeGiocatorePrimaCarta.Font = new System.Drawing.Font("Juice ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGiocatorePrimaCarta.Location = new System.Drawing.Point(20, 44);
            this.lblNomeGiocatorePrimaCarta.Name = "lblNomeGiocatorePrimaCarta";
            this.lblNomeGiocatorePrimaCarta.Size = new System.Drawing.Size(217, 27);
            this.lblNomeGiocatorePrimaCarta.TabIndex = 15;
            this.lblNomeGiocatorePrimaCarta.Text = "Nome giocatore prima carta";
            // 
            // lblChiHaPreso
            // 
            this.lblChiHaPreso.AutoSize = true;
            this.lblChiHaPreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiHaPreso.Location = new System.Drawing.Point(20, 127);
            this.lblChiHaPreso.Name = "lblChiHaPreso";
            this.lblChiHaPreso.Size = new System.Drawing.Size(161, 29);
            this.lblChiHaPreso.TabIndex = 14;
            this.lblChiHaPreso.Text = "Chi ha preso";
            // 
            // lblCartaTavolo1
            // 
            this.lblCartaTavolo1.AutoSize = true;
            this.lblCartaTavolo1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaTavolo1.Location = new System.Drawing.Point(23, 72);
            this.lblCartaTavolo1.Name = "lblCartaTavolo1";
            this.lblCartaTavolo1.Size = new System.Drawing.Size(167, 25);
            this.lblCartaTavolo1.TabIndex = 4;
            this.lblCartaTavolo1.Text = "Carta Tavolo 1";
            // 
            // lblCartaTavolo2
            // 
            this.lblCartaTavolo2.AutoSize = true;
            this.lblCartaTavolo2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaTavolo2.Location = new System.Drawing.Point(267, 72);
            this.lblCartaTavolo2.Name = "lblCartaTavolo2";
            this.lblCartaTavolo2.Size = new System.Drawing.Size(167, 25);
            this.lblCartaTavolo2.TabIndex = 2;
            this.lblCartaTavolo2.Text = "Carta Tavolo 2";
            // 
            // lblCarte
            // 
            this.lblCarte.AutoSize = true;
            this.lblCarte.BackColor = System.Drawing.Color.White;
            this.lblCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarte.Location = new System.Drawing.Point(727, 239);
            this.lblCarte.Name = "lblCarte";
            this.lblCarte.Size = new System.Drawing.Size(110, 37);
            this.lblCarte.TabIndex = 14;
            this.lblCarte.Text = "Carte:";
            // 
            // frmTavolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1001, 555);
            this.Controls.Add(this.lblCarte);
            this.Controls.Add(this.lblMazzo);
            this.Controls.Add(this.lblBriscola);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.grbTavolo);
            this.Controls.Add(this.lblNCarte);
            this.Controls.Add(this.picMazzo);
            this.Controls.Add(this.pnlMano);
            this.Controls.Add(this.pnlCambioPlayer);
            this.Name = "frmTavolo";
            this.Text = "Briscola";
            ((System.ComponentModel.ISupportInitialize)(this.picMazzo)).EndInit();
            this.pnlCambioPlayer.ResumeLayout(false);
            this.pnlCambioPlayer.PerformLayout();
            this.pnlMano.ResumeLayout(false);
            this.grbMano.ResumeLayout(false);
            this.grbMano.PerformLayout();
            this.grbTavolo.ResumeLayout(false);
            this.grbTavolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNCarte;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblBriscola;
        private System.Windows.Forms.Label lblMazzo;
        private System.Windows.Forms.PictureBox picMazzo;
        private System.Windows.Forms.Panel pnlCambioPlayer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblCambioGiocatore1;
        private System.Windows.Forms.Panel pnlMano;
        private System.Windows.Forms.GroupBox grbMano;
        private System.Windows.Forms.Button btnCarta3;
        private System.Windows.Forms.Button btnCarta2;
        private System.Windows.Forms.Button btnCarta1;
        private System.Windows.Forms.Label lblCarta1;
        private System.Windows.Forms.Label lblCarta2;
        private System.Windows.Forms.Label lblCarta3;
        private System.Windows.Forms.GroupBox grbTavolo;
        private System.Windows.Forms.Label lblNomeGiocatoreSecondaCarta;
        private System.Windows.Forms.Label lblNomeGiocatorePrimaCarta;
        private System.Windows.Forms.Label lblChiHaPreso;
        private System.Windows.Forms.Label lblCartaTavolo1;
        private System.Windows.Forms.Label lblCartaTavolo2;
        private System.Windows.Forms.Label lblCarte;
    }
}


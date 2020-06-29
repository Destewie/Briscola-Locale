namespace Briscola
{
    partial class frmGiocatori
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
            this.btnGioca = new System.Windows.Forms.Button();
            this.txtNomeGiocatore2 = new System.Windows.Forms.TextBox();
            this.txtNomeGiocatore1 = new System.Windows.Forms.TextBox();
            this.lblNomeGiocatore2 = new System.Windows.Forms.Label();
            this.lblNomeGiocatore1 = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.OldLace;
            this.btnGioca.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGioca.Font = new System.Drawing.Font("Rosewood Std Regular", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioca.Location = new System.Drawing.Point(232, 232);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(217, 72);
            this.btnGioca.TabIndex = 11;
            this.btnGioca.Text = "GIOCA!";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // txtNomeGiocatore2
            // 
            this.txtNomeGiocatore2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGiocatore2.Location = new System.Drawing.Point(363, 163);
            this.txtNomeGiocatore2.Name = "txtNomeGiocatore2";
            this.txtNomeGiocatore2.Size = new System.Drawing.Size(227, 30);
            this.txtNomeGiocatore2.TabIndex = 10;
            this.txtNomeGiocatore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeGiocatore1
            // 
            this.txtNomeGiocatore1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGiocatore1.Location = new System.Drawing.Point(89, 163);
            this.txtNomeGiocatore1.Name = "txtNomeGiocatore1";
            this.txtNomeGiocatore1.Size = new System.Drawing.Size(227, 30);
            this.txtNomeGiocatore1.TabIndex = 9;
            this.txtNomeGiocatore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeGiocatore2
            // 
            this.lblNomeGiocatore2.AutoSize = true;
            this.lblNomeGiocatore2.Font = new System.Drawing.Font("Rosewood Std Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGiocatore2.Location = new System.Drawing.Point(377, 123);
            this.lblNomeGiocatore2.Name = "lblNomeGiocatore2";
            this.lblNomeGiocatore2.Size = new System.Drawing.Size(202, 37);
            this.lblNomeGiocatore2.TabIndex = 8;
            this.lblNomeGiocatore2.Text = "Giocatore 2:";
            // 
            // lblNomeGiocatore1
            // 
            this.lblNomeGiocatore1.AutoSize = true;
            this.lblNomeGiocatore1.Font = new System.Drawing.Font("Rosewood Std Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGiocatore1.Location = new System.Drawing.Point(104, 123);
            this.lblNomeGiocatore1.Name = "lblNomeGiocatore1";
            this.lblNomeGiocatore1.Size = new System.Drawing.Size(198, 37);
            this.lblNomeGiocatore1.TabIndex = 7;
            this.lblNomeGiocatore1.Text = "Giocatore 1:";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(186, 9);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(313, 75);
            this.lblTitolo.TabIndex = 6;
            this.lblTitolo.Text = "BRISCOLA";
            // 
            // frmGiocatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(704, 327);
            this.Controls.Add(this.btnGioca);
            this.Controls.Add(this.txtNomeGiocatore2);
            this.Controls.Add(this.txtNomeGiocatore1);
            this.Controls.Add(this.lblNomeGiocatore2);
            this.Controls.Add(this.lblNomeGiocatore1);
            this.Controls.Add(this.lblTitolo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmGiocatori";
            this.Text = "Giocatori";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.TextBox txtNomeGiocatore2;
        private System.Windows.Forms.TextBox txtNomeGiocatore1;
        private System.Windows.Forms.Label lblNomeGiocatore2;
        private System.Windows.Forms.Label lblNomeGiocatore1;
        private System.Windows.Forms.Label lblTitolo;
    }
}
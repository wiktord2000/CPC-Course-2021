
namespace WiktorDanielewskiLab1PracDom
{
    partial class FormWiesniacy
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
            this.components = new System.ComponentModel.Container();
            this.timerOknoWiesniakow = new System.Windows.Forms.Timer(this.components);
            this.labelLiczbaNieprzypisanychWiesniakow = new System.Windows.Forms.Label();
            this.buttonDokupWiesniaka = new System.Windows.Forms.Button();
            this.labelKamien = new System.Windows.Forms.Label();
            this.labelZloto = new System.Windows.Forms.Label();
            this.labelDrewno = new System.Windows.Forms.Label();
            this.labelJedzenie = new System.Windows.Forms.Label();
            this.pictureBoxOdejmnijOdJedzenia = new System.Windows.Forms.PictureBox();
            this.pictureBoxDodajDoJedzenia = new System.Windows.Forms.PictureBox();
            this.pictureBoxOdejmnijOdKamienia = new System.Windows.Forms.PictureBox();
            this.pictureBoxDodajDoKamienia = new System.Windows.Forms.PictureBox();
            this.pictureBoxOdejmnijOdDrewna = new System.Windows.Forms.PictureBox();
            this.pictureBoxDodajDoDrewna = new System.Windows.Forms.PictureBox();
            this.pictureBoxOdejmnijOdZlota = new System.Windows.Forms.PictureBox();
            this.pictureBoxDodajDoZlota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdJedzenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoJedzenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdKamienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoKamienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdDrewna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoDrewna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdZlota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoZlota)).BeginInit();
            this.SuspendLayout();
            // 
            // timerOknoWiesniakow
            // 
            this.timerOknoWiesniakow.Enabled = true;
            this.timerOknoWiesniakow.Interval = 1;
            this.timerOknoWiesniakow.Tick += new System.EventHandler(this.timerOknoWiesniakow_Tick);
            // 
            // labelLiczbaNieprzypisanychWiesniakow
            // 
            this.labelLiczbaNieprzypisanychWiesniakow.AutoSize = true;
            this.labelLiczbaNieprzypisanychWiesniakow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLiczbaNieprzypisanychWiesniakow.Location = new System.Drawing.Point(206, 33);
            this.labelLiczbaNieprzypisanychWiesniakow.Name = "labelLiczbaNieprzypisanychWiesniakow";
            this.labelLiczbaNieprzypisanychWiesniakow.Size = new System.Drawing.Size(360, 25);
            this.labelLiczbaNieprzypisanychWiesniakow.TabIndex = 0;
            this.labelLiczbaNieprzypisanychWiesniakow.Text = "Liczba nieprzypisanych wieśniaków:";
            this.labelLiczbaNieprzypisanychWiesniakow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDokupWiesniaka
            // 
            this.buttonDokupWiesniaka.Location = new System.Drawing.Point(285, 316);
            this.buttonDokupWiesniaka.Name = "buttonDokupWiesniaka";
            this.buttonDokupWiesniaka.Size = new System.Drawing.Size(208, 53);
            this.buttonDokupWiesniaka.TabIndex = 1;
            this.buttonDokupWiesniaka.Text = "Dokup wieśniaka(50 zlota)";
            this.buttonDokupWiesniaka.UseVisualStyleBackColor = true;
            this.buttonDokupWiesniaka.Click += new System.EventHandler(this.buttonDokupWiesniaka_Click);
            // 
            // labelKamien
            // 
            this.labelKamien.AutoSize = true;
            this.labelKamien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKamien.Location = new System.Drawing.Point(398, 194);
            this.labelKamien.Name = "labelKamien";
            this.labelKamien.Size = new System.Drawing.Size(90, 25);
            this.labelKamien.TabIndex = 10;
            this.labelKamien.Text = "Kamień: ";
            // 
            // labelZloto
            // 
            this.labelZloto.AutoSize = true;
            this.labelZloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZloto.Location = new System.Drawing.Point(151, 194);
            this.labelZloto.Name = "labelZloto";
            this.labelZloto.Size = new System.Drawing.Size(66, 25);
            this.labelZloto.TabIndex = 11;
            this.labelZloto.Text = "Złoto: ";
            // 
            // labelDrewno
            // 
            this.labelDrewno.AutoSize = true;
            this.labelDrewno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrewno.Location = new System.Drawing.Point(271, 194);
            this.labelDrewno.Name = "labelDrewno";
            this.labelDrewno.Size = new System.Drawing.Size(85, 25);
            this.labelDrewno.TabIndex = 12;
            this.labelDrewno.Text = "Drewno:";
            // 
            // labelJedzenie
            // 
            this.labelJedzenie.AutoSize = true;
            this.labelJedzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJedzenie.Location = new System.Drawing.Point(523, 194);
            this.labelJedzenie.Name = "labelJedzenie";
            this.labelJedzenie.Size = new System.Drawing.Size(98, 25);
            this.labelJedzenie.TabIndex = 13;
            this.labelJedzenie.Text = "Jedzenie:";
            // 
            // pictureBoxOdejmnijOdJedzenia
            // 
            this.pictureBoxOdejmnijOdJedzenia.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Minus2;
            this.pictureBoxOdejmnijOdJedzenia.Location = new System.Drawing.Point(554, 222);
            this.pictureBoxOdejmnijOdJedzenia.Name = "pictureBoxOdejmnijOdJedzenia";
            this.pictureBoxOdejmnijOdJedzenia.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxOdejmnijOdJedzenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdejmnijOdJedzenia.TabIndex = 9;
            this.pictureBoxOdejmnijOdJedzenia.TabStop = false;
            this.pictureBoxOdejmnijOdJedzenia.Click += new System.EventHandler(this.pictureBoxOdejmnijOdJedzenia_Click);
            // 
            // pictureBoxDodajDoJedzenia
            // 
            this.pictureBoxDodajDoJedzenia.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Plus2;
            this.pictureBoxDodajDoJedzenia.Location = new System.Drawing.Point(554, 145);
            this.pictureBoxDodajDoJedzenia.Name = "pictureBoxDodajDoJedzenia";
            this.pictureBoxDodajDoJedzenia.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxDodajDoJedzenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDodajDoJedzenia.TabIndex = 8;
            this.pictureBoxDodajDoJedzenia.TabStop = false;
            this.pictureBoxDodajDoJedzenia.Click += new System.EventHandler(this.pictureBoxDodajDoJedzenia_Click);
            // 
            // pictureBoxOdejmnijOdKamienia
            // 
            this.pictureBoxOdejmnijOdKamienia.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Minus2;
            this.pictureBoxOdejmnijOdKamienia.Location = new System.Drawing.Point(426, 222);
            this.pictureBoxOdejmnijOdKamienia.Name = "pictureBoxOdejmnijOdKamienia";
            this.pictureBoxOdejmnijOdKamienia.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxOdejmnijOdKamienia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdejmnijOdKamienia.TabIndex = 7;
            this.pictureBoxOdejmnijOdKamienia.TabStop = false;
            this.pictureBoxOdejmnijOdKamienia.Click += new System.EventHandler(this.pictureBoxOdejmnijOdKamienia_Click);
            // 
            // pictureBoxDodajDoKamienia
            // 
            this.pictureBoxDodajDoKamienia.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Plus2;
            this.pictureBoxDodajDoKamienia.Location = new System.Drawing.Point(426, 145);
            this.pictureBoxDodajDoKamienia.Name = "pictureBoxDodajDoKamienia";
            this.pictureBoxDodajDoKamienia.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxDodajDoKamienia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDodajDoKamienia.TabIndex = 6;
            this.pictureBoxDodajDoKamienia.TabStop = false;
            this.pictureBoxDodajDoKamienia.Click += new System.EventHandler(this.pictureBoxDodajDoKamienia_Click);
            // 
            // pictureBoxOdejmnijOdDrewna
            // 
            this.pictureBoxOdejmnijOdDrewna.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Minus2;
            this.pictureBoxOdejmnijOdDrewna.Location = new System.Drawing.Point(298, 222);
            this.pictureBoxOdejmnijOdDrewna.Name = "pictureBoxOdejmnijOdDrewna";
            this.pictureBoxOdejmnijOdDrewna.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxOdejmnijOdDrewna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdejmnijOdDrewna.TabIndex = 5;
            this.pictureBoxOdejmnijOdDrewna.TabStop = false;
            this.pictureBoxOdejmnijOdDrewna.Click += new System.EventHandler(this.pictureBoxOdejmnijOdDrewna_Click);
            // 
            // pictureBoxDodajDoDrewna
            // 
            this.pictureBoxDodajDoDrewna.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Plus2;
            this.pictureBoxDodajDoDrewna.Location = new System.Drawing.Point(298, 145);
            this.pictureBoxDodajDoDrewna.Name = "pictureBoxDodajDoDrewna";
            this.pictureBoxDodajDoDrewna.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxDodajDoDrewna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDodajDoDrewna.TabIndex = 4;
            this.pictureBoxDodajDoDrewna.TabStop = false;
            this.pictureBoxDodajDoDrewna.Click += new System.EventHandler(this.pictureBoxDodajDoDrewna_Click);
            // 
            // pictureBoxOdejmnijOdZlota
            // 
            this.pictureBoxOdejmnijOdZlota.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Minus2;
            this.pictureBoxOdejmnijOdZlota.Location = new System.Drawing.Point(170, 222);
            this.pictureBoxOdejmnijOdZlota.Name = "pictureBoxOdejmnijOdZlota";
            this.pictureBoxOdejmnijOdZlota.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxOdejmnijOdZlota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOdejmnijOdZlota.TabIndex = 3;
            this.pictureBoxOdejmnijOdZlota.TabStop = false;
            this.pictureBoxOdejmnijOdZlota.Click += new System.EventHandler(this.pictureBoxOdejmnijOdZlota_Click);
            // 
            // pictureBoxDodajDoZlota
            // 
            this.pictureBoxDodajDoZlota.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.Plus2;
            this.pictureBoxDodajDoZlota.Location = new System.Drawing.Point(170, 145);
            this.pictureBoxDodajDoZlota.Name = "pictureBoxDodajDoZlota";
            this.pictureBoxDodajDoZlota.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxDodajDoZlota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDodajDoZlota.TabIndex = 2;
            this.pictureBoxDodajDoZlota.TabStop = false;
            this.pictureBoxDodajDoZlota.Click += new System.EventHandler(this.pictureBoxDodajDoZlota_Click);
            // 
            // FormWiesniacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJedzenie);
            this.Controls.Add(this.labelDrewno);
            this.Controls.Add(this.labelZloto);
            this.Controls.Add(this.labelKamien);
            this.Controls.Add(this.pictureBoxOdejmnijOdJedzenia);
            this.Controls.Add(this.pictureBoxDodajDoJedzenia);
            this.Controls.Add(this.pictureBoxOdejmnijOdKamienia);
            this.Controls.Add(this.pictureBoxDodajDoKamienia);
            this.Controls.Add(this.pictureBoxOdejmnijOdDrewna);
            this.Controls.Add(this.pictureBoxDodajDoDrewna);
            this.Controls.Add(this.pictureBoxOdejmnijOdZlota);
            this.Controls.Add(this.pictureBoxDodajDoZlota);
            this.Controls.Add(this.buttonDokupWiesniaka);
            this.Controls.Add(this.labelLiczbaNieprzypisanychWiesniakow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormWiesniacy";
            this.Text = "Wieśniacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWiesniacy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdJedzenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoJedzenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdKamienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoKamienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdDrewna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoDrewna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOdejmnijOdZlota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDodajDoZlota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerOknoWiesniakow;
        private System.Windows.Forms.Label labelLiczbaNieprzypisanychWiesniakow;
        private System.Windows.Forms.Button buttonDokupWiesniaka;
        private System.Windows.Forms.PictureBox pictureBoxDodajDoZlota;
        private System.Windows.Forms.PictureBox pictureBoxOdejmnijOdZlota;
        private System.Windows.Forms.PictureBox pictureBoxOdejmnijOdDrewna;
        private System.Windows.Forms.PictureBox pictureBoxDodajDoDrewna;
        private System.Windows.Forms.PictureBox pictureBoxOdejmnijOdKamienia;
        private System.Windows.Forms.PictureBox pictureBoxDodajDoKamienia;
        private System.Windows.Forms.PictureBox pictureBoxOdejmnijOdJedzenia;
        private System.Windows.Forms.PictureBox pictureBoxDodajDoJedzenia;
        private System.Windows.Forms.Label labelKamien;
        private System.Windows.Forms.Label labelZloto;
        private System.Windows.Forms.Label labelDrewno;
        private System.Windows.Forms.Label labelJedzenie;
    }
}
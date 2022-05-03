
namespace WiktorDanielewskiLab1PracDom
{
    partial class MainForm
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
            this.buttonWojsko = new System.Windows.Forms.Button();
            this.buttonWiesniacy = new System.Windows.Forms.Button();
            this.buttonMury = new System.Windows.Forms.Button();
            this.buttonZamek = new System.Windows.Forms.Button();
            this.buttonStatystyki = new System.Windows.Forms.Button();
            this.buttonNagrody = new System.Windows.Forms.Button();
            this.labelZloto = new System.Windows.Forms.Label();
            this.labelDrewno = new System.Windows.Forms.Label();
            this.labelKamien = new System.Windows.Forms.Label();
            this.labelJedzenie = new System.Windows.Forms.Label();
            this.labelPopulacja = new System.Windows.Forms.Label();
            this.timerLicznikSekund = new System.Windows.Forms.Timer(this.components);
            this.labelCzas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWojsko
            // 
            this.buttonWojsko.Location = new System.Drawing.Point(604, 224);
            this.buttonWojsko.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWojsko.Name = "buttonWojsko";
            this.buttonWojsko.Size = new System.Drawing.Size(128, 38);
            this.buttonWojsko.TabIndex = 0;
            this.buttonWojsko.Text = "Wojsko";
            this.buttonWojsko.UseVisualStyleBackColor = true;
            this.buttonWojsko.Click += new System.EventHandler(this.buttonWojsko_Click);
            // 
            // buttonWiesniacy
            // 
            this.buttonWiesniacy.Location = new System.Drawing.Point(199, 348);
            this.buttonWiesniacy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWiesniacy.Name = "buttonWiesniacy";
            this.buttonWiesniacy.Size = new System.Drawing.Size(127, 38);
            this.buttonWiesniacy.TabIndex = 1;
            this.buttonWiesniacy.Text = "Wieśniacy";
            this.buttonWiesniacy.UseVisualStyleBackColor = true;
            this.buttonWiesniacy.Click += new System.EventHandler(this.buttonWiesniacy_Click);
            // 
            // buttonMury
            // 
            this.buttonMury.Location = new System.Drawing.Point(920, 89);
            this.buttonMury.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMury.Name = "buttonMury";
            this.buttonMury.Size = new System.Drawing.Size(128, 38);
            this.buttonMury.TabIndex = 2;
            this.buttonMury.Text = "Mury";
            this.buttonMury.UseVisualStyleBackColor = true;
            this.buttonMury.Click += new System.EventHandler(this.buttonMury_Click);
            // 
            // buttonZamek
            // 
            this.buttonZamek.Location = new System.Drawing.Point(289, 113);
            this.buttonZamek.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZamek.Name = "buttonZamek";
            this.buttonZamek.Size = new System.Drawing.Size(127, 38);
            this.buttonZamek.TabIndex = 3;
            this.buttonZamek.Text = "Zamek";
            this.buttonZamek.UseVisualStyleBackColor = true;
            this.buttonZamek.Click += new System.EventHandler(this.buttonZamek_Click);
            // 
            // buttonStatystyki
            // 
            this.buttonStatystyki.Location = new System.Drawing.Point(993, 270);
            this.buttonStatystyki.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatystyki.Name = "buttonStatystyki";
            this.buttonStatystyki.Size = new System.Drawing.Size(128, 38);
            this.buttonStatystyki.TabIndex = 4;
            this.buttonStatystyki.Text = "Statystyki";
            this.buttonStatystyki.UseVisualStyleBackColor = true;
            this.buttonStatystyki.Click += new System.EventHandler(this.buttonStatystyki_Click);
            // 
            // buttonNagrody
            // 
            this.buttonNagrody.Location = new System.Drawing.Point(993, 476);
            this.buttonNagrody.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNagrody.Name = "buttonNagrody";
            this.buttonNagrody.Size = new System.Drawing.Size(127, 38);
            this.buttonNagrody.TabIndex = 5;
            this.buttonNagrody.Text = "Nagrody";
            this.buttonNagrody.UseVisualStyleBackColor = true;
            this.buttonNagrody.Click += new System.EventHandler(this.buttonNagrody_Click);
            // 
            // labelZloto
            // 
            this.labelZloto.AutoSize = true;
            this.labelZloto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelZloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZloto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelZloto.Location = new System.Drawing.Point(21, 506);
            this.labelZloto.Name = "labelZloto";
            this.labelZloto.Size = new System.Drawing.Size(82, 29);
            this.labelZloto.TabIndex = 6;
            this.labelZloto.Text = "Złoto:";
            // 
            // labelDrewno
            // 
            this.labelDrewno.AutoSize = true;
            this.labelDrewno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelDrewno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrewno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDrewno.Location = new System.Drawing.Point(21, 546);
            this.labelDrewno.Name = "labelDrewno";
            this.labelDrewno.Size = new System.Drawing.Size(110, 29);
            this.labelDrewno.TabIndex = 7;
            this.labelDrewno.Text = "Drewno:";
            // 
            // labelKamien
            // 
            this.labelKamien.AutoSize = true;
            this.labelKamien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelKamien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKamien.Location = new System.Drawing.Point(21, 587);
            this.labelKamien.Name = "labelKamien";
            this.labelKamien.Size = new System.Drawing.Size(108, 29);
            this.labelKamien.TabIndex = 8;
            this.labelKamien.Text = "Kamień:";
            // 
            // labelJedzenie
            // 
            this.labelJedzenie.AutoSize = true;
            this.labelJedzenie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelJedzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelJedzenie.Location = new System.Drawing.Point(21, 626);
            this.labelJedzenie.Name = "labelJedzenie";
            this.labelJedzenie.Size = new System.Drawing.Size(126, 29);
            this.labelJedzenie.TabIndex = 9;
            this.labelJedzenie.Text = "Jedzenie:";
            // 
            // labelPopulacja
            // 
            this.labelPopulacja.AutoSize = true;
            this.labelPopulacja.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelPopulacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopulacja.Location = new System.Drawing.Point(21, 664);
            this.labelPopulacja.Name = "labelPopulacja";
            this.labelPopulacja.Size = new System.Drawing.Size(136, 29);
            this.labelPopulacja.TabIndex = 10;
            this.labelPopulacja.Text = "Populacja:";
            // 
            // timerLicznikSekund
            // 
            this.timerLicznikSekund.Enabled = true;
            this.timerLicznikSekund.Interval = 1000;
            this.timerLicznikSekund.Tick += new System.EventHandler(this.timerLicznikSekund_Tick);
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCzas.Location = new System.Drawing.Point(1128, 18);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(84, 29);
            this.labelCzas.TabIndex = 11;
            this.labelCzas.Text = "Czas: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WiktorDanielewskiLab1PracDom.Properties.Resources.ImperiumView;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 711);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.labelPopulacja);
            this.Controls.Add(this.labelJedzenie);
            this.Controls.Add(this.labelKamien);
            this.Controls.Add(this.labelDrewno);
            this.Controls.Add(this.labelZloto);
            this.Controls.Add(this.buttonNagrody);
            this.Controls.Add(this.buttonStatystyki);
            this.Controls.Add(this.buttonZamek);
            this.Controls.Add(this.buttonMury);
            this.Controls.Add(this.buttonWiesniacy);
            this.Controls.Add(this.buttonWojsko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Imperium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Przycisk otwierający okno związane z wojskiem
        /// </summary>
        private System.Windows.Forms.Button buttonWojsko;
        /// <summary>
        /// Przycisk otwierający okno związane z wieśniakami
        /// </summary>
        private System.Windows.Forms.Button buttonWiesniacy;
        /// <summary>
        /// Przycisk otwierający okno związane z murami
        /// </summary>
        private System.Windows.Forms.Button buttonMury;
        /// <summary>
        /// Przycisk otwierający okno związane z zamkiem
        /// </summary>
        private System.Windows.Forms.Button buttonZamek;
        /// <summary>
        /// Przycisk otwierający okno związane ze statystykami
        /// </summary>
        private System.Windows.Forms.Button buttonStatystyki;
        /// <summary>
        /// Przycisk otwierający okno nagrod
        /// </summary>
        private System.Windows.Forms.Button buttonNagrody;
        /// <summary>
        /// Etykieta informująca o liczbie złota
        /// </summary>
        private System.Windows.Forms.Label labelZloto;
        /// <summary>
        /// Etykieta informująca o liczbie drewna
        /// </summary>
        private System.Windows.Forms.Label labelDrewno;
        /// <summary>
        /// Etykieta informująca o liczbie kamienia
        /// </summary>
        private System.Windows.Forms.Label labelKamien;
        /// <summary>
        /// Etykieta informująca o liczbie jedzenia
        /// </summary>
        private System.Windows.Forms.Label labelJedzenie;
        /// <summary>
        /// Etykieta informująca o populacji
        /// </summary>
        private System.Windows.Forms.Label labelPopulacja;
        /// <summary>
        /// Timer ustawiony na zliczanie sekund
        /// </summary>
        private System.Windows.Forms.Timer timerLicznikSekund;
        /// <summary>
        /// Etykieta zawierająca informację o aktualnym czasie w grze
        /// </summary>
        private System.Windows.Forms.Label labelCzas;
    }
}


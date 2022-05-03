
namespace WiktorDanielewskiLab1PracDom
{
    partial class FormNagrody
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
            this.buttonOdbierz = new System.Windows.Forms.Button();
            this.labelCzasOczekiwania = new System.Windows.Forms.Label();
            this.timerOknaNagrody = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxNagroda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNagroda)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOdbierz
            // 
            this.buttonOdbierz.Enabled = false;
            this.buttonOdbierz.Location = new System.Drawing.Point(282, 300);
            this.buttonOdbierz.Name = "buttonOdbierz";
            this.buttonOdbierz.Size = new System.Drawing.Size(229, 50);
            this.buttonOdbierz.TabIndex = 1;
            this.buttonOdbierz.Text = "Odbierz";
            this.buttonOdbierz.UseVisualStyleBackColor = true;
            this.buttonOdbierz.Click += new System.EventHandler(this.buttonOdbierz_Click);
            // 
            // labelCzasOczekiwania
            // 
            this.labelCzasOczekiwania.AutoSize = true;
            this.labelCzasOczekiwania.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCzasOczekiwania.ForeColor = System.Drawing.Color.Red;
            this.labelCzasOczekiwania.Location = new System.Drawing.Point(296, 365);
            this.labelCzasOczekiwania.Name = "labelCzasOczekiwania";
            this.labelCzasOczekiwania.Size = new System.Drawing.Size(0, 20);
            this.labelCzasOczekiwania.TabIndex = 2;
            this.labelCzasOczekiwania.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerOknaNagrody
            // 
            this.timerOknaNagrody.Enabled = true;
            this.timerOknaNagrody.Interval = 1000;
            this.timerOknaNagrody.Tick += new System.EventHandler(this.timerOknaNagrody_Tick);
            // 
            // pictureBoxNagroda
            // 
            this.pictureBoxNagroda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNagroda.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.ClosedCase;
            this.pictureBoxNagroda.Location = new System.Drawing.Point(268, 18);
            this.pictureBoxNagroda.Name = "pictureBoxNagroda";
            this.pictureBoxNagroda.Size = new System.Drawing.Size(260, 265);
            this.pictureBoxNagroda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNagroda.TabIndex = 0;
            this.pictureBoxNagroda.TabStop = false;
            // 
            // FormNagrody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCzasOczekiwania);
            this.Controls.Add(this.buttonOdbierz);
            this.Controls.Add(this.pictureBoxNagroda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormNagrody";
            this.Text = "Nagrody";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNagrody_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNagroda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Zawiera jeden z obrazków: OpenCase lub ClosedCase
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxNagroda;
        /// <summary>
        /// Przycisk umożliwiajacy odebranie nagrody, jeśli jest to możliwe
        /// </summary>
        private System.Windows.Forms.Button buttonOdbierz;
        /// <summary>
        /// Etykieta informująca ile czasu pozostało do odebrania nagrody
        /// </summary>
        private System.Windows.Forms.Label labelCzasOczekiwania;
        /// <summary>
        /// Timer dla okna 'formNagrody' (ustawiony na tik, co 1 sekundę)
        /// </summary>
        private System.Windows.Forms.Timer timerOknaNagrody;
    }
}

namespace WiktorDanielewskiLab1PracDom
{
    partial class FormPopulacja
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
            this.labelKosztJednejJPopulacji = new System.Windows.Forms.Label();
            this.labelPolaczoneKoszty = new System.Windows.Forms.Label();
            this.labelIleJednostek = new System.Windows.Forms.Label();
            this.textBoxLiczbaJednostek = new System.Windows.Forms.TextBox();
            this.buttonKup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKosztJednejJPopulacji
            // 
            this.labelKosztJednejJPopulacji.AutoSize = true;
            this.labelKosztJednejJPopulacji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKosztJednejJPopulacji.Location = new System.Drawing.Point(169, 56);
            this.labelKosztJednejJPopulacji.Name = "labelKosztJednejJPopulacji";
            this.labelKosztJednejJPopulacji.Size = new System.Drawing.Size(322, 25);
            this.labelKosztJednejJPopulacji.TabIndex = 0;
            this.labelKosztJednejJPopulacji.Text = "Koszt jednej jednostki populacji:";
            // 
            // labelPolaczoneKoszty
            // 
            this.labelPolaczoneKoszty.AutoSize = true;
            this.labelPolaczoneKoszty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPolaczoneKoszty.Location = new System.Drawing.Point(278, 109);
            this.labelPolaczoneKoszty.Name = "labelPolaczoneKoszty";
            this.labelPolaczoneKoszty.Size = new System.Drawing.Size(0, 25);
            this.labelPolaczoneKoszty.TabIndex = 1;
            this.labelPolaczoneKoszty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIleJednostek
            // 
            this.labelIleJednostek.AutoSize = true;
            this.labelIleJednostek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIleJednostek.Location = new System.Drawing.Point(188, 228);
            this.labelIleJednostek.Name = "labelIleJednostek";
            this.labelIleJednostek.Size = new System.Drawing.Size(277, 25);
            this.labelIleJednostek.TabIndex = 2;
            this.labelIleJednostek.Text = "Ile jednostek chcesz kupić?";
            // 
            // textBoxLiczbaJednostek
            // 
            this.textBoxLiczbaJednostek.Location = new System.Drawing.Point(206, 269);
            this.textBoxLiczbaJednostek.Name = "textBoxLiczbaJednostek";
            this.textBoxLiczbaJednostek.Size = new System.Drawing.Size(258, 22);
            this.textBoxLiczbaJednostek.TabIndex = 3;
            this.textBoxLiczbaJednostek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonKup
            // 
            this.buttonKup.Location = new System.Drawing.Point(263, 319);
            this.buttonKup.Name = "buttonKup";
            this.buttonKup.Size = new System.Drawing.Size(145, 50);
            this.buttonKup.TabIndex = 4;
            this.buttonKup.Text = "Kup";
            this.buttonKup.UseVisualStyleBackColor = true;
            this.buttonKup.Click += new System.EventHandler(this.buttonKup_Click);
            // 
            // FormPopulacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.buttonKup);
            this.Controls.Add(this.textBoxLiczbaJednostek);
            this.Controls.Add(this.labelIleJednostek);
            this.Controls.Add(this.labelPolaczoneKoszty);
            this.Controls.Add(this.labelKosztJednejJPopulacji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPopulacja";
            this.Text = "Populacja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Etykieta zawierająca napis "Koszt jednej jednostki populacji:"
        /// </summary>
        private System.Windows.Forms.Label labelKosztJednejJPopulacji;
        /// <summary>
        /// Etykieta zawierająca informację o wszystkich kosztach jakie trzeba ponieść, aby powiększyć limit populacji
        /// </summary>
        private System.Windows.Forms.Label labelPolaczoneKoszty;
        /// <summary>
        /// Etykieta zawierająca napis "Ile jednostek chcesz kupić?"
        /// </summary>
        private System.Windows.Forms.Label labelIleJednostek;
        /// <summary>
        /// Pole tekstowe na liczbę jednostek populacji do kupienia
        /// </summary>
        private System.Windows.Forms.TextBox textBoxLiczbaJednostek;
        /// <summary>
        /// Przycisk umożliwiający zakup jednostek populacji. Jeśli nie będziemy mieli wystarczająco zasobów to otrzymamy o tym komunikat
        /// </summary>
        private System.Windows.Forms.Button buttonKup;
    }
}
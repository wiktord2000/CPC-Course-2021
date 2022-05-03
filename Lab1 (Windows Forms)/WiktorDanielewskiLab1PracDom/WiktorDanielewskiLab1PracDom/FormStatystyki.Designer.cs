
namespace WiktorDanielewskiLab1PracDom
{
    partial class FormStatystyki
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
            this.labelStatystyki = new System.Windows.Forms.Label();
            this.timerOknaStatystyki = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStatystyki
            // 
            this.labelStatystyki.AutoSize = true;
            this.labelStatystyki.BackColor = System.Drawing.Color.Transparent;
            this.labelStatystyki.Font = new System.Drawing.Font("Magneto", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatystyki.Location = new System.Drawing.Point(26, 37);
            this.labelStatystyki.Name = "labelStatystyki";
            this.labelStatystyki.Size = new System.Drawing.Size(58, 28);
            this.labelStatystyki.TabIndex = 0;
            this.labelStatystyki.Text = "brak";
            // 
            // timerOknaStatystyki
            // 
            this.timerOknaStatystyki.Enabled = true;
            this.timerOknaStatystyki.Tick += new System.EventHandler(this.timerOknaStatystyki_Tick);
            // 
            // FormStatystyki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WiktorDanielewskiLab1PracDom.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(232, 256);
            this.Controls.Add(this.labelStatystyki);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStatystyki";
            this.Text = "Statystyki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStatystyki_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// Etykieta wyświetlająca statystyki
        /// </summary>
        private System.Windows.Forms.Label labelStatystyki;
        /// <summary>
        /// Timer okna statystyki
        /// </summary>
        private System.Windows.Forms.Timer timerOknaStatystyki;
    }
}
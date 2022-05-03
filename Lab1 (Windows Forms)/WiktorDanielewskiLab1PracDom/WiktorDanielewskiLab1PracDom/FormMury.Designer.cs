
namespace WiktorDanielewskiLab1PracDom
{
    partial class FormMury
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
            this.pictureBoxMur = new System.Windows.Forms.PictureBox();
            this.labelPoziomMurow = new System.Windows.Forms.Label();
            this.labelKosztMurow = new System.Windows.Forms.Label();
            this.timerOknaMury = new System.Windows.Forms.Timer(this.components);
            this.buttonUlepsz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMur)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMur
            // 
            this.pictureBoxMur.Image = global::WiktorDanielewskiLab1PracDom.Properties.Resources.PalisadeWall;
            this.pictureBoxMur.Location = new System.Drawing.Point(98, 46);
            this.pictureBoxMur.Name = "pictureBoxMur";
            this.pictureBoxMur.Size = new System.Drawing.Size(246, 211);
            this.pictureBoxMur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMur.TabIndex = 0;
            this.pictureBoxMur.TabStop = false;
            // 
            // labelPoziomMurow
            // 
            this.labelPoziomMurow.AutoSize = true;
            this.labelPoziomMurow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomMurow.Location = new System.Drawing.Point(103, 265);
            this.labelPoziomMurow.Name = "labelPoziomMurow";
            this.labelPoziomMurow.Size = new System.Drawing.Size(85, 29);
            this.labelPoziomMurow.TabIndex = 1;
            this.labelPoziomMurow.Text = "LVL: 1";
            // 
            // labelKosztMurow
            // 
            this.labelKosztMurow.AutoSize = true;
            this.labelKosztMurow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKosztMurow.Location = new System.Drawing.Point(103, 294);
            this.labelKosztMurow.Name = "labelKosztMurow";
            this.labelKosztMurow.Size = new System.Drawing.Size(104, 40);
            this.labelKosztMurow.TabIndex = 2;
            this.labelKosztMurow.Text = "Koszt:\n1000 drewna";
            // 
            // timerOknaMury
            // 
            this.timerOknaMury.Enabled = true;
            this.timerOknaMury.Tick += new System.EventHandler(this.timerOknaMury_Tick);
            // 
            // buttonUlepsz
            // 
            this.buttonUlepsz.Enabled = false;
            this.buttonUlepsz.Location = new System.Drawing.Point(98, 360);
            this.buttonUlepsz.Name = "buttonUlepsz";
            this.buttonUlepsz.Size = new System.Drawing.Size(246, 60);
            this.buttonUlepsz.TabIndex = 3;
            this.buttonUlepsz.Text = "Ulepsz";
            this.buttonUlepsz.UseVisualStyleBackColor = true;
            this.buttonUlepsz.Click += new System.EventHandler(this.buttonUlepsz_Click);
            // 
            // FormMury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 498);
            this.Controls.Add(this.buttonUlepsz);
            this.Controls.Add(this.labelKosztMurow);
            this.Controls.Add(this.labelPoziomMurow);
            this.Controls.Add(this.pictureBoxMur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMury";
            this.Text = "Mury";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMury_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Przechowuje obrazy reprezentujące wszystkie możliwe mury występujące w grze
        /// </summary>
        private System.Windows.Forms.PictureBox pictureBoxMur;
        /// <summary>
        /// Informuje o poziomie muru
        /// </summary>
        private System.Windows.Forms.Label labelPoziomMurow;
        /// <summary>
        /// Informuje o koszcie muru
        /// </summary>
        private System.Windows.Forms.Label labelKosztMurow;
        /// <summary>
        /// Dedykowany timer dla okna formMury. Tik, co 0,1s.
        /// </summary>
        private System.Windows.Forms.Timer timerOknaMury;
        /// <summary>
        /// Przycisk okna formMury
        /// </summary>
        private System.Windows.Forms.Button buttonUlepsz;
    }
}
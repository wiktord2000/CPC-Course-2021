
namespace WiktorDanielewskiLab1PracDom
{
    partial class FormWojsko
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Calavery Archer", "CavalryArcher");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Crossbowman", "Crossbowman");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Knight", "Knight");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Long Swordsman", "LongSwordsman");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Pikeman", "Pikeman");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Mangonel", "Mangonel");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWojsko));
            this.listViewWojownicy = new System.Windows.Forms.ListView();
            this.imageListWojownicy = new System.Windows.Forms.ImageList(this.components);
            this.labelPosiadani = new System.Windows.Forms.Label();
            this.labelKoszt = new System.Windows.Forms.Label();
            this.buttonKup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewWojownicy
            // 
            this.listViewWojownicy.HideSelection = false;
            listViewItem6.StateImageIndex = 0;
            this.listViewWojownicy.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listViewWojownicy.LargeImageList = this.imageListWojownicy;
            this.listViewWojownicy.Location = new System.Drawing.Point(43, 25);
            this.listViewWojownicy.MultiSelect = false;
            this.listViewWojownicy.Name = "listViewWojownicy";
            this.listViewWojownicy.Size = new System.Drawing.Size(524, 375);
            this.listViewWojownicy.TabIndex = 0;
            this.listViewWojownicy.UseCompatibleStateImageBehavior = false;
            this.listViewWojownicy.SelectedIndexChanged += new System.EventHandler(this.listViewWojownicy_SelectedIndexChanged);
            // 
            // imageListWojownicy
            // 
            this.imageListWojownicy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListWojownicy.ImageStream")));
            this.imageListWojownicy.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListWojownicy.Images.SetKeyName(0, "CavalryArcher");
            this.imageListWojownicy.Images.SetKeyName(1, "Crossbowman");
            this.imageListWojownicy.Images.SetKeyName(2, "Knight");
            this.imageListWojownicy.Images.SetKeyName(3, "LongSwordsman");
            this.imageListWojownicy.Images.SetKeyName(4, "Pikeman");
            this.imageListWojownicy.Images.SetKeyName(5, "Mangonel");
            // 
            // labelPosiadani
            // 
            this.labelPosiadani.AutoSize = true;
            this.labelPosiadani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPosiadani.Location = new System.Drawing.Point(637, 59);
            this.labelPosiadani.Name = "labelPosiadani";
            this.labelPosiadani.Size = new System.Drawing.Size(120, 25);
            this.labelPosiadani.TabIndex = 1;
            this.labelPosiadani.Text = "Posiadani: ";
            // 
            // labelKoszt
            // 
            this.labelKoszt.AutoSize = true;
            this.labelKoszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKoszt.Location = new System.Drawing.Point(637, 99);
            this.labelKoszt.Name = "labelKoszt";
            this.labelKoszt.Size = new System.Drawing.Size(68, 25);
            this.labelKoszt.TabIndex = 2;
            this.labelKoszt.Text = "Koszt:";
            // 
            // buttonKup
            // 
            this.buttonKup.Location = new System.Drawing.Point(642, 281);
            this.buttonKup.Name = "buttonKup";
            this.buttonKup.Size = new System.Drawing.Size(230, 63);
            this.buttonKup.TabIndex = 3;
            this.buttonKup.Text = "Kup";
            this.buttonKup.UseVisualStyleBackColor = true;
            this.buttonKup.Click += new System.EventHandler(this.buttonKup_Click);
            // 
            // FormWojsko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 445);
            this.Controls.Add(this.buttonKup);
            this.Controls.Add(this.labelKoszt);
            this.Controls.Add(this.labelPosiadani);
            this.Controls.Add(this.listViewWojownicy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormWojsko";
            this.Text = "Wojsko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWojsko_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// Wyświetla możliwych do kupienia wojowników
        /// </summary>
        private System.Windows.Forms.ListView listViewWojownicy;
        /// <summary>
        /// Zawiera listę obrazów przedstawiających możliwych do kupienia wojowników
        /// </summary>
        private System.Windows.Forms.ImageList imageListWojownicy;
        /// <summary>
        /// Wyświetla aktualną liczbę wojowników danego typu
        /// </summary>
        private System.Windows.Forms.Label labelPosiadani;
        /// <summary>
        /// Wyświetla koszt wybranego wojownika
        /// </summary>
        private System.Windows.Forms.Label labelKoszt;
        /// <summary>
        /// Umożliwia zakup wybranego wojownika
        /// </summary>
        private System.Windows.Forms.Button buttonKup;
    }
}
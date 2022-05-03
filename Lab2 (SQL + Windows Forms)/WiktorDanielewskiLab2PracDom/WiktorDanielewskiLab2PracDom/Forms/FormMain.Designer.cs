
namespace WiktorDanielewskiLab2PracDom
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
            this.dataGridViewShoes = new System.Windows.Forms.DataGridView();
            this.labelShoes = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelProducentName = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxProducentName = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.textBoxAvailability = new System.Windows.Forms.TextBox();
            this.buttonUsunButy = new System.Windows.Forms.Button();
            this.buttonEdytujButy = new System.Windows.Forms.Button();
            this.buttonWyczyscPola = new System.Windows.Forms.Button();
            this.buttonDodajButy = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxMale = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShoes
            // 
            this.dataGridViewShoes.AllowUserToAddRows = false;
            this.dataGridViewShoes.AllowUserToOrderColumns = true;
            this.dataGridViewShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShoes.Location = new System.Drawing.Point(93, 66);
            this.dataGridViewShoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewShoes.Name = "dataGridViewShoes";
            this.dataGridViewShoes.ReadOnly = true;
            this.dataGridViewShoes.RowHeadersWidth = 51;
            this.dataGridViewShoes.RowTemplate.Height = 24;
            this.dataGridViewShoes.Size = new System.Drawing.Size(1031, 206);
            this.dataGridViewShoes.TabIndex = 0;
            this.dataGridViewShoes.SelectionChanged += new System.EventHandler(this.dataGridViewShoes_SelectionChanged);
            // 
            // labelShoes
            // 
            this.labelShoes.AutoSize = true;
            this.labelShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShoes.Location = new System.Drawing.Point(88, 28);
            this.labelShoes.Name = "labelShoes";
            this.labelShoes.Size = new System.Drawing.Size(75, 25);
            this.labelShoes.TabIndex = 1;
            this.labelShoes.Text = "Shoes:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(99, 302);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 17);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID:";
            // 
            // labelProducentName
            // 
            this.labelProducentName.AutoSize = true;
            this.labelProducentName.Location = new System.Drawing.Point(99, 330);
            this.labelProducentName.Name = "labelProducentName";
            this.labelProducentName.Size = new System.Drawing.Size(116, 17);
            this.labelProducentName.TabIndex = 3;
            this.labelProducentName.Text = "Producent name:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(99, 358);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(50, 17);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Model:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(99, 386);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(39, 17);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Size:";
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Location = new System.Drawing.Point(99, 415);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(42, 17);
            this.labelMale.TabIndex = 6;
            this.labelMale.Text = "Male:";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Location = new System.Drawing.Point(99, 443);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(78, 17);
            this.labelAvailability.TabIndex = 7;
            this.labelAvailability.Text = "Availability:";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(240, 299);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(201, 22);
            this.textBoxID.TabIndex = 8;
            // 
            // textBoxProducentName
            // 
            this.textBoxProducentName.Location = new System.Drawing.Point(240, 327);
            this.textBoxProducentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProducentName.Name = "textBoxProducentName";
            this.textBoxProducentName.Size = new System.Drawing.Size(201, 22);
            this.textBoxProducentName.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(240, 356);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(201, 22);
            this.textBoxModel.TabIndex = 10;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(240, 383);
            this.textBoxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(201, 22);
            this.textBoxSize.TabIndex = 11;
            // 
            // textBoxAvailability
            // 
            this.textBoxAvailability.Location = new System.Drawing.Point(240, 439);
            this.textBoxAvailability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAvailability.Name = "textBoxAvailability";
            this.textBoxAvailability.Size = new System.Drawing.Size(201, 22);
            this.textBoxAvailability.TabIndex = 13;
            // 
            // buttonUsunButy
            // 
            this.buttonUsunButy.Location = new System.Drawing.Point(507, 309);
            this.buttonUsunButy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsunButy.Name = "buttonUsunButy";
            this.buttonUsunButy.Size = new System.Drawing.Size(169, 30);
            this.buttonUsunButy.TabIndex = 14;
            this.buttonUsunButy.Text = "Usuń buty";
            this.buttonUsunButy.UseVisualStyleBackColor = true;
            this.buttonUsunButy.Click += new System.EventHandler(this.buttonUsunButy_Click);
            // 
            // buttonEdytujButy
            // 
            this.buttonEdytujButy.Location = new System.Drawing.Point(507, 345);
            this.buttonEdytujButy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdytujButy.Name = "buttonEdytujButy";
            this.buttonEdytujButy.Size = new System.Drawing.Size(169, 30);
            this.buttonEdytujButy.TabIndex = 15;
            this.buttonEdytujButy.Text = "Edytuj buty";
            this.buttonEdytujButy.UseVisualStyleBackColor = true;
            this.buttonEdytujButy.Click += new System.EventHandler(this.buttonEdytujButy_Click);
            // 
            // buttonWyczyscPola
            // 
            this.buttonWyczyscPola.Location = new System.Drawing.Point(507, 379);
            this.buttonWyczyscPola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWyczyscPola.Name = "buttonWyczyscPola";
            this.buttonWyczyscPola.Size = new System.Drawing.Size(169, 30);
            this.buttonWyczyscPola.TabIndex = 16;
            this.buttonWyczyscPola.Text = "Wyczyść pola";
            this.buttonWyczyscPola.UseVisualStyleBackColor = true;
            this.buttonWyczyscPola.Click += new System.EventHandler(this.buttonWyczyscPola_Click);
            // 
            // buttonDodajButy
            // 
            this.buttonDodajButy.Location = new System.Drawing.Point(507, 414);
            this.buttonDodajButy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajButy.Name = "buttonDodajButy";
            this.buttonDodajButy.Size = new System.Drawing.Size(169, 30);
            this.buttonDodajButy.TabIndex = 17;
            this.buttonDodajButy.Text = "Dodaj buty";
            this.buttonDodajButy.UseVisualStyleBackColor = true;
            this.buttonDodajButy.Click += new System.EventHandler(this.buttonDodajButy_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(99, 471);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 17);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(240, 468);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(201, 22);
            this.textBoxPrice.TabIndex = 19;
            // 
            // comboBoxMale
            // 
            this.comboBoxMale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMale.FormattingEnabled = true;
            this.comboBoxMale.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxMale.Location = new System.Drawing.Point(240, 411);
            this.comboBoxMale.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMale.Name = "comboBoxMale";
            this.comboBoxMale.Size = new System.Drawing.Size(201, 24);
            this.comboBoxMale.TabIndex = 21;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(501, 468);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 25);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Status: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 578);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxMale);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonDodajButy);
            this.Controls.Add(this.buttonWyczyscPola);
            this.Controls.Add(this.buttonEdytujButy);
            this.Controls.Add(this.buttonUsunButy);
            this.Controls.Add(this.textBoxAvailability);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxProducentName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelAvailability);
            this.Controls.Add(this.labelMale);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelProducentName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelShoes);
            this.Controls.Add(this.dataGridViewShoes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Shoe Store";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShoes;
        private System.Windows.Forms.Label labelShoes;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelProducentName;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxProducentName;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.TextBox textBoxAvailability;
        private System.Windows.Forms.Button buttonUsunButy;
        private System.Windows.Forms.Button buttonEdytujButy;
        private System.Windows.Forms.Button buttonWyczyscPola;
        private System.Windows.Forms.Button buttonDodajButy;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxMale;
        private System.Windows.Forms.Label labelStatus;
    }
}


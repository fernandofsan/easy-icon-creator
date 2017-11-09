namespace EasyIconCreator
{
    partial class Form1
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
            this.btBackgroundColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBackgound = new System.Windows.Forms.ColorDialog();
            this.cbImageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lgImagemTamanho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIconPosition = new System.Windows.Forms.ComboBox();
            this.cbIconColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIconSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.trackTextVertical = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackTextHorizontal = new System.Windows.Forms.TrackBar();
            this.checkTextEnabled = new System.Windows.Forms.CheckBox();
            this.cbTextPosition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btTextColor = new System.Windows.Forms.Button();
            this.cbTextAlignment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbIcone = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbIconAlignment = new System.Windows.Forms.ComboBox();
            this.cbIconSize = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trackIconVertical = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.trackIconHorizontal = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.cbIconImage = new ComboxExtended.ImagedComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorText = new System.Windows.Forms.ColorDialog();
            this.folderIconsPath = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTextVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTextHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).BeginInit();
            this.gbIcone.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackIconVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIconHorizontal)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBackgroundColor
            // 
            this.btBackgroundColor.Location = new System.Drawing.Point(203, 39);
            this.btBackgroundColor.Name = "btBackgroundColor";
            this.btBackgroundColor.Size = new System.Drawing.Size(130, 62);
            this.btBackgroundColor.TabIndex = 0;
            this.btBackgroundColor.UseVisualStyleBackColor = true;
            this.btBackgroundColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 427);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbImageSize
            // 
            this.cbImageSize.FormattingEnabled = true;
            this.cbImageSize.Location = new System.Drawing.Point(9, 39);
            this.cbImageSize.Name = "cbImageSize";
            this.cbImageSize.Size = new System.Drawing.Size(166, 21);
            this.cbImageSize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fundo";
            // 
            // lgImagemTamanho
            // 
            this.lgImagemTamanho.AutoSize = true;
            this.lgImagemTamanho.Location = new System.Drawing.Point(6, 23);
            this.lgImagemTamanho.Name = "lgImagemTamanho";
            this.lgImagemTamanho.Size = new System.Drawing.Size(52, 13);
            this.lgImagemTamanho.TabIndex = 7;
            this.lgImagemTamanho.Text = "Tamanho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Icon Image";
            // 
            // cbIconPosition
            // 
            this.cbIconPosition.FormattingEnabled = true;
            this.cbIconPosition.Location = new System.Drawing.Point(185, 127);
            this.cbIconPosition.Name = "cbIconPosition";
            this.cbIconPosition.Size = new System.Drawing.Size(148, 21);
            this.cbIconPosition.TabIndex = 14;
            // 
            // cbIconColor
            // 
            this.cbIconColor.FormattingEnabled = true;
            this.cbIconColor.Items.AddRange(new object[] {
            "White",
            "Black"});
            this.cbIconColor.Location = new System.Drawing.Point(185, 32);
            this.cbIconColor.Name = "cbIconColor";
            this.cbIconColor.Size = new System.Drawing.Size(148, 21);
            this.cbIconColor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Posição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Icon Color";
            // 
            // lblIconSize
            // 
            this.lblIconSize.AutoSize = true;
            this.lblIconSize.Location = new System.Drawing.Point(186, 56);
            this.lblIconSize.Name = "lblIconSize";
            this.lblIconSize.Size = new System.Drawing.Size(51, 13);
            this.lblIconSize.TabIndex = 10;
            this.lblIconSize.Text = "Icon Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(9, 40);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(324, 20);
            this.txtTexto.TabIndex = 18;
            this.txtTexto.Text = "Vendas";
            // 
            // gbText
            // 
            this.gbText.Controls.Add(this.label12);
            this.gbText.Controls.Add(this.trackTextVertical);
            this.gbText.Controls.Add(this.label11);
            this.gbText.Controls.Add(this.trackTextHorizontal);
            this.gbText.Controls.Add(this.checkTextEnabled);
            this.gbText.Controls.Add(this.cbTextPosition);
            this.gbText.Controls.Add(this.label9);
            this.gbText.Controls.Add(this.label8);
            this.gbText.Controls.Add(this.TextSize);
            this.gbText.Controls.Add(this.label2);
            this.gbText.Controls.Add(this.btTextColor);
            this.gbText.Controls.Add(this.cbTextAlignment);
            this.gbText.Controls.Add(this.label7);
            this.gbText.Controls.Add(this.label6);
            this.gbText.Controls.Add(this.txtTexto);
            this.gbText.Location = new System.Drawing.Point(600, 12);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(482, 170);
            this.gbText.TabIndex = 19;
            this.gbText.TabStop = false;
            this.gbText.Text = "Conteúdo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(362, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Margem Vertical";
            // 
            // trackTextVertical
            // 
            this.trackTextVertical.Location = new System.Drawing.Point(356, 89);
            this.trackTextVertical.Name = "trackTextVertical";
            this.trackTextVertical.Size = new System.Drawing.Size(104, 45);
            this.trackTextVertical.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Margem Horizontal";
            // 
            // trackTextHorizontal
            // 
            this.trackTextHorizontal.Location = new System.Drawing.Point(353, 39);
            this.trackTextHorizontal.Name = "trackTextHorizontal";
            this.trackTextHorizontal.Size = new System.Drawing.Size(104, 45);
            this.trackTextHorizontal.TabIndex = 23;
            // 
            // checkTextEnabled
            // 
            this.checkTextEnabled.AutoSize = true;
            this.checkTextEnabled.Checked = true;
            this.checkTextEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTextEnabled.Location = new System.Drawing.Point(242, 137);
            this.checkTextEnabled.Name = "checkTextEnabled";
            this.checkTextEnabled.Size = new System.Drawing.Size(51, 17);
            this.checkTextEnabled.TabIndex = 27;
            this.checkTextEnabled.Text = "Exibir";
            this.checkTextEnabled.UseVisualStyleBackColor = true;
            // 
            // cbTextPosition
            // 
            this.cbTextPosition.FormattingEnabled = true;
            this.cbTextPosition.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.cbTextPosition.Location = new System.Drawing.Point(185, 90);
            this.cbTextPosition.Name = "cbTextPosition";
            this.cbTextPosition.Size = new System.Drawing.Size(148, 21);
            this.cbTextPosition.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Posição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tamanho";
            // 
            // TextSize
            // 
            this.TextSize.Location = new System.Drawing.Point(9, 136);
            this.TextSize.Name = "TextSize";
            this.TextSize.Size = new System.Drawing.Size(166, 20);
            this.TextSize.TabIndex = 23;
            this.TextSize.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cor";
            // 
            // btTextColor
            // 
            this.btTextColor.Location = new System.Drawing.Point(189, 136);
            this.btTextColor.Name = "btTextColor";
            this.btTextColor.Size = new System.Drawing.Size(34, 21);
            this.btTextColor.TabIndex = 21;
            this.btTextColor.UseVisualStyleBackColor = true;
            this.btTextColor.Click += new System.EventHandler(this.btTextColor_Click);
            // 
            // cbTextAlignment
            // 
            this.cbTextAlignment.FormattingEnabled = true;
            this.cbTextAlignment.Location = new System.Drawing.Point(9, 90);
            this.cbTextAlignment.Name = "cbTextAlignment";
            this.cbTextAlignment.Size = new System.Drawing.Size(166, 21);
            this.cbTextAlignment.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Alinhamento";
            // 
            // gbIcone
            // 
            this.gbIcone.Controls.Add(this.lgImagemTamanho);
            this.gbIcone.Controls.Add(this.cbImageSize);
            this.gbIcone.Controls.Add(this.label1);
            this.gbIcone.Controls.Add(this.btBackgroundColor);
            this.gbIcone.Location = new System.Drawing.Point(600, 188);
            this.gbIcone.Name = "gbIcone";
            this.gbIcone.Size = new System.Drawing.Size(482, 130);
            this.gbIcone.TabIndex = 20;
            this.gbIcone.TabStop = false;
            this.gbIcone.Text = "Imagem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbIconAlignment);
            this.groupBox1.Controls.Add(this.cbIconSize);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.trackIconVertical);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.trackIconHorizontal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbIconPosition);
            this.groupBox1.Controls.Add(this.cbIconImage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbIconColor);
            this.groupBox1.Controls.Add(this.lblIconSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(600, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 167);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ícone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Change Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbIconAlignment
            // 
            this.cbIconAlignment.FormattingEnabled = true;
            this.cbIconAlignment.Location = new System.Drawing.Point(9, 127);
            this.cbIconAlignment.Name = "cbIconAlignment";
            this.cbIconAlignment.Size = new System.Drawing.Size(166, 21);
            this.cbIconAlignment.TabIndex = 23;
            // 
            // cbIconSize
            // 
            this.cbIconSize.FormattingEnabled = true;
            this.cbIconSize.Location = new System.Drawing.Point(185, 72);
            this.cbIconSize.Name = "cbIconSize";
            this.cbIconSize.Size = new System.Drawing.Size(148, 21);
            this.cbIconSize.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Margem Vertical";
            // 
            // trackIconVertical
            // 
            this.trackIconVertical.Location = new System.Drawing.Point(362, 82);
            this.trackIconVertical.Name = "trackIconVertical";
            this.trackIconVertical.Size = new System.Drawing.Size(104, 45);
            this.trackIconVertical.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Margem Horizontal";
            // 
            // trackIconHorizontal
            // 
            this.trackIconHorizontal.Location = new System.Drawing.Point(359, 32);
            this.trackIconHorizontal.Name = "trackIconHorizontal";
            this.trackIconHorizontal.Size = new System.Drawing.Size(104, 45);
            this.trackIconHorizontal.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Alinhamento";
            // 
            // cbIconImage
            // 
            this.cbIconImage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbIconImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIconImage.FormattingEnabled = true;
            this.cbIconImage.ItemHeight = 60;
            this.cbIconImage.Location = new System.Drawing.Point(6, 42);
            this.cbIconImage.Name = "cbIconImage";
            this.cbIconImage.Size = new System.Drawing.Size(166, 66);
            this.cbIconImage.TabIndex = 16;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(660, 507);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(345, 48);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 431);
            this.panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "asdf",
            "asdfasdfa",
            "fasdfasdfasdfqer"});
            this.listBox1.Location = new System.Drawing.Point(1088, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 394);
            this.listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 587);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIcone);
            this.Controls.Add(this.gbText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbText.ResumeLayout(false);
            this.gbText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackTextVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTextHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSize)).EndInit();
            this.gbIcone.ResumeLayout(false);
            this.gbIcone.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackIconVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackIconHorizontal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBackgroundColor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorBackgound;
        private System.Windows.Forms.ComboBox cbImageSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lgImagemTamanho;
        private System.Windows.Forms.ComboBox cbIconPosition;
        private System.Windows.Forms.ComboBox cbIconColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIconSize;
        private System.Windows.Forms.Label label3;
        private ComboxExtended.ImagedComboBox cbIconImage;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.ComboBox cbTextAlignment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbIcone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTextColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown TextSize;
        private System.Windows.Forms.ColorDialog colorText;
        private System.Windows.Forms.ComboBox cbTextPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkTextEnabled;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackTextVertical;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackTextHorizontal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackIconVertical;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackIconHorizontal;
        private System.Windows.Forms.ComboBox cbIconSize;
        private System.Windows.Forms.ComboBox cbIconAlignment;
        private System.Windows.Forms.FolderBrowserDialog folderIconsPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


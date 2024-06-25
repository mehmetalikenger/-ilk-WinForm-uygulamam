namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedBitis = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.maskedTekCarpim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTekToplam = new System.Windows.Forms.MaskedTextBox();
            this.listViewTekSayilar = new System.Windows.Forms.ListView();
            this.columnTekSayilar = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.maskedCiftCarpim = new System.Windows.Forms.MaskedTextBox();
            this.listViewCiftSayilar = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.maskedCiftToplam = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabAsalSayilar = new System.Windows.Forms.TabPage();
            this.maskedAsalCarpim = new System.Windows.Forms.MaskedTextBox();
            this.listViewAsalSayilar = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.maskedAsalToplam = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabMukemmelSayilar = new System.Windows.Forms.TabPage();
            this.maskedMukemmelCarpim = new System.Windows.Forms.MaskedTextBox();
            this.listViewMukemmelSayilar = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedMukemmelToplam = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsalSayilar.SuspendLayout();
            this.tabMukemmelSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedBitis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedBaslangic);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(38, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(456, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çalıştır";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedBitis
            // 
            this.maskedBitis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedBitis.Location = new System.Drawing.Point(331, 52);
            this.maskedBitis.Name = "maskedBitis";
            this.maskedBitis.Size = new System.Drawing.Size(98, 22);
            this.maskedBitis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(255, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Değeri:";
            // 
            // maskedBaslangic
            // 
            this.maskedBaslangic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedBaslangic.Location = new System.Drawing.Point(126, 52);
            this.maskedBaslangic.Name = "maskedBaslangic";
            this.maskedBaslangic.Size = new System.Drawing.Size(98, 22);
            this.maskedBaslangic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Değeri:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTekSayilar);
            this.tabControl1.Controls.Add(this.tabCiftSayilar);
            this.tabControl1.Controls.Add(this.tabAsalSayilar);
            this.tabControl1.Controls.Add(this.tabMukemmelSayilar);
            this.tabControl1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 19);
            this.tabControl1.Location = new System.Drawing.Point(38, 196);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 335);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTekSayilar.Controls.Add(this.maskedTekCarpim);
            this.tabTekSayilar.Controls.Add(this.maskedTekToplam);
            this.tabTekSayilar.Controls.Add(this.listViewTekSayilar);
            this.tabTekSayilar.Controls.Add(this.label4);
            this.tabTekSayilar.Controls.Add(this.label3);
            this.tabTekSayilar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 23);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(562, 308);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayılar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // maskedTekCarpim
            // 
            this.maskedTekCarpim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTekCarpim.Enabled = false;
            this.maskedTekCarpim.Location = new System.Drawing.Point(73, 66);
            this.maskedTekCarpim.Name = "maskedTekCarpim";
            this.maskedTekCarpim.Size = new System.Drawing.Size(146, 22);
            this.maskedTekCarpim.TabIndex = 7;
            this.maskedTekCarpim.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTekCarpim_MaskInputRejected);
            // 
            // maskedTekToplam
            // 
            this.maskedTekToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTekToplam.Enabled = false;
            this.maskedTekToplam.Location = new System.Drawing.Point(74, 25);
            this.maskedTekToplam.Name = "maskedTekToplam";
            this.maskedTekToplam.Size = new System.Drawing.Size(145, 22);
            this.maskedTekToplam.TabIndex = 6;
            this.maskedTekToplam.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTekToplam_MaskInputRejected);
            // 
            // listViewTekSayilar
            // 
            this.listViewTekSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTekSayilar});
            this.listViewTekSayilar.Location = new System.Drawing.Point(269, 6);
            this.listViewTekSayilar.Name = "listViewTekSayilar";
            this.listViewTekSayilar.Size = new System.Drawing.Size(284, 294);
            this.listViewTekSayilar.TabIndex = 5;
            this.listViewTekSayilar.UseCompatibleStateImageBehavior = false;
            this.listViewTekSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnTekSayilar
            // 
            this.columnTekSayilar.Text = "Sayılar";
            this.columnTekSayilar.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Çarpım:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam:";
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCiftSayilar.Controls.Add(this.maskedCiftCarpim);
            this.tabCiftSayilar.Controls.Add(this.listViewCiftSayilar);
            this.tabCiftSayilar.Controls.Add(this.maskedCiftToplam);
            this.tabCiftSayilar.Controls.Add(this.label7);
            this.tabCiftSayilar.Controls.Add(this.label8);
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 23);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(562, 308);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Çift Sayılar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // maskedCiftCarpim
            // 
            this.maskedCiftCarpim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedCiftCarpim.Enabled = false;
            this.maskedCiftCarpim.Location = new System.Drawing.Point(74, 68);
            this.maskedCiftCarpim.Name = "maskedCiftCarpim";
            this.maskedCiftCarpim.Size = new System.Drawing.Size(146, 22);
            this.maskedCiftCarpim.TabIndex = 16;
            // 
            // listViewCiftSayilar
            // 
            this.listViewCiftSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewCiftSayilar.Location = new System.Drawing.Point(272, 8);
            this.listViewCiftSayilar.Name = "listViewCiftSayilar";
            this.listViewCiftSayilar.Size = new System.Drawing.Size(284, 294);
            this.listViewCiftSayilar.TabIndex = 13;
            this.listViewCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.listViewCiftSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sayılar";
            this.columnHeader2.Width = 100;
            // 
            // maskedCiftToplam
            // 
            this.maskedCiftToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedCiftToplam.Enabled = false;
            this.maskedCiftToplam.Location = new System.Drawing.Point(75, 27);
            this.maskedCiftToplam.Name = "maskedCiftToplam";
            this.maskedCiftToplam.Size = new System.Drawing.Size(145, 22);
            this.maskedCiftToplam.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Çarpım:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Toplam:";
            // 
            // tabAsalSayilar
            // 
            this.tabAsalSayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAsalSayilar.Controls.Add(this.maskedAsalCarpim);
            this.tabAsalSayilar.Controls.Add(this.listViewAsalSayilar);
            this.tabAsalSayilar.Controls.Add(this.maskedAsalToplam);
            this.tabAsalSayilar.Controls.Add(this.label9);
            this.tabAsalSayilar.Controls.Add(this.label10);
            this.tabAsalSayilar.Location = new System.Drawing.Point(4, 23);
            this.tabAsalSayilar.Name = "tabAsalSayilar";
            this.tabAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayilar.Size = new System.Drawing.Size(562, 308);
            this.tabAsalSayilar.TabIndex = 2;
            this.tabAsalSayilar.Text = "Asal Sayılar";
            this.tabAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // maskedAsalCarpim
            // 
            this.maskedAsalCarpim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedAsalCarpim.Enabled = false;
            this.maskedAsalCarpim.Location = new System.Drawing.Point(74, 69);
            this.maskedAsalCarpim.Name = "maskedAsalCarpim";
            this.maskedAsalCarpim.Size = new System.Drawing.Size(146, 22);
            this.maskedAsalCarpim.TabIndex = 16;
            // 
            // listViewAsalSayilar
            // 
            this.listViewAsalSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewAsalSayilar.Location = new System.Drawing.Point(272, 8);
            this.listViewAsalSayilar.Name = "listViewAsalSayilar";
            this.listViewAsalSayilar.Size = new System.Drawing.Size(284, 294);
            this.listViewAsalSayilar.TabIndex = 10;
            this.listViewAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.listViewAsalSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sayılar";
            this.columnHeader1.Width = 100;
            // 
            // maskedAsalToplam
            // 
            this.maskedAsalToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedAsalToplam.Enabled = false;
            this.maskedAsalToplam.Location = new System.Drawing.Point(75, 28);
            this.maskedAsalToplam.Name = "maskedAsalToplam";
            this.maskedAsalToplam.Size = new System.Drawing.Size(145, 22);
            this.maskedAsalToplam.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "Çarpım:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Toplam:";
            // 
            // tabMukemmelSayilar
            // 
            this.tabMukemmelSayilar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMukemmelSayilar.Controls.Add(this.maskedMukemmelCarpim);
            this.tabMukemmelSayilar.Controls.Add(this.listViewMukemmelSayilar);
            this.tabMukemmelSayilar.Controls.Add(this.label6);
            this.tabMukemmelSayilar.Controls.Add(this.maskedMukemmelToplam);
            this.tabMukemmelSayilar.Controls.Add(this.label5);
            this.tabMukemmelSayilar.Location = new System.Drawing.Point(4, 23);
            this.tabMukemmelSayilar.Name = "tabMukemmelSayilar";
            this.tabMukemmelSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMukemmelSayilar.Size = new System.Drawing.Size(562, 308);
            this.tabMukemmelSayilar.TabIndex = 3;
            this.tabMukemmelSayilar.Text = "Mükemmel Sayılar";
            this.tabMukemmelSayilar.UseVisualStyleBackColor = true;
            // 
            // maskedMukemmelCarpim
            // 
            this.maskedMukemmelCarpim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedMukemmelCarpim.Enabled = false;
            this.maskedMukemmelCarpim.Location = new System.Drawing.Point(72, 69);
            this.maskedMukemmelCarpim.Name = "maskedMukemmelCarpim";
            this.maskedMukemmelCarpim.Size = new System.Drawing.Size(148, 22);
            this.maskedMukemmelCarpim.TabIndex = 12;
            // 
            // listViewMukemmelSayilar
            // 
            this.listViewMukemmelSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewMukemmelSayilar.Location = new System.Drawing.Point(272, 6);
            this.listViewMukemmelSayilar.Name = "listViewMukemmelSayilar";
            this.listViewMukemmelSayilar.Size = new System.Drawing.Size(284, 294);
            this.listViewMukemmelSayilar.TabIndex = 17;
            this.listViewMukemmelSayilar.UseCompatibleStateImageBehavior = false;
            this.listViewMukemmelSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sayılar";
            this.columnHeader3.Width = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Toplam:";
            // 
            // maskedMukemmelToplam
            // 
            this.maskedMukemmelToplam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedMukemmelToplam.Enabled = false;
            this.maskedMukemmelToplam.Location = new System.Drawing.Point(73, 28);
            this.maskedMukemmelToplam.Name = "maskedMukemmelToplam";
            this.maskedMukemmelToplam.Size = new System.Drawing.Size(147, 22);
            this.maskedMukemmelToplam.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Çarpım:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(132, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "━";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(193, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(619, 585);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabTekSayilar.PerformLayout();
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabCiftSayilar.PerformLayout();
            this.tabAsalSayilar.ResumeLayout(false);
            this.tabAsalSayilar.PerformLayout();
            this.tabMukemmelSayilar.ResumeLayout(false);
            this.tabMukemmelSayilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox maskedBaslangic;
        private Label label1;
        private Button button1;
        private MaskedTextBox maskedBitis;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabTekSayilar;
        private TabPage tabAsalSayilar;
        private TabPage tabMukemmelSayilar;
        private NotifyIcon notifyIcon1;
        private Label label4;
        private Label label3;
        private ListView listViewTekSayilar;
        private ColumnHeader columnTekSayilar;
        private MaskedTextBox maskedTekToplam;
        private MaskedTextBox maskedTekCarpim;
        private TabPage tabCiftSayilar;
        private MaskedTextBox maskedCiftCarpim;
        private ListView listViewCiftSayilar;
        private ColumnHeader columnHeader2;
        private MaskedTextBox maskedCiftToplam;
        private Label label7;
        private Label label8;
        private MaskedTextBox maskedAsalCarpim;
        private ListView listViewAsalSayilar;
        private ColumnHeader columnHeader1;
        private MaskedTextBox maskedAsalToplam;
        private Label label9;
        private Label label10;
        private MaskedTextBox maskedMukemmelCarpim;
        private ListView listViewMukemmelSayilar;
        private ColumnHeader columnHeader3;
        private Label label6;
        private MaskedTextBox maskedMukemmelToplam;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}
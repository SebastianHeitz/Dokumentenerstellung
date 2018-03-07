namespace Dokumentenerstellung
{
	partial class MainWindow
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
			this.gbx_recipient = new System.Windows.Forms.GroupBox();
			this.ckbx_company_optional = new System.Windows.Forms.CheckBox();
			this.tbx_cityRecipient = new System.Windows.Forms.TextBox();
			this.tbx_postcode = new System.Windows.Forms.TextBox();
			this.tbx_houseNumber = new System.Windows.Forms.TextBox();
			this.tbx_street = new System.Windows.Forms.TextBox();
			this.tbx_contactPerson = new System.Windows.Forms.TextBox();
			this.tbx_company = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_date = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Lbl_ContactPersonText = new System.Windows.Forms.Label();
			this.Cbox_salutation = new System.Windows.Forms.ComboBox();
			this.Lbl_salutation = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pbx_digitalSignature = new System.Windows.Forms.PictureBox();
			this.chkbx_addSignature = new System.Windows.Forms.CheckBox();
			this.Cbx_signature = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Rtb_mainText = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Tbx_subject = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.Lbl_citySender = new System.Windows.Forms.Label();
			this.Tbx_citySender = new System.Windows.Forms.TextBox();
			this.Btn_generateDocument = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.gbx_recipient.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_digitalSignature)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbx_recipient
			// 
			this.gbx_recipient.Controls.Add(this.ckbx_company_optional);
			this.gbx_recipient.Controls.Add(this.tbx_cityRecipient);
			this.gbx_recipient.Controls.Add(this.tbx_postcode);
			this.gbx_recipient.Controls.Add(this.tbx_houseNumber);
			this.gbx_recipient.Controls.Add(this.tbx_street);
			this.gbx_recipient.Controls.Add(this.tbx_contactPerson);
			this.gbx_recipient.Controls.Add(this.tbx_company);
			this.gbx_recipient.Controls.Add(this.label6);
			this.gbx_recipient.Controls.Add(this.label5);
			this.gbx_recipient.Controls.Add(this.label4);
			this.gbx_recipient.Controls.Add(this.label3);
			this.gbx_recipient.Controls.Add(this.label2);
			this.gbx_recipient.Controls.Add(this.label1);
			this.gbx_recipient.Location = new System.Drawing.Point(12, 12);
			this.gbx_recipient.Name = "gbx_recipient";
			this.gbx_recipient.Size = new System.Drawing.Size(356, 148);
			this.gbx_recipient.TabIndex = 0;
			this.gbx_recipient.TabStop = false;
			this.gbx_recipient.Text = "Empfänger";
			// 
			// ckbx_company_optional
			// 
			this.ckbx_company_optional.AutoSize = true;
			this.ckbx_company_optional.Location = new System.Drawing.Point(270, 18);
			this.ckbx_company_optional.Name = "ckbx_company_optional";
			this.ckbx_company_optional.Size = new System.Drawing.Size(81, 17);
			this.ckbx_company_optional.TabIndex = 12;
			this.ckbx_company_optional.Text = "Keine Firma";
			this.ckbx_company_optional.UseVisualStyleBackColor = true;
			this.ckbx_company_optional.CheckedChanged += new System.EventHandler(this.ckbx_company_optional_CheckedChanged);
			// 
			// tbx_cityRecipient
			// 
			this.tbx_cityRecipient.Location = new System.Drawing.Point(159, 110);
			this.tbx_cityRecipient.Name = "tbx_cityRecipient";
			this.tbx_cityRecipient.Size = new System.Drawing.Size(102, 20);
			this.tbx_cityRecipient.TabIndex = 6;
			// 
			// tbx_postcode
			// 
			this.tbx_postcode.Location = new System.Drawing.Point(58, 110);
			this.tbx_postcode.Name = "tbx_postcode";
			this.tbx_postcode.Size = new System.Drawing.Size(65, 20);
			this.tbx_postcode.TabIndex = 5;
			// 
			// tbx_houseNumber
			// 
			this.tbx_houseNumber.Location = new System.Drawing.Point(217, 78);
			this.tbx_houseNumber.Name = "tbx_houseNumber";
			this.tbx_houseNumber.Size = new System.Drawing.Size(44, 20);
			this.tbx_houseNumber.TabIndex = 4;
			// 
			// tbx_street
			// 
			this.tbx_street.Location = new System.Drawing.Point(58, 78);
			this.tbx_street.Name = "tbx_street";
			this.tbx_street.Size = new System.Drawing.Size(95, 20);
			this.tbx_street.TabIndex = 3;
			// 
			// tbx_contactPerson
			// 
			this.tbx_contactPerson.Location = new System.Drawing.Point(111, 51);
			this.tbx_contactPerson.Name = "tbx_contactPerson";
			this.tbx_contactPerson.Size = new System.Drawing.Size(150, 20);
			this.tbx_contactPerson.TabIndex = 2;
			this.tbx_contactPerson.TextChanged += new System.EventHandler(this.tbx_contactPerson_TextChanged);
			// 
			// tbx_company
			// 
			this.tbx_company.Location = new System.Drawing.Point(111, 16);
			this.tbx_company.Name = "tbx_company";
			this.tbx_company.Size = new System.Drawing.Size(150, 20);
			this.tbx_company.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(129, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ort:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 113);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "PLZ:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(164, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hausnr.:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Straße:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ansprechpartner:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firma:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(617, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// lbl_date
			// 
			this.lbl_date.AutoSize = true;
			this.lbl_date.Location = new System.Drawing.Point(570, 18);
			this.lbl_date.Name = "lbl_date";
			this.lbl_date.Size = new System.Drawing.Size(41, 13);
			this.lbl_date.TabIndex = 2;
			this.lbl_date.Text = "Datum:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Lbl_ContactPersonText);
			this.groupBox1.Controls.Add(this.Cbox_salutation);
			this.groupBox1.Controls.Add(this.Lbl_salutation);
			this.groupBox1.Location = new System.Drawing.Point(3, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(715, 57);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Anrede";
			// 
			// Lbl_ContactPersonText
			// 
			this.Lbl_ContactPersonText.AutoSize = true;
			this.Lbl_ContactPersonText.Location = new System.Drawing.Point(218, 26);
			this.Lbl_ContactPersonText.Name = "Lbl_ContactPersonText";
			this.Lbl_ContactPersonText.Size = new System.Drawing.Size(0, 13);
			this.Lbl_ContactPersonText.TabIndex = 2;
			// 
			// Cbox_salutation
			// 
			this.Cbox_salutation.FormattingEnabled = true;
			this.Cbox_salutation.Items.AddRange(new object[] {
            "Frau",
            "Herr",
            "Damen und Herren"});
			this.Cbox_salutation.Location = new System.Drawing.Point(98, 23);
			this.Cbox_salutation.Name = "Cbox_salutation";
			this.Cbox_salutation.Size = new System.Drawing.Size(114, 21);
			this.Cbox_salutation.TabIndex = 9;
			this.Cbox_salutation.SelectedIndexChanged += new System.EventHandler(this.Cbox_salutation_SelectedIndexChanged);
			// 
			// Lbl_salutation
			// 
			this.Lbl_salutation.AutoSize = true;
			this.Lbl_salutation.Location = new System.Drawing.Point(16, 26);
			this.Lbl_salutation.Name = "Lbl_salutation";
			this.Lbl_salutation.Size = new System.Drawing.Size(76, 13);
			this.Lbl_salutation.TabIndex = 0;
			this.Lbl_salutation.Text = "Sehr geehrte/r";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 166);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(732, 468);
			this.tabControl1.TabIndex = 7;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.Tbx_subject);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(724, 442);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Allgemein";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pbx_digitalSignature);
			this.groupBox3.Controls.Add(this.chkbx_addSignature);
			this.groupBox3.Controls.Add(this.Cbx_signature);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(4, 342);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(714, 89);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Grußformel";
			// 
			// pbx_digitalSignature
			// 
			this.pbx_digitalSignature.Image = global::Dokumentenerstellung.Properties.Resources.Unterschrift_Ralf_Risse;
			this.pbx_digitalSignature.Location = new System.Drawing.Point(443, 20);
			this.pbx_digitalSignature.Name = "pbx_digitalSignature";
			this.pbx_digitalSignature.Size = new System.Drawing.Size(100, 50);
			this.pbx_digitalSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_digitalSignature.TabIndex = 3;
			this.pbx_digitalSignature.TabStop = false;
			this.pbx_digitalSignature.Visible = false;
			// 
			// chkbx_addSignature
			// 
			this.chkbx_addSignature.AutoSize = true;
			this.chkbx_addSignature.Location = new System.Drawing.Point(186, 49);
			this.chkbx_addSignature.Name = "chkbx_addSignature";
			this.chkbx_addSignature.Size = new System.Drawing.Size(217, 17);
			this.chkbx_addSignature.TabIndex = 12;
			this.chkbx_addSignature.Text = "digitale Unterschrift hinzufügen (optional)";
			this.chkbx_addSignature.UseVisualStyleBackColor = true;
			this.chkbx_addSignature.CheckedChanged += new System.EventHandler(this.chkbx_addSignature_CheckedChanged);
			// 
			// Cbx_signature
			// 
			this.Cbx_signature.AutoCompleteCustomSource.AddRange(new string[] {
            "Ralf Risse",
            "Ute Heitz"});
			this.Cbx_signature.FormattingEnabled = true;
			this.Cbx_signature.Items.AddRange(new object[] {
            "Ralf Risse",
            "Ute Heitz"});
			this.Cbx_signature.Location = new System.Drawing.Point(6, 47);
			this.Cbx_signature.Name = "Cbx_signature";
			this.Cbx_signature.Size = new System.Drawing.Size(121, 21);
			this.Cbx_signature.TabIndex = 11;
			this.Cbx_signature.Text = "Ralf Risse";
			this.Cbx_signature.SelectedIndexChanged += new System.EventHandler(this.Cbx_signature_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Mit freundlichen Grüßen";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Rtb_mainText);
			this.groupBox2.Location = new System.Drawing.Point(3, 143);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(715, 192);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hauptteil";
			// 
			// Rtb_mainText
			// 
			this.Rtb_mainText.Location = new System.Drawing.Point(6, 19);
			this.Rtb_mainText.Name = "Rtb_mainText";
			this.Rtb_mainText.Size = new System.Drawing.Size(703, 167);
			this.Rtb_mainText.TabIndex = 10;
			this.Rtb_mainText.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Betreffzeile";
			// 
			// Tbx_subject
			// 
			this.Tbx_subject.Location = new System.Drawing.Point(84, 29);
			this.Tbx_subject.MaxLength = 100;
			this.Tbx_subject.Name = "Tbx_subject";
			this.Tbx_subject.Size = new System.Drawing.Size(630, 20);
			this.Tbx_subject.TabIndex = 8;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(724, 442);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Rechnung";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(724, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Pos.";
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 35;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Anzahl";
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Einheit";
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 50;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Bezeichnung";
			this.Column4.Name = "Column4";
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.Width = 300;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "MwSt.";
			this.Column5.Name = "Column5";
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column5.Width = 40;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Einzelpreis";
			this.Column6.Name = "Column6";
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "Gesamtpreis";
			this.Column7.Name = "Column7";
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(724, 442);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Angebot";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(724, 442);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Gehaltsabrechnung";
			// 
			// Lbl_citySender
			// 
			this.Lbl_citySender.AutoSize = true;
			this.Lbl_citySender.Location = new System.Drawing.Point(570, 50);
			this.Lbl_citySender.Name = "Lbl_citySender";
			this.Lbl_citySender.Size = new System.Drawing.Size(24, 13);
			this.Lbl_citySender.TabIndex = 6;
			this.Lbl_citySender.Text = "Ort:";
			// 
			// Tbx_citySender
			// 
			this.Tbx_citySender.Location = new System.Drawing.Point(617, 47);
			this.Tbx_citySender.Name = "Tbx_citySender";
			this.Tbx_citySender.Size = new System.Drawing.Size(113, 20);
			this.Tbx_citySender.TabIndex = 14;
			this.Tbx_citySender.Text = "Gelsenkirchen";
			// 
			// Btn_generateDocument
			// 
			this.Btn_generateDocument.Location = new System.Drawing.Point(508, 120);
			this.Btn_generateDocument.Name = "Btn_generateDocument";
			this.Btn_generateDocument.Size = new System.Drawing.Size(176, 23);
			this.Btn_generateDocument.TabIndex = 14;
			this.Btn_generateDocument.Text = "Dokument erstellen";
			this.Btn_generateDocument.UseVisualStyleBackColor = true;
			this.Btn_generateDocument.Click += new System.EventHandler(this.Btn_generateDocument_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(409, 47);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 47);
			this.button1.TabIndex = 15;
			this.button1.Text = "Haupt-Text\r\nhinzufügen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 641);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Btn_generateDocument);
			this.Controls.Add(this.Tbx_citySender);
			this.Controls.Add(this.Lbl_citySender);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lbl_date);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.gbx_recipient);
			this.Name = "MainWindow";
			this.Text = "Bancarella - Dokumentenerstellung";
			this.gbx_recipient.ResumeLayout(false);
			this.gbx_recipient.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbx_digitalSignature)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbx_recipient;
		private System.Windows.Forms.TextBox tbx_cityRecipient;
		private System.Windows.Forms.TextBox tbx_postcode;
		private System.Windows.Forms.TextBox tbx_houseNumber;
		private System.Windows.Forms.TextBox tbx_street;
		private System.Windows.Forms.TextBox tbx_contactPerson;
		private System.Windows.Forms.TextBox tbx_company;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lbl_date;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label Lbl_salutation;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Tbx_subject;
		private System.Windows.Forms.Label Lbl_citySender;
		private System.Windows.Forms.TextBox Tbx_citySender;
		private System.Windows.Forms.ComboBox Cbox_salutation;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox Rtb_mainText;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pbx_digitalSignature;
		private System.Windows.Forms.CheckBox chkbx_addSignature;
		private System.Windows.Forms.ComboBox Cbx_signature;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Btn_generateDocument;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.CheckBox ckbx_company_optional;
		private System.Windows.Forms.Label Lbl_ContactPersonText;
		private System.Windows.Forms.Button button1;
	}
}


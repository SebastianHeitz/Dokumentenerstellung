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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbx_company = new System.Windows.Forms.TextBox();
			this.tbx_contactPerson = new System.Windows.Forms.TextBox();
			this.tbx_street = new System.Windows.Forms.TextBox();
			this.tbx_houseNumber = new System.Windows.Forms.TextBox();
			this.tbx_postcode = new System.Windows.Forms.TextBox();
			this.tbx_city = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lbl_date = new System.Windows.Forms.Label();
			this.gbx_documentType = new System.Windows.Forms.GroupBox();
			this.rbtn_general = new System.Windows.Forms.RadioButton();
			this.rbtn_invoice = new System.Windows.Forms.RadioButton();
			this.rbtn_offer = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.gbx_recipient.SuspendLayout();
			this.gbx_documentType.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbx_recipient
			// 
			this.gbx_recipient.Controls.Add(this.tbx_city);
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
			this.gbx_recipient.Size = new System.Drawing.Size(294, 179);
			this.gbx_recipient.TabIndex = 0;
			this.gbx_recipient.TabStop = false;
			this.gbx_recipient.Text = "Empfänger";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firma:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ansprechpartner:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Straße:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(166, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hausnr.:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "PLZ:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(131, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ort:";
			// 
			// tbx_company
			// 
			this.tbx_company.Location = new System.Drawing.Point(60, 32);
			this.tbx_company.Name = "tbx_company";
			this.tbx_company.Size = new System.Drawing.Size(100, 20);
			this.tbx_company.TabIndex = 6;
			// 
			// tbx_contactPerson
			// 
			this.tbx_contactPerson.Location = new System.Drawing.Point(113, 63);
			this.tbx_contactPerson.Name = "tbx_contactPerson";
			this.tbx_contactPerson.Size = new System.Drawing.Size(100, 20);
			this.tbx_contactPerson.TabIndex = 7;
			// 
			// tbx_street
			// 
			this.tbx_street.Location = new System.Drawing.Point(60, 90);
			this.tbx_street.Name = "tbx_street";
			this.tbx_street.Size = new System.Drawing.Size(95, 20);
			this.tbx_street.TabIndex = 8;
			// 
			// tbx_houseNumber
			// 
			this.tbx_houseNumber.Location = new System.Drawing.Point(219, 90);
			this.tbx_houseNumber.Name = "tbx_houseNumber";
			this.tbx_houseNumber.Size = new System.Drawing.Size(44, 20);
			this.tbx_houseNumber.TabIndex = 9;
			// 
			// tbx_postcode
			// 
			this.tbx_postcode.Location = new System.Drawing.Point(55, 127);
			this.tbx_postcode.Name = "tbx_postcode";
			this.tbx_postcode.Size = new System.Drawing.Size(44, 20);
			this.tbx_postcode.TabIndex = 10;
			// 
			// tbx_city
			// 
			this.tbx_city.Location = new System.Drawing.Point(161, 127);
			this.tbx_city.Name = "tbx_city";
			this.tbx_city.Size = new System.Drawing.Size(95, 20);
			this.tbx_city.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(617, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker1.TabIndex = 1;
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
			// gbx_documentType
			// 
			this.gbx_documentType.Controls.Add(this.rbtn_offer);
			this.gbx_documentType.Controls.Add(this.rbtn_invoice);
			this.gbx_documentType.Controls.Add(this.rbtn_general);
			this.gbx_documentType.Location = new System.Drawing.Point(365, 59);
			this.gbx_documentType.Name = "gbx_documentType";
			this.gbx_documentType.Size = new System.Drawing.Size(327, 63);
			this.gbx_documentType.TabIndex = 3;
			this.gbx_documentType.TabStop = false;
			this.gbx_documentType.Text = "Dokumentenart";
			// 
			// rbtn_general
			// 
			this.rbtn_general.AutoSize = true;
			this.rbtn_general.Location = new System.Drawing.Point(22, 33);
			this.rbtn_general.Name = "rbtn_general";
			this.rbtn_general.Size = new System.Drawing.Size(70, 17);
			this.rbtn_general.TabIndex = 0;
			this.rbtn_general.TabStop = true;
			this.rbtn_general.Text = "Allgemein";
			this.rbtn_general.UseVisualStyleBackColor = true;
			// 
			// rbtn_invoice
			// 
			this.rbtn_invoice.AutoSize = true;
			this.rbtn_invoice.Location = new System.Drawing.Point(127, 33);
			this.rbtn_invoice.Name = "rbtn_invoice";
			this.rbtn_invoice.Size = new System.Drawing.Size(75, 17);
			this.rbtn_invoice.TabIndex = 1;
			this.rbtn_invoice.TabStop = true;
			this.rbtn_invoice.Text = "Rechnung";
			this.rbtn_invoice.UseVisualStyleBackColor = true;
			// 
			// rbtn_offer
			// 
			this.rbtn_offer.AutoSize = true;
			this.rbtn_offer.Location = new System.Drawing.Point(230, 33);
			this.rbtn_offer.Name = "rbtn_offer";
			this.rbtn_offer.Size = new System.Drawing.Size(65, 17);
			this.rbtn_offer.TabIndex = 2;
			this.rbtn_offer.TabStop = true;
			this.rbtn_offer.Text = "Angebot";
			this.rbtn_offer.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(27, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(75, 366);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(585, 253);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(577, 227);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.checkBox1);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(577, 227);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(308, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(308, 109);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 682);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.gbx_documentType);
			this.Controls.Add(this.lbl_date);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.gbx_recipient);
			this.Name = "MainWindow";
			this.Text = "Bancarella - Dokumentenerstellung";
			this.gbx_recipient.ResumeLayout(false);
			this.gbx_recipient.PerformLayout();
			this.gbx_documentType.ResumeLayout(false);
			this.gbx_documentType.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbx_recipient;
		private System.Windows.Forms.TextBox tbx_city;
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
		private System.Windows.Forms.GroupBox gbx_documentType;
		private System.Windows.Forms.RadioButton rbtn_offer;
		private System.Windows.Forms.RadioButton rbtn_invoice;
		private System.Windows.Forms.RadioButton rbtn_general;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
	}
}


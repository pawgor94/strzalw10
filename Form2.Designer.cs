namespace Giveaway
{
	partial class Generator
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
			this.podglad_pliku = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.plik_generowania = new System.Windows.Forms.TextBox();
			this.generuj_plik = new System.Windows.Forms.Button();
			this.dodaj_istniejaca = new System.Windows.Forms.RadioButton();
			this.dodaj_nowa = new System.Windows.Forms.RadioButton();
			this.nagrody = new System.Windows.Forms.ComboBox();
			this.nowa_nagroda = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.losowo = new System.Windows.Forms.RadioButton();
			this.recznie = new System.Windows.Forms.RadioButton();
			this.nr_pola_wybor = new System.Windows.Forms.NumericUpDown();
			this.dodaj = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.plik_zapisu = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nr_pola_wybor)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// podglad_pliku
			// 
			this.podglad_pliku.Enabled = false;
			this.podglad_pliku.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.podglad_pliku.Location = new System.Drawing.Point(461, 35);
			this.podglad_pliku.Name = "podglad_pliku";
			this.podglad_pliku.Size = new System.Drawing.Size(327, 403);
			this.podglad_pliku.TabIndex = 0;
			this.podglad_pliku.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(464, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Podgląd pliku";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nazwa pliku do zapisu";
			// 
			// plik_generowania
			// 
			this.plik_generowania.Location = new System.Drawing.Point(137, 16);
			this.plik_generowania.Name = "plik_generowania";
			this.plik_generowania.Size = new System.Drawing.Size(124, 23);
			this.plik_generowania.TabIndex = 3;
			// 
			// generuj_plik
			// 
			this.generuj_plik.Location = new System.Drawing.Point(268, 17);
			this.generuj_plik.Name = "generuj_plik";
			this.generuj_plik.Size = new System.Drawing.Size(177, 23);
			this.generuj_plik.TabIndex = 4;
			this.generuj_plik.Text = "Otwórz / Utwórz";
			this.generuj_plik.UseVisualStyleBackColor = true;
			this.generuj_plik.Click += new System.EventHandler(this.generuj_plik_func);
			// 
			// dodaj_istniejaca
			// 
			this.dodaj_istniejaca.AutoSize = true;
			this.dodaj_istniejaca.Enabled = false;
			this.dodaj_istniejaca.Location = new System.Drawing.Point(12, 45);
			this.dodaj_istniejaca.Name = "dodaj_istniejaca";
			this.dodaj_istniejaca.Size = new System.Drawing.Size(108, 19);
			this.dodaj_istniejaca.TabIndex = 5;
			this.dodaj_istniejaca.TabStop = true;
			this.dodaj_istniejaca.Text = "Dodaj istniejącą";
			this.dodaj_istniejaca.UseVisualStyleBackColor = true;
			this.dodaj_istniejaca.Click += new System.EventHandler(this.dodad_istniejaca_CheckedChanged);
			// 
			// dodaj_nowa
			// 
			this.dodaj_nowa.AutoSize = true;
			this.dodaj_nowa.Enabled = false;
			this.dodaj_nowa.Location = new System.Drawing.Point(12, 79);
			this.dodaj_nowa.Name = "dodaj_nowa";
			this.dodaj_nowa.Size = new System.Drawing.Size(88, 19);
			this.dodaj_nowa.TabIndex = 6;
			this.dodaj_nowa.TabStop = true;
			this.dodaj_nowa.Text = "Dodaj nową";
			this.dodaj_nowa.UseVisualStyleBackColor = true;
			this.dodaj_nowa.Click += new System.EventHandler(this.dodaj_nowa_CheckedChanged);
			// 
			// nagrody
			// 
			this.nagrody.Enabled = false;
			this.nagrody.FormattingEnabled = true;
			this.nagrody.Location = new System.Drawing.Point(126, 45);
			this.nagrody.Name = "nagrody";
			this.nagrody.Size = new System.Drawing.Size(121, 23);
			this.nagrody.TabIndex = 7;
			// 
			// nowa_nagroda
			// 
			this.nowa_nagroda.Enabled = false;
			this.nowa_nagroda.Location = new System.Drawing.Point(126, 79);
			this.nowa_nagroda.Name = "nowa_nagroda";
			this.nowa_nagroda.Size = new System.Drawing.Size(121, 23);
			this.nowa_nagroda.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Wybór pola";
			// 
			// losowo
			// 
			this.losowo.AutoSize = true;
			this.losowo.Enabled = false;
			this.losowo.Location = new System.Drawing.Point(11, 16);
			this.losowo.Name = "losowo";
			this.losowo.Size = new System.Drawing.Size(63, 19);
			this.losowo.TabIndex = 10;
			this.losowo.TabStop = true;
			this.losowo.Text = "losowo";
			this.losowo.UseVisualStyleBackColor = true;
			this.losowo.Click += new System.EventHandler(this.losowo_CheckedChanged);
			// 
			// recznie
			// 
			this.recznie.AutoSize = true;
			this.recznie.Enabled = false;
			this.recznie.Location = new System.Drawing.Point(11, 41);
			this.recznie.Name = "recznie";
			this.recznie.Size = new System.Drawing.Size(97, 19);
			this.recznie.TabIndex = 11;
			this.recznie.TabStop = true;
			this.recznie.Text = "wybor_reczny";
			this.recznie.UseVisualStyleBackColor = true;
			this.recznie.Click += new System.EventHandler(this.recznie_CheckedChanged);
			// 
			// nr_pola_wybor
			// 
			this.nr_pola_wybor.Enabled = false;
			this.nr_pola_wybor.Location = new System.Drawing.Point(114, 41);
			this.nr_pola_wybor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nr_pola_wybor.Name = "nr_pola_wybor";
			this.nr_pola_wybor.Size = new System.Drawing.Size(120, 23);
			this.nr_pola_wybor.TabIndex = 12;
			this.nr_pola_wybor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nr_pola_wybor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// dodaj
			// 
			this.dodaj.Enabled = false;
			this.dodaj.Location = new System.Drawing.Point(292, 186);
			this.dodaj.Name = "dodaj";
			this.dodaj.Size = new System.Drawing.Size(153, 23);
			this.dodaj.TabIndex = 13;
			this.dodaj.Text = "Dodaj";
			this.dodaj.UseVisualStyleBackColor = true;
			this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nr_pola_wybor);
			this.groupBox1.Controls.Add(this.recznie);
			this.groupBox1.Controls.Add(this.losowo);
			this.groupBox1.Location = new System.Drawing.Point(3, 133);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(244, 76);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(322, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 15);
			this.label4.TabIndex = 15;
			this.label4.Text = "Plik zapisu:";
			// 
			// plik_zapisu
			// 
			this.plik_zapisu.AutoSize = true;
			this.plik_zapisu.Location = new System.Drawing.Point(322, 68);
			this.plik_zapisu.Name = "plik_zapisu";
			this.plik_zapisu.Size = new System.Drawing.Size(112, 15);
			this.plik_zapisu.TabIndex = 16;
			this.plik_zapisu.Text = "Aktualnie brak pliku";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(312, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "Zapisz plik";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.zapisz_Click);
			// 
			// Generator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.plik_zapisu);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dodaj);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nowa_nagroda);
			this.Controls.Add(this.nagrody);
			this.Controls.Add(this.dodaj_nowa);
			this.Controls.Add(this.dodaj_istniejaca);
			this.Controls.Add(this.generuj_plik);
			this.Controls.Add(this.plik_generowania);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.podglad_pliku);
			this.Name = "Generator";
			this.Text = "Generator";
			((System.ComponentModel.ISupportInitialize)(this.nr_pola_wybor)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RichTextBox podglad_pliku;
		private Label label1;
		private Label label2;
		private TextBox plik_generowania;
		private Button generuj_plik;
		private RadioButton dodaj_istniejaca;
		private RadioButton dodaj_nowa;
		private ComboBox nagrody;
		private TextBox nowa_nagroda;
		private Label label3;
		private RadioButton losowo;
		private RadioButton recznie;
		private NumericUpDown nr_pola_wybor;
		private Button dodaj;
		private GroupBox groupBox1;
		private Label label4;
		private Label plik_zapisu;
		private Button button1;
	}
}
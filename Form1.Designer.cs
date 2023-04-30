namespace Giveaway
{
    partial class Strzal_w_10
    {
        
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                //components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.wczyt = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.opcjezdobycia = new System.Windows.Forms.ComboBox();
			this.Nick_widza = new System.Windows.Forms.TextBox();
			this.przydielstrz = new System.Windows.Forms.Button();
			this.Ile_zostalo_strzalow = new System.Windows.Forms.NumericUpDown();
			this.Follow7 = new System.Windows.Forms.CheckBox();
			this.pozostale_nagrody = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.powiadomienie = new System.Windows.Forms.TextBox();
			this.TierSub = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.opcjeDodatkoweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generujNowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modyfikatorBonusówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.Ile_zostalo_strzalow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TierSub)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();

			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(5, 383);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 100;
			// 
			// wczyt
			// 
			this.wczyt.Location = new System.Drawing.Point(107, 383);
			this.wczyt.Name = "wczyt";
			this.wczyt.Size = new System.Drawing.Size(75, 23);
			this.wczyt.TabIndex = 101;
			this.wczyt.Text = "Wczytaj";
			this.wczyt.UseVisualStyleBackColor = true;
			this.wczyt.Click += new System.EventHandler(this.wczyt_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(192, 388);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 15);
			this.label1.TabIndex = 102;
			this.label1.Text = "Zapisuję w:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(256, 385);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 23);
			this.textBox2.TabIndex = 103;
			// 
			// opcjezdobycia
			// 
			this.opcjezdobycia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.opcjezdobycia.FormattingEnabled = true;
			this.opcjezdobycia.Location = new System.Drawing.Point(111, 412);
			this.opcjezdobycia.Name = "opcjezdobycia";
			this.opcjezdobycia.Size = new System.Drawing.Size(121, 23);
			this.opcjezdobycia.TabIndex = 104;
			// 
			// Nick_widza
			// 
			this.Nick_widza.Location = new System.Drawing.Point(5, 412);
			this.Nick_widza.Name = "Nick_widza";
			this.Nick_widza.Size = new System.Drawing.Size(100, 23);
			this.Nick_widza.TabIndex = 105;
			this.Nick_widza.Text = "nick_widza";
			// 
			// przydielstrz
			// 
			this.przydielstrz.Location = new System.Drawing.Point(237, 412);
			this.przydielstrz.Name = "przydielstrz";
			this.przydielstrz.Size = new System.Drawing.Size(119, 23);
			this.przydielstrz.TabIndex = 106;
			this.przydielstrz.Text = "Przydziel strzały";
			this.przydielstrz.UseVisualStyleBackColor = true;
			this.przydielstrz.Click += new System.EventHandler(this.przydzial_strzalow);
			// 
			// Ile_zostalo_strzalow
			// 
			this.Ile_zostalo_strzalow.Enabled = false;
			this.Ile_zostalo_strzalow.Location = new System.Drawing.Point(300, 438);
			this.Ile_zostalo_strzalow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.Ile_zostalo_strzalow.Name = "Ile_zostalo_strzalow";
			this.Ile_zostalo_strzalow.Size = new System.Drawing.Size(33, 23);
			this.Ile_zostalo_strzalow.TabIndex = 107;
			// 
			// Follow7
			// 
			this.Follow7.AutoSize = true;
			this.Follow7.Location = new System.Drawing.Point(113, 440);
			this.Follow7.Name = "Follow7";
			this.Follow7.Size = new System.Drawing.Size(90, 19);
			this.Follow7.TabIndex = 109;
			this.Follow7.Text = "Follow 7d+?";
			this.Follow7.UseVisualStyleBackColor = true;
			// 
			// pozostale_nagrody
			// 
			this.pozostale_nagrody.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.pozostale_nagrody.FormattingEnabled = true;
			this.pozostale_nagrody.ItemHeight = 15;
			this.pozostale_nagrody.Location = new System.Drawing.Point(361, 42);
			this.pozostale_nagrody.Name = "pozostale_nagrody";
			this.pozostale_nagrody.Size = new System.Drawing.Size(251, 364);
			this.pozostale_nagrody.TabIndex = 111;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(437, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 15);
			this.label2.TabIndex = 112;
			this.label2.Text = "Pozostałe Nagrody";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(206, 441);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 15);
			this.label4.TabIndex = 115;
			this.label4.Text = "Zostało strzałów:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(405, 419);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(159, 15);
			this.label5.TabIndex = 116;
			this.label5.Text = "Nagroda / przydział strzałów:";
			// 
			// powiadomienie
			// 
			this.powiadomienie.Location = new System.Drawing.Point(338, 436);
			this.powiadomienie.Name = "powiadomienie";
			this.powiadomienie.Size = new System.Drawing.Size(274, 23);
			this.powiadomienie.TabIndex = 117;
			// 
			// TierSub
			// 
			this.TierSub.Location = new System.Drawing.Point(54, 438);
			this.TierSub.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.TierSub.Name = "TierSub";
			this.TierSub.Size = new System.Drawing.Size(47, 23);
			this.TierSub.TabIndex = 118;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(4, 441);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 15);
			this.label6.TabIndex = 119;
			this.label6.Text = "Sub Tier";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeDodatkoweToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 120;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// opcjeDodatkoweToolStripMenuItem
			// 
			this.opcjeDodatkoweToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.opcjeDodatkoweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generujNowyToolStripMenuItem,
            this.modyfikatorBonusówToolStripMenuItem});
			this.opcjeDodatkoweToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.opcjeDodatkoweToolStripMenuItem.Name = "opcjeDodatkoweToolStripMenuItem";
			this.opcjeDodatkoweToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
			this.opcjeDodatkoweToolStripMenuItem.Text = "Opcje dodatkowe";
			// 
			// generujNowyToolStripMenuItem
			// 
			this.generujNowyToolStripMenuItem.Name = "generujNowyToolStripMenuItem";
			this.generujNowyToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.generujNowyToolStripMenuItem.Text = "Generator";
			this.generujNowyToolStripMenuItem.Click += new System.EventHandler(this.generujNowyToolStripMenuItem_Click);
			// 
			// modyfikatorBonusówToolStripMenuItem
			// 
			this.modyfikatorBonusówToolStripMenuItem.Name = "modyfikatorBonusówToolStripMenuItem";
			this.modyfikatorBonusówToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			this.modyfikatorBonusówToolStripMenuItem.Text = "Ustawienia Bonusów";
			this.modyfikatorBonusówToolStripMenuItem.Click += new System.EventHandler(this.modyfikatorBonusówToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.infoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "Info";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
			// 
			// Strzal_w_10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 461);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TierSub);
			this.Controls.Add(this.powiadomienie);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pozostale_nagrody);
			this.Controls.Add(this.Follow7);
			this.Controls.Add(this.Ile_zostalo_strzalow);
			this.Controls.Add(this.przydielstrz);
			this.Controls.Add(this.Nick_widza);
			this.Controls.Add(this.opcjezdobycia);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.wczyt);
			this.Controls.Add(this.textBox1);			
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(640, 500);
			this.MinimumSize = new System.Drawing.Size(640, 500);
			this.Name = "Strzal_w_10";
			this.Text = "Strzał w 10";
			((System.ComponentModel.ISupportInitialize)(this.Ile_zostalo_strzalow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TierSub)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion

        private TextBox textBox1;
        private Button wczyt;
        private Label label1;
        private TextBox textBox2;
        private ComboBox opcjezdobycia;
        private TextBox Nick_widza;
        private Button przydielstrz;
        private NumericUpDown Ile_zostalo_strzalow;
        private CheckBox Follow7;
        private ListBox pozostale_nagrody;
        private Label label2;
		private Label label4;
		private Label label5;
		private TextBox powiadomienie;
		private NumericUpDown TierSub;
		private Label label6;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem opcjeDodatkoweToolStripMenuItem;
		private ToolStripMenuItem generujNowyToolStripMenuItem;
		private ToolStripMenuItem infoToolStripMenuItem;
		private ToolStripMenuItem modyfikatorBonusówToolStripMenuItem;
	}
}
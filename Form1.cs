using System;
using System.IO;
using System.Security.Cryptography.Pkcs;

namespace Giveaway
{

    public partial class Strzal_w_10 : Form
    {
        private int ile_nagrod = 0;
        private int ile_dostepnych = 0;


        public Strzal_w_10()
        {
            InitializeComponent();
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.Text != "Wczytaj")
                    button.Enabled = false;
            }
            String path = @"files\settings.pgor";
            if (!File.Exists(path))
            {
                powiadomienie.Text = "BRAK PLIKU Z USTAWIENIAMI!!";
				powiadomienie.BackColor = Color.Red;
				return;
            }
            String line = " ";
            String opcja = " ";
            Boolean koniec_opcji = false;
            using (StreamReader sr = new StreamReader(path))
            { 
            while ((line = sr.ReadLine()) != "START")
                {
                    
                }
            while ((line = sr.ReadLine()) != "KONIEC")
                {
                    opcja = "";
                    koniec_opcji = false;
                    foreach (char c in line)
                    {
                        
                        if (c!='|' && koniec_opcji==false)
                        {
                            opcja += c;
                        }
                        else
                            koniec_opcji=true;
                    }
                    opcjezdobycia.Items.Add(opcja);
                }
            }
            opcjezdobycia.SelectedIndex = 0;
        }

        //MessageBox.Show(wynik.ToString());

        public void strzal(int x)
        {
			powiadomienie.BackColor = Color.White;
			if (Ile_zostalo_strzalow.Value==0)
            {
                powiadomienie.Text = "BRAK STRZA£ÓW";
				powiadomienie.BackColor = Color.Red;
				return;
            }
            //CZY ISTNIEJE WSKAZANY PLIK
            String path = @"files" + '\\' + textBox2.Text + ".pgor";
            if (!File.Exists(path))
            {
                powiadomienie.Text = "BRAK PLIKU!!";
                powiadomienie.BackColor = Color.Red;
                return;
            }
            Ile_zostalo_strzalow.Value--;

            /*
            Przyk³ad zapisu Pliku (minimal):
            .A.B
            C..X
            ..DA
            ..DA
            KONIEC
            A 75 PLN
            B Gra
            C Sub
            D 20 PLN
            */
            //SZUKANIE KTÓRY PRZYCISK WCIŒNIÊTY
            String nazwa = "button" + x;
            String nagroda_full = "";
            char nagroda = ' ';
            String linia_zmiana = "            ";
            foreach (Button but in this.Controls.OfType<Button>())
            {
                if (but.Name == nazwa)
                {
                    but.Enabled = false;
                }
            }
            //ZCZYTANIE NAGRODY Z PLIKU
            using (StreamReader sr = File.OpenText(path))
            {                
                string line = File.ReadLines(path).Skip((x-1) / 10).Take(1).First(); //Skok do w³aœciwej linii pliku
                nagroda = line[(x - 1) % 10];
                if (nagroda == 'X')                                              //Weryfikowanie dostêopnoœci nagrody
                {
                    powiadomienie.Text = "B£¥D, NMAGRODA JU¯ WZIÊTA!";
                    return;
                }
                ile_dostepnych--;
                linia_zmiana = line;
                char[] linia_zmiana2 = linia_zmiana.ToCharArray();
                linia_zmiana2[(x - 1) % 10] = 'X';
                linia_zmiana = "";
                foreach (char c in linia_zmiana2)
                {
                    linia_zmiana += c;                                           //zapis linii w celu póŸniejszej modyfikacji
                }
                while ((line = sr.ReadLine()) != "KONIEC")                      //przejœcie do list nagród w pliku
                {
                }
                //Wyœwietlenie okienka z informacj¹ o nagrodzie lub jej braku
                
                while ((line = sr.ReadLine()) != "KONIEC2")
                {
                    if (line[0] == nagroda)
                    {
                        for (int i = 2; i < line.Length; i++)
                        {
                            nagroda_full += line[i];
                        }
                    }
                }
            }
            //Edycja pliku z zapisem
            string[] stary = File.ReadAllLines(path);
            using (StreamWriter writer = File.CreateText(path))
            {


                for (int currentLine = 1; currentLine <= stary.Length; ++currentLine)
                {
                    if (currentLine == (x-1) / 10 + 1)
                    {
                        writer.WriteLine(linia_zmiana);
                    }
                    else
                    {
                        writer.WriteLine(stary[currentLine - 1]);
                    }
                }
                /**String line = File.ReadLines(path).Skip(x / 10).Take(1);
                sw.WriteLine(linia_zmiana);*/
            }
            //Zapis do log-u
            path = @"files" + '\\' + textBox2.Text + ".log.pgor";
            string nagroda_full_log;
            if (nagroda_full == "") nagroda_full_log = "XXX"; else nagroda_full_log=nagroda_full;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
			wczyt_Click(null, null);
			using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(DateTime.Now.ToString() + "    " + Nick_widza.Text + "    " + nagroda_full_log);
            }
			// wyœwietlenie nagrody
			if (nagroda == '.')
			{
				powiadomienie.Text = "Brak nagrody.";
			}
			else
			{
				ile_nagrod--;
				powiadomienie.Text = nagroda_full.ToString();
				if (nagroda_full.Contains("+1"))
				{
					Ile_zostalo_strzalow.Value++;
				}
			}
		}


        // // // // // // // // // // // // // // // // // // // // //

        private void buttonstrzal_Click(object sender, EventArgs e)
        {
            String s = (sender as Button).Text;
            int i = 0;
            foreach (char c in s)
            {
                i =  i * 10 + ((int)c - 48);
            }
            MessageBox.Show(i.ToString());
			strzal(i);
        }

        // // // // // // // // // // // // // // // // // // // // //
       
        private void wczyt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Button nowy_przycisk = new Button();
                nowy_przycisk.Location = new System.Drawing.Point(5+(i%10)*35, 27+(i/10)*35);
				nowy_przycisk.Name = "button" + i.ToString();
				nowy_przycisk.Size = new System.Drawing.Size(35, 35);
				nowy_przycisk.TabIndex = 0;
				nowy_przycisk.Text = (i+1).ToString();
				nowy_przycisk.UseVisualStyleBackColor = true;
				nowy_przycisk.Click += new System.EventHandler(this.buttonstrzal_Click);
				this.Controls.Add(nowy_przycisk);
			}
			powiadomienie.BackColor = Color.White;
            powiadomienie.Text = "";
            pozostale_nagrody.Items.Clear();
            String path = @"files" + '\\' + textBox1.Text + ".pgor";
            this.ile_nagrod = 0;
            this.ile_dostepnych = 0;
            przydielstrz.Enabled = true;
            if (File.Exists(path))
            {
                foreach (Button b in this.Controls.OfType<Button>())
                {
                    if (b.Name.Contains("button"))
                        b.Enabled = false;
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    string alfabet = "ABCDEFGHIJKLMNOPQRSTUWYZabcdefghijklmnopqrstuwyxz";
                    int[] ile_nagrod_tab = new int[alfabet.Length];
                    for (int ind = 0; ind < ile_nagrod_tab.Length; ind++)
                    {
                        ile_nagrod_tab[ind] = 0;
                    }
                    textBox2.Text = textBox1.Text;
                    textBox2.Enabled = false;
                    int i = 0; //dziesiatki
                    int j = 0; //jednosci
                    int wynik = 0;
                    while ((s = sr.ReadLine()) != "KONIEC")
                    {
                        j = 0;
                        foreach (char c in s)
                        {
                            j++;
                            if (c != 'X')
                            {
								ile_dostepnych++;
								wynik = i * 10 + j;
                                foreach (Button button in this.Controls.OfType<Button>())
                                {
                                    if (button.Text == wynik.ToString())
                                        button.Enabled = true;
                                }
                                for (int temp = 0; temp < alfabet.Length; temp++)
                                {
                                    if (c == alfabet[temp])
                                    {
                                        ile_nagrod_tab[temp]++;
                                        ile_nagrod++;
                                    }
                                }
                            }
                        }
                        i++; //Nastêpna linia 1x, 2x....
                    }
                    while ((s = sr.ReadLine()) != "KONIEC2")
                    {
                        char temp_nagroda = s[0];
                        String final = "";
                        int temp_wsk = 0;
                        int final_wsk = -1;
                        for (; temp_wsk < alfabet.Length; temp_wsk++)
                        {
                            if (temp_nagroda == alfabet[temp_wsk])
                            {
                                final_wsk = temp_wsk;
                            }
                        }
                        if (final_wsk != -1 && ile_nagrod_tab[final_wsk] != 0)
                        {
                            for (int temp_nazwa = 2; temp_nazwa < s.Length; temp_nazwa++)
                            {
                                final += s[temp_nazwa];
                            }
                            //MessageBox.Show(final.ToString() + " " + ((float)(final.Length)/8).ToString());
                            int ile_tab = 3 - (int)((float)(final.Length) / 8);
                            //if ((final.Length) % 8 == 0) ile_tab++;
                            for (; ile_tab > 0; ile_tab--)
                            {
                                final += "\t";
                            }
                            final += ile_nagrod_tab[final_wsk];
                            pozostale_nagrody.Items.Add(final);
                        }
                    }
                }
            }
            else
            {
                powiadomienie.Text = "BRAK PLIKU Z TAK¥ NAZW¥!";
                powiadomienie.BackColor = Color.Red;
                return;
            }
		}

        private void przydzial_strzalow(object sender, EventArgs e)
        {
			powiadomienie.BackColor = Color.White;
            String path_sub = @"files\Sub_Bonus.pgor";
			String[] sub_bonuses = File.ReadAllLines(path_sub);
			
			String path = @"files\settings.pgor";
            String jakaopcja = opcjezdobycia.Text;
            String linia_z_pliku= " ";
            Boolean pierwsza_wartosc = false;
            int wynik = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                while(!(linia_z_pliku=sr.ReadLine()).Contains(jakaopcja))
                {
                }
                foreach (char c in linia_z_pliku)
                {
                    if (c == '|' && pierwsza_wartosc == false)
                    {
                        pierwsza_wartosc = true;
                    }
                    else if (pierwsza_wartosc == true && c != ' ')
                    {
                        wynik = wynik * 10 + ((int)c - 48);
                    }
                }
                if (Follow7.Checked == false) wynik--;
				int bonus = 0;
				if (wynik < 0) wynik = 1;
                switch (TierSub.Value)
                {
                    case 0:
                        break;
                    case 1:
                        if (sub_bonuses[0][0] == '%')
                        {
                            //OBLICZANIE BONUSU PROCENTOWEGO SUB TIER 1
                            wynik = oblicz_bonus_proc(sub_bonuses[1], sub_bonuses[2], wynik);
						}   
                        else if (sub_bonuses[0][0] == '+')
                        {
                            foreach (char c in sub_bonuses[1])
                            {
                                if (c >= 48 && c <= 57)
                                {
                                    bonus = bonus * 10 + ((int)c - 48);
                                }
                            }
							wynik = wynik + bonus;
                        }
                        break;
                    case 2:
						if (sub_bonuses[3][0] == '%')
						{
							//OBLICZANIE BONUSU PROCENTOWEGO SUB TIER 2
							wynik = oblicz_bonus_proc(sub_bonuses[4], sub_bonuses[5], wynik);
						}
						else if (sub_bonuses[3][0] == '+')
						{
							foreach (char c in sub_bonuses[4])
							{
								if (c >= 48 && c <= 57)
								{
									bonus = bonus * 10 + ((int)c - 48);
								}
							}
							wynik = wynik + bonus;
						}
						break;
					case 3:
						if (sub_bonuses[6][0] == '%')
						{
							//OBLICZANIE BONUSU PROCENTOWEGO SUB TIER 3
							wynik = oblicz_bonus_proc(sub_bonuses[7], sub_bonuses[8], wynik);
						}
						else if (sub_bonuses[6][0] == '+')
						{
							foreach (char c in sub_bonuses[1])
							{
								if (c >= 48 && c <= 57)
								{
									bonus = bonus * 10 + ((int)c - 48);
								}
							}
							wynik = wynik + bonus;
						}
						break;
					default:
                        break;

				}
				Ile_zostalo_strzalow.Value = wynik;
                powiadomienie.Text = "Przydzielono " + wynik.ToString() + " strzalow";
            }
        }

        public int oblicz_bonus_proc(String bonus_str, String min, int wynik_s)
        {
			int bonus = 0;
            int bonus_min = 0;
            //SPRAWDZ ILE % BONUS
			foreach (char c in bonus_str)
			{
				if (c >= 48 && c <= 57)
				{
					bonus = bonus * 10 + ((int)c - 48);
				}
			}
            //SPRAWDZ MINIMALNY BONUS
			foreach (char c in min)
			{
				if (c >= 48 && c <= 57)
				{
					bonus_min = bonus_min * 10 + ((int)c - 48);
                }
            }
            //WYLICZANIE MNOZNIKA BONUSU
            float bonus_percent = 1 + (float)bonus / 100;
            //WYLICZANIE MINIMUM
            int wynik_temp = wynik_s + bonus_min;
            // WYLICZANIE PODSTAWA * BONUS
			wynik_s = (int)Math.Round((float)wynik_s * bonus_percent);
            //SPWAWDZ CO WIEKSZE
			if (wynik_temp > wynik_s) wynik_s = wynik_temp;
			return wynik_s;
        }

        private void generujNowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WLACZANIE OKIENKA GENERATORA PLIKÓW 
            Form generator = new Generator();
            generator.ShowDialog();
        }

        private void modyfikatorBonusówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsy = new Settingsy();
            settingsy.ShowDialog();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twórca: \nPawel \"pawgor\" Gorski\nwersja: 1.7.1\n2023-04-30 01:53 UTC");
        }
    }
}
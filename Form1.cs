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

        void szanse()
        {
            Kalkulacje_szans.Items.Clear();
            if ((int)Ile_zostalo_strzalow.Value == 0)
            {
                Kalkulacje_szans.Items.Add("1 \t- " + Math.Round((double)ile_nagrod / ile_dostepnych * 100, 2).ToString() + "%");
            }
            for (int traf = (int)Ile_zostalo_strzalow.Value; traf > 0; traf--)
            {
                if (traf <= ile_nagrod)
                { //int temporary = (int)((float)temp/ile_nagrod * (float)(Ile_zostalo_strzalow.Value/(ile_dostepnych-ile_nagrod))*10000);
                    int chyb = (int)Ile_zostalo_strzalow.Value - traf;
                    int temp_mozl = ile_dostepnych;
                    double wynik_szansa = 100.0;
                    for (int traf2 = traf; traf2 > 0; traf2--)
                    {
                        //MessageBox.Show(wynik_szansa.ToString() + "   traf " + traf2 + " " + traf);
                        wynik_szansa = wynik_szansa * (ile_nagrod - traf2 + 1);
                        wynik_szansa = wynik_szansa / temp_mozl;
                        temp_mozl--;
                    }
                    //MessageBox.Show(wynik_szansa.ToString());
                    Kalkulacje_szans.Items.Add(traf.ToString() + "+ \t- " + (Math.Round(wynik_szansa, 4)).ToString() + "%");
                }
                else
                    Kalkulacje_szans.Items.Add(traf.ToString() + "+ \t- Nagród mniej ni¿ strza³ów");
            }
		}

        // // // // // // // // // // // // // // // // // // // // //

        private void button100_Click(object sender, EventArgs e)
        {
            strzal(100);
        }
        private void button99_Click(object sender, EventArgs e)
        {
            strzal(99);
        }
        private void button98_Click(object sender, EventArgs e)
        {
            strzal(98);
        }
        private void button97_Click(object sender, EventArgs e)
        {
            strzal(97);
        }
        private void button96_Click(object sender, EventArgs e)
        {
            strzal(96);
        }
        private void button95_Click(object sender, EventArgs e)
        {
            strzal(95);
        }
        private void button94_Click(object sender, EventArgs e)
        {
            strzal(94);
        }
        private void button93_Click(object sender, EventArgs e)
        {
            strzal(93);
        }
        private void button92_Click(object sender, EventArgs e)
        {
            strzal(92);
        }
        private void button91_Click(object sender, EventArgs e)
        {
            strzal(91);
        }
        private void button90_Click(object sender, EventArgs e)
        {
            strzal(90);
        }
        private void button89_Click(object sender, EventArgs e)
        {
            strzal(89);
        }
        private void button88_Click(object sender, EventArgs e)
        {
            strzal(88);
        }
        private void button87_Click(object sender, EventArgs e)
        {
            strzal(87);
        }
        private void button86_Click(object sender, EventArgs e)
        {
            strzal(86);
        }
        private void button85_Click(object sender, EventArgs e)
        {
            strzal(85);
        }
        private void button84_Click(object sender, EventArgs e)
        {
            strzal(84);
        }
        private void button83_Click(object sender, EventArgs e)
        {
            strzal(83);
        }
        private void button82_Click(object sender, EventArgs e)
        {
            strzal(82);
        }
        private void button81_Click(object sender, EventArgs e)
        {
            strzal(81);
        }
        private void button80_Click(object sender, EventArgs e)
        {
            strzal(80);
        }
        private void button79_Click(object sender, EventArgs e)
        {
            strzal(79);
        }
        private void button78_Click(object sender, EventArgs e)
        {
            strzal(78);
        }
        private void button77_Click(object sender, EventArgs e)
        {
            strzal(77);
        }
        private void button76_Click(object sender, EventArgs e)
        {
            strzal(76);
        }
        private void button75_Click(object sender, EventArgs e)
        {
            strzal(75);
        }
        private void button74_Click(object sender, EventArgs e)
        {
            strzal(74);
        }
        private void button73_Click(object sender, EventArgs e)
        {
            strzal(73);
        }
        private void button72_Click(object sender, EventArgs e)
        {
            strzal(72);
        }
        private void button71_Click(object sender, EventArgs e)
        {
            strzal(71);
        }
        private void button70_Click(object sender, EventArgs e)
        {
            strzal(70);
        }
        private void button69_Click(object sender, EventArgs e)
        {
            strzal(69);
        }
        private void button68_Click(object sender, EventArgs e)
        {
            strzal(68);
        }
        private void button67_Click(object sender, EventArgs e)
        {
            strzal(67);
        }
        private void button66_Click(object sender, EventArgs e)
        {
            strzal(66);
        }
        private void button65_Click(object sender, EventArgs e)
        {
            strzal(65);
        }
        private void button64_Click(object sender, EventArgs e)
        {
            strzal(64);
        }
        private void button63_Click(object sender, EventArgs e)
        {
            strzal(63);
        }
        private void button62_Click(object sender, EventArgs e)
        {
            strzal(62);
        }
        private void button61_Click(object sender, EventArgs e)
        {
            strzal(61);
        }
        private void button60_Click(object sender, EventArgs e)
        {
            strzal(60);
        }
        private void button59_Click(object sender, EventArgs e)
        {
            strzal(59);
        }
        private void button58_Click(object sender, EventArgs e)
        {
            strzal(58);
        }
        private void button57_Click(object sender, EventArgs e)
        {
            strzal(57);
        }
        private void button56_Click(object sender, EventArgs e)
        {
            strzal(56);
        }
        private void button55_Click(object sender, EventArgs e)
        {
            strzal(55);
        }
        private void button54_Click(object sender, EventArgs e)
        {
            strzal(54);
        }
        private void button53_Click(object sender, EventArgs e)
        {
            strzal(53); 
        }
        private void button52_Click(object sender, EventArgs e)
        {
            strzal(52);
        }
        private void button51_Click(object sender, EventArgs e)
        {
            strzal(51);
        }
        private void button50_Click(object sender, EventArgs e)
        {
            strzal(50);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            strzal(49);
        }
        private void button48_Click(object sender, EventArgs e)
        {
            strzal(48);
        }
        private void button47_Click(object sender, EventArgs e)
        {
            strzal(47);
        }
        private void button46_Click(object sender, EventArgs e)
        {
            strzal(46);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            strzal(45);
        }
        private void button44_Click(object sender, EventArgs e)
        {
            strzal(44);
        }
        private void button43_Click(object sender, EventArgs e)
        {
            strzal(43);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            strzal(42);
        }
        private void button41_Click(object sender, EventArgs e)
        {
            strzal(41);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            strzal(40);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            strzal(39);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            strzal(38);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            strzal(37);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            strzal(36);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            strzal(35);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            strzal(34);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            strzal(33);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            strzal(32);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            strzal(31);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            strzal(30);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            strzal(29);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            strzal(28);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            strzal(27);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            strzal(26);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            strzal(25);
        }
        private void button24_Click(object sender, EventArgs e)
        {
            strzal(24);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            strzal(23);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            strzal(22);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            strzal(21);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            strzal(20);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            strzal(19);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            strzal(18);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            strzal(17);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            strzal(16);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            strzal(15);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            strzal(14);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            strzal(13);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            strzal(12);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            strzal(11);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            strzal(10);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            strzal(9);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            strzal(8);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            strzal(7);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            strzal(6);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            strzal(5);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            strzal(4);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            strzal(3);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            strzal(2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            strzal(1);
        }

        // // // // // // // // // // // // // // // // // // // // //
       
        private void wczyt_Click(object sender, EventArgs e)
        {
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
                    string alfabet = "ABCDEFGHIJKLMNOPQRSTUWYZ";
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
            szanse();
		}

        private void przydzial_strzalow(object sender, EventArgs e)
        {
			powiadomienie.BackColor = Color.White;
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
                if (wynik == 0) wynik = 1;
                switch (TierSub.Value)
                {
                    case 0:
                        break;
                    case 1:
						if ((float)wynik * 0.15 <= 0.5)
							wynik++;
						else
							wynik = (int)Math.Round((float)wynik * 1.15);
                        break;
                    case 2:
						if ((float)wynik * 0.3 <= 0.5)
							wynik++;
						else
							wynik = (int)Math.Round((float)wynik * 1.3);
                        break;
                    case 3:
						if ((float)wynik * 0.5 <= 0.5)
							wynik++;
						else
							wynik = (int)Math.Round((float)wynik * 1.5);
                        break;
                    default:
                        break;

				}
				Ile_zostalo_strzalow.Value = wynik;
                powiadomienie.Text = "Przydzielono " + wynik.ToString() + " strzalow";
            }
            szanse();
        }

        private void generujNowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Twórca: \nPawel \"pawgor\" Gorski\nwersja: 1.6.0a\n2023-01-19");
        }
    }
}
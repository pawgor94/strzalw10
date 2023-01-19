using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.ComponentModel.Design;

namespace Giveaway
{
	public partial class Generator : Form
	{
		public Generator()
		{
			InitializeComponent();
		}

		private void sprawdz_wolne_pole(int x)
		{
			x--;
			String line = podglad_pliku.Lines[x / 10];
			char c = line[x % 10];
			if (c == '.')
			{
				dodaj.Enabled = true;
			}
			else
				dodaj.Enabled = false;
		}

		private void generuj_plik_func(object sender, EventArgs e)
		{
			nagrody.Items.Clear();
			podglad_pliku.Text = "";
			String path = @"files" + '\\' + plik_generowania.Text + ".pgor";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
				podglad_pliku.Text =	"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"..........\n" +
										"KONIEC\n" +
										"A +1 Strzal\n" +
										"KONIEC2";
				using (StreamWriter writer = File.CreateText(path))
				{
					writer.Write(podglad_pliku.Text);
				}
				nagrody.Items.Add("+1 Strzal");
			}
			else
			{
				String[] stary_plik = File.ReadAllLines(path);
				Boolean lista_nagrod = false;
				String nast_nagroda = "";
				for (int i = 0; i < stary_plik.Length; i++)
				{
					podglad_pliku.Text += stary_plik[i].ToString();
					if (i+1 < stary_plik.Length)
					{
						podglad_pliku.Text += '\n';
					}
					if (lista_nagrod == true && stary_plik[i].ToString() != "KONIEC2")
					{
						nast_nagroda = "";
						for (int i2=2; i2< stary_plik[i].ToString().Length; i2++)
						{
							nast_nagroda += stary_plik[i][i2];
						}
						nagrody.Items.Add(nast_nagroda);
					}
					else if (stary_plik[i].ToString() == "KONIEC")
					{
						lista_nagrod = true;
					}
				}
				nagrody.SelectedIndex = 0;
			}
			plik_zapisu.Text = path;
			//Nazwy zagrody
			nowa_nagroda.Enabled = true;
			nagrody.Enabled = true;
			//nagrosy radio buttony
			dodaj_istniejaca.Enabled = true;
			dodaj_nowa.Enabled = true;
			dodaj_nowa.Checked = true;
			//wybor pola
			recznie.Enabled = true;
			losowo.Enabled = true;
			losowo.Checked = true;
			nr_pola_wybor.Enabled = true;
			//dodaj
			dodaj.Enabled = true;

		}

		private void dodad_istniejaca_CheckedChanged(object sender, EventArgs e)
		{
			dodaj_nowa.Checked = false;
			dodaj_istniejaca.Checked = true;
		}

		private void dodaj_nowa_CheckedChanged(object sender, EventArgs e)
		{
			dodaj_istniejaca.Checked = false;
			dodaj_nowa.Checked = true;
		}

		private void losowo_CheckedChanged(object sender, EventArgs e)
		{
			recznie.Checked = false;
			losowo.Checked = true;
			dodaj.Enabled = true;
			nr_pola_wybor.Enabled = false;
		}

		private void recznie_CheckedChanged(object sender, EventArgs e)
		{
			losowo.Checked = false;
			recznie.Checked = true;
			nr_pola_wybor.Enabled = true;
			sprawdz_wolne_pole((int)nr_pola_wybor.Value);
		}

		private void dodaj_nowa_nagroda(int nr_pola)
		{
			nr_pola--;
			String nagroda = nowa_nagroda.Text;
			int ilosc_linni = podglad_pliku.Lines.Length;
			String linia_z_planszy = podglad_pliku.Lines[nr_pola / 10];
			ilosc_linni -= 2;
			char litera_nagrody = podglad_pliku.Lines[ilosc_linni][0];
			litera_nagrody++;
			if (litera_nagrody == 'X')
			{
				litera_nagrody = 'Z';
			}

			linia_z_planszy = linia_z_planszy.Remove(nr_pola%10, 1).Insert(nr_pola%10, litera_nagrody.ToString());

			String[] lines = podglad_pliku.Lines;
			lines[nr_pola / 10] = linia_z_planszy;
			podglad_pliku.Lines = lines;
			podglad_pliku.Text = podglad_pliku.Text.Replace("KONIEC2" , litera_nagrody + " " + nagroda + "\n");
			podglad_pliku.Text += "KONIEC2";
			nagrody.Items.Add(nagroda);
		}

		private void dodaj_istniejaca_nagroda(int nr_pola)
		{
			nr_pola--;
			String nagroda = (String)nagrody.Text;
			String[] lines = podglad_pliku.Lines;
			String linia_z_planszy = lines[nr_pola / 10];
			char litera_nagrody = '\0';
			for (int i=0; i<lines.Length; i++)
			{
				if (lines[i].Contains(nagroda))
				{
					litera_nagrody = lines[i][0];
				}
			}
			linia_z_planszy = linia_z_planszy.Remove(nr_pola % 10, 1).Insert(nr_pola % 10, litera_nagrody.ToString());
			lines[nr_pola / 10] = linia_z_planszy;
			podglad_pliku.Lines = lines;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			sprawdz_wolne_pole((int)nr_pola_wybor.Value);
		}

		private void dodaj_Click(object sender, EventArgs e)
		{
			Boolean istnieje = false;
			int index_istniejaca = -1;
			int pole = -1;
			if (dodaj_nowa.Checked)
			{
				if (nowa_nagroda.Text == "")
					return;
				index_istniejaca = nagrody.FindStringExact(nowa_nagroda.Text);
				if (index_istniejaca == -1)
				{
					if (losowo.Checked == true)
					{
						Random r = new Random();
						{
							nagrody.SelectedIndex = index_istniejaca;
							do
							{
								pole = (int)r.NextInt64(1, 100);
							} while (dodaj.Enabled == false);
						}
					}
					else if (recznie.Checked == true)
					{
						pole = (int)nr_pola_wybor.Value;
					}
					dodaj_nowa_nagroda(pole);
				}
				else
					istnieje = true;
			}
			if (dodaj_istniejaca.Checked || istnieje == true)
			{
				if (losowo.Checked==true)
				{
					Random r = new Random();
					{
						do
						{
							pole = (int)r.NextInt64(1, 100);
						} while (dodaj.Enabled == false);
					}
				}
				else if (recznie.Checked == true)
				{
					pole = (int)nr_pola_wybor.Value;
				}
				dodaj_istniejaca_nagroda(pole);
			}
		}


		private void zapisz_Click(object sender, EventArgs e)
		{
			String path = plik_zapisu.Text;
			using (StreamWriter writer = File.CreateText(path))
			{
				writer.Write(podglad_pliku.Text);
			}
		}
	}
}

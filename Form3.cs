using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Giveaway
{
	public partial class Settingsy : Form
	{
		public Settingsy()
		{
			InitializeComponent();
			dz_mies_r.SelectedIndex = 0;
		}

		private void dodaj_nowy_prog_Click(object sender, EventArgs e)
		{
			String nowy_prog_x = dz_mies_r.SelectedItem.ToString() + " ";
			if (numericUpDown1.Value <= 9)
			{
				nowy_prog_x += ' ';
			}
			nowy_prog_x += (numericUpDown1.Value.ToString());
			MessageBox.Show(nowy_prog_x + '\n' + numericUpDown1.Value.ToString());
			for (int i=0; i<lista_progow.Items.Count; i++)
			{
				if (lista_progow.Items[i].ToString() == nowy_prog_x)
				{
					return;
				}
			}
			lista_progow.Items.Add(nowy_prog_x);
			//if(nowy_prog_ilosc.)
			//nowy_prog_x=nowy_prog_ilosc.Text + 
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (dz_mies_r.SelectedIndex)
			{ 
				case 0:
					numericUpDown1.Maximum = 28;
					break;
				case 1:
					numericUpDown1.Maximum = 12;
					break;
				case 2:
					numericUpDown1.Maximum = 10;
					break;
				default:
					break;
						
			}

		}

		private void usun_prog_Click(object sender, EventArgs e)
		{
			lista_progow.Items.Remove(lista_progow.SelectedItem);
		}

		Boolean czy_cyferka(char c)
		{
			if (!char.IsControl(c) && !char.IsDigit(c))
			{
				return true;
			}
			return false;
		}


		private void TIER_1_ILE_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TIER_2_ILE_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TIER_3_ILE_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TIER_1_MIN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TIER_2_MIN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TIER_3_MIN_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (czy_cyferka(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void Zapis_ustawien_Click(object sender, EventArgs e)
		{
			String path = @"files" + '\\' + "Sub_Bonus.pgor";
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
			String settingstxt = "";

			settingstxt += TIER_1_RODZ_PRZYROSTU.Text + "\n";
			settingstxt += TIER_1_ILE.Text + "\n";
			settingstxt += TIER_1_MIN.Text + "\n";
		
			settingstxt += TIER_2_RODZ_PRZYROSTU.Text + "\n";
			settingstxt += TIER_2_ILE.Text + "\n";
			settingstxt += TIER_2_MIN.Text + "\n";
			
			settingstxt += TIER_3_RODZ_PRZYROSTU.Text + "\n";
			settingstxt += TIER_3_ILE.Text + "\n";
			settingstxt += TIER_3_MIN.Text + "\n";




			using (StreamWriter writer = File.CreateText(path))
			{
				writer.Write(settingstxt);
			}
		}

		private void TIER_1_RODZ_PRZYROSTU_TextChanged(object sender, EventArgs e)
		{
			if (TIER_1_RODZ_PRZYROSTU.Text == "%")
			{
				TIER_1_MIN.Enabled = true;
			}
			else
			{
				TIER_1_MIN.Enabled = false;
				TIER_1_MIN.Text = "0";
			}
		}

		private void TIER_2_RODZ_PRZYROSTU_TextChanged(object sender, EventArgs e)
		{
			if (TIER_2_RODZ_PRZYROSTU.Text == "%")
			{
				TIER_2_MIN.Enabled = true;
			}
			else
			{
				TIER_2_MIN.Enabled = false;
				TIER_2_MIN.Text = "0";
			}
		}

		private void TIER_3_RODZ_PRZYROSTU_TextChanged(object sender, EventArgs e)
		{
			if (TIER_3_RODZ_PRZYROSTU.Text == "%")
			{
				TIER_3_MIN.Enabled = true;
			}
			else
			{
				TIER_3_MIN.Enabled = false;
				TIER_3_MIN.Text = "0";
			}
		}
	}
}

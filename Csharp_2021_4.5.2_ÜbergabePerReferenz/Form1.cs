using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_4._5._2_ÜbergabePerReferenz
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnKopie_Click(object sender, EventArgs e)
		{
			int x, y;
			x = 5;
			y = 12;

			lblAnzeige.Text = "Vorher: x: " + x + ", y:" + y;
			TauscheKopie(x, y);
			lblAnzeige.Text += "\nNachher: x: " + x + ", y:" + y;
		}

		private void TauscheKopie(int a, int b)
		{
			int zwischenspeicher;
			zwischenspeicher = a;
			a = b;
			b = zwischenspeicher;
		}

		private void btnReferenz_Click(object sender, EventArgs e)
		{
			int x, y;
			x = 5;
			y = 12;

			lblAnzeige.Text = "Vorher: x: " + x + ", y:" + y;
			TauscheReferenz(ref x,ref y);
			lblAnzeige.Text += "\nNachher: x: " + x + ", y:" + y;
		}

		private void TauscheReferenz(ref int a, ref int b)
		{
			int zwischenspeicher;
			zwischenspeicher = a;
			a = b;
			b = zwischenspeicher;
		}
	}
}

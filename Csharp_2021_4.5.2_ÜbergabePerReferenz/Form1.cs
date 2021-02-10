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

		private void btnFeldVerdoppeln_Click(object sender, EventArgs e)
		{
			int[] p = { 6, 7, 2 };

			Verdoppeln(p);

			lblAnzeige.Text = "";
			foreach (int element in p)
			{
				lblAnzeige.Text += element + " ";
			}
		}

		private void Verdoppeln(int[] x)
		{
			for (int i = 0; i < x.Length; i++)
			{
				// Jeden Wert des Feldes verdoppeln
				x[i] = x[i] * 2;

				// Alternative:
				// x[i] *= 2;
			}
		}

		private void btnOut_Click(object sender, EventArgs e)
		{
			int a, b;
			a = 12;
			b = 3;

			Rechnen(a, b, out int summe, out int produkt);

			lblAnzeige.Text = "Summe: " + summe
				+ "\nProdukt: " + produkt;
		}

		private void Rechnen(int x, int y, out int s, out int p)
		{
			// Summe berechnen
			s = x + y;
			// Produkt berechnen
			p = x * y;
		}

		private void btnMaxAnzeigen_Click(object sender, EventArgs e)
		{
			int a, b, c;
			a = 12;
			b = 17;

			// Max-Wert berechnen
			// Methode liefert den MaxWert zurück
			c = MaxWert(a, b);

			lblAnzeige.Text = "Maximum: " + c;
		}

		private int MaxWert(int x, int y)
		{
			if (x > y) return x;
			else return y;
		}

		private void btnOptionaleArgumente_Click(object sender, EventArgs e)
		{
			double a = 4.5, c = 10.3;
			int b = 7, d = 9;

			// lblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c, d);
			// lblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c);
			lblAnzeige.Text = "Ergebnis: " + Addiere(a, b);

		}

		private double Addiere(double x, int y, double z = 0, int q = 0)
		{
			return x + y + z + q;
		}
	}
}

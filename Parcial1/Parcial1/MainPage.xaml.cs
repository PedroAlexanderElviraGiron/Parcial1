using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Parcial1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			float CAN;
			int C200, C100, C50, C20, C10, C5, C1, M50, M25, M10, M5, M1;
			C200 = 0;
			C100 = 0;
			C50 = 0;
			C20 = 0;
			C10 = 0;
			C5 = 0;
			C1 = 0;
			M50 = 0;
			M25 = 0;
			M10 = 0;
			M5 = 0;
			M1 = 0;
			var cantidad = double.Parse(linea.Text);
			CAN = float.Parse(linea.Text);
			if ((CAN >= 200))
			{
				C200 = ((int)CAN / 200);
				CAN = CAN - (C200 * 200);

			}
			if ((CAN >= 100))
			{
				C100 = ((int)CAN / 100);
				CAN = CAN - (C100 * 100);

			}
			if ((CAN >= 50))
			{
				C50 = ((int)CAN / 50);
				CAN = CAN - (C50 * 50);

			}
			if ((CAN >= 20))
			{
				C20 = ((int)CAN / 20);
				CAN = CAN - (C20 * 20);

			}
			if ((CAN >= 10))
			{
				C10 = ((int)CAN / 10);
				CAN = CAN - (C10 * 10);
			}
			if ((CAN >= 5))
			{
				C5 = ((int)CAN / 5);
				CAN = CAN - (C5 * 5);
			}
			if ((CAN >= 1))
			{
				C1 = ((int)CAN / 1);
				CAN = CAN - (C1 * 1);
			}
			if ((CAN >= 0.5))
			{
				M50 = (int)(CAN / 0.5);
				CAN = CAN - (float)(M50 * 0.5);
			}
			if ((CAN >= 0.25))
			{
				M25 = (int)(CAN / 0.25);
				CAN = CAN - (float)(M25 * 0.25);
			}
			if ((CAN >= 0.1))
			{
				M10 = (int)(CAN / 0.1);
				CAN = CAN - (float)(M10 * 0.1);
			}
			if ((CAN >= 0.05))
			{
				M5 = (int)(CAN / 0.05);
				CAN = CAN - (float)(M5 * 0.05);
			}
			if ((CAN >= 0.01))
			{
				M1 = (int)Math.Round(CAN / 0.01);
				CAN = CAN - (float)(M1 * 0.01);
			}
			BILLEDOCIEN.Text = "Billetes de Q200.00 = " +C200;
			BILLECIEN.Text = "Billetes de Q100.00 = " + C100;
			BILLECINCUE.Text = "Billetes de Q50.00 = " + C50;
			BILLEVEINT.Text = "Billetes de Q20.00 = " + C20;
			BILLEDIEZ.Text = "Billetes de Q10.00 = " + C10;
			BILLECINCO.Text = "Billetes de Q5.00 = " + C5;
			BILLEUNO.Text = "Billetes de Q1.00 = " + C1;
			MONEDACINCUEN.Text = "Monedas de ¢50 = " + M50;
			MONEDAVEINTI.Text = "Monedas de ¢25 = " + M25;
			MONEDADIEZ.Text = "Monedas de ¢10 = " + M10;
			MONEDACINCO.Text = "Monedas de ¢5 = " + M5;
			MONEDAUNO.Text = "Monedas de ¢1 = " + M1;
		}
    }
}

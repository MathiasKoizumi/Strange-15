using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		private Bongo jiggy;

		private Form1 form1;

		public BolleHeaven(Form1 form)
		{
			form1 = form;
			form1.explodeMe(1200, 1000);
			if (!form1.timer1IsRunning)
			{
				form1.SpellOut(form1.junkie.Next(3, 6));
				form1.timer1.Start();
				form1.timer1IsRunning = true;
			}
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		public string vowel(int joy, Random jiggo)
		{
			string[] array = callShuffle(new string[11]
			{
				"a",
				"e",
				"ole",
				"i",
				"y",
				"iv",
				"af",
				" ",
				"up",
				"ed",
				"an"
			});
			return array[jiggo.Next(11)];
		}

		public string constantIteration(int numberJoy, Random joy)
		{
			string[] array = callShuffle(new string[15]
			{
				"j",
				"k",
				"t",
				"s",
				"r",
				"v",
				" ",
				"n",
				"m",
				"p",
				"-",
				"\u00b4",
				"|",
				"3",
				"-4"
			});
			return array[joy.Next(15)];
		}

		private string[] callShuffle(string[] bonnysFornøjelse)
		{
			return bonnysFornøjelse;
		}

		public string gEn2Name(int lenght, Random pig)
		{
			switch (pig.Next(15))
			{
			case 0:
				return constantIteration(133, pig) + vowel(12, pig) + constantIteration(150, pig) + vowel(1400, pig) + constantIteration(132, pig);
			case 1:
				return vowel(21, pig) + constantIteration(951, pig) + constantIteration(391, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 2:
				return constantIteration(124, pig) + constantIteration(135, pig) + vowel(146, pig) + vowel(61, pig) + constantIteration(13, pig);
			case 3:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig);
			case 4:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(153, pig) + constantIteration(561, pig);
			case 5:
				return vowel(153, pig) + constantIteration(186, pig) + constantIteration(55, pig) + constantIteration(186, pig) + vowel(153, pig) + vowel(153, pig) + constantIteration(561, pig) + constantIteration(561, pig);
			case 6:
				return constantIteration(186, pig) + vowel(153, pig) + constantIteration(55, pig) + constantIteration(561, pig) + vowel(351, pig) + vowel(351, pig);
			case 7:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(234, pig);
			case 8:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig) + constantIteration(4851, pig);
			case 9:
				return constantIteration(951, pig) + vowel(21, pig) + constantIteration(391, pig) + constantIteration(4851, pig) + vowel(5861, pig);
			case 10:
				return constantIteration(951, pig) + vowel(21, pig) + vowel(5861, pig);
			default:
				return constantIteration(364, pig) + vowel(136, pig) + constantIteration(153, pig);
			}
		}

		internal static Jongo bongo(int p, Afmagt afmagt)
		{
			throw new NotImplementedException();
		}

		public string[] getSentenceVolaHovski(int lines, int words)
		{
			string[] array = new string[400];
			array[0] = "Der";
			array[1] = "var";
			array[2] = "engang";
			array[3] = "en";
			array[4] = "gammel";
			array[5] = "mand";
			array[6] = "han";
			array[7] = "hed";
			array[8] = "OlleBolle";
			array[9] = "fire";
			array[10] = "måneder";
			array[11] = "senere";
			array[12] = "gik";
			array[13] = "han";
			array[14] = "i";
			array[15] = "skole";
			array[16] = "maden";
			array[17] = "var";
			array[18] = "tam";
			array[19] = "men";
			array[20] = "nem";
			array[21] = "at";
			array[22] = "få";
			array[23] = "ned";
			array[24] = "to";
			array[25] = "sætninger";
			array[26] = "blev";
			array[27] = "til";
			array[28] = "i";
			array[29] = "hans";
			array[30] = "skolegård";
			array[31] = "fire";
			array[32] = "mennesker";
			array[33] = "så";
			array[34] = "til";
			array[35] = "mens";
			array[36] = "han";
			array[37] = "spiste";
			array[38] = "leverpostej";
			array[39] = "det";
			array[40] = "var";
			array[41] = "en";
			array[42] = "dejlig";
			array[43] = "dag";
			array[44] = "hunden";
			array[45] = "gik";
			array[46] = "tur";
			array[47] = "med";
			array[48] = "sig";
			array[49] = "selv";
			array[50] = "en";
			array[51] = "dag";
			array[52] = "gik";
			array[53] = "det";
			array[54] = "op";
			array[55] = "for";
			array[56] = "ham";
			array[57] = "mennesker";
			array[58] = "stod";
			array[59] = "i";
			array[60] = "kø";
			array[61] = "for";
			array[62] = "at";
			array[63] = "sige";
			array[64] = "goddag";
			array[65] = "flere";
			array[66] = "kom";
			array[67] = "til";
			array[68] = "en";
			array[69] = "dag";
			array[70] = "blev";
			array[71] = "det";
			array[72] = "mange";
			array[73] = "fornøjelser";
			array[74] = "kom";
			array[75] = "og";
			array[76] = "gik";
			array[77] = "klokken";
			array[78] = "blev";
			array[79] = "sent";
			array[80] = "men";
			array[81] = "han";
			array[82] = "var";
			array[83] = "vågen";
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text += ", ";
						num = form1.junkie.Next(3);
					}
					text = text + array[form1.junkie.Next(84)] + " ";
					num++;
				}
				array2[i] = text;
			}
			return array2;
		}

		public string[] getSentenceVolaHovskiPovski(int lines, int words)
		{
			new List<string>();
			string str = "Der var engang en smuk tusse den hed alfred og boede i en skov skoven lå mellem to bjerge og midt imellem løb en flod";
			str += " I dalen boede fem tosser den ene havde en datter så smuk hun hed Magdalene hendes yndlingsdyr var en enhjørning som viste sig i en lysning";
			str += " i dalen to mennesker troede de ville have hævn og det var den rene sandhed godt nok sagde jesus en masse om kærlighed";
			string str2 = "Fire mennesker troede på Jesus men så kom en alien og sagde goddag på fransk han hed ipswitch og handler om";
			str2 += " tid og sted to patroner til du forstår det handler om divine intervention betyder på fransk at gud er med os";
			str2 += " hvad enten vi tror eller ej sådan er livet min ven vi handler i god tro altid vi er guds efterkommere";
			string str3 = "vi har en tid for os selv musikken er mærkelig og livet går vidre frøen bor i os alle alle er guds børn forstå mig ret";
			str3 += " sådan er livet vi moser med trends der får os i uføre hvem skal overtage showet det er en tanke fra det vilde vest vi er trætte af at";
			str3 += " forstå hvad der sker i fremtiden rummet er uendeligt vi har ingen chance for at begå os rigtigt det er en tanke fra de varme  lande  at vi er";
			str3 += " vanskelige at forstå sådan er virkeligheden vi elsker os selv og det ukendte";
			string[] array;
			switch (form1.junkie.Next(3))
			{
			case 0:
				array = str.Split(' ');
				break;
			case 1:
				array = str2.Split(' ');
				break;
			case 2:
				array = str3.Split(' ');
				break;
			default:
				array = str.Split(' ');
				break;
			}
			string[] array2 = new string[lines];
			for (int i = 0; i < lines; i++)
			{
				string text = "";
				int num = 0;
				for (int j = 0; j < form1.junkie.Next(words) + 4; j++)
				{
					if (num >= 6)
					{
						text += ", ";
						num = form1.junkie.Next(3);
					}
					text = text + array[form1.junkie.Next(array.Length)] + " ";
					num++;
				}
				array2[i] = text;
			}
			return array2;
		}
	}
}

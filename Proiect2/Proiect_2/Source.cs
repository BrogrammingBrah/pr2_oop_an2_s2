using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_2
{
	static class RandomLetter
	{
		static Random letter = new Random();
		public static String lettersRandom()
		{
			int litera = letter.Next(0, 26);
			string letter1 = ((char)('A' + litera)).ToString();
			return letter1;
		}
	}
	class Matrice
	{
		int n;
		String[][] M;
		public int N
		{
			get { return n; }
			set { this.n = value; }
		}
		public String[][] m
		{
			get { return M; }
			set { this.M = value; }
		}
		public Matrice(int n)
		{
			this.n = n;
			M = new String[n][];
			for (int i = 0; i < n; i++)
				M[i] = new String[n];
			int ij;
			String[] literele = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
			Random letter = new Random();
			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
				{
					ij = letter.Next(0, 26);
					M[i][j] = literele[ij];
				}
		}
	}
	class word_search
	{
		int w, h, l,p, nrmax, nrmin;
		ListBox cuvinte;
		int n,t;
		Graphics g;
		String lb, categ,dif;
		
		public int W
        {
            get { return w; }
            set { this.w = value; }
        }
		public int H
		{
			get { return h; }
			set { this.h = value; }
		}
		public int P
		{
			get { return p; }
			set { this.p = value; }
		}
		public int N
		{
			get { return n; }
			set { this.n = value; }
		}
		public int Nrmax
		{
			get { return nrmax; }
			set { this.nrmax = value; }
		}
		public int Nrmin
		{
			get { return nrmin; }
			set { this.nrmin = value; }
		}
		public int T
		{
			get { return t; }
			set { this.t = value; }
		}
		public String Lb
        {
			get { return lb; }
			set { this.lb = value; }
		}
		public String Categ
		{
			get { return categ; }
			set { this.categ = value; }
		}
		public String Dif
		{
			get { return dif; }
			set { this.dif = value; }
		}
		public word_search(int w, int h,int n,int p,int nrmax,int nrmin,String lb,String categ,int t, Graphics g, String dif)
		{
			this.w = w;
			this.h = h;
			this.n = n;
			this.p = p;
			this.nrmax = nrmax;
			this.nrmin = nrmin;
			this.lb = lb;
			this.categ = categ;
			this.t = t;
			this.dif = dif;
			this.g = g;
        }
		public void desenez_tabela_printare(Graphics g1, int d, int t)
		{
			
			
		}
		public void desen_foaiejoc_joc(Graphics g, int d, int t, bool c)
		{
			l = 500 / (d + 2);
			g.Clear(Color.White);
			Pen creion = new Pen(Color.Black, 2);
			Matrice M = new Matrice(d);
			System.Drawing.Font f = new System.Drawing.Font("Times New Roman", l / 3);
			System.Drawing.Font f1 = new System.Drawing.Font("Times New Roman", 12);
			StringFormat sf = new StringFormat();
			sf.Alignment = StringAlignment.Center;
			sf.LineAlignment = StringAlignment.Center;
			for (int i = 0; i <= d; i++)
			{
				g.DrawLine(creion, l, l + l * i, (d + 1) * l, l + l * i);
				g.DrawLine(creion, l + l * +i, l, l * i + l, (d + 1) * l);
			}
			citesc_cuvant();
			random_cuv(Rom);
         
			if (c == true)
			{
				g.DrawString("Nume     ___________________", f1, Brushes.Black, 0, 0);
				g.DrawString("Prenume ___________________", f1, Brushes.Black, 0, 15);
				g.DrawString("Data __________", f1, Brushes.Black, 360, 0);
				g.DrawString("Timp: " + t + " minute", f1, Brushes.Black, 360, 15);
				Random random = new Random();
				
			}
			else
			{
				Random random = new Random();
				for (int i = 0; i < p; i++)
				{
					int[] v = new int[p];
					v[i] = random.Next(words.Count);
					g.DrawString(words[v[i]].Text.ToUpper(), f1, Brushes.Black, new Rectangle(30, 15 * i + 460, 100, 20), sf);
				}
			}
			
			for (int i = 0; i < d; i++)
			{
				for (int j = 0; j < d; j++)
				{
					g.DrawString(M.m[i][j], f, Brushes.Black, new Rectangle((i + 1) * l, l + j * l, l, l), sf);
				}
			}

		}
		public void Joc_nou(int d, int t, bool c)
		{
			desen_foaiejoc_joc(g, d, t,c);
			
		}
		List<Cuvant> Rom;
		List<Cuvant> Eng;
		List<Cuvant> words = new List<Cuvant>();
		public void citesc_cuvant()
		{
			Rom = Cuvant.citesc_cuvant("CuvinteRomana.txt");
			Eng = Cuvant.citesc_cuvant("CuvinteEngleza.txt");
		}
		public void random_cuv(List<Cuvant> C)
		{
			words.Clear();
			foreach (Cuvant c in C)
			{
				if (c.Text.Length <=nrmax&& c.Text.Length >= nrmin)
					words.Add(c);
			}
		}

		
	}
	class Cuvant
	{
		String text; int id;
		public Cuvant(String text, int id)
		{
			this.text = text;
			this.id = id;
		}
		public String Text
		{
			get { return text; }
			set { this.text = value; }
		}
		public int Id
		{
			get { return id; }
			set { this.id = value; }
		}
		public static List<Cuvant> citesc_cuvant(String nume_fisier)
		{
			List<Cuvant> lista = new List<Cuvant>();
			FileStream fs = null;
			StreamReader sr = null;
			try
			{
				fs = new FileStream(nume_fisier, FileMode.Open, FileAccess.Read);
				sr = new StreamReader(fs);
				for (; ; )
				{
					String linie = sr.ReadLine();
					if (linie == null)
						break; 
					int index = linie.IndexOf(";");
					if (index >= 0)
					{
						String temp_text = linie.Substring(1, index - 2);
						linie = linie.Substring(index + 1);
						try
						{
							lista.Add(new Cuvant(temp_text, Convert.ToInt32(linie)));
						}
						catch (Exception) { };
					}
				}
			}
			catch (System.Exception)
			{ }
			finally
			{
				if (sr != null)
					sr.Close();
				if (fs != null)
					fs.Close();
			}
			return lista;
		}
	};
}
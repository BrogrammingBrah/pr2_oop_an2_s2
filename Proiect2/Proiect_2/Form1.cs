using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_2
{
   
    public partial class Form1 : Form
    {
        Image img,img1;
        Graphics g,g1;
        int l,nr_cuvinte;
        int d=1;
        int t = 1;
      
      
        word_search joc, joc1;
        DateTime time_stop1, time_stop2;
        TimeSpan t1, t2;
     
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(picture.Width, picture.Height);
            img1= new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(img);
            g1 = Graphics.FromImage(img1);
            l = img.Width / d;
            picture.Refresh();

        }
        private void Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Despre_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
            img1.Save(save.FileName);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        public void button7_Click(object sender, EventArgs e)
        {
           


        }

        private void picture_Click(object sender, EventArgs e)
        {

        }
        
        private void button_joc_nou_Click(object sender, EventArgs e)
        {


            if (dim.Text != "")
            {
                if (dim.Text == "4")
                    d = 4;
                else if (dim.Text == "5")
                    d = 5;
                else if (dim.Text == "6")
                    d = 6;
                else if (dim.Text == "7")
                    d = 7;
                else if (dim.Text == "8")
                    d = 8;
                else if (dim.Text == "9")
                    d = 9;
               if (nr_cuv.Text != "")
                {
                    nr_cuvinte = Convert.ToInt32(nr_cuv.Text);
                    if (lb.Text != "")
                    {
                        if (categ.Text != "")
                        {
                            if (nr_max.Text != "")
                            {
                                int nr_maxim = Convert.ToInt32(nr_max.Text);
                                if (nr_maxim > d)
                                {
                                    MessageBox.Show("Nr max de caractere trebuie sa fie mai mic sau egal cu dimensiunea tabelei");
                                }
                                else
                                {

                                    if (nr_min.Text != "")
                                    {
                                        int nr_minim = Convert.ToInt32(nr_min.Text);
                                        if (nr_minim <= nr_maxim)
                                        {
                                            if (timp_max.Text != "")
                                            {
                                                if (timp_max.Text == "2 min")
                                                    t = 2;
                                                else if (timp_max.Text == "3 min")
                                                    t = 3;
                                                else if (timp_max.Text == "4 min")
                                                    t = 4;
                                                else if (timp_max.Text == "5 min")
                                                    t = 5;
                                                else if (timp_max.Text == "6 min")
                                                    t = 6;
                                                joc = new word_search(picture.Width, picture.Height, d, Convert.ToInt32(nr_cuv.Text), nr_maxim, nr_minim, lb.Text, categ.Text, t, g, dif.Text);
                                                joc1 = new word_search(picture.Width, picture.Height, d, Convert.ToInt32(nr_cuv.Text), nr_maxim, nr_minim, lb.Text, categ.Text, t, g, dif.Text);
                                                joc.desen_foaiejoc_joc(g, d, t, false);
                                                joc1.desen_foaiejoc_joc(g1, d, t, true);
                                                Timer();
                                                picture.Visible = true;
                                                picture.Refresh();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Introduceti timpul maxim ");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nr min de caractere trebuie sa fie mai mic sau egal cu nr max de caractere");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Introduceti nr min de caractere ");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Introduceti nr max de caractere ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduceti categoria ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduceti limba ");
                    }

                }
                else
                {
                    MessageBox.Show("Introduceti nr de cuvinte ");
                }
            }
            else
            {
                MessageBox.Show("Introduceti dimensiunea tabelei ");
            }


            joc.Joc_nou(d, t, false);
            joc1.Joc_nou(d, t, true);
            picture.Refresh();
            dif.Refresh();
            Configurare.Refresh();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dim.Text != "")
            {
                if (dim.Text == "4")
                    d = 4;
                else if (dim.Text == "5")
                    d = 5;
                else if (dim.Text == "6")
                    d = 6;
                else if (dim.Text == "7")
                    d = 7;
                else if (dim.Text == "8")
                    d = 8;
                else if (dim.Text == "9")
                    d = 9;
                if (nr_cuv.Text != "")
                {
                    nr_cuvinte = Convert.ToInt32(nr_cuv.Text);
                    if (lb.Text != "")
                    {
                        if (categ.Text != "")
                        {
                            if (nr_max.Text != "")
                            {
                                int nr_maxim = Convert.ToInt32(nr_max.Text);
                                if (nr_maxim > d)
                                {
                                    MessageBox.Show("Nr max de caractere trebuie sa fie mai mic sau egal cu dimensiunea tabelei");
                                }
                                else
                                {

                                    if (nr_min.Text != "")
                                    {
                                        int nr_minim = Convert.ToInt32(nr_min.Text);
                                        if (nr_minim <= nr_maxim)
                                        {
                                            if (timp_max.Text != "")
                                            {
                                                if (timp_max.Text == "2 min")
                                                    t = 2;
                                                else if (timp_max.Text == "3 min")
                                                    t = 3;
                                                else if (timp_max.Text == "4 min")
                                                    t = 4;
                                                else if (timp_max.Text == "5 min")
                                                    t = 5;
                                                else if (timp_max.Text == "6 min")
                                                    t = 6;
                                                joc = new word_search(picture.Width, picture.Height, d, Convert.ToInt32(nr_cuv.Text), nr_maxim, nr_minim, lb.Text, categ.Text, t, g, dif.Text);
                                                joc1 = new word_search(picture.Width, picture.Height, d, Convert.ToInt32(nr_cuv.Text), nr_maxim, nr_minim, lb.Text, categ.Text, t, g, dif.Text);
                                                joc.desen_foaiejoc_joc(g, d, t, false);
                                                joc1.desen_foaiejoc_joc(g1, d, t, true);
                                                Timer();
                                                picture.Visible = true;
                                                picture.Refresh();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Introduceti timpul maxim ");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Nr min de caractere trebuie sa fie mai mic sau egal cu nr max de caractere ");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Introduceti nr min de caractere ");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Introduceti nr max de caractere ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduceti categoria ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduceti limba ");
                    }

                }
                else
                {
                    MessageBox.Show("Introduceti nr de cuvinte ");
                }
            }
            else
            {
                MessageBox.Show("Introduceti dimensiunea tabelei ");
            }

          
            joc.Joc_nou(d,t,false);
            joc1.Joc_nou(d,t,true);
            picture.Refresh();
            dif.Refresh();
            Configurare.Refresh();
        }
        private void picture_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dif_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string dificultate = dif.Text;
            if (dificultate == "Incepator")
            {
                dim.Text = "4";
                nr_cuv.Text = "2";
                lb.Text = "Rom";
                categ.Text = "Animale";
                nr_max.Text = "4";
                nr_min.Text = "3";
                timp_max.Text = "4 min";
            }
            else if (dificultate == "Mediu")
            {
                dim.Text = "6";
                nr_cuv.Text = "4";
                lb.Text = "Eng";
                categ.Text = "School";
                nr_max.Text = "5";
                nr_min.Text = "3";
                timp_max.Text = "5 min";
            }
            else if (dificultate == "Avansat")
            {
                dim.Text = "8";
                nr_cuv.Text = "5";
                lb.Text = "Rom";
                categ.Text = "Gradina";
                nr_max.Text = "7";
                nr_min.Text = "4";
                timp_max.Text = "5 min";
            }
        }
        void imprimare()
        {
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                print.Print();
            }
        }
        void Timer()
        {
            Reset_Timer();
            DateTime time_stop2 = new DateTime();
            t1 = DateTime.Now - time_stop1 + t1;
            t2 = DateTime.Now - time_stop2;

            this.timer_up.Start();
            this.timer_down.Start();
            
        }
        void Reset_Timer()
        {

            t1 = DateTime.Now - System.DateTime.MinValue;
            time_stop1 = DateTime.Now;
            timer_down.Stop();
            timer_up.Stop();
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button_setari_Click(object sender, EventArgs e)
        {

        }

        private void button_dificultate_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            imprimare();
        }

        private void nr_cuv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Danila Ionut");
        }

        private void button_clasament_Click(object sender, EventArgs e)
        {
          
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void l_dificultate_Click(object sender, EventArgs e)
        {

        }

        private void nr_max_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timp_max_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_down_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 60);
            DateTime dt = DateTime.Now - t2 + ts;
            String s_min = Convert.ToString(t- dt.Minute);
            String s_sec = Convert.ToString(59 - dt.Second);

            if (s_min.Length == 1)
                s_min = "0" + s_min;
            if (s_sec.Length == 1)
                s_sec = "0" + s_sec;

            this.label9.Text = s_min + ":" + s_sec;
            if (this.label9.Text == "00:00")
            {
                timer_down.Stop();
                timer_up.Stop();
            }
        }

        private void timer_up_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now - t1;
            String s_min = Convert.ToString(dt.Minute);
            String s_sec = Convert.ToString(dt.Second);

            if (s_min.Length == 1) s_min = "0" + s_min;
            if (s_sec.Length == 1) s_sec = "0" + s_sec;

            this.label10.Text = s_min + ":" + s_sec;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_export_Click(object sender, EventArgs e)
        {
           
        }

        private void button_printare_Click(object sender, EventArgs e)
        {
            imprimare();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(img1, 0, 50);
        }
    }
}

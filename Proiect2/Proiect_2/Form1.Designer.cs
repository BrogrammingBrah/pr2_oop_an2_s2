
namespace Proiect_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_joc_nou = new System.Windows.Forms.ToolStripButton();
            this.button_clasament = new System.Windows.Forms.ToolStripButton();
            this.button_iesire = new System.Windows.Forms.ToolStripButton();
            this.button_printare = new System.Windows.Forms.ToolStripButton();
            this.Configurare = new System.Windows.Forms.GroupBox();
            this.timp_max = new System.Windows.Forms.ComboBox();
            this.nr_min = new System.Windows.Forms.ComboBox();
            this.nr_max = new System.Windows.Forms.ComboBox();
            this.categ = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nr_cuv = new System.Windows.Forms.ComboBox();
            this.dim = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.l_dificultate = new System.Windows.Forms.Label();
            this.dif = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clasament = new System.Windows.Forms.Button();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.print = new System.Drawing.Printing.PrintDocument();
            this.pageSetup = new System.Windows.Forms.PageSetupDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.timer_down = new System.Windows.Forms.Timer(this.components);
            this.picture = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.Configurare.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_joc_nou,
            this.button_clasament,
            this.button_iesire,
            this.button_printare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1249, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // button_joc_nou
            // 
            this.button_joc_nou.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_joc_nou.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_joc_nou.Name = "button_joc_nou";
            this.button_joc_nou.Size = new System.Drawing.Size(54, 50);
            this.button_joc_nou.Text = "Joc Nou";
            this.button_joc_nou.ToolTipText = "Joc nou";
            this.button_joc_nou.Click += new System.EventHandler(this.button_joc_nou_Click);
            // 
            // button_clasament
            // 
            this.button_clasament.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_clasament.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_clasament.Name = "button_clasament";
            this.button_clasament.Size = new System.Drawing.Size(67, 50);
            this.button_clasament.Text = "Clasament";
            this.button_clasament.Click += new System.EventHandler(this.button_clasament_Click);
            // 
            // button_iesire
            // 
            this.button_iesire.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.button_iesire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_iesire.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(38, 50);
            this.button_iesire.Text = "Iesire";
            this.button_iesire.ToolTipText = "Iesire";
            this.button_iesire.Click += new System.EventHandler(this.Iesire_Click);
            // 
            // button_printare
            // 
            this.button_printare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_printare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_printare.Name = "button_printare";
            this.button_printare.Size = new System.Drawing.Size(59, 50);
            this.button_printare.Text = "Printeaza";
            this.button_printare.ToolTipText = "Printare foaie de joc";
            this.button_printare.Click += new System.EventHandler(this.button_printare_Click);
            // 
            // Configurare
            // 
            this.Configurare.Controls.Add(this.timp_max);
            this.Configurare.Controls.Add(this.nr_min);
            this.Configurare.Controls.Add(this.nr_max);
            this.Configurare.Controls.Add(this.categ);
            this.Configurare.Controls.Add(this.lb);
            this.Configurare.Controls.Add(this.dif);
            this.Configurare.Controls.Add(this.label7);
            this.Configurare.Controls.Add(this.label6);
            this.Configurare.Controls.Add(this.l_dificultate);
            this.Configurare.Controls.Add(this.label5);
            this.Configurare.Controls.Add(this.label4);
            this.Configurare.Controls.Add(this.label1);
            this.Configurare.Controls.Add(this.label3);
            this.Configurare.Controls.Add(this.label2);
            this.Configurare.Controls.Add(this.nr_cuv);
            this.Configurare.Controls.Add(this.dim);
            this.Configurare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Configurare.ForeColor = System.Drawing.Color.Black;
            this.Configurare.Location = new System.Drawing.Point(6, 112);
            this.Configurare.Name = "Configurare";
            this.Configurare.Size = new System.Drawing.Size(631, 373);
            this.Configurare.TabIndex = 1;
            this.Configurare.TabStop = false;
            this.Configurare.Text = "Configurare";
            // 
            // timp_max
            // 
            this.timp_max.BackColor = System.Drawing.Color.Silver;
            this.timp_max.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timp_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timp_max.FormattingEnabled = true;
            this.timp_max.Items.AddRange(new object[] {
            "2 min",
            "3 min",
            "4 min",
            "5 min",
            "6 min"});
            this.timp_max.Location = new System.Drawing.Point(480, 298);
            this.timp_max.Name = "timp_max";
            this.timp_max.Size = new System.Drawing.Size(107, 25);
            this.timp_max.TabIndex = 18;
            this.timp_max.SelectedIndexChanged += new System.EventHandler(this.timp_max_SelectedIndexChanged);
            // 
            // nr_min
            // 
            this.nr_min.BackColor = System.Drawing.Color.Silver;
            this.nr_min.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nr_min.FormattingEnabled = true;
            this.nr_min.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.nr_min.Location = new System.Drawing.Point(201, 289);
            this.nr_min.Name = "nr_min";
            this.nr_min.Size = new System.Drawing.Size(107, 25);
            this.nr_min.TabIndex = 10;
            // 
            // nr_max
            // 
            this.nr_max.BackColor = System.Drawing.Color.Silver;
            this.nr_max.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nr_max.FormattingEnabled = true;
            this.nr_max.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.nr_max.Location = new System.Drawing.Point(201, 242);
            this.nr_max.Name = "nr_max";
            this.nr_max.Size = new System.Drawing.Size(107, 25);
            this.nr_max.TabIndex = 17;
            this.nr_max.SelectedIndexChanged += new System.EventHandler(this.nr_max_SelectedIndexChanged);
            // 
            // categ
            // 
            this.categ.BackColor = System.Drawing.Color.Silver;
            this.categ.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categ.FormattingEnabled = true;
            this.categ.Items.AddRange(new object[] {
            "Animale",
            "School",
            "Gradina"});
            this.categ.Location = new System.Drawing.Point(480, 242);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(107, 25);
            this.categ.TabIndex = 16;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // lb
            // 
            this.lb.BackColor = System.Drawing.Color.Silver;
            this.lb.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb.FormattingEnabled = true;
            this.lb.Items.AddRange(new object[] {
            "Ro",
            "En"});
            this.lb.Location = new System.Drawing.Point(201, 202);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(107, 25);
            this.lb.TabIndex = 15;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Timp maxim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nr min caractere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nr max caractere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimensiune tabela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Limba";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numar cuvinte";
            // 
            // nr_cuv
            // 
            this.nr_cuv.BackColor = System.Drawing.Color.Silver;
            this.nr_cuv.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr_cuv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nr_cuv.FormattingEnabled = true;
            this.nr_cuv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.nr_cuv.Location = new System.Drawing.Point(480, 202);
            this.nr_cuv.Name = "nr_cuv";
            this.nr_cuv.Size = new System.Drawing.Size(107, 25);
            this.nr_cuv.TabIndex = 9;
            this.nr_cuv.SelectedIndexChanged += new System.EventHandler(this.nr_cuv_SelectedIndexChanged);
            // 
            // dim
            // 
            this.dim.BackColor = System.Drawing.Color.Silver;
            this.dim.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dim.FormattingEnabled = true;
            this.dim.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.dim.Location = new System.Drawing.Point(342, 152);
            this.dim.Name = "dim";
            this.dim.Size = new System.Drawing.Size(107, 25);
            this.dim.TabIndex = 8;
            this.dim.SelectedIndexChanged += new System.EventHandler(this.dim_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(14, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Joc nou";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_dificultate
            // 
            this.l_dificultate.AutoSize = true;
            this.l_dificultate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dificultate.ForeColor = System.Drawing.Color.Black;
            this.l_dificultate.Location = new System.Drawing.Point(198, 53);
            this.l_dificultate.Name = "l_dificultate";
            this.l_dificultate.Size = new System.Drawing.Size(83, 18);
            this.l_dificultate.TabIndex = 3;
            this.l_dificultate.Text = "Dificultate";
            this.l_dificultate.Click += new System.EventHandler(this.l_dificultate_Click);
            // 
            // dif
            // 
            this.dif.BackColor = System.Drawing.Color.Silver;
            this.dif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif.ForeColor = System.Drawing.Color.Black;
            this.dif.FormattingEnabled = true;
            this.dif.Items.AddRange(new object[] {
            "Incepator",
            "Mediu",
            "Avansat"});
            this.dif.Location = new System.Drawing.Point(317, 47);
            this.dif.Name = "dif";
            this.dif.Size = new System.Drawing.Size(93, 24);
            this.dif.TabIndex = 4;
            this.dif.SelectedIndexChanged += new System.EventHandler(this.dif_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(229, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Printeaza";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.clasament);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Configurare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(584, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 572);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meniu Principal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Timp scurs";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Timp ramas";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(572, 540);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Iesire";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(132, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 10;
            this.button4.Text = "Despre";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // clasament
            // 
            this.clasament.BackColor = System.Drawing.Color.Silver;
            this.clasament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clasament.ForeColor = System.Drawing.Color.Black;
            this.clasament.Location = new System.Drawing.Point(362, 31);
            this.clasament.Name = "clasament";
            this.clasament.Size = new System.Drawing.Size(108, 26);
            this.clasament.TabIndex = 9;
            this.clasament.Text = "Clasament";
            this.clasament.UseVisualStyleBackColor = false;
            this.clasament.Click += new System.EventHandler(this.button4_Click);
            // 
            // pd
            // 
            this.pd.Document = this.print;
            this.pd.UseEXDialog = true;
            // 
            // print
            // 
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetup
            // 
            this.pageSetup.Document = this.print;
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // timer_up
            // 
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // timer_down
            // 
            this.timer_down.Tick += new System.EventHandler(this.timer_down_Tick);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(46, 70);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(508, 590);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1249, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Configurare.ResumeLayout(false);
            this.Configurare.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_joc_nou;
        private System.Windows.Forms.ToolStripButton button_iesire;
        private System.Windows.Forms.ToolStripButton button_printare;
        private System.Windows.Forms.ToolStripButton button_clasament;
        private System.Windows.Forms.GroupBox Configurare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nr_cuv;
        private System.Windows.Forms.ComboBox dim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timp_max;
        private System.Windows.Forms.ComboBox nr_min;
        private System.Windows.Forms.ComboBox nr_max;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.ComboBox lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label l_dificultate;
        private System.Windows.Forms.ComboBox dif;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clasament;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PrintDialog pd;
        private System.Windows.Forms.PageSetupDialog pageSetup;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer_up;
        private System.Windows.Forms.Timer timer_down;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}


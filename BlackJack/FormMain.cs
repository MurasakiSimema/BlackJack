using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class FormMain : Form
    {
        List<Carta> carte;
        List<Point> points;
        Random rnd = new Random(DateTime.Now.Second);
        const int ncarte = 52;
        int[] punteggi;
        int[] soldi;
        int[] puntata;
        bool ok;
        bool[] fatto;
        TextBox[] texts;
        BackgroundWorker[] workers;
        public FormMain()
        {
            InitializeComponent();
        }
        private void bgwBanco_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            int k = int.Parse(e.Argument.ToString());
            Banco g = new Banco();
            PictureBox pcb = new PictureBox();
            PictureBox pcbg = new PictureBox();

            g.Add(carte[rnd.Next(0, ncarte)]);
            GeneraPCB(pcb, g.Cards, k);
            bgw.ReportProgress(0, pcb);

            Thread.Sleep(300);
            points[4] = new Point(points[4].X + 30, points[4].Y);
            pcbg.Name = string.Format("pcbg");
            pcbg.Image = carte[rnd.Next(52, 54)].Image;
            pcbg.BackColor = Color.Transparent;
            pcbg.Size = new Size(100, 157);
            pcbg.Location = points[4];
            pcbg.Visible = true;
            pcbg.SizeMode = PictureBoxSizeMode.StretchImage;

            g.Add(carte[rnd.Next(0, ncarte)]);
            bgw.ReportProgress(0, pcbg);

            ok = true;
            while (!fatto[0] || !fatto[1] || !fatto[2] || !fatto[3])   
            {
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);
            pcbg.Image = g.Cards[g.Cards.Count - 1].Image;
            bgw.ReportProgress(1);

            while (g.Next(rnd))
            {
                Thread.Sleep(500);
                points[4] = new Point(points[4].X + 30, points[4].Y);
                g.Add(carte[rnd.Next(0, ncarte)]);
                pcb = new PictureBox();
                GeneraPCB(pcb, g.Cards, 4);
                bgw.ReportProgress(0, pcb);
                Thread.Sleep(500);
            }
            e.Result = g.Value;
        }
        private void bgwG_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            int k = int.Parse(e.Argument.ToString());
            Giocatore g = new Giocatore();
            PictureBox pcb = new PictureBox();

            while (!ok)
            {
                Thread.Sleep(1000);
            }
            Thread.Sleep(1500);

            puntata[k] = rnd.Next(1, soldi[k] / 2 + 2);
            soldi[k] -= puntata[k];

            g.Add(carte[rnd.Next(0, ncarte)]);
            GeneraPCB(pcb, g.Cards, k);
            bgw.ReportProgress(0, pcb);

            while (g.Next(rnd))
            {
                Thread.Sleep(1000);
                points[k] = new Point(points[k].X + 30, points[k].Y);
                g.Add(carte[rnd.Next(0, ncarte)]);
                pcb = new PictureBox();
                GeneraPCB(pcb, g.Cards, k);
                bgw.ReportProgress(0, pcb);
                Thread.Sleep(500);
            }
            punteggi[k] = g.Value;
            e.Result = k;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            carte = new List<Carta>();
            points = new List<Point>();
            punteggi = new int[4];
            soldi = new int[4];
            puntata = new int[4];
            fatto = new bool[4];
            CaricaCarte(carte);

            texts = new TextBox[4];
            texts[0] = txt1;
            texts[1] = txt2;
            texts[2] = txt3;
            texts[3] = txt4;

            points.Add(new Point(50, 100));
            points.Add(new Point(700, 100));
            points.Add(new Point(50, 250));
            points.Add(new Point(700, 250));
            points.Add(new Point(375, 50));

            workers = new BackgroundWorker[4];
            workers[0] = bgwG1;
            workers[1] = bgwG2;
            workers[2] = bgwG3;
            workers[3] = bgwG4;
        }
        private void bgwG_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox pcb = e.UserState as PictureBox;
            Change(pcb);
        }
        private void bgwG_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fatto[int.Parse(e.Result.ToString())] = true;
        }
        private void bgwBanco_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox pcb = e.UserState as PictureBox;
            if (e.ProgressPercentage == 0)
                Change(pcb);
            else
            {
                Invoke(new Action(() =>
                {
                    Refresh();
                }));
            }
        }
        private void bgwBanco_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int banco = int.Parse(e.Result.ToString());
            if (banco > 21)
            {
                if (punteggi[0] <= 21)
                    TxtW(0);
                else
                    TxtL(0);
                if (punteggi[1] <= 21)
                    TxtW(1);
                else
                    TxtL(1);
                if (punteggi[2] <= 21)
                    TxtW(2);
                else
                    TxtL(2);
                if (punteggi[3] <= 21)
                    TxtW(3);
                else
                    TxtL(3);
            }
            else
            {
                if (punteggi[0] > banco && punteggi[0] <= 21)
                    TxtW(0);
                else
                    TxtL(0);
                if (punteggi[1] > banco && punteggi[1] <= 21)
                    TxtW(1);
                else
                    TxtL(1);
                if (punteggi[2] > banco && punteggi[2] <= 21)
                    TxtW(2);
                else
                    TxtL(2);
                if (punteggi[3] > banco && punteggi[3] <= 21)
                    TxtW(3);
                else
                    TxtL(3);
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            points[0] = new Point(50, 100);
            points[1] = new Point(700, 100);
            points[2] = new Point(50, 350);
            points[3] = new Point(700, 350);
            points[4] = new Point(375, 50);

            Thread.Sleep(500);
            Refresh();
            Thread.Sleep(500);

            ok = false;
            for (int i = 0; i < 4; i++)
                soldi[i] = 10;

            txt1.Text = soldi[0].ToString();
            txt2.Text = soldi[1].ToString();
            txt3.Text = soldi[2].ToString();
            txt4.Text = soldi[3].ToString();

            bgwGame.RunWorkerAsync();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
        private void CaricaCarte(List<Carta> lc)
        {
            string[] str = File.ReadAllLines("carte.txt");
            foreach (string elem in str)
            {
                string[] line = elem.Split(';');
                lc.Add(new Carta(Image.FromFile(line[0]), int.Parse(line[1])));
            }
        }
        private void GeneraPCB(PictureBox pcb, List<Carta> g, int k)
        {
            pcb.Name = string.Format("pcb{0}_{1}", k, g.Count);
            pcb.Image = g[g.Count - 1].Image;
            pcb.BackColor = Color.Transparent;
            pcb.Size = new Size(100, 157);
            pcb.Location = points[k];
            pcb.Visible = true;
            pcb.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Change(PictureBox pcb)
        {
            Invoke(new Action(() =>
            {
                lock (this.Controls)
                    this.Controls.Add(pcb);
                pcb.BringToFront();
            }));
        }
        private void TxtW(int k)
        {
            Invoke(new Action(() =>
            {
                soldi[k] += (Int32)(puntata[k] * 1.5) + 1;
                texts[k].Text = soldi[k].ToString();
            }));
        }
        private void TxtL(int k)
        {
            Invoke(new Action(() =>
            {
                texts[k].Text = soldi[k].ToString();
            }));
        }
        private void bgwGame_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (!worker.CancellationPending && (soldi[0] > 0 || soldi[1] > 0 || soldi[2] > 0 || soldi[3] > 0)) 
            {
                for (int i = 0; i < 4; i++)
                    if(soldi[i] > 0)
                    fatto[i] = false;
                bgwBanco.RunWorkerAsync(4);
                if (soldi[0] > 0)
                    workers[0].RunWorkerAsync(0);
                for (int i = 1; i < 4; i++)
                {
                    if (soldi[i] > 0)
                    {
                        while (workers[i - 1].IsBusy)
                            Thread.Sleep(1500);
                        workers[i].RunWorkerAsync(i);
                    }
                }

                while (bgwBanco.IsBusy || bgwG4.IsBusy)
                    Thread.Sleep(1500);

                worker.ReportProgress(0);
                Thread.Sleep(1000);
            }
        }
        private void bgwGame_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            points[0] = new Point(50, 100);
            points[1] = new Point(700, 100);
            points[2] = new Point(50, 350);
            points[3] = new Point(700, 350);
            points[4] = new Point(375, 50);

            List<Control> lc = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    lc.Add(control);
                }
            }
            foreach (Control elem in lc)
            {
                Invoke(new Action(() =>
                {
                    this.Controls.Remove(elem);
                    elem.Dispose();
                }));                
            }
            lc = null;
            Thread.Sleep(500);
            Invoke(new Action(() =>
            {
                Refresh();
            }));

            Thread.Sleep(1000);
        }
        private void bgwGame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            MessageBox.Show(string.Format("G1 ha {0} fiches \nG2 ha {1} fiches \nG3 ha {2} fiches \nG4 ha {3} fiches", soldi[0], soldi[1], soldi[2], soldi[3]));
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            bgwGame.CancelAsync();
            btnStop.Enabled = false;
        }
    }
}

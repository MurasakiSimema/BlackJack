namespace BlackJack
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bgwBanco = new System.ComponentModel.BackgroundWorker();
            this.bgwG1 = new System.ComponentModel.BackgroundWorker();
            this.bgwG2 = new System.ComponentModel.BackgroundWorker();
            this.bgwG3 = new System.ComponentModel.BackgroundWorker();
            this.bgwG4 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.bgwGame = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgwBanco
            // 
            this.bgwBanco.WorkerReportsProgress = true;
            this.bgwBanco.WorkerSupportsCancellation = true;
            this.bgwBanco.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBanco_DoWork);
            this.bgwBanco.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwBanco_ProgressChanged);
            this.bgwBanco.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBanco_RunWorkerCompleted);
            // 
            // bgwG1
            // 
            this.bgwG1.WorkerReportsProgress = true;
            this.bgwG1.WorkerSupportsCancellation = true;
            this.bgwG1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwG_DoWork);
            this.bgwG1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwG_ProgressChanged);
            this.bgwG1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwG_RunWorkerCompleted);
            // 
            // bgwG2
            // 
            this.bgwG2.WorkerReportsProgress = true;
            this.bgwG2.WorkerSupportsCancellation = true;
            this.bgwG2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwG_DoWork);
            this.bgwG2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwG_ProgressChanged);
            this.bgwG2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwG_RunWorkerCompleted);
            // 
            // bgwG3
            // 
            this.bgwG3.WorkerReportsProgress = true;
            this.bgwG3.WorkerSupportsCancellation = true;
            this.bgwG3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwG_DoWork);
            this.bgwG3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwG_ProgressChanged);
            this.bgwG3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwG_RunWorkerCompleted);
            // 
            // bgwG4
            // 
            this.bgwG4.WorkerReportsProgress = true;
            this.bgwG4.WorkerSupportsCancellation = true;
            this.bgwG4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwG_DoWork);
            this.bgwG4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwG_ProgressChanged);
            this.bgwG4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwG_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(448, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "G1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "G2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "G3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "G4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Banco";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(82, 56);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(56, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(82, 288);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(56, 20);
            this.txt3.TabIndex = 7;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(703, 56);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(56, 20);
            this.txt2.TabIndex = 8;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(703, 288);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(56, 20);
            this.txt4.TabIndex = 9;
            // 
            // bgwGame
            // 
            this.bgwGame.WorkerReportsProgress = true;
            this.bgwGame.WorkerSupportsCancellation = true;
            this.bgwGame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGame_DoWork);
            this.bgwGame.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwGame_ProgressChanged);
            this.bgwGame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwGame_RunWorkerCompleted);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(448, 265);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwBanco;
        private System.ComponentModel.BackgroundWorker bgwG1;
        private System.ComponentModel.BackgroundWorker bgwG2;
        private System.ComponentModel.BackgroundWorker bgwG3;
        private System.ComponentModel.BackgroundWorker bgwG4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.ComponentModel.BackgroundWorker bgwGame;
        private System.Windows.Forms.Button btnStop;
    }
}


namespace progressBar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbar
            // 
            this.pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbar.AnimationSpeed = 500;
            this.pbar.BackColor = System.Drawing.Color.Transparent;
            this.pbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbar.ForeColor = System.Drawing.Color.DarkGray;
            this.pbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pbar.InnerMargin = 2;
            this.pbar.InnerWidth = -1;
            this.pbar.Location = new System.Drawing.Point(91, 28);
            this.pbar.MarqueeAnimationSpeed = 2000;
            this.pbar.Name = "pbar";
            this.pbar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pbar.OuterMargin = -25;
            this.pbar.OuterWidth = 26;
            this.pbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pbar.ProgressWidth = 18;
            this.pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbar.Size = new System.Drawing.Size(616, 380);
            this.pbar.StartAngle = 270;
            this.pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbar.SubscriptText = "";
            this.pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbar.SuperscriptText = "°C";
            this.pbar.TabIndex = 0;
            this.pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pbar;
        private System.Windows.Forms.Timer timer1;
    }
}


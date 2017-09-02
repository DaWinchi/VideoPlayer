namespace VideoPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Open = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VideoPlayer.Properties.Resources._1;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 582);
            this.panel1.TabIndex = 0;
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Black;
            this.Open.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Open.Location = new System.Drawing.Point(407, 34);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(196, 62);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open...";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Black;
            this.Play.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Play.Location = new System.Drawing.Point(3, 34);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(196, 62);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Black;
            this.Pause.Font = new System.Drawing.Font("Mathematica6", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pause.Location = new System.Drawing.Point(205, 34);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(196, 62);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Black;
            this.Volume.Location = new System.Drawing.Point(609, 34);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(307, 45);
            this.Volume.TabIndex = 4;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.Volume);
            this.panel2.Controls.Add(this.Play);
            this.panel2.Controls.Add(this.Open);
            this.panel2.Controls.Add(this.Pause);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 99);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoPlayer.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}


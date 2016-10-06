namespace samPingPong
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.gameOver = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(16, 32);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Aqua;
            this.racket.Location = new System.Drawing.Point(126, 257);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(50, 10);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            this.racket.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Linen;
            this.playground.Controls.Add(this.gameOver);
            this.playground.Controls.Add(this.points);
            this.playground.Controls.Add(this.score);
            this.playground.Controls.Add(this.racket);
            this.playground.Controls.Add(this.ball);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(421, 305);
            this.playground.TabIndex = 2;
            this.playground.Paint += new System.Windows.Forms.PaintEventHandler(this.playground_Paint);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.Location = new System.Drawing.Point(121, 41);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(160, 192);
            this.gameOver.TabIndex = 4;
            this.gameOver.Text = "Game Over\r\n\r\nPress ESC to End\r\nPress S \r\nto Restart\r\n\r\n\r\n\r\n";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Click += new System.EventHandler(this.gameOver_Click);
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.Location = new System.Drawing.Point(94, 10);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(18, 20);
            this.points.TabIndex = 3;
            this.points.Text = "0";
            this.points.Click += new System.EventHandler(this.label1_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(81, 20);
            this.score.TabIndex = 2;
            this.score.Text = "SCORE :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 305);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gameOver;
    }
}


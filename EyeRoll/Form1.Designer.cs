
namespace EyeRoll
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VisibleButton = new System.Windows.Forms.Button();
            this.Tools = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Width_TextBox = new System.Windows.Forms.TextBox();
            this.Height_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MoveType = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.UserUpDownTimer = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.DomainUpDown();
            this.Speed = new System.Windows.Forms.DomainUpDown();
            this.Movement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackColor1 = new System.Windows.Forms.Button();
            this.BackColor2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.SecTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VisibleButton
            // 
            this.VisibleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisibleButton.Location = new System.Drawing.Point(1252, 13);
            this.VisibleButton.Margin = new System.Windows.Forms.Padding(4);
            this.VisibleButton.Name = "VisibleButton";
            this.VisibleButton.Size = new System.Drawing.Size(123, 28);
            this.VisibleButton.TabIndex = 0;
            this.VisibleButton.Text = "visible";
            this.VisibleButton.UseVisualStyleBackColor = true;
            this.VisibleButton.Click += new System.EventHandler(this.VisibleButton_Click);
            // 
            // Tools
            // 
            this.Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools.BackColor = System.Drawing.SystemColors.Control;
            this.Tools.Controls.Add(this.label10);
            this.Tools.Controls.Add(this.Width_TextBox);
            this.Tools.Controls.Add(this.Height_TextBox);
            this.Tools.Controls.Add(this.label8);
            this.Tools.Controls.Add(this.label7);
            this.Tools.Controls.Add(this.label9);
            this.Tools.Controls.Add(this.Direction);
            this.Tools.Controls.Add(this.label6);
            this.Tools.Controls.Add(this.MoveType);
            this.Tools.Controls.Add(this.StopButton);
            this.Tools.Controls.Add(this.Start);
            this.Tools.Controls.Add(this.label5);
            this.Tools.Controls.Add(this.UserUpDownTimer);
            this.Tools.Controls.Add(this.label4);
            this.Tools.Controls.Add(this.label3);
            this.Tools.Controls.Add(this.Size);
            this.Tools.Controls.Add(this.Speed);
            this.Tools.Controls.Add(this.Movement);
            this.Tools.Controls.Add(this.label2);
            this.Tools.Controls.Add(this.label1);
            this.Tools.Controls.Add(this.BackColor1);
            this.Tools.Controls.Add(this.BackColor2);
            this.Tools.Controls.Add(this.button4);
            this.Tools.Controls.Add(this.RedButton);
            this.Tools.Controls.Add(this.BlueButton);
            this.Tools.Controls.Add(this.GreenButton);
            this.Tools.Location = new System.Drawing.Point(1252, 49);
            this.Tools.Margin = new System.Windows.Forms.Padding(4);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(288, 789);
            this.Tools.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Type";
            // 
            // Width_TextBox
            // 
            this.Width_TextBox.Location = new System.Drawing.Point(119, 352);
            this.Width_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Width_TextBox.Name = "Width_TextBox";
            this.Width_TextBox.Size = new System.Drawing.Size(49, 22);
            this.Width_TextBox.TabIndex = 7;
            // 
            // Height_TextBox
            // 
            this.Height_TextBox.Location = new System.Drawing.Point(119, 389);
            this.Height_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Height_TextBox.Name = "Height_TextBox";
            this.Height_TextBox.Size = new System.Drawing.Size(49, 22);
            this.Height_TextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Horizontal, mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Direction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Vertical, mm";
            // 
            // Direction
            // 
            this.Direction.FormattingEnabled = true;
            this.Direction.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.Direction.Location = new System.Drawing.Point(119, 228);
            this.Direction.Margin = new System.Windows.Forms.Padding(4);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(143, 24);
            this.Direction.TabIndex = 19;
            this.Direction.Text = "Horizontal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Movement type";
            // 
            // MoveType
            // 
            this.MoveType.FormattingEnabled = true;
            this.MoveType.Items.AddRange(new object[] {
            "step",
            "smooth"});
            this.MoveType.Location = new System.Drawing.Point(119, 194);
            this.MoveType.Margin = new System.Windows.Forms.Padding(4);
            this.MoveType.Name = "MoveType";
            this.MoveType.Size = new System.Drawing.Size(143, 24);
            this.MoveType.TabIndex = 17;
            this.MoveType.Text = "smooth";
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopButton.Location = new System.Drawing.Point(8, 748);
            this.StopButton.Margin = new System.Windows.Forms.Padding(4);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(117, 28);
            this.StopButton.TabIndex = 16;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start.Location = new System.Drawing.Point(155, 748);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 28);
            this.Start.TabIndex = 15;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Timer, min";
            // 
            // UserUpDownTimer
            // 
            this.UserUpDownTimer.Items.Add("15");
            this.UserUpDownTimer.Items.Add("14");
            this.UserUpDownTimer.Items.Add("13");
            this.UserUpDownTimer.Items.Add("12");
            this.UserUpDownTimer.Items.Add("11");
            this.UserUpDownTimer.Items.Add("10");
            this.UserUpDownTimer.Items.Add("9");
            this.UserUpDownTimer.Items.Add("8");
            this.UserUpDownTimer.Items.Add("7");
            this.UserUpDownTimer.Items.Add("6");
            this.UserUpDownTimer.Items.Add("5");
            this.UserUpDownTimer.Items.Add("4");
            this.UserUpDownTimer.Items.Add("3");
            this.UserUpDownTimer.Items.Add("2");
            this.UserUpDownTimer.Items.Add("1");
            this.UserUpDownTimer.Location = new System.Drawing.Point(187, 162);
            this.UserUpDownTimer.Margin = new System.Windows.Forms.Padding(4);
            this.UserUpDownTimer.Name = "UserUpDownTimer";
            this.UserUpDownTimer.Size = new System.Drawing.Size(76, 22);
            this.UserUpDownTimer.TabIndex = 13;
            this.UserUpDownTimer.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Circle size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed of movement";
            // 
            // Size
            // 
            this.Size.Items.Add("10");
            this.Size.Items.Add("9");
            this.Size.Items.Add("8");
            this.Size.Items.Add("7");
            this.Size.Items.Add("6");
            this.Size.Items.Add("5");
            this.Size.Items.Add("4");
            this.Size.Items.Add("3");
            this.Size.Items.Add("2");
            this.Size.Items.Add("1");
            this.Size.Location = new System.Drawing.Point(187, 133);
            this.Size.Margin = new System.Windows.Forms.Padding(4);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(76, 22);
            this.Size.TabIndex = 10;
            this.Size.Text = "1";
            this.Size.SelectedItemChanged += new System.EventHandler(this.Size_SelectedItemChanged);
            // 
            // Speed
            // 
            this.Speed.Items.Add("3");
            this.Speed.Items.Add("2");
            this.Speed.Items.Add("1");
            this.Speed.Location = new System.Drawing.Point(187, 101);
            this.Speed.Margin = new System.Windows.Forms.Padding(4);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(76, 22);
            this.Speed.TabIndex = 9;
            this.Speed.Text = "1";
            // 
            // Movement
            // 
            this.Movement.FormattingEnabled = true;
            this.Movement.Location = new System.Drawing.Point(119, 68);
            this.Movement.Margin = new System.Windows.Forms.Padding(4);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(142, 24);
            this.Movement.TabIndex = 8;
            this.Movement.Text = "Circle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Background color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Circle color";
            // 
            // BackColor1
            // 
            this.BackColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackColor1.Location = new System.Drawing.Point(189, 36);
            this.BackColor1.Margin = new System.Windows.Forms.Padding(4);
            this.BackColor1.Name = "BackColor1";
            this.BackColor1.Size = new System.Drawing.Size(27, 25);
            this.BackColor1.TabIndex = 5;
            this.BackColor1.UseVisualStyleBackColor = false;
            this.BackColor1.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // BackColor2
            // 
            this.BackColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackColor2.Location = new System.Drawing.Point(223, 36);
            this.BackColor2.Margin = new System.Windows.Forms.Padding(4);
            this.BackColor2.Name = "BackColor2";
            this.BackColor2.Size = new System.Drawing.Size(27, 25);
            this.BackColor2.TabIndex = 4;
            this.BackColor2.UseVisualStyleBackColor = false;
            this.BackColor2.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(257, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 25);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BackgroundColorButtonClick);
            // 
            // RedButton
            // 
            this.RedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RedButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedButton.Location = new System.Drawing.Point(189, 4);
            this.RedButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(27, 25);
            this.RedButton.TabIndex = 2;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // BlueButton
            // 
            this.BlueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.BlueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BlueButton.Location = new System.Drawing.Point(223, 4);
            this.BlueButton.Margin = new System.Windows.Forms.Padding(4);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(27, 25);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // GreenButton
            // 
            this.GreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.GreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GreenButton.Location = new System.Drawing.Point(257, 4);
            this.GreenButton.Margin = new System.Windows.Forms.Padding(4);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(27, 25);
            this.GreenButton.TabIndex = 0;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.ForegroundColorButtonClick);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Black;
            this.Ball.Location = new System.Drawing.Point(439, 261);
            this.Ball.Margin = new System.Windows.Forms.Padding(4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 18);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 20;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Timer
            // 
            this.Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(1438, 19);
            this.Timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(39, 17);
            this.Timer.TabIndex = 3;
            this.Timer.Text = "Time";
            // 
            // SecTimer
            // 
            this.SecTimer.Interval = 1000;
            this.SecTimer.Tick += new System.EventHandler(this.SecTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1541, 838);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.ClientSizeChanged += new System.EventHandler(this.WhenPictureBoxChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 838);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.VisibleButton);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Eye roll";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisibleButton;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Button BackColor1;
        private System.Windows.Forms.Button BackColor2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Movement;
        private new System.Windows.Forms.DomainUpDown Size;
        private System.Windows.Forms.DomainUpDown Speed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown UserUpDownTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MoveType;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer SecTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Direction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Width_TextBox;
        private System.Windows.Forms.TextBox Height_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}


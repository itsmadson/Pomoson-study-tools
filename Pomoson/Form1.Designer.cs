namespace Pomoson
{
    partial class Pomoson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomoson));
            this.lblTimer = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnToggleNightLight = new System.Windows.Forms.PictureBox();
            this.btnLofi = new System.Windows.Forms.PictureBox();
            this.btnWhiteNoise = new System.Windows.Forms.PictureBox();
            this.btnIncrease = new System.Windows.Forms.PictureBox();
            this.btnDecrease = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.AddTaskButton = new System.Windows.Forms.PictureBox();
            this.RemoveTaskButton = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleNightLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLofi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhiteNoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecrease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTaskButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveTaskButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Vermin Vibes 1989", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTimer.Location = new System.Drawing.Point(54, 153);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(105, 32);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "25:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskTextBox
            // 
            this.taskTextBox.BackColor = System.Drawing.Color.Teal;
            this.taskTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.taskTextBox.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.taskTextBox.Location = new System.Drawing.Point(40, 319);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(224, 23);
            this.taskTextBox.TabIndex = 5;
            this.taskTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskTextBox_KeyDown);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.checkedListBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(33, 357);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(233, 140);
            this.checkedListBox1.TabIndex = 6;
            // 
            // btnToggleNightLight
            // 
            this.btnToggleNightLight.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleNightLight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToggleNightLight.BackgroundImage")));
            this.btnToggleNightLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnToggleNightLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleNightLight.Location = new System.Drawing.Point(289, 133);
            this.btnToggleNightLight.Name = "btnToggleNightLight";
            this.btnToggleNightLight.Size = new System.Drawing.Size(74, 90);
            this.btnToggleNightLight.TabIndex = 12;
            this.btnToggleNightLight.TabStop = false;
            this.btnToggleNightLight.Click += new System.EventHandler(this.btnToggleNightLight_Click);
            // 
            // btnLofi
            // 
            this.btnLofi.BackColor = System.Drawing.Color.Transparent;
            this.btnLofi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLofi.BackgroundImage")));
            this.btnLofi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLofi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLofi.Location = new System.Drawing.Point(285, 260);
            this.btnLofi.Name = "btnLofi";
            this.btnLofi.Size = new System.Drawing.Size(74, 131);
            this.btnLofi.TabIndex = 13;
            this.btnLofi.TabStop = false;
            this.btnLofi.Click += new System.EventHandler(this.btnLofi_Click);
            // 
            // btnWhiteNoise
            // 
            this.btnWhiteNoise.BackColor = System.Drawing.Color.Transparent;
            this.btnWhiteNoise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhiteNoise.BackgroundImage")));
            this.btnWhiteNoise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWhiteNoise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhiteNoise.Location = new System.Drawing.Point(288, 397);
            this.btnWhiteNoise.Name = "btnWhiteNoise";
            this.btnWhiteNoise.Size = new System.Drawing.Size(74, 131);
            this.btnWhiteNoise.TabIndex = 14;
            this.btnWhiteNoise.TabStop = false;
            this.btnWhiteNoise.Click += new System.EventHandler(this.btnWhiteNoise_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.BackColor = System.Drawing.Color.Transparent;
            this.btnIncrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncrease.BackgroundImage")));
            this.btnIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncrease.Location = new System.Drawing.Point(201, 101);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(85, 21);
            this.btnIncrease.TabIndex = 15;
            this.btnIncrease.TabStop = false;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecrease.BackgroundImage")));
            this.btnDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrease.Location = new System.Drawing.Point(201, 214);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(85, 21);
            this.btnDecrease.TabIndex = 16;
            this.btnDecrease.TabStop = false;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(200, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 29);
            this.btnStart.TabIndex = 17;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(200, 170);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 29);
            this.btnReset.TabIndex = 18;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddTaskButton.BackgroundImage")));
            this.AddTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTaskButton.Location = new System.Drawing.Point(99, 296);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(81, 20);
            this.AddTaskButton.TabIndex = 19;
            this.AddTaskButton.TabStop = false;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // RemoveTaskButton
            // 
            this.RemoveTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveTaskButton.BackgroundImage")));
            this.RemoveTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveTaskButton.Location = new System.Drawing.Point(177, 296);
            this.RemoveTaskButton.Name = "RemoveTaskButton";
            this.RemoveTaskButton.Size = new System.Drawing.Size(81, 20);
            this.RemoveTaskButton.TabIndex = 20;
            this.RemoveTaskButton.TabStop = false;
            this.RemoveTaskButton.Click += new System.EventHandler(this.RemoveTaskButton_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Location = new System.Drawing.Point(79, 42);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 27);
            this.btnexit.TabIndex = 21;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmin.BackgroundImage")));
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.Location = new System.Drawing.Point(112, 44);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(30, 27);
            this.btnmin.TabIndex = 22;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.status.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.status.Location = new System.Drawing.Point(56, 540);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(287, 16);
            this.status.TabIndex = 23;
            this.status.Text = "Madson\'s creation!, hope you enjoy it (=";
            // 
            // Pomoson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 561);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.RemoveTaskButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnWhiteNoise);
            this.Controls.Add(this.btnLofi);
            this.Controls.Add(this.btnToggleNightLight);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.lblTimer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pomoson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomoson";
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleNightLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLofi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhiteNoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDecrease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTaskButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveTaskButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox btnToggleNightLight;
        private System.Windows.Forms.PictureBox btnLofi;
        private System.Windows.Forms.PictureBox btnWhiteNoise;
        private System.Windows.Forms.PictureBox btnIncrease;
        private System.Windows.Forms.PictureBox btnDecrease;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.PictureBox AddTaskButton;
        private System.Windows.Forms.PictureBox RemoveTaskButton;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.Label status;
    }
}


namespace TaskTimeTracker.Forms
{
    partial class MainForm
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
            txtTaskName = new TextBox();
            btnStart = new Button();
            btnStop = new Button();
            lstTaskHistory = new ListBox();
            lblTimer = new Label();
            btnShowHistory = new Button();
            SuspendLayout();
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(25, 18);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(241, 27);
            txtTaskName.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(35, 187);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Başlat";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(168, 187);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 2;
            btnStop.Text = "Durdur";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click_1;
            // 
            // lstTaskHistory
            // 
            lstTaskHistory.FormattingEnabled = true;
            lstTaskHistory.Location = new Point(25, 51);
            lstTaskHistory.Name = "lstTaskHistory";
            lstTaskHistory.Size = new Size(241, 104);
            lstTaskHistory.TabIndex = 3;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(25, 233);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(42, 20);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "label";
            // 
            // btnShowHistory
            // 
            btnShowHistory.Location = new Point(85, 233);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(181, 31);
            btnShowHistory.TabIndex = 5;
            btnShowHistory.Text = "Geçmiş";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnShowHistory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowHistory);
            Controls.Add(lblTimer);
            Controls.Add(lstTaskHistory);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtTaskName);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaskName;
        private Button btnStart;
        private Button btnStop;
        private ListBox lstTaskHistory;
        private Label lblTimer;
        private Button btnShowHistory;
    }
}
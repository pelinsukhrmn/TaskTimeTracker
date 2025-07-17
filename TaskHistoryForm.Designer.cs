namespace TaskTimeTracker.Forms
{
    partial class TaskHistoryForm
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
            lstHistory = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(56, 38);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(496, 184);
            lstHistory.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(56, 228);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(496, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // TaskHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(lstHistory);
            Name = "TaskHistoryForm";
            Text = "TaskHistoryForm";
            Load += TaskHistoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstHistory;
        private Button btnClose;
    }
}
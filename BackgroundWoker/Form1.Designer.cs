namespace BackgroundWoker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultLabel = new Label();
            startAasyncButton = new Button();
            cancelAsyncButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(79, -1);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 0;
            // 
            // startAasyncButton
            // 
            startAasyncButton.Location = new Point(0, 41);
            startAasyncButton.Margin = new Padding(3, 4, 3, 4);
            startAasyncButton.Name = "startAasyncButton";
            startAasyncButton.Size = new Size(86, 31);
            startAasyncButton.TabIndex = 1;
            startAasyncButton.Text = "Start";
            startAasyncButton.UseVisualStyleBackColor = true;
            startAasyncButton.Click += startAasyncButton_Click;
            // 
            // cancelAsyncButton
            // 
            cancelAsyncButton.Location = new Point(123, 41);
            cancelAsyncButton.Margin = new Padding(3, 4, 3, 4);
            cancelAsyncButton.Name = "cancelAsyncButton";
            cancelAsyncButton.Size = new Size(86, 31);
            cancelAsyncButton.TabIndex = 2;
            cancelAsyncButton.Text = "Cancel";
            cancelAsyncButton.UseVisualStyleBackColor = true;
            cancelAsyncButton.Click += cancelAsyncButton_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cancelAsyncButton);
            Controls.Add(startAasyncButton);
            Controls.Add(resultLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Button startAasyncButton;
        private Button cancelAsyncButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

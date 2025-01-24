namespace _24._01
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
            Horse1 = new ProgressBar();
            Horse2 = new ProgressBar();
            Horse3 = new ProgressBar();
            Horse4 = new ProgressBar();
            Horse5 = new ProgressBar();
            Start = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // Horse1
            // 
            Horse1.Location = new Point(203, 58);
            Horse1.Name = "Horse1";
            Horse1.Size = new Size(100, 23);
            Horse1.TabIndex = 0;
            // 
            // Horse2
            // 
            Horse2.Location = new Point(203, 98);
            Horse2.Name = "Horse2";
            Horse2.Size = new Size(100, 23);
            Horse2.TabIndex = 1;
            // 
            // Horse3
            // 
            Horse3.Location = new Point(203, 151);
            Horse3.Name = "Horse3";
            Horse3.Size = new Size(100, 23);
            Horse3.TabIndex = 2;
            // 
            // Horse4
            // 
            Horse4.Location = new Point(203, 201);
            Horse4.Name = "Horse4";
            Horse4.Size = new Size(100, 23);
            Horse4.TabIndex = 3;
            // 
            // Horse5
            // 
            Horse5.Location = new Point(203, 248);
            Horse5.Name = "Horse5";
            Horse5.Size = new Size(100, 23);
            Horse5.TabIndex = 4;
            // 
            // Start
            // 
            Start.Location = new Point(215, 304);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 5;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // result
            // 
            result.Location = new Point(463, 98);
            result.Name = "result";
            result.Size = new Size(199, 129);
            result.TabIndex = 6;
            result.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(Start);
            Controls.Add(Horse5);
            Controls.Add(Horse4);
            Controls.Add(Horse3);
            Controls.Add(Horse2);
            Controls.Add(Horse1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar Horse1;
        private ProgressBar Horse2;
        private ProgressBar Horse3;
        private ProgressBar Horse4;
        private ProgressBar Horse5;
        private Button Start;
        private Label result;
    }
}

namespace Student
{
    partial class Main
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
            this.Panel_Loading = new System.Windows.Forms.Panel();
            this.Label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Panel_Answer = new System.Windows.Forms.Panel();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.Panel_Loading.SuspendLayout();
            this.Panel_Answer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Loading
            // 
            this.Panel_Loading.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_Loading.Controls.Add(this.Label);
            this.Panel_Loading.Controls.Add(this.progressBar1);
            this.Panel_Loading.Location = new System.Drawing.Point(20, 20);
            this.Panel_Loading.Margin = new System.Windows.Forms.Padding(10);
            this.Panel_Loading.Name = "Panel_Loading";
            this.Panel_Loading.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Loading.Size = new System.Drawing.Size(444, 100);
            this.Panel_Loading.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(10, 10);
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(424, 39);
            this.Label.TabIndex = 1;
            this.Label.Text = "Waiting for Question...";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 57);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListenForQuestion);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FoundQuestion);
            // 
            // Panel_Answer
            // 
            this.Panel_Answer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_Answer.Controls.Add(this.Button_Send);
            this.Panel_Answer.Controls.Add(this.Input);
            this.Panel_Answer.Controls.Add(this.Output);
            this.Panel_Answer.Location = new System.Drawing.Point(20, 42);
            this.Panel_Answer.Margin = new System.Windows.Forms.Padding(10);
            this.Panel_Answer.Name = "Panel_Answer";
            this.Panel_Answer.Padding = new System.Windows.Forms.Padding(10);
            this.Panel_Answer.Size = new System.Drawing.Size(444, 50);
            this.Panel_Answer.TabIndex = 2;
            this.Panel_Answer.Visible = false;
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.Location = new System.Drawing.Point(357, 6);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(77, 38);
            this.Button_Send.TabIndex = 2;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(199, 6);
            this.Input.Margin = new System.Windows.Forms.Padding(5);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(153, 38);
            this.Input.TabIndex = 1;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.Margin = new System.Windows.Forms.Padding(10);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.Output.Size = new System.Drawing.Size(202, 50);
            this.Output.TabIndex = 0;
            this.Output.Text = "1000 x 1000 =";
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(484, 141);
            this.Controls.Add(this.Panel_Loading);
            this.Controls.Add(this.Panel_Answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(500, 180);
            this.MinimumSize = new System.Drawing.Size(500, 180);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.Panel_Loading.ResumeLayout(false);
            this.Panel_Answer.ResumeLayout(false);
            this.Panel_Answer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Loading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel Panel_Answer;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Button_Send;
    }
}
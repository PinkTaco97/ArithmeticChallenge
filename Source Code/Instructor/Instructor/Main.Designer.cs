namespace Instructor
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
            this.Panel_Question = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Input_Operator = new System.Windows.Forms.ComboBox();
            this.Input_Answer = new System.Windows.Forms.TextBox();
            this.Input_B = new System.Windows.Forms.NumericUpDown();
            this.Input_A = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Array = new System.Windows.Forms.Panel();
            this.Panel_LinkedList = new System.Windows.Forms.Panel();
            this.Panel_BinaryTree = new System.Windows.Forms.Panel();
            this.Panel_Question.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_A)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Question
            // 
            this.Panel_Question.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel_Question.Controls.Add(this.panel1);
            this.Panel_Question.Controls.Add(this.label1);
            this.Panel_Question.Location = new System.Drawing.Point(15, 15);
            this.Panel_Question.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Question.Name = "Panel_Question";
            this.Panel_Question.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Question.Size = new System.Drawing.Size(276, 207);
            this.Panel_Question.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.Button_Send);
            this.panel1.Controls.Add(this.Input_Operator);
            this.panel1.Controls.Add(this.Input_A);
            this.panel1.Controls.Add(this.Input_Answer);
            this.panel1.Controls.Add(this.Input_B);
            this.panel1.Location = new System.Drawing.Point(8, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(253, 136);
            this.panel1.TabIndex = 2;
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.Location = new System.Drawing.Point(15, 87);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(10);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(220, 34);
            this.Button_Send.TabIndex = 6;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            // 
            // Input_Operator
            // 
            this.Input_Operator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Input_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Operator.FormattingEnabled = true;
            this.Input_Operator.Location = new System.Drawing.Point(95, 15);
            this.Input_Operator.Margin = new System.Windows.Forms.Padding(10);
            this.Input_Operator.Name = "Input_Operator";
            this.Input_Operator.Size = new System.Drawing.Size(60, 28);
            this.Input_Operator.TabIndex = 5;
            // 
            // Input_Answer
            // 
            this.Input_Answer.Enabled = false;
            this.Input_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Answer.Location = new System.Drawing.Point(15, 50);
            this.Input_Answer.Margin = new System.Windows.Forms.Padding(10);
            this.Input_Answer.Name = "Input_Answer";
            this.Input_Answer.Size = new System.Drawing.Size(220, 29);
            this.Input_Answer.TabIndex = 4;
            // 
            // Input_B
            // 
            this.Input_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_B.Location = new System.Drawing.Point(175, 15);
            this.Input_B.Margin = new System.Windows.Forms.Padding(10);
            this.Input_B.Name = "Input_B";
            this.Input_B.Size = new System.Drawing.Size(60, 27);
            this.Input_B.TabIndex = 2;
            // 
            // Input_A
            // 
            this.Input_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_A.Location = new System.Drawing.Point(15, 15);
            this.Input_A.Margin = new System.Windows.Forms.Padding(10);
            this.Input_A.Name = "Input_A";
            this.Input_A.Size = new System.Drawing.Size(60, 27);
            this.Input_A.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Array
            // 
            this.Panel_Array.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_Array.Location = new System.Drawing.Point(301, 15);
            this.Panel_Array.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Array.Name = "Panel_Array";
            this.Panel_Array.Size = new System.Drawing.Size(668, 207);
            this.Panel_Array.TabIndex = 0;
            // 
            // Panel_LinkedList
            // 
            this.Panel_LinkedList.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_LinkedList.Location = new System.Drawing.Point(15, 422);
            this.Panel_LinkedList.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_LinkedList.Name = "Panel_LinkedList";
            this.Panel_LinkedList.Size = new System.Drawing.Size(954, 83);
            this.Panel_LinkedList.TabIndex = 1;
            // 
            // Panel_BinaryTree
            // 
            this.Panel_BinaryTree.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_BinaryTree.Location = new System.Drawing.Point(15, 515);
            this.Panel_BinaryTree.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_BinaryTree.Name = "Panel_BinaryTree";
            this.Panel_BinaryTree.Size = new System.Drawing.Size(954, 181);
            this.Panel_BinaryTree.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.Panel_BinaryTree);
            this.Controls.Add(this.Panel_LinkedList);
            this.Controls.Add(this.Panel_Array);
            this.Controls.Add(this.Panel_Question);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Main";
            this.Panel_Question.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_A)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Question;
        private System.Windows.Forms.Panel Panel_Array;
        private System.Windows.Forms.Panel Panel_LinkedList;
        private System.Windows.Forms.Panel Panel_BinaryTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Input_A;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Input_B;
        private System.Windows.Forms.ComboBox Input_Operator;
        private System.Windows.Forms.TextBox Input_Answer;
        private System.Windows.Forms.Button Button_Send;
    }
}
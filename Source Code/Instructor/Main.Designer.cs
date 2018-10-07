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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_Question = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Random = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Input_A = new System.Windows.Forms.NumericUpDown();
            this.Output_Answer = new System.Windows.Forms.TextBox();
            this.Input_Operator = new System.Windows.Forms.ComboBox();
            this.Input_B = new System.Windows.Forms.NumericUpDown();
            this.ArrayDataTable = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BinaryTreeView = new System.Windows.Forms.TreeView();
            this.Panel_Waiting = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Panel_Question.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayDataTable)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Panel_Waiting.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Question
            // 
            this.Panel_Question.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel_Question.Controls.Add(this.panel1);
            this.Panel_Question.Location = new System.Drawing.Point(15, 603);
            this.Panel_Question.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Question.Name = "Panel_Question";
            this.Panel_Question.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Question.Size = new System.Drawing.Size(954, 89);
            this.Panel_Question.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.Button_Random);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Button_Send);
            this.panel1.Controls.Add(this.Input_A);
            this.panel1.Controls.Add(this.Output_Answer);
            this.panel1.Controls.Add(this.Input_Operator);
            this.panel1.Controls.Add(this.Input_B);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(936, 68);
            this.panel1.TabIndex = 2;
            // 
            // Button_Random
            // 
            this.Button_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Random.Location = new System.Drawing.Point(680, 16);
            this.Button_Random.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(129, 38);
            this.Button_Random.TabIndex = 6;
            this.Button_Random.Text = "Random";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Send
            // 
            this.Button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.Location = new System.Drawing.Point(817, 16);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(5);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(109, 38);
            this.Button_Send.TabIndex = 3;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Input_A
            // 
            this.Input_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_A.Location = new System.Drawing.Point(15, 15);
            this.Input_A.Margin = new System.Windows.Forms.Padding(10);
            this.Input_A.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Input_A.Name = "Input_A";
            this.Input_A.Size = new System.Drawing.Size(100, 38);
            this.Input_A.TabIndex = 0;
            this.Input_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_A.ValueChanged += new System.EventHandler(this.Input_A_ValueChanged);
            // 
            // Output_Answer
            // 
            this.Output_Answer.Enabled = false;
            this.Output_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_Answer.Location = new System.Drawing.Point(385, 16);
            this.Output_Answer.Margin = new System.Windows.Forms.Padding(10);
            this.Output_Answer.Name = "Output_Answer";
            this.Output_Answer.Size = new System.Drawing.Size(280, 38);
            this.Output_Answer.TabIndex = 4;
            this.Output_Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Input_Operator
            // 
            this.Input_Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Input_Operator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Input_Operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Operator.Location = new System.Drawing.Point(135, 14);
            this.Input_Operator.Margin = new System.Windows.Forms.Padding(10);
            this.Input_Operator.Name = "Input_Operator";
            this.Input_Operator.Size = new System.Drawing.Size(60, 39);
            this.Input_Operator.TabIndex = 1;
            this.Input_Operator.SelectedIndexChanged += new System.EventHandler(this.Input_Operator_SelectedIndexChanged);
            // 
            // Input_B
            // 
            this.Input_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_B.Location = new System.Drawing.Point(215, 15);
            this.Input_B.Margin = new System.Windows.Forms.Padding(10);
            this.Input_B.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Input_B.Name = "Input_B";
            this.Input_B.Size = new System.Drawing.Size(100, 38);
            this.Input_B.TabIndex = 2;
            this.Input_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input_B.ValueChanged += new System.EventHandler(this.Input_B_ValueChanged);
            // 
            // ArrayDataTable
            // 
            this.ArrayDataTable.AllowUserToAddRows = false;
            this.ArrayDataTable.AllowUserToDeleteRows = false;
            this.ArrayDataTable.AllowUserToResizeColumns = false;
            this.ArrayDataTable.AllowUserToResizeRows = false;
            this.ArrayDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ArrayDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ArrayDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ArrayDataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArrayDataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArrayDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ArrayDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrayDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.ArrayDataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ArrayDataTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ArrayDataTable.Location = new System.Drawing.Point(0, 0);
            this.ArrayDataTable.Margin = new System.Windows.Forms.Padding(5);
            this.ArrayDataTable.MultiSelect = false;
            this.ArrayDataTable.Name = "ArrayDataTable";
            this.ArrayDataTable.ReadOnly = true;
            this.ArrayDataTable.RowHeadersVisible = false;
            this.ArrayDataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ArrayDataTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ArrayDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArrayDataTable.Size = new System.Drawing.Size(946, 562);
            this.ArrayDataTable.TabIndex = 0;
            this.ArrayDataTable.TabStop = false;
            this.ArrayDataTable.SelectionChanged += new System.EventHandler(this.ArrayTable_SelectionChanged);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(15, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(954, 586);
            this.TabControl.TabIndex = 1;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndex_Changed);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ArrayDataTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Array List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linked List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BinaryTreeView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(946, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Binary Tree";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BinaryTreeView
            // 
            this.BinaryTreeView.Location = new System.Drawing.Point(10, 10);
            this.BinaryTreeView.Margin = new System.Windows.Forms.Padding(10);
            this.BinaryTreeView.Name = "BinaryTreeView";
            this.BinaryTreeView.Size = new System.Drawing.Size(920, 540);
            this.BinaryTreeView.TabIndex = 0;
            // 
            // Panel_Waiting
            // 
            this.Panel_Waiting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Panel_Waiting.Controls.Add(this.panel2);
            this.Panel_Waiting.Location = new System.Drawing.Point(15, 605);
            this.Panel_Waiting.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_Waiting.Name = "Panel_Waiting";
            this.Panel_Waiting.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_Waiting.Size = new System.Drawing.Size(954, 89);
            this.Panel_Waiting.TabIndex = 2;
            this.Panel_Waiting.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(936, 68);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(920, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waiting for Answer...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 42);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(936, 26);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListenForAnswer);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.FoundAnswer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.Panel_Question);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Panel_Waiting);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Instructor";
            this.Panel_Question.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Input_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayDataTable)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.Panel_Waiting.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Question;
        private System.Windows.Forms.NumericUpDown Input_A;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Input_B;
        private System.Windows.Forms.ComboBox Input_Operator;
        private System.Windows.Forms.TextBox Output_Answer;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ArrayDataTable;
        private System.Windows.Forms.Button Button_Random;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel Panel_Waiting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TreeView BinaryTreeView;
    }
}
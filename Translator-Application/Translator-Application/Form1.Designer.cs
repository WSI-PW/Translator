
namespace Translator_Application
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.probabilisticTextBox = new System.Windows.Forms.TextBox();
            this.bruteForceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.translateButton = new System.Windows.Forms.Button();
            this.probabilisticButton = new System.Windows.Forms.Button();
            this.bruteForceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dynamicButton = new System.Windows.Forms.RadioButton();
            this.recursiveButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DatabaseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.probabilisticTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bruteForceTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(3, 228);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(384, 219);
            this.inputTextBox.TabIndex = 2;
            // 
            // probabilisticTextBox
            // 
            this.probabilisticTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilisticTextBox.Enabled = false;
            this.probabilisticTextBox.Location = new System.Drawing.Point(393, 3);
            this.probabilisticTextBox.Multiline = true;
            this.probabilisticTextBox.Name = "probabilisticTextBox";
            this.probabilisticTextBox.Size = new System.Drawing.Size(384, 219);
            this.probabilisticTextBox.TabIndex = 1;
            // 
            // bruteForceTextBox
            // 
            this.bruteForceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bruteForceTextBox.Enabled = false;
            this.bruteForceTextBox.Location = new System.Drawing.Point(3, 3);
            this.bruteForceTextBox.Multiline = true;
            this.bruteForceTextBox.Name = "bruteForceTextBox";
            this.bruteForceTextBox.Size = new System.Drawing.Size(384, 219);
            this.bruteForceTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.29167F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.70834F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DatabaseGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.translateButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(393, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.07763F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.92237F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 219);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(3, 3);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate!";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // probabilisticButton
            // 
            this.probabilisticButton.Location = new System.Drawing.Point(6, 48);
            this.probabilisticButton.Name = "probabilisticButton";
            this.probabilisticButton.Size = new System.Drawing.Size(134, 23);
            this.probabilisticButton.TabIndex = 1;
            this.probabilisticButton.Text = "Load probabilistic database";
            this.probabilisticButton.UseVisualStyleBackColor = true;
            this.probabilisticButton.Click += new System.EventHandler(this.probabilisticButton_Click);
            // 
            // bruteForceButton
            // 
            this.bruteForceButton.Location = new System.Drawing.Point(6, 19);
            this.bruteForceButton.Name = "bruteForceButton";
            this.bruteForceButton.Size = new System.Drawing.Size(134, 23);
            this.bruteForceButton.TabIndex = 0;
            this.bruteForceButton.Text = "Load Brute/force database";
            this.bruteForceButton.UseVisualStyleBackColor = true;
            this.bruteForceButton.Click += new System.EventHandler(this.bruteForceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dynamicButton);
            this.groupBox1.Controls.Add(this.recursiveButton);
            this.groupBox1.Location = new System.Drawing.Point(126, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(255, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version of probabilistic algorithm";
            // 
            // dynamicButton
            // 
            this.dynamicButton.AutoSize = true;
            this.dynamicButton.Location = new System.Drawing.Point(14, 58);
            this.dynamicButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dynamicButton.Name = "dynamicButton";
            this.dynamicButton.Size = new System.Drawing.Size(66, 17);
            this.dynamicButton.TabIndex = 1;
            this.dynamicButton.TabStop = true;
            this.dynamicButton.Text = "Dynamic";
            this.dynamicButton.UseVisualStyleBackColor = true;
            // 
            // recursiveButton
            // 
            this.recursiveButton.AutoSize = true;
            this.recursiveButton.Location = new System.Drawing.Point(14, 36);
            this.recursiveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(73, 17);
            this.recursiveButton.TabIndex = 0;
            this.recursiveButton.TabStop = true;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(496, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.Controls.Add(this.DatabaseStatusLabel);
            this.DatabaseGroupBox.Controls.Add(this.bruteForceButton);
            this.DatabaseGroupBox.Controls.Add(this.probabilisticButton);
            this.DatabaseGroupBox.Location = new System.Drawing.Point(127, 3);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Size = new System.Drawing.Size(254, 109);
            this.DatabaseGroupBox.TabIndex = 4;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Data source";
            // 
            // DatabaseStatusLabel
            // 
            this.DatabaseStatusLabel.AutoSize = true;
            this.DatabaseStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DatabaseStatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DatabaseStatusLabel.Location = new System.Drawing.Point(3, 93);
            this.DatabaseStatusLabel.Name = "DatabaseStatusLabel";
            this.DatabaseStatusLabel.Size = new System.Drawing.Size(68, 13);
            this.DatabaseStatusLabel.TabIndex = 2;
            this.DatabaseStatusLabel.Text = "No database";
            this.DatabaseStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DatabaseGroupBox.ResumeLayout(false);
            this.DatabaseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox bruteForceTextBox;
        private System.Windows.Forms.TextBox probabilisticTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button probabilisticButton;
        private System.Windows.Forms.Button bruteForceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dynamicButton;
        private System.Windows.Forms.RadioButton recursiveButton;
        private System.Windows.Forms.GroupBox DatabaseGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label DatabaseStatusLabel;
    }
}


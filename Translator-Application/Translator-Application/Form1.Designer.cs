
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.probabilisticTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bruteForceTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(4, 281);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(525, 269);
            this.inputTextBox.TabIndex = 2;
            // 
            // probabilisticTextBox
            // 
            this.probabilisticTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilisticTextBox.Enabled = false;
            this.probabilisticTextBox.Location = new System.Drawing.Point(537, 4);
            this.probabilisticTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.probabilisticTextBox.Multiline = true;
            this.probabilisticTextBox.Name = "probabilisticTextBox";
            this.probabilisticTextBox.Size = new System.Drawing.Size(526, 269);
            this.probabilisticTextBox.TabIndex = 1;
            // 
            // bruteForceTextBox
            // 
            this.bruteForceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bruteForceTextBox.Enabled = false;
            this.bruteForceTextBox.Location = new System.Drawing.Point(4, 4);
            this.bruteForceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bruteForceTextBox.Multiline = true;
            this.bruteForceTextBox.Name = "bruteForceTextBox";
            this.bruteForceTextBox.Size = new System.Drawing.Size(525, 269);
            this.bruteForceTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.translateButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.probabilisticButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bruteForceButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(537, 281);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(526, 269);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(4, 138);
            this.translateButton.Margin = new System.Windows.Forms.Padding(4);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(100, 28);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate!";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // probabilisticButton
            // 
            this.probabilisticButton.Location = new System.Drawing.Point(267, 4);
            this.probabilisticButton.Margin = new System.Windows.Forms.Padding(4);
            this.probabilisticButton.Name = "probabilisticButton";
            this.probabilisticButton.Size = new System.Drawing.Size(208, 28);
            this.probabilisticButton.TabIndex = 1;
            this.probabilisticButton.Text = "Load probabilistic database";
            this.probabilisticButton.UseVisualStyleBackColor = true;
            this.probabilisticButton.Click += new System.EventHandler(this.probabilisticButton_Click);
            // 
            // bruteForceButton
            // 
            this.bruteForceButton.Location = new System.Drawing.Point(4, 4);
            this.bruteForceButton.Margin = new System.Windows.Forms.Padding(4);
            this.bruteForceButton.Name = "bruteForceButton";
            this.bruteForceButton.Size = new System.Drawing.Size(179, 28);
            this.bruteForceButton.TabIndex = 0;
            this.bruteForceButton.Text = "Load Brute/force database";
            this.bruteForceButton.UseVisualStyleBackColor = true;
            this.bruteForceButton.Click += new System.EventHandler(this.bruteForceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dynamicButton);
            this.groupBox1.Controls.Add(this.recursiveButton);
            this.groupBox1.Location = new System.Drawing.Point(266, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version of probabilistic algorithm";
            // 
            // dynamicButton
            // 
            this.dynamicButton.AutoSize = true;
            this.dynamicButton.Location = new System.Drawing.Point(18, 71);
            this.dynamicButton.Name = "dynamicButton";
            this.dynamicButton.Size = new System.Drawing.Size(83, 21);
            this.dynamicButton.TabIndex = 1;
            this.dynamicButton.TabStop = true;
            this.dynamicButton.Text = "Dynamic";
            this.dynamicButton.UseVisualStyleBackColor = true;
            // 
            // recursiveButton
            // 
            this.recursiveButton.AutoSize = true;
            this.recursiveButton.Location = new System.Drawing.Point(18, 44);
            this.recursiveButton.Name = "recursiveButton";
            this.recursiveButton.Size = new System.Drawing.Size(92, 21);
            this.recursiveButton.TabIndex = 0;
            this.recursiveButton.TabStop = true;
            this.recursiveButton.Text = "Recursive";
            this.recursiveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}


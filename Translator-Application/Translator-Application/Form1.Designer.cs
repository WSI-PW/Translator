
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
            this.bruteForceTextBox = new System.Windows.Forms.TextBox();
            this.probabilisticTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bruteForceButton = new System.Windows.Forms.Button();
            this.probabilisticButton = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bruteForceTextBox
            // 
            this.bruteForceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bruteForceTextBox.Enabled = false;
            this.bruteForceTextBox.Location = new System.Drawing.Point(3, 3);
            this.bruteForceTextBox.Multiline = true;
            this.bruteForceTextBox.Name = "bruteForceTextBox";
            this.bruteForceTextBox.Size = new System.Drawing.Size(394, 219);
            this.bruteForceTextBox.TabIndex = 0;
            // 
            // probabilisticTextBox
            // 
            this.probabilisticTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilisticTextBox.Enabled = false;
            this.probabilisticTextBox.Location = new System.Drawing.Point(403, 3);
            this.probabilisticTextBox.Multiline = true;
            this.probabilisticTextBox.Name = "probabilisticTextBox";
            this.probabilisticTextBox.Size = new System.Drawing.Size(394, 219);
            this.probabilisticTextBox.TabIndex = 1;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(3, 228);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(394, 219);
            this.inputTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.translateButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.probabilisticButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bruteForceButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(403, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // bruteForceButton
            // 
            this.bruteForceButton.Location = new System.Drawing.Point(3, 3);
            this.bruteForceButton.Name = "bruteForceButton";
            this.bruteForceButton.Size = new System.Drawing.Size(134, 23);
            this.bruteForceButton.TabIndex = 0;
            this.bruteForceButton.Text = "Load Brute/force database";
            this.bruteForceButton.UseVisualStyleBackColor = true;
            this.bruteForceButton.Click += new System.EventHandler(this.bruteForceButton_Click);
            // 
            // probabilisticButton
            // 
            this.probabilisticButton.Location = new System.Drawing.Point(200, 3);
            this.probabilisticButton.Name = "probabilisticButton";
            this.probabilisticButton.Size = new System.Drawing.Size(156, 23);
            this.probabilisticButton.TabIndex = 1;
            this.probabilisticButton.Text = "Load probabilistic database";
            this.probabilisticButton.UseVisualStyleBackColor = true;
            this.probabilisticButton.Click += new System.EventHandler(this.probabilisticButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(3, 112);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate!";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox probabilisticTextBox;
        private System.Windows.Forms.TextBox bruteForceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Button probabilisticButton;
        private System.Windows.Forms.Button bruteForceButton;
    }
}


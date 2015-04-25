using System;
using System.Drawing;
using System.Windows.Forms;
namespace CribDragging
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
            if (disposing && this.components != null)
            {
                this.components.Dispose();
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
            this.HexBox1 = new RichTextBox();
            this.HexBox2 = new RichTextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.CribBox1 = new ListBox();
            this.CribFindings = new ListBox();
            this.AddCribButt = new Button();
            this.AddCrib = new TextBox();
            this.DelButt = new Button();
            this.KeyBox = new RichTextBox();
            this.label3 = new Label();
            this.button1 = new Button();
            this.label4 = new Label();
            this.XORBox = new TextBox();
            this.CribberBox = new TextBox();
            this.CribYieldings = new TextBox();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            base.SuspendLayout();
            this.HexBox1.Location = new Point(33, 38);
            this.HexBox1.Name = "HexBox1";
            this.HexBox1.Size = new Size(549, 129);
            this.HexBox1.TabIndex = 0;
            this.HexBox1.Text = "";
            this.HexBox2.Location = new Point(33, 195);
            this.HexBox2.Name = "HexBox2";
            this.HexBox2.Size = new Size(549, 129);
            this.HexBox2.TabIndex = 1;
            this.HexBox2.Text = "";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter CipherText1 in Hex:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(33, 179);
            this.label2.Name = "label2";
            this.label2.Size = new Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter CipherText2 in Hex:";
            this.CribBox1.FormattingEnabled = true;
            this.CribBox1.Location = new Point(602, 54);
            this.CribBox1.Name = "CribBox1";
            this.CribBox1.Size = new Size(120, 381);
            this.CribBox1.TabIndex = 5;
            this.CribBox1.SelectedIndexChanged += new EventHandler(this.CribBox1_SelectedIndexChanged);
            this.CribFindings.FormattingEnabled = true;
            this.CribFindings.Location = new Point(746, 54);
            this.CribFindings.Name = "CribFindings";
            this.CribFindings.Size = new Size(741, 563);
            this.CribFindings.TabIndex = 6;
            this.CribFindings.SelectedIndexChanged += new EventHandler(this.CribFindings_SelectedIndexChanged);
            this.AddCribButt.Location = new Point(454, 361);
            this.AddCribButt.Name = "AddCribButt";
            this.AddCribButt.Size = new Size(128, 23);
            this.AddCribButt.TabIndex = 7;
            this.AddCribButt.Text = "Add to Crib List->";
            this.AddCribButt.UseVisualStyleBackColor = true;
            this.AddCribButt.Click += new EventHandler(this.AddCribButt_Click);
            this.AddCrib.Location = new Point(454, 335);
            this.AddCrib.Name = "AddCrib";
            this.AddCrib.Size = new Size(128, 20);
            this.AddCrib.TabIndex = 8;
            this.DelButt.Location = new Point(602, 441);
            this.DelButt.Name = "DelButt";
            this.DelButt.Size = new Size(120, 24);
            this.DelButt.TabIndex = 9;
            this.DelButt.Text = "Delete word";
            this.DelButt.UseVisualStyleBackColor = true;
            this.DelButt.Click += new EventHandler(this.DelButt_Click);
            this.KeyBox.Location = new Point(33, 504);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new Size(549, 108);
            this.KeyBox.TabIndex = 10;
            this.KeyBox.Text = "";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(30, 488);
            this.label3.Name = "label3";
            this.label3.Size = new Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Notes:";
            this.button1.Location = new Point(33, 330);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Begin It";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.label4.AutoSize = true;
            this.label4.Location = new Point(30, 401);
            this.label4.Name = "label4";
            this.label4.Size = new Size(153, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CipherText1 XOR CipherText2:";
            this.XORBox.Location = new Point(188, 398);
            this.XORBox.Name = "XORBox";
            this.XORBox.Size = new Size(394, 20);
            this.XORBox.TabIndex = 16;
            this.CribberBox.Location = new Point(188, 424);
            this.CribberBox.Name = "CribberBox";
            this.CribberBox.Size = new Size(394, 20);
            this.CribberBox.TabIndex = 17;
            this.CribYieldings.Location = new Point(188, 463);
            this.CribYieldings.Name = "CribYieldings";
            this.CribYieldings.Size = new Size(394, 20);
            this.CribYieldings.TabIndex = 18;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(599, 38);
            this.label5.Name = "label5";
            this.label5.Size = new Size(28, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Crib:";
            this.label6.AutoSize = true;
            this.label6.Location = new Point(743, 38);
            this.label6.Name = "label6";
            this.label6.Size = new Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Crib Drag:";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(121, 427);
            this.label7.Name = "label7";
            this.label7.Size = new Size(61, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Crib in Hex:";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(30, 447);
            this.label8.Name = "label8";
            this.label8.Size = new Size(200, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CipherText1 XOR CipherText2 XOR Crib:";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1499, 624);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.CribYieldings);
            base.Controls.Add(this.CribberBox);
            base.Controls.Add(this.XORBox);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.KeyBox);
            base.Controls.Add(this.DelButt);
            base.Controls.Add(this.AddCrib);
            base.Controls.Add(this.AddCribButt);
            base.Controls.Add(this.CribFindings);
            base.Controls.Add(this.CribBox1);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.HexBox2);
            base.Controls.Add(this.HexBox1);
            base.Name = "Form1";
            this.Text = "Form1";
            base.Load += new EventHandler(this.Form1_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}


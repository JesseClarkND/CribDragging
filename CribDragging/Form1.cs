using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CribDragging
{
    public partial class Form1 : Form
    {
        private string[,] StringResults;
        private byte[, ,] Results;
        private byte[,] Kerbed;
        private int bucket = 0;
        //private IContainer components = null;
        private RichTextBox HexBox1;
        private RichTextBox HexBox2;
        private Label label1;
        private Label label2;
        private ListBox CribBox1;
        private ListBox CribFindings;
        private Button AddCribButt;
        private TextBox AddCrib;
        private Button DelButt;
        private RichTextBox KeyBox;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox XORBox;
        private TextBox CribberBox;
        private TextBox CribYieldings;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public Form1()
        {
            this.InitializeComponent();
        }
        private void AddCribButt_Click(object sender, EventArgs e)
        {
            if (this.AddCrib.Text != "")
            {
                this.CribBox1.Items.Add(this.AddCrib.Text);
                this.CribBox1.Enabled = false;
                this.AddCrib.Text = "";
            }
        }
        private void DelButt_Click(object sender, EventArgs e)
        {
            this.CribBox1.Items.RemoveAt(this.CribBox1.SelectedIndex);
            this.CribBox1.SelectedIndex = 0;
        }
        private int HexToInt(char hexChar)
        {
            hexChar = char.ToUpper(hexChar);
            return (int)((hexChar < 'A') ? (hexChar - '0') : ('\n' + (hexChar - 'A')));
        }
        private int KerbedLength(int i)
        {
            int j;
            for (j = 0; j < 10; j++)
            {
                if (this.Kerbed[i, j] == 0)
                {
                    break;
                }
            }
            return j;
        }
        private void start_the_madness(int x, int y, byte[] RunAlong)
        {
            this.Results = new byte[x, y, 100];
            for (int i = 0; i < x; i++)
            {
                int num = this.KerbedLength(i);
                for (int j = 0; j < y - num + 1; j++)
                {
                    int num2 = 0;
                    while (this.Kerbed[i, num2] != 0)
                    {
                        if (j + num2 < RunAlong.Length)
                        {
                            this.Results[i, j, num2] = (byte)(this.Kerbed[i, num2] ^ RunAlong[j + num2]);
                        }
                        num2++;
                    }
                }
            }
        }
        private void string_the_madness(int x, int y)
        {
            this.StringResults = new string[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    string text = string.Format("{0}{1}", Convert.ToString(j), ": ");
                    int num = 0;
                    while (this.Results[i, j, num] != 0)
                    {
                        text = string.Format("{0}{1}", text, Convert.ToChar(this.Results[i, j, num]));
                        num++;
                    }
                    this.StringResults[i, j] = text;
                }
            }
        }
        private void print_the_madness()
        {
            this.CribBox1.SetSelected(0, true);
        }
        private void kerberize()
        {
            this.Kerbed = new byte[this.CribBox1.Items.Count, 100];
            for (int i = 0; i < this.CribBox1.Items.Count; i++)
            {
                for (int j = 0; j < this.CribBox1.Items[i].ToString().Length; j++)
                {
                    this.Kerbed[i, j] = Convert.ToByte(this.CribBox1.Items[i].ToString()[j]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.HexBox1.Text != "" && this.HexBox2.Text != "")
            {
                this.HexBox1.Text = this.HexBox1.Text.Replace(" ", string.Empty);
                this.HexBox2.Text = this.HexBox2.Text.Replace(" ", string.Empty);
                this.HexBox1.Text = this.HexBox1.Text.Replace("  ", string.Empty);
                this.HexBox2.Text = this.HexBox2.Text.Replace("  ", string.Empty);
                char[] array = this.HexBox1.Text.ToCharArray();
                char[] array2 = this.HexBox2.Text.ToCharArray();
                byte[] array3 = new byte[array.Length];
                byte[] array4 = new byte[array2.Length];
                byte[] array5 = new byte[(array.Length <= array2.Length) ? (array.Length / 2) : (array2.Length / 2)];
                int num = 0;
                int num2 = 0;
                while (num2 + 1 < array.Length && num2 + 1 < array2.Length)
                {
                    array3[num] = Convert.ToByte(int.Parse(string.Format("{0}{1}", array[num2], array[num2 + 1]), NumberStyles.HexNumber));
                    array4[num] = Convert.ToByte(int.Parse(string.Format("{0}{1}", array2[num2], array2[num2 + 1]), NumberStyles.HexNumber));
                    array5[num] = (byte)(array3[num] ^ array4[num]);
                    num++;
                    num2 += 2;
                }
                this.CribBox1.Enabled = true;
                this.bucket = array5.Length;
                string text = string.Empty;
                for (int i = 0; i < this.bucket; i++)
                {
                    text = string.Format("{0}{1}{2}", text, array5[i].ToString("X2"), " ");
                }
                text = text.TrimEnd(new char[0]);
                this.XORBox.Text = text;
                this.kerberize();
                this.start_the_madness(this.CribBox1.Items.Count, array5.Length, array5);
                this.string_the_madness(this.CribBox1.Items.Count, array5.Length);
                this.print_the_madness();
            }
            else
            {
                this.HexBox1.Text = "3b101c091d53320c000910";
                this.HexBox2.Text = "071d154502010a04000419";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CribBox1.HorizontalScrollbar = true;
            this.CribFindings.HorizontalScrollbar = true;
            this.CribBox1.Items.Add(" the ");
            this.CribBox1.Items.Add(" be ");
            this.CribBox1.Items.Add(" to ");
            this.CribBox1.Items.Add(" of ");
            this.CribBox1.Items.Add(" and ");
            this.CribBox1.Items.Add(" a ");
            this.CribBox1.Items.Add(" in ");
            this.CribBox1.Items.Add(" that ");
            this.CribBox1.Items.Add(" have ");
            this.CribBox1.Items.Add(" I ");
            this.CribBox1.Items.Add(" it ");
            this.CribBox1.Items.Add(" for ");
            this.CribBox1.Items.Add(" not ");
        }
        private void CribBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CribFindings.Items.Clear();
            if (this.CribBox1.SelectedIndex != -1)
            {
                string[] array = new string[this.bucket];
                for (int i = 0; i < this.bucket; i++)
                {
                    array[i] = this.StringResults[this.CribBox1.SelectedIndex, i];
                }
                this.CribFindings.Items.AddRange(array);
            }
        }
        private void CribFindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = this.CribBox1.Items[this.CribBox1.SelectedIndex].ToString().Length;
            string text = string.Empty;
            for (int i = 0; i < this.bucket; i++)
            {
                if (i == this.CribFindings.SelectedIndex)
                {
                    for (int j = 0; j < length; j++)
                    {
                        text = string.Format("{0}{1}{2}", text, this.Kerbed[this.CribBox1.SelectedIndex, j].ToString("X2"), " ");
                        i++;
                    }
                    i--;
                }
                else
                {
                    text = string.Format("{0}{1}{2}", text, "00", " ");
                }
            }
            text = text.Trim();
            this.CribberBox.Text = text;
            string text2 = string.Empty;
            for (int k = 0; k < this.bucket; k++)
            {
                if (k == this.CribFindings.SelectedIndex)
                {
                    for (int j = 0; j < length; j++)
                    {
                        text2 = string.Format("{0}{1}{2}", text2, this.Results[this.CribBox1.SelectedIndex, this.CribFindings.SelectedIndex, j].ToString("X2"), " ");
                        k++;
                    }
                    k--;
                }
                else
                {
                    text2 = string.Format("{0}{1}{2}", text2, "00", " ");
                }
            }
            text2 = text2.TrimEnd(new char[0]);
            this.CribYieldings.Text = text2;
        }



    }
}

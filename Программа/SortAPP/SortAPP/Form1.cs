using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAPP
{
    public partial class Form1 : Form
    {
        int SortType = 0;


        private void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        private int[] TextStr()
        {
            int size;
            String[] ss = textBox1.Text.Split(' ');
            size = ss.Count();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(ss[i]);
            }
            return arr;
        }

        private void Pyzurok()
        {
            int n = Int32.Parse(textBox3.Text);
            int[] mas = new int[n];
            mas = TextStr();
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
              textBox2.Text += mas[i].ToString()+' ';
            }
        }

        private void Shaker()
        {

            int n = Int32.Parse(textBox3.Text);
            int[] mas = new int[n];
            mas = TextStr();

            for (var i = 0; i < n / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < n - i - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        Swap(ref mas[j], ref mas[j + 1]);
                        swapFlag = true;
                    }
                }
                for (var j = n - 2 - i; j > i; j--)
                {
                    if (mas[j - 1] > mas[j])
                    {
                        Swap(ref mas[j - 1], ref mas[j]);
                        swapFlag = true;
                    }
                }
                if (!swapFlag)
                {
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                textBox2.Text += mas[i].ToString() + ' ';
            }
        }


        private void Razchoska()
        {
            int n = Int32.Parse(textBox3.Text);
            int[] mas = new int[n];
            mas = TextStr();

            double gap = n;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < n)
                {
                    int igap = i + (int)gap;
                    if (mas[i] > mas[igap])
                    {
                        int swap = mas[i];
                        mas[i] = mas[igap];
                        mas[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                textBox2.Text += mas[i].ToString() + ' ';
            }
        }

        private void Vstavki()
        {
            int n = Int32.Parse(textBox3.Text);
            int[] mas = new int[n];
            mas = TextStr();

            for (int i = 1; i < n; i++)
            {
                int k = mas[i];
                int j = i - 1;

                while (j >= 0 && mas[j] > k)
                {
                    mas[j + 1] = mas[j];
                    mas[j] = k;
                    j--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                textBox2.Text += mas[i].ToString() + ' ';
            }
        }

            public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton1 = (RadioButton)sender;
            if (radioButton1.Checked)
            {
                SortType = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton2 = (RadioButton)sender;
            if (radioButton2.Checked)
            {
                SortType = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton3 = (RadioButton)sender;
            if (radioButton3.Checked)
            {
                SortType = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton4 = (RadioButton)sender;
            if (radioButton4.Checked)
            {
                SortType = 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите данные банковской карты");
            }
            else
            {
            switch (SortType)
            {
                case 0: MessageBox.Show("Выберите тип сортировки"); break;
                case 1: Pyzurok(); break;
                case 2: Shaker(); break; 
                case 3: Razchoska(); break;
                case 4: Vstavki(); break;
            }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

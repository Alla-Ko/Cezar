using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.SelectedIndex = 0;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //зашифрувати
            String mal = "абвгґдеєжзіїйклмнопрстуфхцчшщьюя";
            String vel = "АБВГҐДЕЄЖЗІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            String text1 = this.textBox1.Text;
            String text2 = "";

            int n = 0;
            
            if(Int32.TryParse(this.comboBox1.SelectedItem.ToString(), out n)!=null)
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    if (mal.IndexOf(text1[i]) != -1)
                    {
                        text2 = text2 + mal[(mal.IndexOf(text1[i]) + n) % 32];
                    }
                    else
                    {
                        if (vel.IndexOf(text1[i]) != -1)
                        {
                            text2 = text2 + vel[(vel.IndexOf(text1[i]) + n) % 32];
                        }
                        else
                        {
                            text2 = text2 + text1[i];
                        }
                    }
                }
                this.textBox2.Text = text2;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //розшифрувати
            String mal = "абвгґдеєжзіїйклмнопрстуфхцчшщьюя";
            String vel = "АБВГҐДЕЄЖЗІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            String text1 = this.textBox1.Text;
            String text2 = "";
            int n = 0;
            if (Int32.TryParse(this.comboBox1.SelectedItem.ToString(), out n) != null)
            {
                for (int i = 0; i < text1.Length; i++)
                {
                    if (mal.IndexOf(text1[i]) != -1)
                    {
                        text2 = text2 + mal[(mal.IndexOf(text1[i]) - n + 32) % 32];
                    }
                    else
                    {
                        if (vel.IndexOf(text1[i]) != -1)
                        {
                            text2 = text2 + vel[(vel.IndexOf(text1[i]) - n + 32) % 32];
                        }
                        else
                        {
                            text2 = text2 + text1[i];
                        }
                    }
                }
                this.textBox2.Text = text2;

            }
        }
    }
}

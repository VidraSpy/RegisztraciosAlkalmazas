using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string lista;
        string nev;
        DateTime szul;
        string nem;
        private void b_save_Click(object sender, EventArgs e)
        {
            if (tb_nev.Text!=null && tb_szul.Text!=null && listBox1.SelectedItem!=null)
            {
                nev = tb_nev.Text;
                szul = DateTime.Parse(tb_szul.Text);
                if (rb_f.Checked)
                {
                    nem = "férfi";
                }
                if (rb_n.Checked)
                {
                    nem = "nő";
                }
                StreamWriter sw = new StreamWriter("data.txt");
                sw.Write(nev + "_" + szul.ToString() + "_" + nem + "_" + listBox1.SelectedItem);
                sw.Close();
            }
        }

        private void b_load_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))
            {
                StreamReader sr = new StreamReader("data.txt", Encoding.Default);
                int n = 0;
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split('_');
                    nev = s[0];
                    szul = DateTime.Parse(s[1]);
                    nem = s[2];
                    lista = s[3];
                    n++;
                }
                sr.Close();
                MessageBox.Show(nev+" "+szul+" "+nem+" "+lista[0]);
            }
            else
            {
                MessageBox.Show("No File Generated!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lista = tb_hobbi.Text;
            listBox1.Items.Add(lista);
        }
    }
}

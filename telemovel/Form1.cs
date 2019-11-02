// Calculadora com Programação Orientada a Objetos

using System;
using System.Windows.Forms;

namespace telemovel
{
    public partial class Form1 : Form
    {
        nokia phone = new nokia();
        public Form1()
        {
            InitializeComponent();
        }

        private void mostra()
        {
            label1.Text = phone.Num;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            phone.reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            phone.Num = ((Button)sender).Name;
            mostra();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            phone.reset();
            mostra();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            phone.chamar();
        }
    }
}

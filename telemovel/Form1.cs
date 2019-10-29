using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telemovel
{
    public partial class Form1 : Form
    {
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void mostra()
        {
            label1.Text = numero.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numero = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int valor = 0;
            switch (((Button)sender).Name)
            {
                case "button1": valor = 1; break;
                case "button2": valor = 2; break;
                case "button3": valor = 3; break;
                case "button4": valor = 4; break;
                case "button5": valor = 5; break;
                case "button6": valor = 6; break;
                case "button7": valor = 7; break;
                case "button8": valor = 8; break;
                case "button9": valor = 9; break;
                case "button11": valor = 0; break;
            }
            Console.Beep(261 + valor*53,200);
            if (numero.ToString().Length < 9)
                numero = numero * 10 + valor;
            mostra();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            numero = 0;
            mostra();
        }
    }
}

using System;
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
            int hi = 0;
            int lo = 0;
            switch (((Button)sender).Name)
            {
                case "button1": valor = 1; hi = 1209; lo = 697;  break;
                case "button2": valor = 2; hi = 1336; lo = 697; break;
                case "button3": valor = 3; hi = 1477; lo = 697; break;
                case "button4": valor = 4; hi = 1209; lo = 770; break;
                case "button5": valor = 5; hi = 1336; lo = 770; break;
                case "button6": valor = 6; hi = 1477; lo = 770; break;
                case "button7": valor = 7; hi = 1209; lo = 852; break;
                case "button8": valor = 8; hi = 1336; lo = 852; break;
                case "button9": valor = 9; hi = 1477; lo = 852; break;
                case "button11": valor = 0; hi = 1336; lo = 941; break;
            }
            Console.Beep(lo, 100);
            Console.Beep(hi, 100);
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

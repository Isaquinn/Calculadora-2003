using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Trabalho do Curso de Porgramação/2003/Isaque de Araújo
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        double x, y, result, potencia;
        bool telinha;
        
        
        string  operate;
        string calculo;
        public Form1()
        {

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "3";
                Conta.Text = Conta.Text + "3";
                telinha = false;
            }
            else if(telinha == false) {
            Visor.Text = Visor.Text + "3";
            Conta.Text = Conta.Text + "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (telinha == true) {
                Visor.Clear();
                Visor.Text = Visor.Text + "1";
                Conta.Text = Conta.Text + "1";
                telinha = false;
            }
             else if (telinha == false) {
                Visor.Text = Visor.Text + "1";
                Conta.Text = Conta.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "2";
                Conta.Text = Conta.Text + "2";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "2";
                Conta.Text = Conta.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "4";
                Conta.Text = Conta.Text + "4";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "4";
                Conta.Text = Conta.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "5";
                Conta.Text = Conta.Text + "5";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "5";
                Conta.Text = Conta.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "6";
                Conta.Text = Conta.Text + "6";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "6";
                Conta.Text = Conta.Text + "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "7";
                Conta.Text = Conta.Text + "7";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "7";
                Conta.Text = Conta.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "8";
                Conta.Text = Conta.Text + "8";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "8";
                Conta.Text = Conta.Text + "8";
                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "9";
                Conta.Text = Conta.Text + "9";
                
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "9";
                Conta.Text = Conta.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {
                Visor.Clear();
                Visor.Text = Visor.Text + "0";
                Conta.Text = Conta.Text + "0";
                telinha = false;
            }
            else if (telinha == false)
            {
                Visor.Text = Visor.Text + "0";
                Conta.Text = Conta.Text + "0";
            }
        }

        private void btmais_Click(object sender, EventArgs e)
        {   
            operate = "+";
            calculo = Conta.Text = Conta.Text + "+";
            
            
            
            
            x = double.Parse(Visor.Text);
            
            Visor.Clear();
              
        }

        private void btmenos_Click(object sender, EventArgs e)
        {
            operate = "-";
            calculo = Conta.Text = Conta.Text + "-";
            x = double.Parse(Visor.Text);
            Visor.Clear();                 
        }

        private void btdividido_Click(object sender, EventArgs e)
        {
            operate = "/";
            calculo = Conta.Text = Conta.Text + "/";
            x = double.Parse(Visor.Text);
            Visor.Clear();                 
        }

        private void btvezes_Click(object sender, EventArgs e)
        {
            operate = "*";
            calculo = Conta.Text = Conta.Text + "*";
            x = double.Parse(Visor.Text);
            Visor.Clear();                
        }

        private void bigual_Click(object sender, EventArgs e)
        {
             
            y = double.Parse(Visor.Text);
            switch (operate) { 
                case "+":
                    result = x + y;
                    Visor.Text = result.ToString();
                    
                    telinha = true;
                     
                    break;

                case "-":
                    result = x - y;
                    Visor.Text = result.ToString();
                    telinha = true;
                    break;

                case "/":
                    result = x / y;
                    Visor.Text = result.ToString();
                    telinha = true;
                    break;
               
                case "*":
                    result = x * y;
                    Visor.Text = result.ToString();
                    telinha = true;
                    break;
                
                case "%":
                    result = x % y;
                    Visor.Text = result.ToString();
                    telinha = true;

                    break;

                case "^":
                    result= Math.Pow(x, y);
                    Visor.Text = result.ToString();
                    telinha = true;

                    break;

                case "$":
                    result = x / 100 * y;
                    Visor.Text = result.ToString();
                    telinha = true;

                    break;
                case "!":
                    potencia = 1.0 / y;
                    result = Math.Pow(x, potencia);
                    Visor.Text = result.ToString();
                    telinha = true;

                    break;
            
            }
            

            
        }

        private void bzerar_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            x = 0;
            
            y = 0;
            Conta.Text = "";  
        }

        private void bvirgula_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + ",";
            calculo = Conta.Text = Conta.Text + ",";
            bvirgula.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
             x = double.Parse(Visor.Text); 
            result = x;
            
            Visor.Text = Math.Cos(x).ToString();
            calculo = Conta.Text = Conta.Text + "Cos";
            telinha = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = double.Parse(Visor.Text); 
            result = x;
            
            Visor.Text = Math.Tan(x).ToString();
            calculo = Conta.Text = Conta.Text + "Tan";
            telinha = true;
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            operate = "!";
            x = double.Parse(Visor.Text);
            calculo = Conta.Text = Conta.Text + "√";
            Visor.Clear();
            

        
        }

        private void sen_Click(object sender, EventArgs e)
        {
                                        
            x = double.Parse(Visor.Text); 
            result = x;
            
            Visor.Text = Math.Sin(x).ToString();
            calculo = Conta.Text = Conta.Text + "Sen";
            
            telinha = true;

        }

        private void porcentagem_Click(object sender, EventArgs e)
        {
            operate = "$";
            x = double.Parse(Visor.Text);
            result = x;
            Visor.Text = Convert.ToString(x/100 * y);
            calculo = Conta.Text = Conta.Text + "%";
            

            Visor.Clear();


        }

        private void exp_Click(object sender, EventArgs e)
        {
            operate = "^";
            x = double.Parse(Visor.Text); 
            result = x;
            
            Visor.Text = Math.Pow(x, y).ToString();
            calculo = Conta.Text = Conta.Text + "^";
            Visor.Clear();

        }

        private void resto_Click(object sender, EventArgs e)
        {
            operate = "%";
            x = double.Parse(Visor.Text);
            calculo = Conta.Text = Conta.Text + "Rest";
            Visor.Clear(); 

        }

        private void CE_Click(object sender, EventArgs e)
        {
            Visor.Text = "";
            Conta.Text = Convert.ToString(x);
            switch (operate) {
                case "+":
                    Conta.Text += "+";

                    break;

                case "-":
                    Conta.Text += "-";
                    
                    break;

                case "/":
                    Conta.Text += "/";

                    break;

                case "*":
                    Conta.Text += "*";
                    
                    break;

                case "%":
                    Conta.Text += "%";

                    break;

                case "^":
                    Conta.Text += "^";

                    break;

                case "$":
                    Conta.Text += "$";

                    break;
                case "!":
                    Conta.Text += "!";

                    break;
            }
            

            y = 0;

        }

        private void apagar_Click(object sender, EventArgs e)
        {


            int tamanho = Visor.Text.Length - 1;
            if(tamanho >= 0 ){
                Visor.Text = Visor.Text.Substring(0, tamanho);
            }

            int tamanho2 = Conta.Text.Length - 1;
            if(tamanho2 >= 0 ){
            Conta.Text = Conta.Text.Substring(0, tamanho2);
            }
            


        }

        private void Visor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


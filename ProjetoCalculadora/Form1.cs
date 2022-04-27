using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//fim do construtor

        private void soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//Coletando o primeiro número
                double num2 = Convert.ToDouble(textBox2.Text);//Coletando o segundo número
                double resultado = model.Somar(num1, num2);//Gerando o resultado
                label3.Text = "" + resultado;//Escrever o resultado na tela
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão somar

        private void subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Subtrair(num1, num2);
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão subtrair

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o primeiro número

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o segundo número

        private void multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Multiplicar(num1, num2);
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão multiplicar

        private void dividir_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Dividir(num1, num2);
                //Tratando a validação
                if (resultado == -1)
                {
                    label3.Text = "Impossível dividir por zero!";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão dividir

        private void potencia_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = model.Potencia(num1, num2);
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão de potência

        private void raiz_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double resultado = model.Raiz(num1);
                if (resultado == -1)
                {
                    label3.Text = "Impossível calcular a raiz!";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }catch(Exception erro)
            {
                MessageBox.Show("Os números não foram digitados!\n\n" + erro);
            }
        }//fim do botão raiz

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim da label resultado
    }//fim da classe
}//fim do projeto

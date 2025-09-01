using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExerciciosModel
    {
        //area de variaveis
        private double area;
        private double IMC;
        //metodo Construtor
        public ExerciciosModel()
        {
            this.area = 0;
        }//fim do construtor

        //Método GET e SET
        public double ModificarArea
        {
            get { return this.area; }
            set { this.area = value; }
        }//fim do metodo getSet

        public double ModificarIMC
        {
            get { return this.IMC; }
            set { this.IMC = value; }
        }//fim do metodo getSet

        //1. Leia um número e exiba seu triplo
        public int Triplo(int num)
        {
            return num * 3;
        }//fim do metodo

        //2. Leia um número e sua metade
        public int Metade(int num)
        {
            return num / 2;
        }// fim do metodo

        
        public double ConverterDolar(double dolar)
        {
            if (dolar < 0)
            {
                return -1;
            }
            else 
            {
                return dolar * 5.16;
            }
        }// fim do metodo
        //5.Converta um valor em horas para minutos 
        public double HorasParaMinutos(double horas)
        {
            if (horas <= 0)
            {
                return -1;
            }
            else
            {
                return horas * 60;
            }
        }//fim do método
       //6.
       public double ConverterPorcentagem(double porcentagem)
        {
            return porcentagem *0.10;
        }//fim do método
        //7. 
        public double ConverterParaVinte(double vintecinco)
        {
            return vintecinco * 0.25;
        }// fim do metodo 


        //8. Calcule a área de um losangulo com base nas diagonais 
        //area = (diagonalMaior * diagonalMenor) / 2

        public double AreaLosango(double diagonalMaior, double diagonalMenor)
        {
            //validação
            if (diagonalMaior > 0 && diagonalMenor > 0)
            {
                ModificarArea = (diagonalMaior * diagonalMenor) / 2;
            }
            else
            {
                ModificarArea = -1;//Criando um alerta com um símbolo
            }
            return ModificarArea;
        }//fim do metodo

        //9. Calcule o volume de um cilindro a partir do raio e altura.
        //volume = Math.pi * Math.pow(raio,2) * altura

        public double VolumeCilindro(double raio, double altura)
        {
            if (raio > 0 && altura > 0)
            {
                return Math.PI * Math.Pow(raio, 2) * altura;
            }
            else
            {
                return -1;
            }

        }// fim do método

        //16. Leia a altura e peso de uma pessoa e calcule o IMC 
        // SE IMC <18.5 - Abaixo do peso
        // SE IMC >=18.5 E IMC < 24.9- peso normal 
        //SE IMC >=24.9 E IMC 29.9 - sobrepeso
        //SE IMC >= 29.9 E IMC <34.4 - obesidade grau I 
        //SE IMC >34.4 E IMC <39.9 - obesidade Grau II
        //SE IMC >39.9 - obesidade grau III

        public string CalcularIMC(double peso, double altura)// STRING = devolver um texto. () = recebe as variaveis 
        {
            string resultado = "";
            if (peso >= 0 && altura >= 0)
            {
                ModificarIMC = peso / Math.Pow(altura, 2);
                resultado = "\nSeu IMC é: " + ModificarIMC;
                if (ModificarIMC < 18.5)
                {
                    resultado += " Abaixo do Peso";
                }
                else if (ModificarIMC < 24.9)
                {
                    resultado += "Peso Normal";
                }
                else if (ModificarIMC < 29.9)
                {
                    resultado += "SobrePeso";
                }
                else if (ModificarIMC < 34.9)
                {
                    resultado += "Obesidade Grau I ";
                }
                else if (ModificarIMC < 39.9)
                {
                    resultado += "Obesidade Grau II";
                }
                else
                {
                    resultado += "Obesidade Grau III";
                }// FIM DO IF RESULTADO
            }// FIM DO IF
            else
            {
                resultado = "Impossivel calcular IMC com peso e/ou altura negativos";
            }
            return resultado;
        }//fim do IMC
        


    }//fim da classe 
}//fim do projeto
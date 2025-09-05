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
         //3.
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
        //4.Calcular Perimetro
        public double CalcularPerimetro(double basee)
        {
            return basee * basee;
        }//fim do método
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
            return porcentagem * 0.10;
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

        //10.
        public double ValorAbsoluto(double absoluto)
        {
            if (absoluto >= 0)
            {
                return absoluto;
            }
            else
            {
                return -absoluto;
            }
        }//fim do método 
        //.11
        public double ConverterKM(double metros)
        {
            if (metros <= 0)
            {
                return -1;
            }
            else
            {
                return metros * 1000;
            }
        }//fim do método
        //12.
        public double Calcular5(double potencia)
        {
            if (potencia <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Pow(potencia, 5);
            }

        }//fim do metodo oooooo gloria deu certo kkkkk
        //13.
        public double CalcularTempo(double distancia, double velocidade)
        {
            if (distancia <= 0 && velocidade <= 0)
            {
                return -1;
            }
            else
            {
                return distancia / velocidade;
            }
        }// fim do metodo
        //14.
        public double CalcularCombustivel(double km, double litros)
        {
            if (km <= 0)
            {
                return -1;
            }
            else
            {
                return km / litros;
            }
        }//fim do método
  
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
                }
            }// fim do if
            else
            {
                resultado = "Impossivel calcular IMC com peso e/ou altura negativos";
            }
            return resultado;
        }//fim do metodo IMC

        //17.
        public double CalcularSalario(double mensal)
        {
            return mensal * 12;
        }// fim do método

        //18. Leia um número e exiba seu logaritmo natural
        public double Logaritmo(double log)
        {
            if (log <= 0)
            {
                return -1;
            }
            else
            {
                return Math.Log10(log);
            }
        }//fim do método

         //19.
        public double CalcularSeno(double catetoO, double hipotenusa)
        {
            if(catetoO <= 0)
            {
                return -1;
            }
            else
            {
                return catetoO / hipotenusa;
            }
        }// fim do metodo 

        //20.
        public double CalcularCosseno(double adjacente, double hipo)
        {
            if (adjacente <= 0)
            {
                return -1;
            }
            else
            {
                return adjacente / hipo;
            }
        }//fim do método

        //21
        public double AreaTrapezio(double baseM,double baseP,double alt)
        {
            if (baseM <= 0)
            {
                return -1;
            }
            return (baseM + baseP) * alt / 2;
        }// fim do metodo

        //22.
        public double ConverterDias(double dias)
        {
            if(dias <= 0)
            {
                return -1;
            }
            else
            {
                return dias * 86400;
            }
        }//fim do metodo
         //23
        public int SomaDigitos(int numero)
        {
            int soma = 0;
            while (numero > 0)
            {
                soma += numero % 10; // pega o último dígito e soma
                numero /= 10;        // remove o último dígito do número
            }
            return soma;
        }
        /*/24
       // public double InversoMultiplicativo(double inverso)
        {

        }// fim do metodo */

        //25.
        public double CalcularHipotenusa(double cate1, double cate2)
        {
            return Math.Sqrt( (cate1 * cate1) + (cate2 * cate2));
        }
        
        //26
        public string ConverterBinario(int num)
        {

            string binario = "";// aspas significa que começa vazio

            while (num != 0)
            {
                binario = "" + num % 2; //( = recebe (<)) (% = mod /)
                num /= 2;
            }//fim do while

            { return binario; }

        }// fim do método
        public string Inverter(string valor)
        {
            int tamanho = valor.Length;
            string binarioInvertido = "";
            for (int i = tamanho - 1; i >= 0; i--)
            {
                {
                    binarioInvertido += valor.Substring(i, 1);
                }

            }//fim do for 
            return binarioInvertido;
        }//fim do metodo 

        //27.Leia um numero e exiba seu correspondente em hexadecimal
        public string Hexadecimal(int decim)
        {
            string hexa = "";
            string result = "";
            while (decim != 0)
            {
                result = "" + decim % 16;
                switch (result)
                {
                    case "10":
                        result = "A";
                        break;
                    case "11":
                        result = "B";
                        break;
                    case "12":
                        result = "C";
                        break;
                    case "13":
                        result = "D";
                        break;
                    case "14":
                        result = "E";
                        break;
                    case "15":
                        result = "F";
                        break;
                }//fim do switch
                decim /= 16;
                hexa += result;
            }//fim do while
            return Inverter(hexa);

        }//fim do método

        //29.
        public double CalcularJuros(double valor)
        {
            if ( valor <= 0 )
            {
                return -1;
            }
            else
            {
                return valor + (valor * 0.15);
            }
        }// fim do metodo

        //30.
        public double CalcularComposto(double composto)
        {
            if ( composto <= 0 )
            {
                return -1;
            }
            else
            {
                return composto / 100;
            }
        }//fim do metodo

        //31
       /* public double ConverterGraus(double graus)
        {

        }// fim do metodo
       */



        //32.
        public double CalcularPorcentagem(double porcento)
        {
            return porcento / 100;
        }// fim do metodo 




        
    }//fim da classe
}//fim do projeto
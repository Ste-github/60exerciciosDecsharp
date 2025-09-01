using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Control
    {
        private int opcao;
        public ExerciciosModel modelo; // Criando Conexão com a classe modelo
        public Control()
        {
            this.opcao = 0;
            this.modelo= new ExerciciosModel(); // Instanciando para usar os metódos 
        }// fim do método
        
        public int ModificarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        } // fim do modificar opcao 

        public void MostrarMenu()
        {
            Console.WriteLine("\nMenu" +
                              "\n0. Sair" +
                              "\n1. Exercício 1" +
                              "\n2. Exercício 2" +
                              "\n3. Exercício 3" + //novo
                              "\n5. Exercício 5" + //novo
                              "\n6. Exercício 6" + //novo
                              "\n7. Exercício 7" + //novo
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9" +
                              "\n16. Exercício 16 ");
            ModificarOpcao= Convert.ToInt32(Console.ReadLine());
        }//fim do mostrar menu 

        public void ExecutarMenu() 
        {
            do //comando para repetição de menu 
            {
                //Chamar o Menu 
                MostrarMenu();
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!!");
                        break;
                    case 1:
                        Console.WriteLine("Exercício 01");
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Chamar a ExercicioModel
                        Console.WriteLine(modelo.Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Exercício 02");
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(modelo.Metade(num));
                        break;

                    case 3:
                        Console.WriteLine("Exercício 3");
                        Console.WriteLine("Informe o valor em Dólar");
                        double dolar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(modelo.ConverterParaVinte(dolar));                      
                        break;
                    case 5:
                        Console.WriteLine("Exercício 05");
                        Console.WriteLine("Informe as horas: ");
                        double horas = Convert.ToDouble(Console.ReadLine());
                        double minutos = modelo.HorasParaMinutos(horas);
                        //Mostar o resultado 
                        if (minutos  == -1)
                        {
                            Console.WriteLine("Número de horas inválidos ");
                        }
                        else
                        {
                            Console.WriteLine($"Essas Horas equivalem a {minutos} minutos.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exercício 06");
                        Console.WriteLine("Informe um número");
                        double porcentagem = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(modelo.ConverterPorcentagem(porcentagem));
                        break;
                    case 7:
                        Console.WriteLine("Exercício 07");
                        Console.WriteLine("Informe um número");
                        double vintecinco = Convert.ToDouble((Console.ReadLine()));
                        Console.WriteLine(modelo.ConverterParaVinte(vintecinco));
                        break;
                        
                    case 8:
                        Console.WriteLine("Exercício 08");
                        Console.WriteLine("Informe a diagonal maior: ");
                        double diagonalMaior = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a diagonal menor: ");
                        double diagonalMenor = Convert.ToDouble(Console.ReadLine());

                        //Mostrar o resultado 
                        if (modelo.AreaLosango(diagonalMaior, diagonalMenor) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine("A área do Losango é : " + modelo.AreaLosango(diagonalMaior, diagonalMenor));
                        }
                        break;


                    case 9:
                        Console.WriteLine("Exercício 09");
                        Console.WriteLine("Informe o valor do raio:");
                        double raio = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        // Mostrar
                        if (modelo.VolumeCilindro(raio, altura) == -1)
                        {
                            Console.WriteLine("Os números digitados não são válidos!");
                        }
                        else
                        {
                            Console.WriteLine($"O volume do cilindro é: {modelo.VolumeCilindro(raio, altura)}");
                        }
                        break;

                    case 16:
                        Console.WriteLine("Exercício 16");
                        Console.WriteLine("Informe o seu peso:");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe sua altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        //mostrar
                        Console.WriteLine(modelo.CalcularIMC(peso, altura));
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;





                }  // fim do escolha  
            } while (ModificarOpcao != 0); //repetir enquanto nao for diferente de zero 
        }// fim do método

    }//fim da classe
}//fim do projeto 

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
                              "\n3. Exercício 3" + 
                              "\n4. Exercício 4 " +
                              "\n5. Exercício 5" +
                              "\n6. Exercício 6" + 
                              "\n7. Exercício 7" + 
                              "\n10. Exercício 10" + 
                              "\n11. Exercício 11" +
                              "\n12. Exercício 12" +
                              "\n13. Exercício 13" +
                              "\n14. Exercício 14" +
                              "\n15. Exercício 15" + //nao
                              "\n16. Exercício 16" +
                              "\n17. Exercício 17" + 
                              "\n18. Exercício 18" + 
                              "\n19. Exercício 19" +
                              "\n20. Exercício 20" +
                              "\n21. Exercício 21" +
                              "\n22. Exercício 22" +
                              "\n23. Exercício 23" +
                              "\n24. Exercício 24" +
                              "\n25. Exercício 25" +
                              "\n26. Exercício 26 " +
                              "\n26. Exercício 27 " +
                              "\n26. Exercício 28" +
                              "\n29. Exercício 29" +
                              "\n26. Exercício 30 " +
                              "\n26. Exercício 31" +
                              " \n29. Exercício 32 ");
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
                        Console.WriteLine($"O valor em reais é de : {modelo.ConverterDolar(dolar)}");                      
                        break;
                    case 4:
                        Console.WriteLine("Exercício 4");
                        Console.WriteLine("Informe o valor da base");
                        double basee = Convert.ToDouble(Console.ReadLine());  
                        Console.WriteLine("O valor do Perimetro é " + modelo.CalcularPerimetro(basee));
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
                    case 10:
                        Console.WriteLine("Exercício 10");
                        Console.WriteLine("Digite um número");
                        double absoluto =Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor absoluto é : {modelo.ValorAbsoluto(absoluto)}");
                        break;
                    case 11:
                        Console.WriteLine("Exercício 11");
                        Console.WriteLine("Informe o valor em Quilometros");
                        double metros = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor em metros é {modelo.ConverterKM(metros)}");
                        break;
                    case 12:
                        Console.WriteLine("Exercício 12");
                        Console.WriteLine("Informe um número");
                        double potencia = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A quinta potência é {modelo.Calcular5(potencia)}");
                        break;
                    case 13:
                        Console.WriteLine("Exercício 13");
                        Console.WriteLine("Informe a Distancia");
                        double distancia = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a Velocidade");
                        double velocidade = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"o tempo sera de : {modelo.CalcularTempo(distancia, velocidade)}");
                        break;

                        case 14:
                        Console.WriteLine("Exercício 14");
                        Console.WriteLine("Informe os kilometros percorridos");
                        double km = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe os litros usados");
                        double litros = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O consumo de combustível foi de {modelo.CalcularCombustivel(km, litros)}");
                            break;
                    case 15:
                        Console.WriteLine("Exercício 15");
                        Console.WriteLine("Informe um Número");
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

                    case 17:
                        Console.WriteLine("Exercicío 17");
                        Console.WriteLine("Informe seu salário mensal");
                        double mensal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O salário anual é de {modelo.CalcularSalario(mensal)}");
                        break;

                    case 18:
                        Console.WriteLine("Exercício 18");
                        Console.WriteLine("Informe o número");
                        double log = Convert.ToDouble(Console.ReadLine());                 
                            Console.WriteLine($"O logaritmo é {modelo.Logaritmo(log)}");
                        break;

                    case 19:
                        Console.WriteLine("Exercicío 19");
                        Console.WriteLine("Informe o valor do Cateto");
                        double catetoO = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor da Hipotenusa");
                        double hipotenusa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor do Seno é {modelo.CalcularSeno(catetoO, hipotenusa)}");                     
                        break;
                    case 20:
                        Console.WriteLine("Exercício 20");
                        Console.WriteLine("Informe o valor do Cateto Adjacente");
                        double adjacente = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor da Hipotensa");
                        double hipo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor do Cosseno é {modelo.CalcularCosseno(adjacente,hipo)}");
                        break;

                    case 21:
                        Console.WriteLine("Exercício 21");
                        Console.WriteLine("Informe a Base Maior");
                        double baseM= Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a Base Menor");
                        double baseP = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a altura ");
                        double alt = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"A area do Triangulo Trapezio é de : {modelo.AreaTrapezio(baseM, baseP, alt)}");
                    break;

                    case 22:
                       Console.WriteLine("Exercicío 22");
                        Console.WriteLine("Informe os dias");
                        double dias = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor em segundos é de : {modelo.ConverterDias(dias)}");  
                        break;
                    
                    case 23:
                        Console.WriteLine("Exercicío 23");
                        Console.WriteLine("Digite um número");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"A soma do número é de : {modelo.SomaDigitos(numero)}");
                        break;
                    
                    case 24:
                        Console.WriteLine("Exercicío 24");
                        Console.WriteLine("Informe um número");
                        double inverso = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 25:
                       Console.WriteLine("Exercicio 25");
                        Console.WriteLine("Informe o valor do primeiro cateto");
                        double cate1 =  Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o valor do segundo cateto");
                        double cate2 =   Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor da Hipotenusa é de  : {modelo.CalcularHipotenusa(cate1,cate2)}");
                        break;

                    case 26:
                        Console.WriteLine("Exercicío 26");
                        Console.WriteLine("Informe o valor em Decimal");
                       int decim= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Valor em Binário{modelo.Inverter(modelo.ConverterBinario(decim))}");
                        break;

                    case 27:
                        Console.WriteLine("Exercício 27");
                        Console.WriteLine("informe um numero");
                        decim = Convert.ToInt32(Console.ReadLine());
                        //OPERAÇÃO
                        Console.WriteLine($"Valor em Hexadecimal: {modelo.Hexadecimal(decim)}");
                        break;
                        //28
                    case 29:
                        Console.WriteLine("Exercicío 29");
                        Console.WriteLine("Informe o montante( terá aplicação de 15% em juros)");
                        double valor= Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O montante final é de : {modelo.CalcularJuros(valor)}");
                        break;
                        //30
                        //31
                    case 32:                    
                        Console.WriteLine("Exercicío 32");
                        Console.WriteLine("Informe um número");
                        double porcento = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"O valor em porcentagem é de : {modelo.CalcularPorcentagem(porcento)}");
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;

                       



                }  // fim do escolha  
            } while (ModificarOpcao != 0); //repetir enquanto nao for diferente de zero 
        }// fim do método

    }//fim da classe
}//fim do projeto 

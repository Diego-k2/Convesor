using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
namespace Atividade_M2
{
    class Program
    {
        static void Main(string[] args)
        {

            inicio();

            static void inicio() //Função MENU PRINCIPAL
            {
                Console.WriteLine("Bem-vindo ao nosso conversor");
                Console.WriteLine("Selecione a opção desejada: \n 1)-Conversor de medidas \n 2)-Conversor de moedas" +
                                  " \n 3)-Conversor de Peso \n 4)-Sair ");

                int opInicial = Int32.Parse(Console.ReadLine());

                if (opInicial >= 1 && opInicial <= 3)
                {
                    switch (opInicial)
                    {
                        case 1: //CONVESOR DE MEDIDA
                            Console.Clear();
                            converteMedida();
                            break;
                        case 2: //CONVERSOR DE MOEDAS
                            Console.Clear();
                            converteMoeda();
                            break;
                        case 3: //CONVERSOR DE PESO
                            Console.Clear();
                            convertePeso();
                            break;
                        case 4: //Sair
                            Console.WriteLine("Saindo do sistema  !");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opção Invalida !");
                            inicio();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA! \n");
                    inicio();
                }
            }

/*
* -----------------------------------(CONVERSOR DE MEDIDA)-------------------------------------------------
*/

            static void converteMedida() //Função Conversora de Medidas
            {
                Console.WriteLine("Você selecionou o conversor de medidas:");
                Console.WriteLine("Selecione oque você deseja: \n 1)-Métricas \n 2)-Volumétricas " +
                                  "\n 3)-Volta ao menu anterior");
                int opMed = Int32.Parse(Console.ReadLine());
                if (opMed >= 1 && opMed <= 3)
                {
                    switch (opMed)
                    {
                        case 1:
                            Console.Clear();
                            metrica();
                            break;
                        case 2:
                            Console.Clear();
                            volumetrica();
                            break;
                        case 3:
                            Console.Clear();
                            inicio();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA ! \n");
                    converteMedida();
                }
            }

/*
* ----------------------------------PASSAR PARA UMA CLASSE--(CONVERSOR MEDIDA)-----------------------------
*/

            static void volumetrica()
            {
                Console.WriteLine("Conversões volumetricas");
                Console.WriteLine("Seleciona a conversão desejada \n 1)-Litro para militro \n 2)-Militro para litro" +
                                  "\n 3)-Voltar ao menu anterior");
                int optVolumetrica = Int32.Parse(Console.ReadLine());

                switch (optVolumetrica)
                {
                    case 1: //LITRO PARA MILILITRO
                        Console.Clear();
                        litroParaMilitro();
                        break;
                    case 2:
                        Console.Clear();
                        militroParaLitro();
                        break;
                    case 3:
                        Console.Clear();
                        converteMedida();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida ! \n");
                        volumetrica();
                        break;
                }


            }

            static void litroParaMilitro()
            {
                Console.WriteLine("Litro para Militro");
                Console.WriteLine("Digite o valor em Litros");
                double medida = Double.Parse(Console.ReadLine());
                if (medida > 0)
                {
                    Console.WriteLine(calculoMegaParaMili(medida));
                } 
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    metroCentimetro();
                }
                
                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }

            }

            static void militroParaLitro()
            {
                Console.WriteLine("Militro para Litro");
                Console.WriteLine("Digite o valor em militros");
                double medida = Double.Parse(Console.ReadLine());

                if (medida > 0)
                {
                    Console.WriteLine(calculoMiliParaMega(medida));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    centimetroMetro();
                }

                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }

/*
* -----------------------------------PASSAR PARA UMA CLASSE--(CONVERSOR MEDIDA)----------------------------
*/

            static void metrica() //METRICA 
            {
                Console.WriteLine("Conversões metricas:");
                Console.WriteLine("Selecione a conversão desejada \n 1)-Metro para centimentro" +
                                  "\n 2)-Centimetro para metro \n 3)-Voltar menu anterior");
                int optMetrica = Int32.Parse(Console.ReadLine());

                switch (optMetrica)
                {
                    case 1: //m para cm 
                        Console.Clear();
                        metroCentimetro();
                        break;
                    case 2:
                        Console.Clear();
                        centimetroMetro();
                        break;
                    case 3:
                        Console.Clear();
                        converteMedida();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida !");
                        metrica();
                        break;
                }


            }

            static void metroCentimetro() //CONVERSOR METRO PARA CM
            {
                Console.WriteLine("Conversão de Metro para Centimetro:");
                Console.WriteLine("Digite o valor em Metros: ");
                double medida = Double.Parse(Console.ReadLine());

                if (medida > 0)
                {
                    Console.WriteLine(calculoMegaParaMili(medida));
                } 
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    metroCentimetro();
                }
                
                
                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
                
            }

            static void centimetroMetro() //CONVERSOR CM PARA METRO
            {
                Console.WriteLine("Conversão Centimetro para Metro");
                Console.WriteLine("Digite o valor em Centimetros: ");
                double medida = Double.Parse(Console.ReadLine());

                if (medida > 0)
                {
                    Console.WriteLine(calculoMiliParaMega(medida));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    centimetroMetro();
                }

               
                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }
/*
* ---------------------------------------CONVERTE MOEDA----------------------------------------------------
*/

            static void converteMoeda()
            {
                Console.WriteLine("Você selecionou o conversor de moedas");
                Console.WriteLine("Selecione a moeda que você deseja \n 1)-Dolar \n 2)-Euro " +
                                  "\n 3)-Voltar ao menu principal");
                int opMed = Int32.Parse(Console.ReadLine());
                if (opMed >= 1 && opMed <= 3)
                {
                    switch (opMed)
                    {
                        case 1:
                            Console.Clear();
                            dolar();
                            break;
                        default:
                            Console.WriteLine("OPÇÃO INVALIDA!");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA ! \n \n");
                    converteMedida();
                }
            }

/*
 * ----------------------------DOLAR------------------------------------------------------------------------------------
 */
            static void dolar()
            {
                Console.WriteLine("Conversões com Dolar:");
                Console.WriteLine("Selecione a conversão desejada \n 1)-Dolar para real" +
                                  "\n 2)-Real para dolar \n 3)-Voltar menu anterior");
                int optDolar = Int32.Parse(Console.ReadLine());

                switch (optDolar)
                {
                    case 1:
                        Console.Clear();
                        dolarParaReal();
                        break;
                    case 2:
                        Console.Clear();
                        realParaDolar();
                        break;
                    case 3:
                        Console.Clear();
                        converteMoeda();
                        break;
                    default:
                        Console.WriteLine("Opção inválida ! \n");
                        dolar();
                        break;
                }
            }

            static void dolarParaReal()
            {
                Console.WriteLine("Você selecionou a opção de converter Dolar para real");
                Console.WriteLine("Digite o valor em Dolares");
                double valor = Double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Console.WriteLine(calculoEstrangeiroParaReal(4.77, valor, "reais"));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida !");
                    dolarParaReal();
                }

                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }

            }
            
            static void realParaDolar()
            {
                Console.WriteLine("Você selecionou a opção de converter Real para Dolar");
                Console.WriteLine("Digite o valor em Reais");
                double valor = Double.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    Console.WriteLine(calculoRealParaExtrangeiro(4.77, valor, "dolares"));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inváilida !");
                    realParaDolar();
                }

                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }
/*
 * ----------------------------PASSAR PARA UMA CLASSE--------CONVERTE MOEDA---------------------------------------------
 */

            static void euro()
            {
                Console.WriteLine("Conversões com Dolar:");
                Console.WriteLine("Selecione a conversão desejada \n 1)-Dolar para real" +
                                  "\n 2)-Real para dolar \n 3)-Voltar menu anterior");
                int optDolar = Int32.Parse(Console.ReadLine());

                switch (optDolar)
                {
                    case 1:
                        Console.Clear();
                        euroParaReal();
                        break;
                    case 2:
                        Console.Clear();
                        realParaEuro();
                        break;
                    case 3:
                        Console.Clear();
                        converteMoeda();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida ! \n");
                        euro();
                        break;
                }
            }

            static void euroParaReal()
            {
                Console.WriteLine("Você selecionou a opção de converter Euro para real");
                Console.WriteLine("Digite o valor em Euro");
                double valor = Double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    Console.WriteLine(calculoEstrangeiroParaReal(5.15, valor, "reais"));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida !");
                    dolarParaReal();
                }
                
                
                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }

            static void realParaEuro()
            {
                Console.WriteLine("Você selecionou a opção de converter Real para Euro");
                Console.WriteLine("Digite o valor em Reais");
                double valor = Double.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    Console.WriteLine(calculoRealParaExtrangeiro(4.77, valor, "euros"));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inváilida !");
                    realParaDolar();
                }

                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }
            
/*
 * ----------------------------CONVERTE PESO---------------------------------------------------------------------------------
 */
            static void convertePeso()
            {
                Console.WriteLine("Conversões volumetricas");
                Console.WriteLine("Seleciona a conversão desejada \n 1)-Litro para militro \n 2)-Militro para litro" +
                                  "\n 3)-Voltar ao menu anterior");
                int optVolumetrica = Int32.Parse(Console.ReadLine());

                switch (optVolumetrica)
                {
                    case 1: 
                        Console.Clear();
                        kiloParaGrama();
                        break;
                    case 2:
                        Console.Clear();
                        gramaParaKilo();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida ! \n");
                        convertePeso();
                        break;
                }
            }

            static void kiloParaGrama()
            {
                Console.WriteLine("Kilo para Grama");
                Console.WriteLine("Digite o valor em Kilos");
                double medida = Double.Parse(Console.ReadLine());
                if (medida > 0)
                {
                    Console.WriteLine(calculoMegaParaMili(medida));
                } 
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    metroCentimetro();
                }
                
                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }

            static void gramaParaKilo()
            {
                Console.WriteLine("Grama para Kilo");
                Console.WriteLine("Digite o valor em Gramas");
                double medida = Double.Parse(Console.ReadLine());

                if (medida > 0)
                {
                    Console.WriteLine(calculoMiliParaMega(medida));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    centimetroMetro();
                }

                if (sair())
                {
                    Console.Clear();
                    realParaDolar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do sistema......");
                }
            }
            
            
/*
 * ----------------------------CALCULOS---------------------------------------------------------------------------------
 */

            static string calculoMegaParaMili(double medida)
            {
                double calculo = medida * 1000;
                return "O valor convertido é " + calculo + "\n";
            }

            static string calculoMiliParaMega(double medida)
            {
                double calculo = medida / 1000;
                return "O valor convertido é " + calculo + "\n";
            }

            static string calculoRealParaExtrangeiro(double cotação, double valor, string moeda)
            {
                if (valor > 0)
                {
                    double calculo = valor / cotação;
                    return "O valor em " + moeda + " é igual, $" + calculo;
                }

                return "";
            }
            
            static string calculoEstrangeiroParaReal(double cotação, double valor, string moeda)
            {
                if (valor > 0)
                {
                    double calculo = valor * cotação;
                    return "O valor em " + moeda + " é igual, $" + calculo;
                }

                return "";
            }

            static bool sair()
            {
                Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                int opSair = Int32.Parse(Console.ReadLine());
                if (opSair == 1)
                {
                    return true;
                }

                return false;
            }
            
        }
    }
}
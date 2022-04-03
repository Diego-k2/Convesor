﻿using System;
using System.Runtime.CompilerServices;
//TODO: IMPLEMENTAR RESTO DOS METODOS
//TODO: TENTAR REDUZIR O NUMERO DE METODOS 
namespace Atividade_M2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            static void inicio() //Função MENU PRINCIPAL
            {
                Console.WriteLine("Bem-vindo ao nosso conversor");
                Console.WriteLine("Selecione a opção desejada: \n 1)-Conversor de medidas \n 2)-Conversor de moedas" +
                                  " \n 3)-Conversor de Peso ");

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
                        
                    }
                } else
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
                        litroParaMilitro();
                        break;
                    case 2:
                        militroParaLitro();
                        break;
                    case 3:
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
                    double calculo = medida * 1000;
                    Console.WriteLine("O valor de " + medida + "L em ml é: " + calculo + " \n");
                    //SAIR DO APLICATIVO
                    Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                    int opSair = Int32.Parse(Console.ReadLine());
                    if (opSair == 1)
                    {
                        Console.Clear();
                        litroParaMilitro();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    litroParaMilitro();
                }

            }

            static void militroParaLitro()
            {
                Console.WriteLine("Militro para Litro");
                Console.WriteLine("Digite o valor em militros");
                double medida = Double.Parse(Console.ReadLine());
                
                if (medida > 0)
                {
                    double calculo = medida / 1000;
                    Console.WriteLine("O valor de " + medida + "ml em L é: " + calculo + " \n");
                    //SAIR DO APLICATIVO
                    Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                    int opSair = Int32.Parse(Console.ReadLine());
                    if (opSair == 1)
                    {
                        Console.Clear();
                        litroParaMilitro();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    litroParaMilitro();
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
                        metroCentimetro();
                        break;
                    case 2:
                        centimetroMetro();
                        break;
                    case 3:
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
                    double calculo = medida * 1000;
                    Console.WriteLine("O valor de " + medida + "M em CM é: " + calculo + "cm \n");
                    //SAIR DO APLICATIVO
                    Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                    int opSair = Int32.Parse(Console.ReadLine());
                    if (opSair == 1)
                    {
                        Console.Clear();
                        metroCentimetro();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    metroCentimetro();
                }
            }

            static void centimetroMetro() //CONVERSOR CM PARA METRO
            {
                Console.WriteLine("Conversão Centimetro para Metro");
                Console.WriteLine("Digite o valor em Centimetros: ");
                double medida = Double.Parse(Console.ReadLine());

                if (medida > 0)
                {
                    double calculo = medida / 1000;
                    Console.WriteLine("O valor de " + medida + "cm em M é: " + calculo );
                    //SAIR DO APLICATIVO
                    Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                    int opSair = Int32.Parse(Console.ReadLine());
                    if (opSair == 1)
                    {
                        Console.Clear();
                        centimetroMetro();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você Digitou um valor invalido !");
                    centimetroMetro();
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
                } else
                {
                    Console.Clear();
                    Console.WriteLine("OPÇÃO INVÁLIDA ! \n \n"); 
                    converteMedida();
                }              
                
/*
 * ----------------------------PASSAR PARA UMA CLASSE--------CONVERTE MOEDA---------------------------------------------
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
                            dolar();
                            break;
                        default:
                            Console.WriteLine("Opção inválida !");
                            dolar();
                            break;
                    }
                }

            }
                   
            
 /*
 * ----------------------------PASSAR PARA UMA CLASSE--------CONVERTE MOEDA---------------------------------------------
 */
                static void dolarParaReal()  
                {
                    Console.WriteLine("Você selecionou a opção de converter Dolar para real");
                    Console.WriteLine("Digite o valor em Dolares");
                    double valor = Double.Parse(Console.ReadLine());

                    if (valor > 0)
                    {
                        double calculo = valor* 4.77;  //VALOR DOLAR EM 02/04/2022
                        Console.WriteLine("O valor em Reiais é igual, R$" + calculo );
                        //SAIR DO APLICATIVO
                        Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                        int opSair = Int32.Parse(Console.ReadLine());
                        if (opSair == 1)
                        {
                            dolarParaReal();
                        }
                    }  else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção Invalida !");
                        dolarParaReal();
                    }

                }
                
/*
 * ----------------------------PASSAR PARA UMA CLASSE--------CONVERTE MOEDA---------------------------------------------
 */

            static void realParaDolar()
            {
                Console.WriteLine("Você selecionou a opção de converter Real para Dolar");
                Console.WriteLine("Digite o valor em Reais");
                double valor = Double.Parse(Console.ReadLine());

                if (valor > 0)
                {
                    double calculo = valor /  4.77;  //VALOR DOLAR EM 02/04/2022
                    Console.WriteLine("O valor em Dolares é igual, USD$" + calculo );
                    //SAIR DO APLICATIVO
                    Console.WriteLine("Deseja Continuar ? \n 1)-Sim \n 2)-Não");
                    int opSair = Int32.Parse(Console.ReadLine());
                    if (opSair == 1)
                    {
                        realParaDolar();
                    }
                }  else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Invalida !");
                    realParaDolar();
                }
            }

/*
 * ----------------------------PASSAR PARA UMA CLASSE--------CONVERTE MOEDA---------------------------------------------
 */

            static void euro()//TODO: COMEÇAR A IMPLEMENTAR
            {
                Console.WriteLine("Conversões com Dolar:");
                Console.WriteLine("Selecione a conversão desejada \n 1)-Dolar para real" +
                                  "\n 2)-Real para dolar \n 3)-Voltar menu anterior");
                int optDolar = Int32.Parse(Console.ReadLine());

                switch (optDolar)
                {
                    case 1: 
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Opção inválida !");
                        break;
                }
            }
            

            inicio();
            

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrela
{
    class Program
    {
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static int[] PentaGrama = new int[6];
        public static string[] StatusPentaGrama = new string[6];
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static int[] HabraGrama;
        public static string[] StatusHabraGrama;
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static int N = 0; // Determina o indeice da estrela
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        static void Main()
        {
            int W = 0, Op = 0;
            int  A, B;
            A = Console.WindowWidth;
            B = Console.WindowHeight;
            A = 60;
            Console.SetWindowSize(A, B);              // Controle do tamanho da janela
            Console.Title = "Orphew Algorithms 2.0";  // Titulo
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Star - Desafio das tochas");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 1 - PentaGrama\n 2 - Habradabra");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write    (" Codigo: ");
                try
                {
                    Op = Convert.ToInt32(Console.ReadLine());
                    if (Op < 1 && Op > 3)
                    {
                        Main();
                    }
                }
                catch
                {
                    Main();
                }
                switch (Op)
                {
                    case 1:
                        Penta();
                        break;
                        
                     case 2:
                        Hablacadabra();
                        break;

                    case 9:
                        Main();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (W == 0);
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void Penta()
        {
            int Wx = 0, W = 0, W1 = 0, W2 = 0, Op = 0, Op1 = 0, Op2 = 0; // Controles de menus e estrutuas do while
            int i, j = 0; // Contadores de estrutura de repetição for
            int QtdGames = 0;
            int Cont  = 0, Cont1 = 0, Cont2 = 0, Cont3  = 0;  // Contadores
            int tocha = 0, best  = 0, Resul = 0, Parada = 0;  // Tocha recebe do User, Best a melhor feita pela IA, 
            int CtrlPen = 0, CtrlPen1 = 0;          // Controles de estrutura do While
            int Nlances = 0, NNlances = 0;          // Numero de jogadas
            int[] QtdpLances = new int[5000000];    // Quantidade de lances por resolução
            int[] Positons   = new int[5000000];    //
            int[] PositonsL  = new int[5000000];    //
            int[] Lances     = new int[5000000];    // Todos os lances feitos na partida
            for (i = 0; i < 5000000; i++)
            {
                QtdpLances[i] = 0;   // Zera o vertor de Qtdplances
            }
            Random   X = new Random();
            LoadinPentagrama();
            do
            {
                LoadinPentagrama();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Star - Penta Grama");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 1 - Resolver\n 2 - Tentativa e Erro\n 3 - Voltar");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Codigo: ");
                try
                {
                    Op = Convert.ToInt32(Console.ReadLine());
                    if(Op < 1 && Op > 3)
                    {
                        Main();
                    }
                }
                catch
                {
                    Main();
                }               
                switch (Op)
                {
                    case 1:
                        do
                        {                         
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Star - Desafio das tochas");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                   F 1");
                            Console.Write("                   [");
                            if (PentaGrama[0] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            Console.Write("" + PentaGrama[0]);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("]                     ");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.WriteLine("                 //  \\\\ ");
                            Console.WriteLine("                //    \\\\ ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("     F 5");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("       //      \\\\");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("       F 2");
                            Console.WriteLine();
                            Console.Write("     [");
                            if (PentaGrama[4] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            Console.Write("" + PentaGrama[4]);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(" ====================== ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("[");
                            if (PentaGrama[1] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            Console.Write("" + PentaGrama[1]);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("]");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.WriteLine("      \\\\     //          \\\\     //");
                            Console.WriteLine("         \\\\ //            \\\\ //");
                            Console.WriteLine("           //              \\\\  ");
                            Console.WriteLine("          //  \\\\        //  \\\\");
                            Console.WriteLine("         //       \\\\ //      \\\\");
                            Console.WriteLine("        //        // \\\\       \\\\");
                            Console.WriteLine("       //      //       \\\\     \\\\");
                            Console.WriteLine("      //    //             \\\\   \\\\");
                            Console.WriteLine("     //  //                  \\\\  \\\\");
                            Console.WriteLine("    ////                        \\\\\\\\");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("    [");
                            if (PentaGrama[3] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            Console.Write("" + PentaGrama[3]);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("]                          [");
                            if (PentaGrama[2] == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            }
                            Console.Write("" + PentaGrama[2]);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("]");
                            Console.WriteLine();
                            Console.WriteLine("    F 4                          F 3");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (i=0; i<5; i++)
                            {
                                Console.WriteLine(" [" + (i+1) + "] - Tocha F"+ (i + 1) + ": " + PentaGrama[i] + " Status: " + StatusPentaGrama[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Escolha uma tocha: \n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" 1-[F1]  2-[F2]  3-[F3]  4-[F4] 5-[F5]");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\n 7 - Resetar");
                            Console.WriteLine(" 8 - Voltar Menu");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" 9 - Main Menu\n 0 - Exit");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" Codigo: ");
                            try
                            {
                                Op1 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Main();
                            }
                            if (Op1 >= 1 && Op1 <= 5)
                            {
                                BuscaPentaGrama(Op1);
                            }
                            else
                            {
                                if(Op1 == 0)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    if (Op1 == 9)
                                    {
                                        Main();
                                    }
                                    else
                                    {
                                        if (Op1 == 8)
                                        {
                                            W1 = 1;
                                        }
                                        else
                                        { 
                                            if (Op1 == 7)
                                            {
                                                LoadinPentagrama();
                                            }     
                                        }
                                    }
                                }
                            }
                        } while (W1 == 0);
                        W1 = 0;
                        break;
                    // ---------------------------------------------------------------------------------- // I.A.
                    // ---------------------------------------------------------------------------------- //
                    case 2:
                        do
                        {
                            if (CtrlPen1 == 0)
                            {
                                do
                                {                              
                                  do
                                  {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Star - Desafio das tochas - IA");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        if (CtrlPen == 0)
                                        {
                                            Console.WriteLine(" * - Digite a quantidade de caminhos ");
                                            Console.WriteLine(" * - O Numero deve ser impar e (> 5) ");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("\n 8 - Main Menu\n 0 - Exit");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" ------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(" Codigo: ");
                                            try
                                            {
                                                QtdGames = Convert.ToInt32(Console.ReadLine());  // Recebe a quantidade de Resoluções que se deseja
                                                if (QtdGames > 1000)
                                                {
                                                    Main();
                                                }
                                                else
                                                {
                                                    if (QtdGames == 0)
                                                    {
                                                        Environment.Exit(0);
                                                    }
                                                    else
                                                    {
                                                        if (QtdGames == 8)
                                                        {
                                                            Main();
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Main();
                                            }
                                        }
                                        CtrlPen = 1; // Assim não repete a pergunta
                                        // ----------------------------------------------------------------------- // Estrela
                                        // ----------------------------------------------------------------------- // Estrela
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                   F 1");
                                        Console.Write("                   [");
                                        if (PentaGrama[0] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[0]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]                     ");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("");
                                        Console.WriteLine("                 //  \\\\ ");
                                        Console.WriteLine("                //    \\\\ ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("     F 5");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Write("       //      \\\\");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("       F 2");
                                        Console.WriteLine();
                                        Console.Write("     [");
                                        if (PentaGrama[4] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[4]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Write(" ====================== ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("[");
                                        if (PentaGrama[1] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[1]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine();
                                        Console.WriteLine("      \\\\     //          \\\\     //");
                                        Console.WriteLine("         \\\\ //            \\\\ //");
                                        Console.WriteLine("           //              \\\\  ");
                                        Console.WriteLine("          //  \\\\        //  \\\\");
                                        Console.WriteLine("         //       \\\\ //      \\\\");
                                        Console.WriteLine("        //        // \\\\       \\\\");
                                        Console.WriteLine("       //      //       \\\\     \\\\");
                                        Console.WriteLine("      //    //             \\\\   \\\\");
                                        Console.WriteLine("     //  //                  \\\\  \\\\");
                                        Console.WriteLine("    ////                        \\\\\\\\");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("    [");
                                        if (PentaGrama[3] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[3]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]                          [");
                                        if (PentaGrama[2] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[2]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.WriteLine();
                                        Console.WriteLine("    F 4                          F 3");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.WriteLine(" ------------------------------------------");
                                        // ----------------------------------------------------------------------- // Estrela
                                        // ----------------------------------------------------------------------- // Estrela
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        for (i = 0; i < 5; i++)
                                        {
                                            Console.WriteLine(" [" + (i + 1) + "] - Tocha F" + (i + 1) + ": " + PentaGrama[i] + " Status: " + StatusPentaGrama[i]);
                                        }
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Escolha uma tocha: \n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(" 1-[F1]  2-[F2]  3-[F3]  4-[F4] 5-[F5]");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine(" Cont: " + Cont + " Find: " + (Cont2 + 1) + " QtdLan: " + NNlances + " Tocha: " + tocha);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(" Loadin...  ");
                                        Nlances = Nlances + 1;   // N lances indica o total lances feito durante toda a resolução, começa em 1
                                        NNlances = NNlances + 1; // NN conta os lances para salvar a quantidade feita ate entao, começa em 1
                                        tocha = X.Next(1, 6);    // Gera randomicamente um numero entre 1 e 5
                                        BuscaPentaGrama(tocha);  // Configura a estrela conforme recebe os camando de tocha
                                        System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(250)); // Aguada tempo
                                        Lances[Cont] = tocha;    // Lancens recebe o valor selecionado, e salva no vetor começando com ZERO
                                        Cont = Cont + 1;         // Cont recebe mais 1 para salvar em lances no proximo turno
                                        // If com condição de todas estarem acessas para sair
                                        if (PentaGrama[0] == 1 && PentaGrama[1] == 1 && PentaGrama[2] == 1 && PentaGrama[3] == 1
                                        && PentaGrama[4] == 1)
                                        {
                                            Positons[Cont3] = tocha; // Recebe a ultima tocha acessa no lance
                                            PositonsL[Cont3] = Cont; // indica o numero do lance feito
                                            Cont3 = Cont3 + 1;       // Atualiza o contador para positions
                                            LoadinPentagrama();
                                            W2 = 1;
                                        }
                                    } while (W2 == 0) ;
                                  W2 = 0; 
                                  QtdpLances[Cont2] = NNlances; // Qtd de lances, recebe o numero de lances e salve no game 1. desde zero, usando contador cont2
                                  Cont2 = Cont2 + 1;
                                  Cont1 = Cont1 + 1; // Mede a quantidade de jogos que passou
                                  NNlances = 0; // Reseta a variavel para contar numero de lances da proxima resolução
                                } while (QtdGames != Cont1);
                                Cont = 0;  // Reseta Cont
                                Cont1 = 0; // Reseta Cont1
                                Cont2 = 0; // Reseta Cont2
                                W2 = 0;
                                best = QtdpLances[0];
                                Resul = 0;
                                for (i = 0; i < QtdGames; i++)
                                {
                                    if (QtdpLances[i] <= best)
                                    {
                                        best = QtdpLances[i]; // Verifica o que teve menos lances
                                        Resul = i;            // Mostra a posição nos vetores 
                                    }
                                }
                            }
                            CtrlPen1 = 1;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Star - Desafio das tochas - IA");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" RESULTADOS: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Quantidade de caminhos : "+QtdGames);
                            Console.WriteLine(" Quantidade de Lances   : "+Nlances);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Melhor resultado       : "+best);
                            Console.WriteLine(" Na resolucao           : "+(Resul+1));
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Quantidade por resolucao: \n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            for (i=0; i<QtdGames; i++)
                            {
                                Console.WriteLine(" ["+(i+1)+"] = " + QtdpLances[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" 1 - Repetir Test\n 2 - Visualizar Jogos\n 3 - Voltar Menu");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" Codigo: ");
                            try
                            {
                                Op1 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Main();
                            }
                            switch (Op1)
                            {
                                case 1:
                                    CtrlPen1 = 0;
                                    CtrlPen = 0;
                                    Wx = 0;
                                    break;

                                case 2:                                   
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" Star - Desafio das tochas - IA");
                                    Console.ForegroundColor = ConsoleColor.Red;                                    
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" ------------------------------------------");
                                    Parada = -1;
                                    for (i=0; i<QtdGames; i++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(" ---------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Find: " + (i) + " Qtd: "+QtdpLances[i]);
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(" ---------------------");
                                        Console.ForegroundColor = ConsoleColor.Cyan;                                     
                                        for (j = Parada; j < ((QtdpLances[i]) + Parada); j++)
                                        {
                                            Console.WriteLine(" Lance: "+Lances[j+1]);
                                        }
                                        if(QtdpLances[i]+1 > (Parada-1))
                                        {
                                            Parada = ((QtdpLances[i]) + Parada);
                                        }
                                        else
                                        {
                                            Parada = (j);
                                        }
                                    }                                  
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(" ---------------------");
                                    Console.WriteLine(" ---------------------");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" 1 - Voltar para Resultados");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(" Codigo: ");
                                    try
                                    {
                                        Op2 = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Main();
                                    }
                                    if (Op2 == 1)
                                    {
                                        Wx = 0;
                                    }
                                    else
                                    {
                                        if(Op2 == 9)
                                        {
                                            Main();
                                        }
                                        else
                                        {
                                            if(Op2 == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Main();
                                            }
                                        }
                                    }
                                    break;

                                case 3:
                                    Wx = 1;
                                    break;


                                case 9:
                                    Main();
                                    break;

                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (Wx == 0);
                        Wx = 0;
                        break;
                    // ---------------------------------------------------------------------------------- // I.A.
                    // ---------------------------------------------------------------------------------- //
                    case 3:
                        Main();
                        break;

                    case 9:
                        Main();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (W == 0);
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void Hablacadabra()
        {
            int W = 0, W1 = 0, Op = 0, Op1 = 0, i, Qtd = 0, Ctrl = 0;

            int Wx = 0, W2 = 0, Op2 = 0; // Controles de menus e estrutuas do while
            int j = 0; // Contadores de estrutura de repetição for
            int QtdGames = 0;
            int Cont = 0, Cont1 = 0, Cont2 = 0, Cont3 = 0;  // Contadores
            int tocha = 0, best = 0, Resul = 0, Parada = 0;  // Tocha recebe do User, Best a melhor feita pela IA, 
            int CtrlPen = 0, CtrlPen1 = 0;          // Controles de estrutura do While
            int Nlances = 0, NNlances = 0;          // Numero de jogadas
            int[] QtdpLances = new int[5000000];    // Quantidade de lances por resolução
            int[] Positons   = new int[5000000];    //
            int[] PositonsL  = new int[5000000];    //
            int[] Lances = new int[5000000];    // Todos os lances feitos na partida
            Random X = new Random();        
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Star - Hablacadabra");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 1 - Resolver\n 2 - Tentativa e Erro\n 3 - Voltar");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Codigo: ");
                try
                {
                    Op = Convert.ToInt32(Console.ReadLine());
                    if (Op != 0 && Op1 != 8 && Op1 != 1 && Op1 != 2 && Op < 0)
                    {
                        Main();
                    }
                    if (Op == 0)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        if (Op == 9)
                        {
                            Main();
                        }
                        else
                        {
                            if (Op == 3)
                            {
                                W1 = 1;
                            }
                        }
                    }
                }
                catch
                {
                    Main();
                }
                switch (Op)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Star - Desafio das tochas");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            if (Ctrl == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" Quanditade de pontas: ");
                                try
                                {
                                    Qtd = Convert.ToInt32(Console.ReadLine());
                                    if (Qtd < 0 || Qtd > 500)
                                    {
                                        Main();
                                    }
                                }
                                catch
                                {
                                    Main();
                                }                                
                                StatusHabraGrama = new string[Qtd];        // Aloca o vetor de estados
                                HabraGrama = new int[Qtd];                 // Aloca o vetor de valor
                                LoadinHabragrama(Qtd);                     // Carrega tudo apagado e com 0
                                Indice(Qtd);                               // Encontra o Indice variavel global N
                            }
                            Ctrl = 1;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Star - Desafio das tochas");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            for (i = 0; i < Qtd; i++)
                            {
                                Console.WriteLine(" [" + (i + 1) + "] - Tocha F" + (i + 1) + ": " + HabraGrama[i] + " Status: " + StatusHabraGrama[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Escolha uma tocha: \n");
                            for (i = 0; i < Qtd; i++)
                            {
                                Console.Write(" " + (i + 1) + "-[F" + (i + 1) + "]");
                                if (i % 4 == 0)
                                {
                                    Console.Write("\n");
                                }
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\n\n 8 - Main Menu\n 0 - Exit");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" Codigo: ");
                            try
                            {
                                Op1 = Convert.ToInt32(Console.ReadLine());
                                
                            }
                            catch
                            {
                                Main();
                            }
                           
                            if (Op1 >= 1 && Op1 <= Qtd)
                            {
                                BuscaHabraGrama(Op1, Qtd);
                            }
                            else
                            {
                                if (Op1 == 0)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    if (Op1 == 8)
                                    {
                                        Main();
                                    }
                                    else
                                    {
                                        if (Op1 == 3)
                                        {
                                            W1 = 1;
                                        }
                                    }
                                }
                            }
                        } while (W1 == 0);
                        W1 = 0;
                        break;
                    // ------------------------------------------------------------- //
                    // ------------------------------------------------------------- //
                    case 2:
                        do
                        {
                            if (CtrlPen1 == 0)
                            {
                                do
                                {
                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Star - Desafio das tochas - IA");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        if (CtrlPen == 0)
                                        {
                                            Console.WriteLine(" * - Digite a quantidade de caminhos ");
                                            Console.WriteLine(" * - O Numero deve ser impar e (> 5) ");
                                            Console.ForegroundColor = ConsoleColor.DarkGray;
                                            Console.WriteLine("\n 8 - Main Menu\n 0 - Exit");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" ------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(" Codigo: ");
                                            try
                                            {
                                                QtdGames = Convert.ToInt32(Console.ReadLine());  // Recebe a quantidade de Resoluções que se deseja
                                                if (QtdGames > 1000)
                                                {
                                                    Main();
                                                }
                                                else
                                                {
                                                    if (QtdGames == 0)
                                                    {
                                                        Environment.Exit(0);
                                                    }
                                                    else
                                                    {
                                                        if (QtdGames == 8)
                                                        {
                                                            Main();
                                                        }
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Main();
                                            }
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" ------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine(" Star - Desafio das tochas - IA");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(" ------------------------------------------");
                                            Console.WriteLine(" ------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write(" Quanditade de pontas: ");
                                            try
                                            {
                                                Qtd = Convert.ToInt32(Console.ReadLine());
                                                if (Qtd < 0 || Qtd > 500)
                                                {
                                                    Main();
                                                }
                                            }
                                            catch
                                            {
                                                Main();
                                            }
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            StatusHabraGrama = new string[Qtd];        // Aloca o vetor de estados
                                            HabraGrama = new int[Qtd];                 // Aloca o vetor de valor
                                            LoadinHabragrama(Qtd);                     // Carrega tudo apagado e com 0
                                            Indice(Qtd);                               // Encontra o Indice variavel global N

                                        }
                                        CtrlPen = 1; // Assim não repete a pergunta
                                        // ----------------------------------------------------------------------- // Estrela
                                        // ----------------------------------------------------------------------- // Estrela
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("                   F 1");
                                        Console.Write("                   [");
                                        if (PentaGrama[0] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[0]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]                     ");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("");
                                        Console.WriteLine("                 //  \\\\ ");
                                        Console.WriteLine("                //    \\\\ ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("     F 5");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Write("       //      \\\\");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("       F 2");
                                        Console.WriteLine();
                                        Console.Write("     [");
                                        if (PentaGrama[4] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[4]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Write(" ====================== ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("[");
                                        if (PentaGrama[1] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[1]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine();
                                        Console.WriteLine("      \\\\     //          \\\\     //");
                                        Console.WriteLine("         \\\\ //            \\\\ //");
                                        Console.WriteLine("           //              \\\\  ");
                                        Console.WriteLine("          //  \\\\        //  \\\\");
                                        Console.WriteLine("         //       \\\\ //      \\\\");
                                        Console.WriteLine("        //        // \\\\       \\\\");
                                        Console.WriteLine("       //      //       \\\\     \\\\");
                                        Console.WriteLine("      //    //             \\\\   \\\\");
                                        Console.WriteLine("     //  //                  \\\\  \\\\");
                                        Console.WriteLine("    ////                        \\\\\\\\");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("    [");
                                        if (PentaGrama[3] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[3]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]                          [");
                                        if (PentaGrama[2] == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                        }
                                        Console.Write("" + PentaGrama[2]);
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("]");
                                        Console.WriteLine();
                                        Console.WriteLine("    F 4                          F 3");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.WriteLine(" ------------------------------------------");
                                        // ----------------------------------------------------------------------- // Estrela
                                        // ----------------------------------------------------------------------- // Estrela
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        for (i = 0; i < 5; i++)
                                        {
                                            Console.WriteLine(" [" + (i + 1) + "] - Tocha F" + (i + 1) + ": " + PentaGrama[i] + " Status: " + StatusPentaGrama[i]);
                                        }
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Escolha uma tocha: \n");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(" 1-[F1]  2-[F2]  3-[F3]  4-[F4] 5-[F5]");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine(" Cont: " + Cont + " Find: " + (Cont2 + 1) + " QtdLan: " + NNlances + " Tocha: " + tocha);
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(" ------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(" Loadin...  ");
                                        Nlances = Nlances + 1;   // N lances indica o total lances feito durante toda a resolução, começa em 1
                                        NNlances = NNlances + 1; // NN conta os lances para salvar a quantidade feita ate entao, começa em 1
                                        tocha = X.Next(1, 6);    // Gera randomicamente um numero entre 1 e 5
                                        BuscaPentaGrama(tocha);  // Configura a estrela conforme recebe os camando de tocha
                                        System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(10)); // Aguada tempo
                                        Lances[Cont] = tocha;    // Lancens recebe o valor selecionado, e salva no vetor começando com ZERO
                                        Cont = Cont + 1;         // Cont recebe mais 1 para salvar em lances no proximo turno
                                        // If com condição de todas estarem acessas para sair
                                        if (PentaGrama[0] == 1 && PentaGrama[1] == 1 && PentaGrama[2] == 1 && PentaGrama[3] == 1
                                        && PentaGrama[4] == 1)
                                        {
                                            Console.Write(" Press Enter To Continue: ");
                                            Console.ReadKey();
                                            Positons[Cont3] = tocha; // Recebe a ultima tocha acessa no lance
                                            PositonsL[Cont3] = Cont; // indica o numero do lance feito
                                            Cont3 = Cont3 + 1;       // Atualiza o contador para positions
                                            LoadinPentagrama();
                                            W2 = 1;
                                        }
                                    } while (W2 == 0);
                                    W2 = 0;
                                    QtdpLances[Cont2] = NNlances; // Qtd de lances, recebe o numero de lances e salve no game 1. desde zero, usando contador cont2
                                    Cont2 = Cont2 + 1;
                                    Cont1 = Cont1 + 1; // Mede a quantidade de jogos que passou
                                    NNlances = 0; // Reseta a variavel para contar numero de lances da proxima resolução
                                } while (QtdGames != Cont1);
                                Cont = 0;  // Reseta Cont
                                Cont1 = 0; // Reseta Cont1
                                Cont2 = 0; // Reseta Cont2
                                W2 = 0;
                                best = QtdpLances[0];
                                Resul = 0;
                                for (i = 0; i < QtdGames; i++)
                                {
                                    if (QtdpLances[i] <= best)
                                    {
                                        best = QtdpLances[i]; // Verifica o que teve menos lances
                                        Resul = i;            // Mostra a posição nos vetores 
                                    }
                                }
                            }
                            CtrlPen1 = 1;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Star - Desafio das tochas - IA");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" RESULTADOS: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Quantidade de caminhos : " + QtdGames);
                            Console.WriteLine(" Quantidade de Lances   : " + Nlances);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(" Melhor resultado       : " + best);
                            Console.WriteLine(" Na resolucao           : " + (Resul + 1));
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" -------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Quantidade por resolucao: \n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            for (i = 0; i < QtdGames; i++)
                            {
                                Console.WriteLine(" [" + (i + 1) + "] = " + QtdpLances[i]);
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" 1 - Repetir Test\n 2 - Visualizar Jogos\n 3 - Voltar Menu");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" Codigo: ");
                            try
                            {
                                Op1 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Main();
                            }
                            switch (Op1)
                            {
                                case 1:
                                    CtrlPen1 = 0;
                                    CtrlPen = 0;
                                    Wx = 0;
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" Star - Desafio das tochas - IA");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" Qtd de lances por resolucao: ");
                                    for (i = 0; i < QtdGames; i++)
                                    {
                                        Console.WriteLine(" [" + (i + 1) + "] = " + QtdpLances[i]);
                                    }
                                    Parada = -1;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" ------------------------------------------");
                                    for (i = 0; i < QtdGames; i++)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(" ---------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(" Find: " + (i) + " Qtd: " + QtdpLances[i]);
                                        Console.WriteLine(" ---------------------");
                                        Console.WriteLine("  P : " + Parada);
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        for (j = Parada; j < ((QtdpLances[i]) + Parada); j++)
                                        {
                                            Console.WriteLine("i :" + (i) + "J: " + (j + 1) + " Lances: " + Lances[j + 1] + " Qtdplances:" + QtdpLances[i] + "PArada: " + Parada);
                                        }
                                        if (QtdpLances[i] + 1 > (Parada - 1))
                                        {
                                            Parada = ((QtdpLances[i]) + Parada);
                                        }
                                        else
                                        {
                                            Parada = (j);
                                        }
                                    }

                                    Parada = 0;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(" ---------------------");
                                    for (i = 0; i < Nlances; i++)
                                    {
                                        Console.WriteLine(" [" + (i) + "] = " + Lances[i]);
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(" ---------------------");
                                    Console.WriteLine(" ---------------------");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine(" ---------------------");
                                    for (i = 0; i < Cont3; i++)
                                    {
                                        Console.WriteLine(" [" + (i) + "] = " + Positons[i] + " Em = " + PositonsL[i]);
                                    }
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(" ---------------------");
                                    Console.WriteLine(" ---------------------");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(" 1 - Voltar para Resultados");
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine("\n 9 - Main Menu\n 0 - Exit");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(" ------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(" Codigo: ");
                                    try
                                    {
                                        Op2 = Convert.ToInt32(Console.ReadLine());
                                    }
                                    catch
                                    {
                                        Main();
                                    }
                                    if (Op2 == 1)
                                    {
                                        Wx = 0;
                                    }
                                    else
                                    {
                                        if (Op2 == 9)
                                        {
                                            Main();
                                        }
                                        else
                                        {
                                            if (Op2 == 0)
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                                Main();
                                            }
                                        }
                                    }
                                    break;

                                case 3:
                                    Wx = 1;
                                    break;


                                case 9:
                                    Main();
                                    break;

                                case 0:
                                    Environment.Exit(0);
                                    break;
                            }
                        } while (Wx == 0);
                        Wx = 0;
                        break;
                }
            } while (W == 0);
        }
        // ------------------------------------------------------------- //
        // ------------------------------------------------------------- //
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void LoadinPentagrama ()
        {
            int i;

            for (i=0; i<5; i++)
            {
                PentaGrama[i] = 0;
                StatusPentaGrama[i] = "APAGADA";
            }
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void LoadinHabragrama(int A)
        {
            int i, Qtd = A;

            for (i = 0; i < Qtd; i++)
            {
                HabraGrama[i] = 0;
                StatusHabraGrama[i] = "APAGADA";
            }
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void BuscaPentaGrama(int A)
        {
            int Tocha = 0;
            Tocha = A;
            if (Tocha == 1)
            {
                Inverso(Tocha); // nao se preocupar em passar valores de vetor
                Inverso(3);
                Inverso(4);
            }
            else
            {
                if(Tocha == 2)
                {
                    Inverso(Tocha); // nao se preocupar em passar valores de vetor
                    Inverso(4);
                    Inverso(5);
                }
                else
                {
                    if(Tocha == 3)
                    {
                        Inverso(Tocha); // nao se preocupar em passar valores de vetor
                        Inverso(1);
                        Inverso(5);
                    }
                    else
                    {
                        if(Tocha == 4)
                        {
                            Inverso(Tocha); // nao se preocupar em passar valores de vetor
                            Inverso(1);
                            Inverso(2);
                        }
                        else
                        {
                            if(Tocha == 5)
                            {
                                Inverso(Tocha); // nao se preocupar em passar valores de vetor
                                Inverso(2);
                                Inverso(3);
                            }
                        }
                    }
                }
            }
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void Inverso(int A)
        {
            int Tocha = 0;

            Tocha = (A-1);

            if (PentaGrama[Tocha] == 0)
            {
                PentaGrama[Tocha] = 1;
                StatusPentaGrama[Tocha] = "ACESSO";
            }
            else
            {
                PentaGrama[Tocha] = 0;
                StatusPentaGrama[Tocha] = "APAGADO";
            }
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void BuscaHabraGrama(int A, int Qtd)
        {
            int Tocha, X = 0, Y = 0;
            Tocha = A;

            if ((Tocha + (N)) > Qtd)
            {
                X = (Tocha + N)-Qtd;
            }
            else
            {
                X = Tocha + N;          
            }
            if ((Tocha + (N+1)) > Qtd)
            {
                Y = (Tocha + (N+1))-Qtd;
            }
            else
            {
                Y = Tocha + (N+1);
            }
            // ------------------------ //
             HabraInverso(Tocha);
             HabraInverso(X);
             HabraInverso(Y);
            // ------------------------ //
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void Indice(int A)
        {
            int Qtd, Cont1 = 4, Cont2 = 2, Ac = 0, i;
            Qtd = A;
            while (Cont1 != (Qtd-1))
            {
                Cont1 = Cont1 + 1;
                if ((Cont1%2) != 0)
                {
                    Ac = Ac + 1;   // Para descobrir a quantidade de numeros impares depois de 5
                }
            }
            for (i = 0; i<Ac; i++)  // Achado a quantidade passa a achar o indice
            {                       // 5 - 2 , 7 - 3, 9 - 4... Etc
                Cont2 = Cont2 + 1;
            }
            N = Cont2;
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
        public static void HabraInverso(int A)
        {
            int Tocha = 0;
            Tocha = (A - 1);
            if (HabraGrama[Tocha] == 0)
            {
                HabraGrama[Tocha] = 1;
                StatusHabraGrama[Tocha] = "ACESSO";
            }
            else
            {
                HabraGrama[Tocha] = 0;
                StatusHabraGrama[Tocha] = "APAGADO";
            }
        }
        // ---------------------------------------------- //
        // ---------------------------------------------- //
    }
}

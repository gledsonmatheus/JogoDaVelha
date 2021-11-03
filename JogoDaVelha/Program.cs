using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            int cordenada, conta = 0;
            bool checaMarcacao = false;
            bool check = TelaInicial.checarInicio();
            Jogador jogador1 ;
            Jogador jogador2 ;
            TelaJogo tela;

            if (check)
            {
                jogador1 = new Jogador('X');
                jogador2 = new Jogador('O');

                tela = new TelaJogo();

                


                while (check)
                {
                    tela.criarTelaJogo(jogador1, jogador2);
                    if (conta % 2 == 0)
                    {
                        do
                        {
                            Console.WriteLine($"vez do(a) {jogador1.Nome} ");
                            Console.WriteLine("digite a cordenada:");
                            cordenada = int.Parse(Console.ReadLine());
                            
                            checaMarcacao = tela.marcarCampo(cordenada, jogador1.Simbulo);
                            tela.atualizaTela(jogador1, jogador2);
                            check = tela.checaVitoria();
                            if (!check)
                            {
                                jogador1.adicionaPonto();
                                tela.atualizaTela(jogador1, jogador2);
                                Console.WriteLine($"================================ VECEDOR :  { jogador1.Nome}   ==============================================================");
                                Console.WriteLine("Deseja jogar novamente ? s/n ");
                                if (Console.ReadLine().ToLower() == "s")
                                {
                                    check = true;
                                    tela = new TelaJogo();
                                }
                            }
                           
                        } while (!checaMarcacao);
                    }
                        if (conta % 2 == 1)
                    {
                        do
                        {
                            Console.WriteLine($"vez do(a) {jogador2.Nome} ");
                            Console.WriteLine("digite a cordenada:");
                            cordenada = int.Parse(Console.ReadLine());
                            
                            checaMarcacao = tela.marcarCampo(cordenada, jogador2.Simbulo);
                            tela.atualizaTela(jogador1, jogador2);
                            check = tela.checaVitoria();
                            if (!check)
                            {
                                jogador2.adicionaPonto();
                                tela.atualizaTela(jogador1, jogador2);
                                Console.WriteLine($"================================   VECEDOR :  {jogador2.Nome}   ==============================================================");
                                Console.WriteLine("Deseja jogar novamente ? s/n ");
                                if (Console.ReadLine().ToLower() == "s") 
                                {
                                    check = true;
                                    tela = new TelaJogo();

                                }
                            }
                        } while (!checaMarcacao);

                    }
                     if (checaMarcacao) 
                    {
                        conta += 1;
                    }
                    
                }

                Console.WriteLine("obrigado por jogar, aperte qualquer tecla para sair.");
                Console.ReadKey();
            }

        }
    }
}

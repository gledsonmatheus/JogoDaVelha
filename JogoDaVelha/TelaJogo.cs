using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class TelaJogo
    {
        private char[,] _matrizTela = new char[3,3];
        
        public TelaJogo()
        {
            
            for (int i = 0, c = 49; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {

                    _matrizTela[i, j] = (char)c;

                    c += 1;
                }
            }
        }
        public void criarTelaJogo(Jogador j1, Jogador j2)
        {
            Console.Clear();
            Console.WriteLine("======================================= Jogo da velha  =============================");
            Console.WriteLine("");
            Console.WriteLine($"====================  {j1.Nome} [{j1.Pontuacao} pontos] ==================  {j2.Nome} [{j2.Pontuacao} pontos] ==========================");
            Console.WriteLine("       ");

            Console.WriteLine("                                        y0     y1     y2  ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x0  __{_matrizTela[0,0]}_|__{_matrizTela[0, 1]}_|__{_matrizTela[0, 2]}__  ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x1  __{_matrizTela[1,0]}_|__{_matrizTela[1, 1]}_|__{_matrizTela[1, 2]}__ ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x2  __{_matrizTela[2,0]}_|__{_matrizTela[2, 1]}_|__{_matrizTela[2, 2]}__   ");
            Console.WriteLine("                                             |    |  ");

            Console.WriteLine("==============================================================================================");


        }
        public void atualizaTela(Jogador j1, Jogador j2)
        {
            Console.Clear();
            Console.WriteLine("======================================= Jogo da velha  =============================");
            Console.WriteLine("");
            Console.WriteLine($"====================  {j1.Nome} [{j1.Pontuacao} pontos] ==================  {j2.Nome} [{j2.Pontuacao} pontos] ==========================");
            Console.WriteLine("       ");

            Console.WriteLine("                                        y0     y1     y2  ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x0  __{_matrizTela[0, 0]}_|__{_matrizTela[0, 1]}_|__{_matrizTela[0, 2]}__  ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x1  __{_matrizTela[1, 0]}_|__{_matrizTela[1, 1]}_|__{_matrizTela[1, 2]}__ ");
            Console.WriteLine("                                             |    |  ");
            Console.WriteLine($"                                     x2  __{_matrizTela[2, 0]}_|__{_matrizTela[2, 1]}_|__{_matrizTela[2, 2]}__   ");
            Console.WriteLine("                                             |    |  ");

            Console.WriteLine("==============================================================================================");


        }
        public bool marcarCampo(int x, char c) {

            switch (x) 
            {
                case 1:
                    if ('1' == _matrizTela[0, 0]) 
                    {
                        _matrizTela[0, 0] = c;
                        return true;
                    }
                    break;
                case 2:

                    if ('2' == _matrizTela[0, 1])
                    {
                        _matrizTela[0, 1] = c;
                        return true;
                    }
                    break;
                case 3:

                    if ('3' == _matrizTela[0, 2])
                    {
                        _matrizTela[0, 2] = c;
                        return true;
                    }
                    break;
                case 4:

                    if ('4' == _matrizTela[1, 0])
                    {
                        _matrizTela[1, 0] = c;
                        return true;
                    }
                    break;
                case 5:

                    if ('5' == _matrizTela[1, 1])
                    {
                        _matrizTela[1, 1] = c;
                        return true;
                    }
                    break;
                case 6:

                    if ('6' == _matrizTela[1, 2])
                    {
                        _matrizTela[1, 2] = c;
                        return true;
                    }
                    break;
                case 7:

                    if ('7' == _matrizTela[2, 0])
                    {
                        _matrizTela[2, 0] = c;
                        return true;
                    }
                    break;
                case 8:

                    if ('8' == _matrizTela[2, 1])
                    {
                        _matrizTela[2, 1] = c;
                        return true;
                    }
                    break;
                case 9:

                    if ('9' == _matrizTela[2, 2])
                    {
                        _matrizTela[2, 2] = c;
                        return true;
                    }
                    break;
                default:
                    break;
            }

           
            return false;
        }
        public bool checaVitoria() 
        {
            for (int i = 0; i < 3; i++) 
            {
                if ((_matrizTela[i, 0] == _matrizTela[i, 1]) && (_matrizTela[i, 0] == _matrizTela[i, 2]))
                {
                    return false;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if ((_matrizTela[0, i] == _matrizTela[1, i]) && (_matrizTela[0, i] == _matrizTela[2, i]))
                {
                    return false;
                }
            }
            if ((_matrizTela[0, 0] == _matrizTela[1, 1]) && (_matrizTela[0, 0] == _matrizTela[2, 2]))
            {
                return false;
            }
            if ((_matrizTela[2, 0] == _matrizTela[1, 1]) && (_matrizTela[2,0 ] == _matrizTela[0, 2]))
            {
                return false;
            }

            return true;
        }

    }
}

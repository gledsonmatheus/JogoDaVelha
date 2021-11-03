using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Jogador
    {

        private int _pontuacao = 0;
         
        public static int contador = 1;
        public char Simbulo;
        public string Nome { get; set; }
        public int Pontuacao 
        {
            get
            {
                return _pontuacao;
            }
            set 
            {
                _pontuacao = value;
            } 
        }

        public Jogador(char simb)
        {
            
            Pontuacao = 0;
            Simbulo = simb;

            Console.WriteLine($"insira o nome do {contador}º jogador.");
            Nome = Console.ReadLine();
            contador += 1;
        }
        public void adicionaPonto() 
        {
            Pontuacao += 1 ;

        }

    }
}

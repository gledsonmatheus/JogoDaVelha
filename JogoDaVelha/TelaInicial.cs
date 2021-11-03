using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class TelaInicial
    {
        public static bool checarInicio() 
        {
            string escolha;
            

            try
            {
                Console.WriteLine("=============================== Jogo da velha  =============================");
                Console.WriteLine("deseja começar um jogo ? (s/n)");
                escolha = Console.ReadLine();
                if (escolha.ToLower() == "s")
                {
                    return true;
                }

            }
            finally
            {
                
                
            }
            return false;

        }
    }
}

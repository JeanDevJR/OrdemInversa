using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemInversa
{
    public class OrdemInversaBusiness
    {
        public static void obter(OrdemInversaDTO ordemInversaDTO) 
        {
            TextReader leitor = System.Console.In;

            Console.Write("Quantos elementos você desaja inserir?");
            ordemInversaDTO.QtdeElementos = Convert.ToInt32(leitor.ReadLine());
            ordemInversaDTO.VetorEntrada = new int[ordemInversaDTO.QtdeElementos];

            for (int i = 0; i < ordemInversaDTO.QtdeElementos; i++)
            {
                Console.Write("Posição" + i + " ");
                ordemInversaDTO.VetorEntrada[i] = Convert.ToInt32(leitor.ReadLine());

                // "i" significa a posição do meu vetor
            }
        }// fim do método obterNumeros 

        public static void imprimir (OrdemInversaDTO ordemInversaDTO)
        {
            for (int i = ordemInversaDTO.QtdeElementos - 1; i >=0; i--)
            {
                Console.Write(ordemInversaDTO.VetorEntrada[i]);
            }
            Console.ReadKey();
        }
    }//fim da classe business
}
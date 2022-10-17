using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votação_Consurso
{
    class Program
    {
        static void Main(string[] args)
        {

            string avaliacao, atualizacao;
            int aprovado = 0, reprovado, nota, numAvaliacao = 1; int totalProvas = 3; int candidato = 1;
            bool candidatoAprovado = true;
            Console.WriteLine("Candidato #1 - Christopher \n" + "Candidato #2 - Teolino \n" + "Candidato #3 - Fewdrick \n");
            while (candidato <= 3)
            {
            for (int i = 1; i <= 3; i++)
            {
                    Console.WriteLine("Candidato # " + candidato);
                    Console.WriteLine("Informe a nota da sua  " + numAvaliacao + " ª prova");
                    nota = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sua nota na # " + numAvaliacao +  "prova foi: " + nota);
                    if (nota > 5)
                    {
                        aprovado++;
                    }
                    if (numAvaliacao >= 3) 
                    {
                        numAvaliacao = 0;
                    }
                    
                    
                    numAvaliacao++;
                    nota = 0;        
           }
            reprovado = totalProvas - aprovado;
            Console.WriteLine("Você aprovou em " + aprovado + " provas \n" + "Voê reprovou em " + reprovado + " provas");
            if (aprovado < 2)
            {
                candidatoAprovado = false;
            }
            if (aprovado >= 2)
            {
                candidatoAprovado = true; 
            }
            if (candidatoAprovado == true)
            {
                Console.WriteLine("PARABÉNS VOCÊ FOI APROVADO!!");
            }
            else
            {
                Console.WriteLine("INFELIZMENTE VOCÊ NÃO FOI APROVADO!");
            }
            candidato++;
            aprovado = 0;
            reprovado = 0;
            }
            Console.Read();
        }
    }
}

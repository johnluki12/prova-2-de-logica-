using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int codigo;
            string mesextenso = null;

            Console.WriteLine(" Escolha um número para representar a cidade desejada : \n\n1 – Atibaia\n2 – Bragança Paulista\n3 – Mairiporã\n4 – Nazaré\n5 – Terra Preta\n6 – Extrema\n7 – Vargem\n");
           codigo = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Digite uma data em formato: dd/mm/aaaa. ");
           
            var datan = Convert.ToDateTime(Console.ReadLine());

            int datames, datadia, dataano;
            datames = datan.Month;
            datadia = datan.Day;
            dataano = datan.Year;
            
            
                switch (datames)
                {
                    case 1:
                        mesextenso = "Janeiro";
                        break;
                    case 2:
                        mesextenso = "Fevereiro";
                        break;
                    case 3:
                        mesextenso = "Março";
                        break;
                    case 4:
                        mesextenso = "Abril";
                        break;
                    case 5:
                        mesextenso = "Maio";
                        break;
                    case 6:
                        mesextenso = "Junho";
                        break;
                    case 7:
                        mesextenso = "Julho";
                        break;
                    case 8:
                        mesextenso = "Agosto";
                        break;
                    case 9:
                        mesextenso = "Setembro";
                        break;
                    case 10:
                        mesextenso = "Outubro";
                        break;
                    case 11:
                        mesextenso = "Novembro";
                        break;
                    case 12:
                        mesextenso = "Dezembro";
                        break;
                }



                if (codigo == 1)
                {
                    Console.Write(" Atibaia," + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 2)
                {
                    Console.Write(" Bragança Paulista," + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 3)
                {
                    Console.Write(" Mariporã, " + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 4)
                {
                    Console.Write(" Nazaré, " + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 5)
                {
                    Console.Write(" Terra Preta, " + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 6)
                {
                    Console.Write(" Extrema," + datadia + " de " + mesextenso + " de " + dataano);
                }
                else if (codigo == 7)
                {
                    Console.Write(" Nazaré, " + datadia + " de " + mesextenso + " de " + dataano);
                }
                else
                {
                    Console.Write(" Código invalido, tente novamente! ");
                    
                }
            Console.ReadKey();
           

        }
    }
}

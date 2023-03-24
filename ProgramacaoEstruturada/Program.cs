using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace ProgramacaoEstruturada
{
    internal class Program
    {
        static int valor,i;
        static int menornumero;
        static int maiornumero;
        static int posicao_menor, posicao_maior;
        static int soma = 0;
        static int media;
        static int X;
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Array
            int[] array =new int[10] { -5,  4, 5, 9, 6, 10, 11, 1, 2, 6};
            //{ 3, 3 4 5 9 6 10 -2 11 1 2 6 7 8 0 -6 };
            int[] array1 = new int[3];
            Console.WriteLine("Qual sua escolha? ");
            Console.WriteLine(" 1 - Maior Valor da sequência");
            Console.WriteLine(" 2 - Menor Valor da sequência");
            Console.WriteLine(" 3 - Valor Médio da sequência");
            Console.WriteLine(" 4 - Os 3 maiores valores da sequência");
            Console.WriteLine(" 5 - Os valores negativos da sequência");
            Console.WriteLine(" 6 - Mostrar na Tela os valores da sequência");
            Console.WriteLine(" 7 - Remover um item da sequência");
            int escolha = int.Parse( Console.ReadLine() );

            
            switch (escolha)
            {
              case 1: //Encontrar o Maior Valor da sequência 
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > maiornumero)
                        {
                            maiornumero = array[i];
                            posicao_maior = i;
                        }
                    }
                    Console.WriteLine($"Maior numero {maiornumero} posição {posicao_maior+1}");

                    break;

               case 2://Encontrar o Menor Valor da sequência
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < menornumero)
                        {
                            menornumero = array[i];
                            posicao_menor = i;
                        }
                    }
                    Console.WriteLine($"Menor numero {menornumero} posição {posicao_menor}");

                    break;

                case 3://Encontrar o Valor Médio da sequência
                    for (int i = 0; i < array.Length; i++)
                    {
                         soma += array[i];                     
                    }
                         media = soma / array.Length;

                            Console.WriteLine($"A soma dos valores é {soma}");
                            Console.WriteLine($"A media dos valores é {media}");
                    break;

                case 4://Encontrar os 3 maiores valores da sequência

                          array1 = new int[3];
                          Array.Sort(array);
                          Array.Reverse(array);
                    for (int i = 0; i < 3; i++)
                    {
                        array1[i] = array[i];

                        Console.WriteLine($"\r Os numeros são {array1[i]}");
 }

                    break;

                case 5: //Encontrar os valores negativos da sequência

                    array1 = new int[3];

                    for (int i = 0;i<array.Length;i++ )
                    {
                        if (array[i] < menornumero)
                        {
                            array1[i] = array[i];

                            Console.WriteLine($"\r Os numeros são {array1[i]}");
                        }
                    }

                    break;  

                case 6://Mostrar na Tela os valores da sequência
                    for (int i = 0; i < array.Length; i++)
                    {
                        valor = array[i];
                        Console.WriteLine($"Posição  {valor}");
                    }
                    break;
                    
                case 7://Remover um item da sequência
                       //pode se usar um List no lugar de array por ser mais flexissivel;

                    Console.WriteLine(" Deseja excluir qual valor do array ");
                    int valorRemover = int.Parse(Console.ReadLine());

                    
                    //Encontrar o indíce onde está o valor a ser removido.
                
                     for (int i = 0; i < array.Length; i++)
                     {
                        int itemAtual = array[i];
                        //Console.WriteLine($" item atual {itemAtual}");

                        if (itemAtual == valorRemover)
                        {
                            itemAtual = X;
                        }
                       Console.WriteLine($"Novo array {itemAtual}");
                     }

                    Console.Write(array[i]);

                        Console.ReadLine();
                        
                    break;
            }
               
        }
    }
}

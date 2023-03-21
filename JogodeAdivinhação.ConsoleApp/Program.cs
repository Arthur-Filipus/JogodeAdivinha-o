namespace JogodeAdivinhação.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("*O JOGO TRIPLE EI MAIS FODA DE TODOS OS TEMPOS!!!*");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            Console.Write("Escolha o nível da sua intelectualidade: \n(1) Ez - (2) Padrão - (3) Hardicóri\nEscolha: ");
            int escolhadificuldade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int chances = 0;
            int pontuacao = 1000;
            Random numero = new Random();
            int numerorandom = numero.Next(1, 21);

            if (escolhadificuldade == 1)
            {
                chances = 15;
            }
            else if (escolhadificuldade == 2)
            {
                chances = 10;
            }
            else if (escolhadificuldade == 3)
            {
                chances = 5;
            }
            
            for (int i = 1; i <= chances; i++)
            {
                int restante = chances - i;
                Console.WriteLine($"Tentátiva número {i}, restam {restante}");
                Console.WriteLine("--------------------------------------");
                Console.Write("Faça sua tentátiva: ");
                int tentativa = Convert.ToInt32(Console.ReadLine());
                pontuacao = Math.Abs(pontuacao - ((tentativa + numerorandom) / 2));

                if (tentativa == numerorandom)
                {
                    Console.WriteLine($"BOUA VAMO GANYAAAR, Acertou o número, magrão\nC fez {restante} pontos");
                    break;
                }
                else if (i == chances)
                {
                    Console.WriteLine($"Cabou tuas chance \nJa era \nPerdeu \nRuim \nPodre \nTua pontuação foi de {pontuacao}");
                    break;
                }
                else if (tentativa < numerorandom)
                {
                    Console.WriteLine("Quase em, mas teu chute foi baixo demais");
                }
                else if (tentativa > numerorandom)
                {
                    Console.WriteLine("Quase em, mas teu chute foi alto demais");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
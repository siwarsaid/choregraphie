namespace choregraphie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] moves = new string[32];
            int nbDePas = 0;
            bool mouveSontTerminee = false;

            while (!mouveSontTerminee)
            {
                Console.WriteLine("entrer un pas de danse :\n  ");

                string pasDeDance = Console.ReadLine();

                if ((nbDePas == moves.Length) || (pasDeDance == "done"))
                {
                    mouveSontTerminee = true;
                }
                else
                {
                   
                    
                        moves[nbDePas] = pasDeDance;
                        nbDePas++;
                    
                    Console.WriteLine();
                    Console.WriteLine("les nombres d'iteration sont: " + nbDePas);
                }
            }

            Console.WriteLine("choisir le nombre d'itérations de la suite de pas :\n");
            int nbIteration = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < nbIteration; i++)
            {
                Console.WriteLine("La repetition" + (i + 1) + " : ");
                foreach (string nbPas in moves)
                {
                    if (nbPas != null)
                        Console.WriteLine(nbPas);
                }
                Console.WriteLine();
            }


        }
    }
}

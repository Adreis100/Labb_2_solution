using System.Reflection.Metadata;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] names = new string[4];
            double[] age = new double[4];
            string fnames;
            double fage;
            int menuSelector = 0;
            int userinput = 0;


            while (menuSelector != 5)
            {
                Console.WriteLine(
                "---------------------------------------------------" +
                "\nVälj ett av alternativen:" +
                "\n1.) Lägg till namn på familjmedlemmar" +
                "\n2.) Lägg till lista på familjmedlemmar" +
                "\n3.) Skriva ut summan av familjemedlemmars ålder" +
                "\n4.) Skriva ut medelåldern för familjemedlemmarna" +
                "\n5.) avsluta" +
                "-----------------------------------------------------"
                );

                menuSelector = int.Parse(Console.ReadLine());
                switch (menuSelector)

                {

                    case 1:

                        if (userinput < 4)
                        {
                            Console.WriteLine(userinput);
                            Console.WriteLine("Lägg till namn på familjmedlem");
                            Console.WriteLine("Lägg till ålder på familjmedlem");
                            fnames = Console.ReadLine();
                            fage = double.Parse(Console.ReadLine());

                            names[userinput] = fnames;
                            age[userinput] = fage;
                            userinput++;
                        }

                        else { Console.WriteLine("Det går inte fylla i nåt mer, listan säger att det är fullt"); }


                        break;

                    case 2:
                        for (int i = 0; i < userinput; i++)
                        {
                            Console.WriteLine(names[i] + " är " + age[i]);

                        }

                        break;

                    case 3:
                        double summan = 0;
                        for (int i = 0; i < userinput; i++)
                        {
                            summan += age[i];
                        }
                        Console.WriteLine(summan);
                        break;

                    case 4:
                        double totalage = 0;
                        for (int i = 0; i < userinput; i++)
                        {
                            totalage += age[i];
                        }
                        Console.WriteLine(totalage / userinput);

                        break;

                    case 5:
                        Console.WriteLine("Avslutning");
                        break;









                }

            }
        }
    }
}
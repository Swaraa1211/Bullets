namespace Bullets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hero_b = 20;
            int villain_b = 20;
            int hero_c = 0;
            int villain_c = 0;

            Console.WriteLine("Start!");

            for(int k=1; k<=hero_b && k<=villain_b; k++)
            {
                Console.WriteLine("Shot: "+ k);
                hero_b--;
                Console.WriteLine("Hero Bullet Remaining: " + hero_b);
                villain_b -= 3;
                Console.WriteLine("Villain Bullet Remaining: " + villain_b);
                hero_c++;
                Console.WriteLine("Hero shot: " + hero_c);
                villain_c += 3;
                Console.WriteLine("Villain shot: " + villain_c);
                /*for(int i=1, j=1; i<=hero_b && j<=villain_b; i++, j++)
                {
                    hero_b--;
                    Console.WriteLine("Hero Bullet Remaining: " + hero_b);
                    villain_b -= 3;
                    Console.WriteLine("Villain Bullet Remaining: " + villain_b);
                    hero_c++;
                    Console.WriteLine("Hero shot: " + hero_c);
                    villain_c++;
                    Console.WriteLine("Villain shot: " + villain_c);
                }*/

            }
            Console.WriteLine("Over!");
        }
    }
}



namespace es7_10
{
    internal class Program
    {
        //es7s
        static void Main(string[] args)
        {
            int[] v = { 3, 11, 9, 2, 14, 29, 18 };

            int a, b, c = 0;

            Console.WriteLine("metti il primo estremo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("metti il secondo estremo");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < v.Length; i++)
            {

                if (v[i] >= a && v[i] <= b)
                {

                    c++;

                }

            }

            Console.WriteLine("i numeri compresi sono " + c);

            Console.WriteLine();

            //es8

            int[] v1 = { 3, 11, 9, 2, 14, 29, 18 };

            int c1 = 0;

            Console.WriteLine("metti primo estremo");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("metti secondo estremo");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < v1.Length; i++)
            {

                if (v1[i] <= a || v1[i] >= b)
                {

                    c1++;

                }

            }

            Console.WriteLine("i  numeri non compresi sono" + c1);

            Console.WriteLine();

            //es9

            int[] v3 = { 3, 11, 9, 2, 14, 29, 18 };

            int c2 = 0;

            Console.WriteLine("dammi il primo estremo del primo int");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il secondo estremo del primo int");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il primo estremo del secondo int");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il secondo estremo del secondo int");
            int d= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < v3.Length; i++)
            {

                if (v3[i] >= a && v3[i] <= b || v3[i] >= c && v3[i] <= d)
                {
                    c2++;
                }

            }

            Console.WriteLine("i numeri tra a e b o tra e e d sono: " + c2);

            Console.WriteLine();

            //es10

            int[] v4 = { 3, 11, 9, 2, 14, 29, 18 };

            int c3 = 0;


            Console.WriteLine("dammi il primo estremo del primo int");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il secondo estremo del primo int");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il primo estremo del secondo int");
            e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dammi il secondo estremo del secondo int");
            d = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < v4.Length; i++)
            {

                if (v3[i] >= a && v3[i] <= b || v3[i] >= c && v3[i] <= d)
                {

                }
                else
                {
                    c3++;
                }

            }

            Console.WriteLine(" i numeri tra a e b o tra e e d non compresi sono: " + c3);

        }
    }
}

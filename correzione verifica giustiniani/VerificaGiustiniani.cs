using System;

namespace correzione_verifica_giustiniani
{
    public class VerificaGiustiniani
    {
        //es 1 
        public static void Massimo()
        {
            Console.WriteLine("inserisci il numero a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il numero b: ");
            int b = int.Parse(Console.ReadLine());
            int massimo = Math.Max(a, b);
            Console.WriteLine($"il massimo è {massimo}");
        }
        //es 2
        public static void Minimo()
        {
            Console.WriteLine("inserisci il numero a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il numero b: ");
            int b = int.Parse(Console.ReadLine());
            int minimo = Math.Min(a, b);
            Console.WriteLine($"il minimo è {minimo}");
        }
        //es 3
        public static void Media()
        {
            Console.WriteLine("inserisci il numero a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il numero b: ");
            double b = double.Parse(Console.ReadLine());
            double media = a + b / 2;
            Console.WriteLine($"la media è {media}");
        }
        //es 4
        public static void Addizione()
        {
            Console.WriteLine("inserisci il numero a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il numero b: ");
            double b = double.Parse(Console.ReadLine());
            double somma = a + b;
            Console.WriteLine($"la somma è {somma}");
        }
        //es 5
        public static void Scambiouint(ref uint a, ref uint b)
        {
            var c = a;
            a = b;
            a = c;
        }
        //es 6
        public static void Scambioshort(ref short a, ref short b)
        {
            var c = a;
            a = b;
            a = c;
        }
        //es 7 
        public static int Contafinoazero()
        {
            int c = 0;
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                    c++;

            } while (n != 0);
            return c;
        }
        //es 8 
        public static int Restituiscilasomma()
        {
            int c = 0;
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n != 0)
                    c++;

            } while (n != 0);
            return c++;
        }
        //es 9
        public static int Somma(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return Somma(n - 1) + n;
        }
        //es 10
        public static int Prodotto(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return Prodotto(n - 1) * n;
        }
        //es 11
        public static double Calcolatore(double a, double b, char o)
        {
            double risultato;
            switch (o)
            {
                case '+': risultato = a + b; break;
                case '-': risultato = a - b; break;
                case '*': risultato = a * b; break;
                case '/': risultato = a / b; break;
                default:
                    throw new Exception("Operazione fallita");
            }
            return risultato;
        }
        //es 12
        public static void Calcolatrice()
        {
            char o;
            do
            {
                Console.WriteLine("inserisci a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci b: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci un operatore tra '+','-','*','/','q': ");
                o = Console.ReadLine()[0];
                if (o != 'q')
                {
                    double risultato = Calcolatore(a, b, o);
                    Console.WriteLine($"{risultato}");
                }
            } while (o != 'q');
        }
        //es 13
        public static double Sconto(double prezzo, double quantita, double iva)
        {
            double totale = prezzo * quantita;
            double sconto = 0;
            if (totale > 100)
            {
                sconto = 0.15;
            }
            else if (quantita >= 30)
            {
                sconto = 0.10;
                    totale = totale * sconto;
                totale = totale * iva;
                return totale;
            }

        }
        //es 14
        public static double Sconto1(double prezzo, double quantita, double iva)
        {
            double totale = prezzo * quantita;
            double sconto = 0;
            if (totale > 200)
            {
                sconto = 0.18;
            }
            else if (quantita >= 20)
            {
                sconto = 0.12;
                totale = totale * sconto;
                totale = totale * iva;
                return totale;
            }

        }
        //es 15
        public static void Stampafibonacci(int n)
        {
            for (int i = 0; i <= n; i++)
                Console.WriteLine(fibonacci(i) + "");
        }
        public static int fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return fibonacci(n - 2) + fibonacci(n - 1);
        }
    }
}

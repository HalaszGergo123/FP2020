using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Pool1
{
    public class Program
    {
        // AM REZOLVAT TOATE EXERCITII CARE SUNT IN METODE NUMITE _1,_2,_3....
        // PE CONSOLA UTILIZATORUL POATE SA "APELEZE" EXERCITII(DE EX. DACA SCRIE 1 PE CONSOLA ATUNCI APELEZE PRIMA EXERCITIU)
        



        /// <summary>
        /// Citeste de la tastatura un numar int.Metoda asta apelez in metode in care am facut exercitii.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Returneaza o valoare int pentru metode in care am facut exercitii</returns>
        static int citireInt(string s)
        {
            Console.Write($"Introduceti un numar intreg {s}: ");
            s = Console.ReadLine();
            return int.Parse(s);
        }
        /// <summary>
        /// Citeste de la tastatura un numar float.Metoda asta apelez in metode in care am facut exercitii.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Returneaza o valoare int pentru metode in care am facut exercitii</returns>
        static float citireFloat(string s)
        {
            Console.Write($"Introduceti un numar float {s}: ");
            s = Console.ReadLine();
            return float.Parse(s);
        }
        /// <summary>
        /// FUNCTIA MAIN ARE ROL DE A SCRIE PE CONSOLA EXERCITIILE SI SA AJUTA PE UTILIZATORUL SA APELEZE EXERCITII a.k.a DRIVER    
        /// </summary>
        /// <param name="args"></param
        static void Main(string[] args) 
        {
            Console.WriteLine("                   -                              Problems pool 1                             -          ");

            string[] cerinte = new string[] //cerintele
    {
                  " 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.",
" 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.",
" 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.",
" 4. Detreminati daca un an y este an bisect. ",
" 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ",
" 6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ",
" 7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ",
" 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.",
" 9. Afisati toti divizorii numarului n.",
"10. Test de primalitate: determinati daca un numar n este prim.",
"11. Afisati in ordine inversa cifrele unui numar n.",
"12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].",
"13. Determianti cati ani bisecti sunt intre anii y1 si y2.",
"14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. ",
"15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.",
"16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)",
"17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.",
"18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. ",
"19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ",
"20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). ",
"21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\"." 

    };
            for (int i = 0; i < cerinte.Length; i++)
            {
                Console.WriteLine($"{cerinte[i]}"); // scriu separat exercitii pe care am facut

            }
            while (true)
            {
                try
                {
                    Console.Write("\nIntroduceti numarul problemei pe care vreti sa accesati.\n>> ");
                    string exercitiuDorita = ""; // string pentru exercitiu dorita
                    exercitiuDorita = Console.ReadLine(); // citesc numarul exercitiului
                    getMethod("_" + exercitiuDorita); // apelez metoda getMethod

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("=============Incercati inca o data!================");
                }
            }

        }

        /// <summary>
        /// Gaseste metoda pentru valoare primita de catre utilizatorul(numarul exercitiului)
        /// </summary>
        /// <param name="s"></param>
        public static void getMethod(string s)
        {
            Type thisType = typeof(Program); // trebuie sa aflam tipul clasei in care apelez metode
            MethodInfo theMethod = thisType.GetMethod(s); // asa pot sa gasesc metoda care este cerut
            theMethod.Invoke(thisType, null); // incep metoda
        }


 
        /// -------------------DE AICI INCEP EXERCITIILE------------------------------

        public static void _1() // primul exercitiu
        {

            float a = citireFloat("a"), b = citireFloat("b");
            Console.WriteLine($"Radacina x este {-b/a}");

        }
        public static void _2()
        {
            float a = citireFloat("a"), b = citireFloat("b"), c = citireFloat("c");

            float delta = b * b - 4 * a * c;

            if(delta>0)
            {
                Console.WriteLine($"Radacina x1 este: {(-b + Math.Sqrt(delta))/2*a}");

                Console.WriteLine($"Radacina x2 este: {(-b - Math.Sqrt(delta)) / 2 * a}");
            }
            else
                if(delta ==0)
                Console.WriteLine($"Radacina x este: {-b/2*a}");
            else
                Console.WriteLine("Nu este radacina");


            
        }
        public static void _3()
        {
            int n = citireInt("n"), k = citireInt("k");

            if(n%k==0)
                Console.WriteLine("n se divide cu k");
            else
                Console.WriteLine("n nu se divide cu k");
        }
        public static void _4()
        {
            int y = citireInt("y");

          /*1) Un an bisect se divide cu 4  
            2) Însă dacă se divide cu 100 atunci nu e an bisect
            3) Însă dacă se divide cu 400, atunci e an bisect */

            Console.WriteLine($"Anul {y}{((y%4==0 && y%100!=0) || y%400==0 ? "" : " nu")} este un an bisect."); 
        }
        public static void _5()
        {

            /*Codul este lung pentru o problema asa de usor , dar numarul k trebuie verificat daca este mai mare decat toate cifrele din numarul n:
             * Daca este mai mare k-ul atunci daca de ex. spun n=123 si k = 4 o sa scrie pe consola 0 care nu este adevarat,de aceea am implementat un algoritm asa de complicat
             * 
             */

            int n = citireInt("n"), k = citireInt("k");
            int K = k , countCifre = 0 , cifra = 0, N = n;
            bool flag = true;
            if (n == 0 && k == 1)
                Console.WriteLine($"{k}-a cifra este: {n}");
            else
                while (flag)
                {
                    n = N;
                    K = k;
                        while (k > 0 && n!=0)
                        {
                       
                        cifra = n % 10;
                       
                            n = n / 10;
                            k--;
                        countCifre++;
                        

                        }
                    if (K == countCifre)
                    {
                        flag = false;
                        Console.WriteLine($"{K}-a cifra este: {cifra}");
                    }
                    else
                    { Console.WriteLine("Numarul k este mai mare decat toate cifre din n,astfel va rog sa va adaugati un numar nou de k!");
                        k = citireInt("k");
                        countCifre = 0; 
                    }
                }
        }
        public static void _6()
        {
            
            int a = citireInt("a"), b = citireInt("b"), c = citireInt("c");
            
            Console.WriteLine($"{a},{b},{c}{ ( a < (b+c) && b < (a+c) && c < (a+b) && a > 0 && b > 0 && c > 0 ? "" : " nu")} pot fi lungimile laturilor unui triunghi.");


        }
        public static void _7()
        {
            int a = citireInt("a"), b = citireInt("b");
            int temp;

            temp = a;
            a = b;
            b = temp;
            Console.Write("a = "+a+" ");
            Console.WriteLine("b = " + b);
        }
        public static void _8()
        {
            int a = citireInt("a"), b = citireInt("b");

            (a, b) = (b, a);

            Console.Write("a = " + a + " ");
            Console.WriteLine("b = " + b);
        }
        public static void _9()
        {
            int n = citireInt("n");
            Console.Write("Divizorii lui n: ");
            for (int i = 1; i <= n/2; i++)
            {
                if(n%i==0)
                    Console.Write(i+" ");
                
            }
            Console.WriteLine();
        }
        public static void _10()
        {
            int n = citireInt("n");
            bool prim = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    prim = false;
            }
            Console.WriteLine($"Numarul {n}{(prim ? "" : " nu")} este prim.");
        }
        public static void _11()
        {
            int n = citireInt("n");
            int s = 0;
            while(n!=0)
            {
                s =s* 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine($"Ordine inversa: {s}");

        }
        public static void _12()
        {
            int n = citireInt("n"), a = citireInt("a"), b = citireInt("b");
            int divideCount = 0;
            for (int i = a; i <= b; i++)
            {
                if (n % i == 0)
                    divideCount++;
            }
            Console.WriteLine($"Numere intregi divizibile cu {n}: {divideCount}");
                
        }
        public static void _13()
        {
            int y1 = citireInt("y1"), y2 = citireInt("y2");
            int bisectCount = 0;
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    bisectCount++;
            }
            Console.WriteLine($"Cati ani bisecti sunt intre anii {y1} si {y2}: {bisectCount}");
        }
        public static void _14()
        {

            int n = citireInt("n"), N = n; 

            int s = 0;
            while (n != 0)
            {
                s = s * 10 + n % 10;
                n /= 10;
            }
                Console.WriteLine($"Numarul {N}{(N==s ? "" : " nu")} este palindrom");
        }
        public static void _15()
        {
            int a = citireInt("a"), b = citireInt("b"), c = citireInt("c");

            if (a > b)
                (a, b) = (b, a);
            if (a > c)
                (a, c) = (c, a);
            if (b > c)
                (b, c) = (c, b);

            Console.WriteLine($"Numere in ordine crescatoare: {a} {b} {c}");
        }
        public static void _16()
        {
            int a = citireInt("a"), b = citireInt("b"), c = citireInt("c"), d = citireInt("d") , e = citireInt("e");

            if (a > b)
                (a, b) = (b, a);
            if(a>c)
                (a, c) = (c, a);
            if (a > d)
                (a, d) = (d, a);
            if(a>e)
                (a, e) = (e, a);


            if(b>c)
                (b, c) = (c, b);
            if(b>d)
                (b, d) = (d,b );
            if (b > e)
                (b, e) = (e, b);


            if(c>d)
                (c, d) = (d, c);
            if (c > e)
                (c, e) = (e, c);


            if (d > e)
                (d, e) = (e, d);

            Console.WriteLine($"Numere in ordine crescatoare: {a} {b} {c} {d} {e}");
        }
        public static void _17()
        {
            int a = citireInt("a"), b = citireInt("b");
            int A = a, B = b;
            while(a!=b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            Console.WriteLine("Cmmdc este: " + a);
            Console.WriteLine("Cmmmc este: " + (A * B) / a);
        }
        public static void _18()
        {
            int n = citireInt("n");
            int d = 2 , h;
            Console.Write(n+"=");
            while(n!=1)
            {
                h = 0;
                while(n%d==0)
                {
                    h++;
                    n /= d;
                }
                if(h!=0)
                {
                    if (h == 1) Console.Write(d+"*");
                    else Console.Write(d+"^"+h+"*");
                }
                if (d == 2) d++;
                else d += 2;
            }
            Console.WriteLine();
        }
        public static void  _19()
        {
            int[] freqCifra = new int[10];
            int c, n = citireInt("n") , contor = 0;
            while (n!=0)
            {
                c = n % 10;
                freqCifra[c]++;
                n /= 10;
            }
            for (int i = 0; i < freqCifra.Length; i++)
            {
                if (freqCifra[i] > 0)
                 contor++; 
            }
            Console.WriteLine($"Numarul {(contor==2 ? "" : "nu " )}e format doar cu 2 cifre.");
        }
        public static void _20()
        {
            string s = "";
            int rest , i = 0,  m = citireInt("m") , n = citireInt("n") , N = n ,M =m;
            int[] resturi = new int[1000];
            bool ok = false;
            if(n==0)
             Console.WriteLine("Nu se poate imparti la 0"); 
           else
            {
                rest = m % n;
                while (rest != 0 && !ok)
                {
                    resturi[i] = rest;
                    i++;
                    m = rest * 10;
                    rest = m % n;
                    s += (m / n).ToString();

                    for (int j = 0; j < i; j++)
                    {
                        if(rest == resturi[j])
                        {
                            s = s.Insert(j, "(");
                            s += ")";
                            ok = true;
                            break;
                        }
                    }


                }
                Console.WriteLine($"Fractia = {M/n}{(s!="" ? "." : "")}{s}");
            }

        }
        public static void _21()
        {
            string s = "";
            int a = 1, b = 1024;
            int mij = -1 , temp , freq=0;
            while (a!=b)
            {
                temp = mij;
                mij = (a + b) / 2;
               //urmatorul 4 line code-uri folosesc pentru a evita un bug(am observat ca daca numarul dorit este 601 atunci urmeaza un infinite loop deoarece 
               // prezint problema : exemplu : merge codul si.... a =601 si b = 606
               // mijlocul o sa fie 603 , 603 este mai mic decat numarul dorit (601)
               //asa ca scriu "nu" si b devine 602 
               // a = 601 b = 602 a+b = 1203 : 2 = 601
               // si intreaba ca daca 601 este mai mare sau egal cu numarul dorit
               //spun ca DA si valoarea a devine 601 astfel infinite loop incepe
                if (temp == mij)
                { freq++; }
                if (freq == 1)
                    break;
                Console.WriteLine($"Numarul este mai mare sau egal decat {mij}?");
                s = Console.ReadLine();

                if (s == "da")
                    a = mij;
                else
                if (s == "nu")
                    b = mij - 1;
                else
                    Console.WriteLine("Raspundeti \"da\" sau \"nu\"");


            }
            Console.WriteLine($"Numarul este: "+a);
        }
    }
}

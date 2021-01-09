using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Pool2
{
    class Program
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
        /// Citeste de la tastatura un n numar (lungimea secventei)
        /// </summary>
        /// <returns></returns>
        static int citireN()
        {
            Console.Write("n= ");

            return int.Parse(Console.ReadLine());

        }
       
        static void Main(string[] args) // FUNCTIA MAIN ARE ROL DE A SCRIE PE CONSOLA EXERCITIILE SI SA AJUTA PE UTILIZATORUL SA APELEZE EXERCITII  
        {
            Console.WriteLine("                   -                              Problems pool 2                             -          ");

            string[] cerinte = new string[] //cerintele
            {
                  " 1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.",
" 2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.",
" 3. Calculati suma si produsul numerelor de la 1 la n.",
" 4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.",
" 5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.",
" 6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.",
" 7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.",
" 8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8...",
" 9. Sa se determine daca o secventa de n numere este monotona.Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.",
"10. Se da o secventa de n numere.Care este numarul maxim de numere consecutive egale din secventa.",
"11. Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere.",
"12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.",
"13. O < secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr - o secventa in ordine crescatoare prin rotiri succesive(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita.",
"14. O < secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.Determinati daca o secventa de n numere este o secventa monotona rotita.",
"15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.",
"16. O < secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.",
"17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati nivelul maxim de incuibare a parantezelor."
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
                    getMethod("_" + exercitiuDorita); // gasesc functia in care am scris exercitiul

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

        public static void _1()
        {
            int n = citireN(), element;
            int freqPare = 0;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element % 2 == 0)
                    freqPare++;
            }
            Console.WriteLine("Elemente pare in secventa dat : " + freqPare);

        }
        public static void _2()
        {
            int n = citireN(), element, contorZero = 0, contorNeg = 0, contorPoz = 0;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element < 0)
                    contorNeg++;
                else
                if (element > 0)
                    contorPoz++;
                else
                    contorZero++;
            }
            Console.WriteLine($"Secventa are {contorPoz} numere pozitive , {contorNeg} numere negative si {contorZero} zerouri");
        }
        public static void _3()
        {
            int n = citireN(), suma = 0, produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor este {suma} si produsul numerelor de la 1 la n este {produs}");
        }
        public static void _4()
        {
            int n = citireN(), a = citireInt("a"), indexPentruA = -1, element;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element == a)
                    indexPentruA = i;
            }
            if (indexPentruA == -1)
                Console.WriteLine(indexPentruA);
            else
                Console.WriteLine("Pozitia pe care se afla in secventa numara a : " + indexPentruA);
        }
        public static void _5()
        {
            int n = citireN(), contorElement = 0, element;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element == i)
                    contorElement++;
            }
            Console.WriteLine($"{contorElement} elemente sunt egale cu pozitia pe care apar in secventa.");
        }
        public static void _6()
        {
            int n = citireN(), saveAux, element;
            bool esteCrescator = true;
            element = int.Parse(Console.ReadLine());
            saveAux = element;
            for (int i = 1; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());

                if (saveAux - element > 0)
                    esteCrescator = false;


                saveAux = element;
            }
            if (esteCrescator)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare.");
            else
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare.");
        }
        public static void _7()
        {
            int n = citireN(), min, max, element;
            element = int.Parse(Console.ReadLine());
            min = element;
            max = element;
            for (int i = 1; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element < min)
                    min = element;
                if (element > max)
                    max = element;
            }
            Console.WriteLine($"Cea mai mare valoare este {max} si cea mai mica valoare este {min}");
        }
        public static int Fibo(int n)
        {

            if (n <= 2)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
        public static void _8()
        {
            int n = citireN();
            if (n == 1)
                Console.WriteLine($"Al n-lea numar din sirul lui Fibonacci este {0}");
            else

                Console.WriteLine($"Al n-lea numar din sirul lui Fibonacci este {Fibo(n - 1)}");
        }
        public static void _9()
        {
            int n = citireN(), saveAux, element;
            bool esteCrescator = true, esteDescrescator = true;
            element = int.Parse(Console.ReadLine());
            saveAux = element;
            for (int i = 1; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());

                if (saveAux - element > 0)
                    esteCrescator = false;
                else
                if (saveAux - element < 0)
                    esteDescrescator = false;


                saveAux = element;
            }
            if (esteCrescator || esteDescrescator)
                Console.WriteLine("Secventa de n numere este monotona");
            else
                Console.WriteLine("Secventa de n numere nu este monotona");
        }
        public static void _10()
            {
            int n = citireN(),bucataConsec = 0, maxConsec = 0, saveAux,element;
            element = int.Parse(Console.ReadLine());
            saveAux = element;

            for (int i = 1; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());

                if (element == saveAux)
                    bucataConsec++;
                else
                    bucataConsec = 0;

                if (maxConsec < bucataConsec)
                    maxConsec = bucataConsec;

                saveAux = element;

            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este : {maxConsec+1}");

            }
        public static void _11()
        {
            int n = citireN(), element, saveAux ,sumInverse = 0;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                saveAux = 0;
                    while(element!=0)
                {
                    saveAux = saveAux * 10 + element % 10;
                    element /= 10;
                    
                }
                sumInverse += saveAux;
            }
            Console.WriteLine("Suma inverselor acestor numere este : "+sumInverse);
        }
        public static void _12()
        {
            int n = citireN(), grup = 0, elemCons = 0, element, k = 0;
            for (int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element != 0)
                    elemCons++;
                else
                {
                    if(elemCons>0)
                    grup++;
                    elemCons = 0;
                }
                    
            }
            if (elemCons > 0)
                grup++;
           
            Console.WriteLine($"{grup} grupuri de numere consecutive diferite de zero sunt in secventa de n numere");
        }
        public static void _13()
        {
            int n = citireN(),element,aux,contorElementeNotCresc=0,indexElementNotCresc = -1;
            aux = int.Parse(Console.ReadLine());
            bool crescator = true;
            element = int.Parse(Console.ReadLine());

            if (aux > element) // daca sirul nu este crescator
            {
                crescator = false;
                contorElementeNotCresc++; // numerez aceste elemente care nu apartine subsirului crescatoare
                indexElementNotCresc = 0; // este pe pozitia 0 elementul care impiedica secventa sa devine crescator
            }
            aux = element;
            for (int i = 2; i < n; i++)
            {
               
                element = int.Parse(Console.ReadLine());
                if (aux > element)
                {
                    crescator = false;
                    contorElementeNotCresc++;
                    indexElementNotCresc = i;
                }
                aux = element;
            
            }
            if(crescator || (contorElementeNotCresc==1 && (indexElementNotCresc == 0 || indexElementNotCresc == n-1))) // daca este crescator secventa sau este un element care nu este in subsirul crescatoare a secventei si elementul acesta este pe prima sau pe ultima pozitie atunci...
                Console.WriteLine("Secventa este o secventa crescatoare rotita");
            else
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita");
        }
        public static void _14()
        {
            int n = citireN(), element, aux, contorElementeNotCresc = 0, indexElementNotCresc = -1, contorElementeCresc = 0, indexElementCresc = -1;
            aux = int.Parse(Console.ReadLine());
            bool crescator = true , descrescator = true;
            element = int.Parse(Console.ReadLine());

            if (aux > element) // daca sirul este descrescator
            {
                crescator = false;
                contorElementeNotCresc++; // numerez aceste elemente care nu apartine subsirului descrescatoare
                indexElementNotCresc = 0; // este pe pozitia 0 elementul care impiedica secventa sa devine descrescator
            }

            if (aux < element) // daca sirul  este crescator
            {
                descrescator = false;
                contorElementeCresc++; // numerez aceste elemente care nu apartine subsirului crescatoare
                indexElementCresc = 0; // este pe pozitia 0 elementul care impiedica secventa sa devine crescator
            }
            aux = element;
            for (int i = 2; i < n ; i++)
            {

                element = int.Parse(Console.ReadLine());
                if (aux > element)
                {
                    crescator = false;
                    contorElementeNotCresc++;
                    indexElementNotCresc = i;
                }
               
                if (aux < element) 
                {
                    descrescator = false;
                    contorElementeCresc++;
                    indexElementCresc = i;
                }
                aux = element;

            }

           

            if ((crescator || (!descrescator && (contorElementeNotCresc == 1 && (indexElementNotCresc == 0 || indexElementNotCresc == n - 1)))) 
                || (descrescator || (!crescator && (contorElementeCresc == 1 && (indexElementCresc == 0 || indexElementCresc == n - 1))))
                )
                // (daca este crescator secventa sau nu este descrescator si este un element care nu este in subsirul crescatoare a secventei si elementul acesta este pe prima sau pe ultima pozitie)
                // sau 
                // (daca este descrescator secventa sau nu este crescator si este un element care nu este in subsirul descrescatoare a secventei si elementul acesta este pe prima sau pe ultima pozitie)
                Console.WriteLine("Secventa este o secventa monotona rotita");
            else
                Console.WriteLine("Secventa nu este o secventa monotona rotita");
           
        }
        public static void _15()
        {
            int n = citireN(), elemente , contorSirCresc = 0 , contorSirDescresc = 0,aux = int.Parse(Console.ReadLine());
            bool monotonie = false;
            
            elemente = int.Parse(Console.ReadLine());

            if (aux < elemente)
            monotonie = true; // true = crescator , false = descrescator
            aux = elemente;
            if (monotonie) // daca sirul "incepe" crescator
            {
                for (int i = 2; i < n; i++)
                {
                    elemente = int.Parse(Console.ReadLine());

                    if (aux > elemente)
                    {
                        if(monotonie)
                        contorSirCresc++;
                        monotonie = false;
                    }
                    if(aux < elemente)
                    {
                        if (!monotonie)
                            contorSirDescresc++;
                        monotonie = true;
                    }
                    aux = elemente;
                }

                if (!monotonie)
                    contorSirDescresc++;
                else
                    contorSirCresc++;
                if(contorSirCresc == 1 && contorSirDescresc == 1)
                    Console.WriteLine("Secventa este bitonica");
                else
                    Console.WriteLine("Secventa nu este bitonica");
            }
            else
                Console.WriteLine("Secventa nu este bitonica");
        }
        public static void _17()
        {
            int n = citireN(), contor = 0,elemente;

            for (int i = 0; i < n; i++)
            {
               
                    elemente = int.Parse(Console.ReadLine());
                if (elemente == 0)
                    contor++;
                else
                   if (elemente == 1)
                    contor--;
                else throw new Exception();

                if (contor == -1)
                {
                    Console.WriteLine("Secventa nu reprezinta o secventa de paranteze corecta");
                    break; 
                }
            }
            if(contor==0)
                Console.WriteLine("Secventa  reprezinta o secventa de paranteze corecta");
            
            
        }

    }
}

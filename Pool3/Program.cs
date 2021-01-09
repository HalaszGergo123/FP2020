using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Pool3
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
        static int citireInt(string s) // citesc variabila dorita
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
        /// Citim o secventa de numere pe care pastram intr-un vector
        /// </summary>
        /// <returns>Returneaza un vector pentru metode</returns>
        static int[] citireVector() // citesc vectorul 
        {
            Console.Write("Introduceti secventa: ");

            string s = Console.ReadLine();
            int[] vector = s.Split(',', ' ').Select(int.Parse).ToArray();
            return vector;     // returnam vectorul
        }
        /// <summary>
        /// Afiseaza pe consola vectorul dorit.
        /// </summary>
        /// <param name="vector"></param>
        static void afisareVector(int[] vector) //afisam vectorul
        {
            Console.Write("Afisare vector: ");
            for (int i = 0; i < vector.Length; i++)
                Console.Write(vector[i] + " ");
        }
        /// <summary>
        /// FUNCTIA MAIN ARE ROL DE A SCRIE PE CONSOLA EXERCITIILE SI SA AJUTA PE UTILIZATORUL SA APELEZE EXERCITII a.k.a DRIVER    
        /// </summary>
        /// <param name="args"></param
        static void Main(string[] args) // functia main,aici apelez exercitii pe care am facut
        {
            Console.WriteLine("                   -                              Problems pool 3                             -          ");

            string[] cerinte = new string[] //cerintele
            {
                  " 1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.",
" 2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.",
" 3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).",
" 4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ",
" 5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. ",
" 6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ",
" 7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.",
" 8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ",
" 9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ",
"10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ",
"11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ",
"12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ",
"13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ",
"14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ",
"15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ",
"16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.",
"17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.",
"18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. ",
"19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). ",
"20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ",
"21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).",
"22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ",
"23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. ",
"24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).",
"25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. ",
"26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. ",
"27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. ",
"28. Quicksort. Sortati un vector folosind metoda QuickSort. ",
"29. MergeSort. Sortati un vector folosind metoda MergeSort.",
"30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. ",
"31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). "

            };
            for (int i = 0; i < cerinte.Length; i++)
            {
                Console.WriteLine(cerinte[i]); // scriu separat exercitii pe care am facut

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
                    Console.WriteLine("\n=============Incercati inca o data!================");
                }
            }

        }
        public static void getMethod(string s)
        {
            Type thisType = typeof(Program); // trebuie sa aflam tipul clasei in care apelez metode
            MethodInfo theMethod = thisType.GetMethod(s); // asa pot sa gasesc metoda care este cerut
            theMethod.Invoke(thisType, null); // incep metoda
        }
        public static void _1()
        {
            int[] elemente = citireVector(); // citim vectorul
            int sumaElem = 0; // suma elementelor

            for (int i = 0; i < elemente.Length; i++)
                sumaElem += elemente[i];  // adunam elemete

            Console.WriteLine("Suma elementelor : " + sumaElem);
        }
        public static void _2()
        {
            int[] elemente = citireVector();
            int k = citireInt("k"), poz = -1; // citesc k

            for (int i = 0; i < elemente.Length; i++)
            {
                if (elemente[i] == k)
                {
                    poz = i; // dupa ce am gasit prima pozitia
                    break; // oprim for-ul
                }
            }
            if (poz == -1) // daca nu am gasit k in secventa
                Console.WriteLine(-1);
            else
                Console.WriteLine("Prima pozitie din vector pe care apare k: " + poz);

        }
        public static void _3()
        {
            int[] elemente = citireVector();

            int mic = elemente[0], mare = elemente[0], pozMin = 0, pozMax = 0;
            for (int i = 1; i < elemente.Length; i++)
            {
                if (elemente[i] < mic)
                    mic = elemente[i];

                if (elemente[i] > mare)
                    mare = elemente[i];

            }
            Console.Write("Pozitiile pe care apar cel mai mic element al vectorului: ");
            for (int i = 0; i < elemente.Length; i++)
            {
                if (elemente[i] == mic)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Pozitiile pe care apar cel mai mare element al vectorului: ");
            for (int i = 0; i < elemente.Length; i++)
            {
                if (elemente[i] == mare)
                    Console.Write(i + " ");
            }

        }





        public static void _4()
        {
            int[] elemente = citireVector();

            int Min = elemente[0], Max = elemente[0], freqMin = 1, freqMax = 1;

            for (int i = 1; i < elemente.Length; i++)
            {
                if (Min > elemente[i])
                {
                    Min = elemente[i];
                    freqMin = 0;
                }
                else
                if (Max < elemente[i])
                {
                    Max = elemente[i];
                    freqMax = 0;
                }
                if (elemente[i] == Min)
                    freqMin++;
                if (elemente[i] == Max)
                    freqMax++;

            }

            Console.WriteLine("Elementul cel mai mic : " + Min);
            Console.WriteLine("Elementul cel mai mare: " + Max);
            Console.WriteLine("Frecventia elementului cel mai mic : " + freqMin);
            Console.WriteLine("Frecventia elementului cel mai mare : " + freqMax);

        }


        public static void _5()
        {
            int[] elemente = citireVector();
            int k = citireInt("k"), e = citireInt("e");
            elemente[k] = e;
            Console.Write("Vectorul modificat: ");
            afisareVector(elemente);
        }
        public static void _6()
        {
            int[] elemente = citireVector();
            int k = citireInt("k");

            for (int i = k; i < elemente.Length - 1; i++)
            {
                elemente[i] = elemente[i + 1];
            }
            Console.Write("Afisarea vectorului modificat: ");

            for (int i = 0; i < elemente.Length - 1; i++)
            {
                Console.Write(elemente[i] + " ");
            }
        }
        public static void _7()
        {
            int[] elemente = citireVector();
            Array.Reverse(elemente);
            afisareVector(elemente);

        }
        public static void _8()
        {
            int[] elemente = citireVector();
            int aux; // extra variable

            aux = elemente[elemente.Length - 1];
            elemente[elemente.Length - 1] = elemente[0];
            for (int i = 1; i < elemente.Length - 1; i++)
            {
                elemente[i - 1] = elemente[i];
            }
            elemente[elemente.Length - 2] = aux;
            afisareVector(elemente);

        }
        public static void _9()
        {
            int[] elemente = citireVector();
            int k = citireInt("k"), aux;


            while (k != 0) // facem k ori metoda care am folosit in exercitia 8
            {
                aux = elemente[elemente.Length - 1];
                elemente[elemente.Length - 1] = elemente[0];
                for (int i = 1; i < elemente.Length - 1; i++)
                {
                    elemente[i - 1] = elemente[i];
                }
                elemente[elemente.Length - 2] = aux;
                k--;

            }
            afisareVector(elemente);

        }
        public static void _10()
        {

            int[] elemets = citireVector();
            int k = citireInt("k");
            int mij, limmin = 0, limmax = elemets.Length - 1;

            while (limmin < limmax)
            {
                mij = (limmin + limmax) / 2;
                if (k <= elemets[mij])
                    limmax = mij;
                else
                    limmin = mij + 1;
            }
            if (limmin != limmax)
                Console.WriteLine("Rezultatul este -1");
            else
                Console.WriteLine("Pozitia elementului dat k este: " + limmin);

        }

        public static void _11()
        {
            int n = citireInt("n"), i, j;
            int[] c = new int[n + 1];
            for (i = 2; i <= n; i++)
                c[i] = i;
            i = 2;
            while (i <= n / 2)
            {
                if (c[i] != 0)
                {
                    j = 2 * i;
                    while (j <= n)
                    {
                        if (c[j] != 0) c[j] = 0;
                        j += i;
                    }
                }
                i++;
            }
            for (i = 2; i <= n; i++)
                if (c[i] != 0)
                    Console.Write(c[i] + " ");


        }
        public static void _12()
        {
            int[] elemente = citireVector();
            int smallest, celMaiMic;
            for (int i = 0; i < elemente.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < elemente.Length; j++)
                {
                    if (elemente[smallest] > elemente[j])
                        smallest = j;
                }
                celMaiMic = elemente[smallest];
                elemente[smallest] = elemente[i];
                elemente[i] = celMaiMic;
            }
            afisareVector(elemente);
        }
        public static void _13()
        {
            int[] elemente = citireVector();
            int aux;
            for (int i = 0; i < elemente.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (elemente[j - 1] > elemente[j])
                    {
                        aux = elemente[j - 1];
                        elemente[j - 1] = elemente[j];
                        elemente[j] = aux;
                    }
                }
            }
            afisareVector(elemente);
        }
        public static void _14()
        {
            int[] elemente = citireVector();
            int lungime = elemente.Length - 1;
            for (int i = 0; i <= lungime; i++)
            {
                while (elemente[lungime] == 0)
                    lungime--;
                if (elemente[i] == 0 && lungime != i)
                {
                    elemente[i] = elemente[lungime];
                    elemente[lungime] = 0;
                    lungime--;
                }
            }
            afisareVector(elemente);
        }
        public static void _15()
        {
            int[] elemente = citireVector();
            int lungime = elemente.Length;
            for (int i = 0; i < lungime - 1; i++)
            {
                for (int j = i + 1; j < lungime; j++)
                {
                    if (elemente[i] == elemente[j])
                    {
                        for (int z = j + 1; z < elemente.Length; z++)
                        {
                            elemente[z - 1] = elemente[z];
                        }
                        j--;
                        lungime--;
                    }

                }
            }
            Console.Write("Afisare vector: ");
            for (int i = 0; i < lungime; i++)
            {

                Console.Write(elemente[i] + " ");
            }

        }
        public static void _16()
        {
            int[] elemente = citireVector();
            int cmmdc = elemente[0], r;
            for (int i = 0; i < elemente.Length; i++)
            {
                while (elemente[i] != 0)
                {
                    r = cmmdc % elemente[i];
                    cmmdc = elemente[i];
                    elemente[i] = r;

                }

            }
            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este {cmmdc}.");

        }
        public static void _17()
        {
            float n = citireFloat("n");
            int b = citireInt("b");
            while (b < 2 || b > 16)
            {
                Console.WriteLine("Baza trebuie sa fie intre 2 si 16!");
                Console.WriteLine();
                b = citireInt("b");
            }
            string s = n.ToString();
            string[] splitS;
            int parteIntreaga = 0, parteZecimala = 0, pInt, pZec = 0;
            Stack myStack = new Stack();
            bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '.')
                {
                    splitS = s.Split('.');
                    parteIntreaga = int.Parse(splitS[0]);
                    parteZecimala = int.Parse(splitS[1]);
                    flag = true;
                    break;
                }


            }
            if (!flag)
            { parteIntreaga = int.Parse(s); }

            Console.Write("Numarul n in baza ceruta: ");

            if (parteIntreaga == 0)
                Console.Write(0);
            while (parteIntreaga != 0)
            {
                int r = parteIntreaga % b;
                parteIntreaga /= b;
                myStack.Push(r);

            }
            foreach (int rest in myStack)
                Console.Write(rest);
            if (parteZecimala != 0)
            {


                Console.Write(".");
                string parteZecimalaConvert = $"0.{parteZecimala}";
                float parteZecimalaFloat = float.Parse(parteZecimalaConvert);
                bool okInt = false, ok = true;
                while (ok)
                {
                    float rezultat = parteZecimalaFloat * b;
                    string parteString = rezultat.ToString();
                    for (int i = 0; i < parteString.Length; i++)
                    {
                        if (parteString[i] == '.')
                        {
                            splitS = parteString.Split('.');
                            pInt = int.Parse(splitS[0]);
                            pZec = int.Parse(splitS[1]);
                            Console.Write(pInt);
                            okInt = true;
                            break;
                        }
                    }
                    if (okInt == false)
                    { Console.Write(rezultat); ok = false; }
                    else
                    {
                        string pZecConvert = $"0.{pZec}";
                        float pZecFloat = float.Parse(pZecConvert);
                        parteZecimalaFloat = pZecFloat;
                    }

                    okInt = false;
                }
            }
        }
        static public void _18()
        {
            int n = citireInt("n");
            int[] elemente = citireVector();
            int x = citireInt("x");
            int sum = 0;
            for (int i = 0; i <= n; i++)
                sum += elemente[i] * (int)Math.Pow(x, i);
            Console.WriteLine("Valoarea in punctul x este : " + sum);
        }
        static public void _19()
        {
            int[] s, p;
            int contorElementeInS = 0, contorAparitie = 0, contorPentruJ = 0;


            Console.Write("Introduceti secventa s: ");
            string s1 = Console.ReadLine();
            s = s1.Split(',', ' ').Select(int.Parse).ToArray();

            Console.Write("Introduceti secventa p: ");
            s1 = Console.ReadLine();
            p = s1.Split(',', ' ').Select(int.Parse).ToArray();



            for (int i = 0; i < s.Length; i++) //  forul i ajuta la indexare j-ului
            {
                for (int j = i; contorElementeInS < p.Length && j < s.Length; j++) //scopul forului j este ca sa incepe de la j verificarea 
                {
                    if (s[j] != p[contorPentruJ])
                        break;
                    else
                    {
                        contorElementeInS++;
                    }
                    contorPentruJ++;
                }
                if (contorElementeInS == p.Length)
                { contorAparitie++; i = i + p.Length - 1; }
                contorElementeInS = 0;
                contorPentruJ = 0;

            }
            Console.WriteLine($"In s vector p apare de {contorAparitie} ori!");
        }
        public static void _21()
        {
            int[] v1 = citireVector(), v2 = citireVector();
            string s1 = "", s2 = "";
            bool asemanator = false;
            for (int i = 0; i < v1.Length; i++)
            {
                s1 += v1[i].ToString() + ",";


            }
            for (int i = 0; i < v2.Length; i++)
            {
                s2 += v2[i].ToString() + ",";
            }
            Console.WriteLine("Ordinea lexicografica: ");
            Console.WriteLine(String.Compare(s1, s2) < 0 ? s1 + "\n" + s2 : s2 + "\n" + s1);

        }
        public static void _22()
        {
            int[] v1 = citireVector(), v2 = citireVector();
            //sortare(insertion) pentru v1
            int smallest, celMaiMic;
            for (int i = 0; i < v1.Length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < v1.Length; j++)
                {
                    if (v1[smallest] > v1[j])
                        smallest = j;
                }
                celMaiMic = v1[smallest];
                v1[smallest] = v1[i];
                v1[i] = celMaiMic;
            }
            //sortare pentru v2
            for (int i = 0; i < v2.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < v2.Length; j++)
                {
                    if (v2[smallest] > v2[j])
                        smallest = j;
                }
                celMaiMic = v2[smallest];
                v2[smallest] = v2[i];
                v2[i] = celMaiMic;
            }
            //intersectia
            Console.Write("Intersectia: ");
            int aux = v1[0];
            for (int j = 0; j < v2.Length; j++)
            {
                if (v1[0] == v2[j])
                {
                    Console.Write(v2[j] + " ");
                    break;
                }
            }

            for (int i = 1; i < v1.Length; i++)
            {

                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j] && v2[j] != aux)
                    {
                        Console.Write(v2[j] + " ");
                        break;
                    }

                }
                aux = v1[i];
            }

            //reunire
            aux = v1[0];
            int min;


            if (v1[0] < v2[0] || v1[0] == v2[0])
                Console.Write(v1[0] + " ");
            else
                Console.WriteLine(v2[0]);


            int z, k = 1;


            for (int i = 1; i < v1.Length; i++)
            {

                for (z = k; z < v2.Length; z++)
                {
                    if (v1[i] < v2[z])
                    {
                        Console.Write(v1[0] + " ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(v2[z]);
                        k++;
                    }

                }
            }

        }
        public static void _23()
        {
            int[] v1 = citireVector(), v2 = citireVector();

            int smallest, celMaiMic;


            Console.Write("Intersectia: ");
            int aux = v1[0];
            for (int j = 0; j < v2.Length; j++)
            {
                if (v1[0] == v2[j])
                {
                    Console.Write(v2[j] + " ");
                    break;
                }
            }

            for (int i = 1; i < v1.Length; i++)
            {

                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j] && v2[j] != aux)
                    {
                        Console.Write(v2[j] + " ");
                        break;
                    }

                }
                aux = v1[i];
            }

            //reunire
            aux = v1[0];
            int min;


            if (v1[0] < v2[0] || v1[0] == v2[0])
                Console.Write(v1[0] + " ");
            else
                Console.WriteLine(v2[0]);


            int z, k = 1;


            for (int i = 1; i < v1.Length; i++)
            {

                for (z = k; z < v2.Length; z++)
                {
                    if (v1[i] < v2[z])
                    {
                        Console.Write(v1[0] + " ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(v2[z]);
                        k++;
                    }

                }
            }

        }
        public static void _25()
        {
            int[] v1 = citireVector(), v2 = citireVector(), v3 = new int[v1.Length + v2.Length];
            int k = 0, i = 0, j = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v3[k] = v1[i];
                    i++;
                    k++;

                }
                else
                {
                    v3[k] = v2[j];
                    k++;
                    j++;
                }
            }

            if (i < v1.Length)
            {
                for (int z = i; z < v1.Length; z++)
                {
                    v3[k] = v1[z];
                    k++;
                }
            }
            if (j < v2.Length)
            {
                for (int z = j; z < v2.Length; z++)
                {
                    v3[k] = v2[j];
                    k++;
                }
            }

            afisareVector(v3);

        }
        public static void _26()
        {

            int[] v1, v2, v3, v4;
            int i, j;
            Console.Write("Spuneti cat ii lungimul primului numar : ");
            int n = int.Parse(Console.ReadLine()), element;
            Console.Write("Citim numarul mare cu o cifra : ");
            v1 = new int[n]; // v1 si v2 sunt pentru adunare

            for (i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element / 10 != 0)
                    throw new Exception();
                else
                    v1[i] = element;
            }
            v3 = v1; //v3 si v4 sunt pentru scadere
            Console.Write("Spuneti cat ii lungimul a doua numar : ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Citim numarul mare cu o cifra : ");
            v2 = new int[m];// v1 si v2 sunt pentru adunare

            for (i = 0; i < m; i++)
            {
                element = int.Parse(Console.ReadLine());
                if (element / 10 != 0)
                    throw new Exception();
                else
                    v2[i] = element;
            }
            v4 = v2;//v3 si v4 sunt pentru scadere
            Stack myStack = new Stack();
            int aux = 0;
            i = v1.Length - 1; j = v2.Length - 1;
            //suma

            while (i >= 0 && j >= 0)
            {
                if (aux == 1)
                {
                    v1[i]++;
                    aux = 0;
                }
                if (v1[i] + v2[j] >= 10)
                {
                    myStack.Push((v1[i] + v2[j]) % 10);
                    aux++;
                    i--;
                    j--;
                }
                else
                {
                    myStack.Push(v1[i] + v2[j]);
                    i--; j--;
                }
            }
            if (i < j)
            {

                for (int z = j; z >= 0; z--)
                {
                    if (aux == 1)
                    {
                        v2[z]++;
                        aux = 0;
                    }

                    if (v2[z] == 10)
                    {
                        myStack.Push(0);
                        aux++;
                    }
                    else
                        myStack.Push(v2[z]);
                }
            }
            if (i > j)
            {


                for (int z = i; z >= 0; z--)
                {
                    if (aux == 1)
                    {
                        v1[z]++;
                        aux = 0;
                    }

                    if (v1[z] == 10)
                    {
                        myStack.Push(0);
                        aux++;
                    }
                    else
                        myStack.Push(v1[z]);
                }

            }


            if (aux == 1)
                myStack.Push(1);
            aux = 0;
            Console.Write("Adunare : ");
            foreach (Object obj in myStack)
                Console.Write($"{obj}");
            Console.WriteLine();
            myStack.Clear();
            Console.Write("Scadere : ");
            //scadere

            i = v3.Length - 1; j = v4.Length - 1;
            while (i >= 0 && j >= 0)
            {
                if (aux == 1)
                {
                    v3[i]--;
                    aux = 0;
                }
                if (v3[i] - v4[j] < 0)
                {
                    myStack.Push(10 + (v3[i] - v4[j]));
                    aux = 1;
                    i--;
                    j--;

                }
                else
                if (v3[i] - v4[j] > 0)
                {
                    myStack.Push(v3[i] - v4[j]);
                    i--;
                    j--;
                }
                else
                if (v3[i] - v4[j] == 0 && (i - 1 >= 0 || j - 1 >= 0))
                {
                    myStack.Push(v3[i] - v4[j]);
                    i--;
                    j--;
                }
                else
                {
                    i--; j--;
                }
            }

            if (i > j)
            {
                for (int z = i; z >= 0; z--)
                {
                    if (aux == 1 && v3[z] != 0)
                    {
                        v3[z]--;
                        aux = 0;
                    }
                    if (v3[z] == 0 && z - 1 >= 0)
                        myStack.Push(v3[z]);
                    else
                    if (v3[z] != 0)
                        myStack.Push(v3[z]);



                }
            }
            else
             if (i < j)
            {
                for (int z = j; z >= 0; z--)
                {
                    if (aux == 1 && v4[z] != 0)
                    {
                        v4[z]--;
                        aux = 0;

                    }
                    if (v4[z] == 0 && z - 1 >= 0)
                        myStack.Push(v4[z]);
                    else
                 if (v4[z] != 0)
                        myStack.Push(v4[z]);
                }
            }
            foreach (Object obj in myStack)
                Console.Write($"{obj}");



        }
        public static int partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            int aux;
            // Put the elements smaller than pivot on the left and 
            // greater than pivot on the right of pivot
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                }
            }
            aux = array[i + 1];
            array[i + 1] = array[high];
            array[high] = aux;
            return (i + 1);
        }
        public static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(array, low, high);

                QuickSort(array, low, pi - 1);

                QuickSort(array, pi + 1, high);
            }
        }
        public static void _27()
        {
            int[] v1 = citireVector();
            int index = citireInt("index");

            QuickSort(v1, 0, v1.Length - 1);
            Console.WriteLine("Valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat : " + v1[index]);

        }
        public static void _28()
        {
            int[] v1 = citireVector();
            QuickSort(v1, 0, v1.Length - 1);
            Console.Write("Un vector sortat folosind metoda QuickSort : ");
            foreach (var item in v1)
            {
                Console.Write(item + " ");
            }
        }
        class MergeSort
        {
            public void merge(int[] arr, int p, int q, int r)
            {
                int n1 = q - p + 1;
                int n2 = r - q;
                int i, j, k;
                int[] L = new int[n1];
                int[] M = new int[n2];

                for (i = 0; i < n1; i++)

                    L[i] = arr[p + i];
                for (i = 0; i < n2; i++)
                    M[i] = arr[q + 1 + i];

                i = 0; k = p; j = 0;

                while (i < n1 && j < n2)
                {
                    if (L[i] <= M[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = M[j];
                        j++;
                    }
                    k++;
                }
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++; k++;
                }
                while (j < n2)
                {
                    arr[k] = M[j];
                    j++; k++;
                }
            }
            public void mergeSort(int[] arr, int p, int r)
            {
                if (p < r)
                {
                    int m = (p + r) / 2;

                    mergeSort(arr, p, m);
                    mergeSort(arr, m + 1, r);

                    merge(arr, p, m, r);
                }
            }
        }
        class MergeSortPentruEx30
        {
            public void merge(int[] arr, int p, int q, int r, int[] w)
            {
                int n1 = q - p + 1;
                int n2 = r - q;
                int i, j, k;
                int[] L = new int[n1];
                int[] M = new int[n2];

                for (i = 0; i < n1; i++)

                    L[i] = arr[p + i];
                for (i = 0; i < n2; i++)
                    M[i] = arr[q + 1 + i];

                i = 0; k = p; j = 0;

                while (i < n1 && j < n2)
                {
                    if (L[i] < M[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                     if (L[i] == M[j])
                    {
                        if (w[p + i] > w[q + 1 + j]) // daca  primul element egal are pondere mai mare
                        { arr[k] = L[i]; i++; } //elementul cu pondere mai mare va fi primul element
                        else
                        { arr[k] = M[j]; j++; } //elementul cu pondere mai mare va fi primul
                        
                    }
                    else
                    {
                        arr[k] = M[j];
                        j++;
                    }
                    k++;
                }
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++; k++;
                }
                while (j < n2)
                {
                    arr[k] = M[j];
                    j++; k++;
                }
            }
            public void mergeSort(int[] arr, int p, int r, int[] w)
            {
                if (p < r)
                {
                    int m = (p + r) / 2;

                    mergeSort(arr, p, m,w);
                    mergeSort(arr, m + 1, r,w);

                    merge(arr, p, m, r,w);
                }
            }
        }
       
    
       


        public static void _29()
        {
            int[] v1 = citireVector();
            MergeSort sorting = new MergeSort();
            

            sorting.mergeSort(v1, 0, v1.Length - 1);

            Console.WriteLine("Sorted array: ");
            foreach (var item in v1)
            {
                Console.Write(item+" ");
            }
        }

        public static void _30()
        {
            int[] E = citireVector(),W=citireVector();
            MergeSortPentruEx30 sorting = new MergeSortPentruEx30();

            sorting.mergeSort(E, 0, E.Length - 1, W);

            Console.WriteLine("Sorted array: ");
            foreach (var item in E)
            {
                Console.Write(item+ " ");
            }

           
        }
        public static void _31()
        {
            int[] v1 = citireVector();
            int m,freq = 1;
            bool majoritate = false;

            for (int i = 0; i < v1.Length-1; i++)
            {
                m = v1[i];
                for (int j = i+1; j < v1.Length; j++)
                {
                    if (v1[j] == m)
                        freq++;
                }
                if (freq > v1.Length / 2)
                {
                    Console.WriteLine("Elementul majoritate al unui vector: " + m);
                    majoritate = true;
                    break;
                }
                freq = 1;
            }
            if(!majoritate)
                Console.WriteLine("<nu exista>");            
        }
    }
    
   

}



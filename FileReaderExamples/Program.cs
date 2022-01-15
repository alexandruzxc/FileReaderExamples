using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileReaderExamples
{

    //Citirea din Fisier
    // obiectele TextReader si TextWritter
    // obiectele astea au functia Readline si WriteLine
    //
    class Program
    {
        static void Main(string[] args)
        {
            //"C:\\Users\\Alexandru.Ifrim\\source\\repos\\FileReaderExamples\\Textfile1.txt"; calea explicita
            // @"..\..\" - calea implicita


            //trebuie sa gasesc calea spre fisier ..."TextFile1.txt

            //TextReader loadx = new StreamReader(@"..\..\Rerurse\text.txt");
            // am creat un TextReader load, dupa care l-am initializat ( new StreamReader) si dupa am pus calea spre fisier
            //TextReader load0 = new StreamReader(@"..\..\Resurse\test.txt");
      
  
            int x; 
            //1AVEM INCLUSIV NUMARUL DE ELEMENTE PE UN SIR si numerele pe acelasi sir 
            TextReader load1 = new StreamReader(@"..\..\TextFile1.txt");
            string buffer0 = load1.ReadLine(); //dupa ce am luat string-ul am terminat cu fisierul

            //trebuie sa impart sirul ca sa aflu elementele

            //buffer0.Split(' ');  aici am folosit functia Split cu separaturul ' ' spatiu ca sa impart string-ul
            string[] local = buffer0.Split(' '); //am folosit split-ul ca sa pun valorile intr-un vector
            for (int i = 0; i < local.Length; i++)   // local.Lenght e lungimea vectorului
                Console.WriteLine(local[i]); // si am afisat toate numerele din fisier 
            Console.WriteLine("Mai sus am afisat toate numerele din TextFile1");
            int s1 = 0;
            int n1 = int.Parse(local[0]); // am pus in n1 cate primul numar din fisier, care reprezinta cate numere am in fisierul respectiv
            for (int i = 1; i <= n1; i++)
            {
                x = int.Parse(local[i]);
                s1 += x; 
            }
            Console.WriteLine(s1);
            Console.WriteLine("____");
            Console.WriteLine(" ");



            //2 TextReader load2 = new StreamReader(@"..\..\TextFile2.txt");
            // avem un numar de numere pe o linie (fara n la inceputul sirului)
            TextReader load2 = new StreamReader(@"..\..\TextFile2.txt");
             buffer0 = load2.ReadLine();  // am folosit buffer0 ca sa pun numerele intr-un string
            int s2 = 0; 
             local = buffer0.Split(' '); // am spart string-ul in functie de spatiu
            for (int i = 0; i < local.Length; i++)
            { 
                x = int.Parse(local[i]);
                s2 += x;
            }
            //am calculat suma si am afisat-o.
            Console.WriteLine(s2);
            Console.WriteLine("____");
            Console.WriteLine(" ");



            //3 am n numarul de numere si apoi PE FIECARE LINIE URMATOARE cate un numar
            TextReader load3 = new StreamReader(@"..\..\TextFile3.txt");
            int s = 0;

            //3 load3.ReadLine(); -> e ca si cum am fi in Console.Readline  - ne citeste o linie
            int n = int.Parse(load3.ReadLine()); // citesc prima linie ca sa aflu cate numere/elemente am in fisier pe cate o linie

            for (int i = 0; i < n; i++) // stiind ca am numarul de linii, parcurg toate liniile ca sa citesc numerele 
            {
                 x = int.Parse(load3.ReadLine());
                s += x;
            }
            Console.WriteLine(s);

            Console.WriteLine("____");
           
            //4 Am citit linie cu linie si m-am folosit ca stiam ca sunt N elemente, si apoi sunt afisate elementele pe cate o linie

            s = 0; 
            //4 am un sir de numere FIECARE PE CATE O LINIE 
            TextReader load4 = new StreamReader(@"..\..\TextFile4.txt");
            string buffer1; // iau o variabila buffer ca sa citesc linie cu linie 
            while ((buffer1 = load4.ReadLine()) != null) //continui sa citesc cat timp bufferul e diferit de zero, adica pana cand primeste valori din fisier
            {
                  x = int.Parse(buffer1);
                s += x;
            }
            Console.WriteLine(s);

            Console.WriteLine("____");

        }
    }
}

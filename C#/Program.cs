using System;

namespace TutorialCsharp
{
    
  class SwitchTest

  {

    static void Main()

    {

     bool uscita=true;
      do
        {
          Console.Write("Da dove vuoi iniziare? 1.Somma, 2.Somma più numeri, 3.Temperatura, 4.Area triangolo, 5.Area quadrato, 6.Calcolatrice, 7.Numero maggiore: ");
          string n = Console.ReadLine();
          int opzione = Int32.Parse(n);
        switch (opzione)
         { //somma di due numeri
          case 1:
          int numero1; //Variabile intera altezza
          int numero2;
          int somma;
          Console.WriteLine("Inserisci il primo numero:"); //Printf
          numero1= Convert.ToInt32(Console.ReadLine()); //Scanf
          Console.WriteLine("Inserisci il secondo numero:");//Printf
          numero2 = Convert.ToInt32(Console.ReadLine()); //Scanf
          somma = numero1 + numero2; //operazione dichiarata
          Console.WriteLine("il risultato è: " + somma); //risultato stampato a schermo
          Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
          string exit = Console.ReadLine();
          int fine = Int32.Parse(exit);
          if (fine == 1)
          uscita = true;
          else if (fine == 0)
          uscita = false;
          break;
           
          case 2://somma più numeri
          int numeri;
          int numeri2=0;
          int somma1=0;
          int contatore =0;
          Console.WriteLine("Quanti numeri vuoi sommare?");
          numeri = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Quali numeri vuoi sommare?");
          while (contatore < numeri) { 
            numeri2 = Convert.ToInt32(Console.ReadLine());
            somma = numeri2;
            somma1 = somma + somma1;
            contatore++;
           }
            Console.WriteLine("La somma dei numeri da te scelti è: " + somma1);
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;

            case 3://temperatura
            int temperatura;
            Console.WriteLine("Inserisci la temperatura (c°):");
            temperatura = Convert.ToInt32(Console.ReadLine());
            if (temperatura < 25)
             {
              Console.WriteLine("C'è freddo.");
             }

            if (temperatura > 25)
             {
              Console.WriteLine("C'è caldo.");
             }

            if (temperatura == 25)
             {
              Console.WriteLine("Si sta bene.");
             }
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;

            case 4://area triangolo
            int b;
            int a;
            int area;
            Console.WriteLine("Inserisci la base del triangolo:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci l'altezza del triangolo:");
            a = Convert.ToInt32(Console.ReadLine());
            area = b * a;
            Console.WriteLine("L'area del triangolo scelto è: " + area);
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;

            case 5://Area quadrato
            int lato1;
            int lato2;
            Console.WriteLine("Inserisci il valore numerico che corrisponde al primo lato del quadrato:");
            lato1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il valore numerico che corrisponde al secondo lato del quadrato:");
            lato2 = Convert.ToInt32(Console.ReadLine());
            area = lato1 * lato2;
            Console.WriteLine("L'area del quadrato scelto è:" + area);
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;

            case 6: //Calcolatrice
            int addizione;
            int sottrazione;
            int moltiplicazione;
            int divisione;
            int c = 0;
            int d = 0;
            Console.WriteLine("1.Addizione");
            Console.WriteLine("2.Sottrazione");
            Console.WriteLine("3.Moltiplicazione");
            Console.WriteLine("4.Divisione");
            Console.WriteLine("Inserisci il primo valore numerico:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo valore numerico:");
            d = Convert.ToInt32(Console.ReadLine());
            addizione = c + d;
            sottrazione = c - d;
            moltiplicazione = c * d;
            divisione = c / d;
            Console.WriteLine("Il risultato della somma applicata ai numeri da te scelti è:" + addizione);
            Console.WriteLine("Il risultato della sottrazione applicata ai numeri da te scelti è:" + sottrazione);
            Console.WriteLine("Il risultato della moltiplicazione applicata ai numeri da te scelti è:" + moltiplicazione);
            Console.WriteLine("Il risultato della divisione applicata ai numeri da te scelti è:" + divisione);
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;

            case 7://valore maggiore
            int e = 0;
            int f = 0;
            Console.WriteLine("Inserisci il primo valore numerico:");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo valore numerico:");
            f = Convert.ToInt32(Console.ReadLine());
            if (e > f)
             {
             Console.WriteLine("Il valore numerico maggiore tra quelli inseriti è:" + e);
             }

            if (e < f)
             {
             Console.WriteLine("Il valore numerico maggiore tra quelli inseriti è:" + f);
             }

            if (e == f)
             {
             Console.WriteLine("I due valori numerici inseriti sono uguali.");
             }
            break;   

            default:
            Console.WriteLine("Sorry, invalid selection.");
            Console.WriteLine("Vuoi continuare? Digita 1 per continuare o 0 se hai finito il tuo lavoro");
            exit = Console.ReadLine();
            fine = Int32.Parse(exit);
            if (fine == 1)
            uscita = true;
            else if (fine == 0)
            uscita = false;
            break;
        }
      } while (uscita);
     }
   }
 }
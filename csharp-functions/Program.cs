﻿using System.Xml.Linq;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -**void StampaArray(int[] array) * *: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
             * 
             - **int Quadrato(int numero) * *: che vi restituisca il quadrato del numero passato come parametro.
             -**int[] ElevaArrayAlQuadrato(int[] array) * *: che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci(vedi slide)
             -**int sommaElementiArray(int[] array) * *: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
             Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri[2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
             -Stampare l’array di numeri fornito a video
             -Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto[2, 6, 7, 5, 3, 9])
             -Stampare la somma di tutti i numeri
             -Stampare la somma di tutti i numeri elevati al quadrati
             ** BONUS:**Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi** di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di... e così via.
             A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.*/


            //funzione per separare i numeri
            void StampaVirgolaESpazio()
            {
                Console.Write(", ");
            }

            //funzione di stampa array
            void StampaArray(int[] array)
            {
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                        StampaVirgolaESpazio();
                }
                Console.WriteLine(")");
            }

            int[] numeri = { 1, 2, 3, 4 };
            StampaArray(numeri);

            //Funzione del quadrato
            int Quadrato(int n)
            {
                return n * n;
            }

            //stampa risultato quadrato per verifica
            Console.WriteLine(Quadrato(2));

            //Funzione di elevamento al quadrato dell'array
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] arrayQuadrati = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    arrayQuadrati[i] = Quadrato(array[i]);
                }
                return arrayQuadrati;
            }
            //creazione del nuovo array elevato al quadrato
            int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);

            //verifica del risultato
            StampaArray(numeriAlQuadrato);


            //somma dei numeri dell'array
            int sommaElementiArray(int[] array)
            {
                //creo la variabile somma inizializzandola a 0
                int somma = 0;
                //ciclo l'array e sommo il valore dell'indice a somma
                for (int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }
                //restituisco la somma totale alla funzione sommaElementiArray
                return somma;
            }

            int somma = sommaElementiArray(numeri);
            Console.WriteLine($"La somma degli elementi è {somma}");

            /*QUANDO IL GIOCO SI FA DURO I DURI INIZIANO A GIOCARE (ED IO SCAPPO)

             Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
            -Stampare l’array di numeri fornito a video
            -Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto[2, 6, 7, 5, 3, 9])
            -Stampare la somma di tutti i numeri
            -Stampare la somma di tutti i numeri elevati al quadrati*/

            //creazione nuovo array come richiesto e stampa
            int[] arrayDuro = { 2, 6, 7, 5, 3, 9 };
            StampaArray(arrayDuro);

            //Stampa dell'array elevato al quadrato con la verifica di non aver modificato il primo
            int [] numeriAlQuadratoDuri = ElevaArrayAlQuadrato(arrayDuro);

            Console.Write("Ecco i tuoi numeri durissimi elevati: ");
            StampaArray(numeriAlQuadratoDuri);

            Console.Write("Ecco i tuoi numeri durissimi non modificati dell'array originale: ");
            StampaArray(arrayDuro);

            //somma dei numeri durissimi
            int sommaDurissima = sommaElementiArray(arrayDuro);
            Console.WriteLine($"Eccoti la tua somma DURISSIMA: {sommaDurissima}");

            //somma dei numeri durissimi elevati al quadrato
            /*int[] arraySommaQuadrataDurissima = StampaArray(sommaElementiArray(numeriAlQuadratoDuri));
            Console.Write("Ecco la fine di questa roba DURISSIMA: ");
                StampaArray(arraySommaQuadrataDurissima);*/
            int sommaQuadrataDurissima = sommaElementiArray(numeriAlQuadratoDuri);
            Console.Write($"Ecco la fine di questa roba DURISSIMA in cui sommo i numeri all'interno dell'array già elevati al quadrato: {sommaQuadrataDurissima} ");
        }
    }
}

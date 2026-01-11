using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6GestionNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string valSaisie;
            int option;
            bool retConv;
            float max=0;
            float moyenne =0;
            int nbNotes;
            float min;
            int cpt = 0;
            string res="";
            int[] lesNotes;
            int ind=0;
            // TODO Ajout des variables nécessaires au programme

            // TODO Saisie du nombre de notes à saisir

            Console.WriteLine(" veuillez saisir le nombre de notes que vous voulez rentrer : ");
            valSaisie = Console.ReadLine().Trim();
            int.TryParse(valSaisie, out nbNotes);

            // TODO Saisie des notes dans un tableau
            lesNotes= new int[nbNotes];

            //on boucle sur la longeur du tableau et on ajoute la note a l indice ou l on est 
            for (ind = 0 ; ind < lesNotes.Length ; ind++) 
            {
                Console.WriteLine("saisissez la note  " + (ind+1)+ " ");
                valSaisie=Console.ReadLine();
                int.TryParse (valSaisie, out lesNotes[ind]);
            }
            #region testes if
            do
            {
                do
                {

                    #region affichage du menu
                    Console.WriteLine(" 1. Afficher toutes les notes");
                    Console.WriteLine(" 2. Afficher le nombre de notes supérieures à 10");
                    Console.WriteLine(" 3. Afficher toutes les notes inférieures à 10");
                    Console.WriteLine(" 4. Afficher la moyenne des notes");
                    Console.WriteLine(" 5. Afficher la meilleure note");
                    Console.WriteLine(" 6. Afficher la moins bonne note");
                    Console.WriteLine(" 7. Y-a-t'il une note égale à 20 ? (réponse oui ou non) ");
                    Console.WriteLine(" 8. Y-a-t'il une note inférieure à 10 ? (réponse oui ou non) ");
                    Console.WriteLine(" 9. Sortie du menu");
                    Console.Write(" Veuillez choisir votre option : ");

                    #endregion
                    #region saisie de l'option souhaité
                    //on demande de saisir un entier ( l option )
                    valSaisie = Console.ReadLine();
                    retConv = int.TryParse(valSaisie, out option); //on utilise un booleen pour faire un controle de saisie

                    //on fait le controle avec les messages d erreurs
                    if (retConv == false)
                    {
                        Console.WriteLine("Saisie erronée : l'option doit être un entier");
                    }
                    else
                    {
                        if (option < 1 || option > 9)
                        {
                            Console.WriteLine("Saisie erronée : l'option doit être comprise entre 1 et 9");
                        }
                    }

                } while (retConv == false || option < 1 || option > 9);


                #endregion
                //on mets des conditions pour mieux traiter le probleme grace au chiffre saisie
                switch (option)
                {
                    case 1:
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            Console.Write("[" + lesNotes[ind] + "]");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        //affichage du nombre de notes superieures a 10
                        for (ind = 0;ind < lesNotes.Length; ind++)
                        {
                            if (lesNotes[ind] >10)
                            {
                                cpt += 1;
                            }
                        }
                        Console.WriteLine("il y a "+cpt+ " notes superieurs a 10 .");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        // affichage toutes les notes inferieures a 10
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            if (lesNotes[ind] < 10)
                            {
                                Console.Write("[" + lesNotes[ind] + "]");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        // affichage de la moyenne
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            moyenne += lesNotes[ind];
                        }
                        Console.WriteLine(moyenne/lesNotes.Length);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        // affichage de la meilleure note
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                           if ( lesNotes[ind] > max)
                            {
                                max=lesNotes[ind] ;
                            }
                        }
                        Console.WriteLine(max);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 6:
                        // afficher la pire note 
                        min=lesNotes[0]; //on defini min ici car si on le defini a 0 dans la variable ca mettra toujours 0
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            if (lesNotes[ind] < min)
                            {
                                min = lesNotes[ind];
                            }
                        }
                        Console.WriteLine(min);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 7:
                        // y a t il une note egale a 20 oui ou non
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            if (lesNotes[ind] == 20 )
                            {
                                res = "oui";
                                cpt += 1;
                            }
                            else
                            {
                                res = "non";
                            }
                        }
                        if (res == "oui")
                        {
                            Console.WriteLine(res + " il y en a : " + cpt);
                        }
                        else
                        {
                            Console.WriteLine(res + " il n'y en a pas ");

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 8:
                        //Affichage s'il y a une note inférieure à 10 (on affiche oui ou non) 
                        for (ind = 0; ind < lesNotes.Length; ind++)
                        {
                            if (lesNotes[ind] < 10)
                            {
                                res = "oui";
                                cpt += 1;   
                            }
                            else
                            {
                                res = "non";
                            }
                        }
                        if (res == "oui")
                        {
                            Console.WriteLine(res + " il y en a : " + cpt);
                        }
                        else
                        {
                            Console.WriteLine(res + " il n'y en a pas ");

                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }

            } while (option != 9); 
            #endregion
        }
    }
}

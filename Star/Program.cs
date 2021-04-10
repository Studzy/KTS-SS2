using System;

namespace Star
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                string argument = args[0];
                int chiffre;
                if (int.TryParse(argument, out chiffre))
                {
                    if (chiffre <= 0)
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        PointeHaute(chiffre);
                        Corp(chiffre);
                        PointeBasse(chiffre);
                    }
                }
                else
                {
                    Console.WriteLine("L'argument est incorrect");
                }

            }
            
            
        }

        static void PointeHaute(int arg)
        {
            string ligne = "";
            string updateLigne = "";
            char[] ligneAsChars;
            int taille = (arg * 2) - 1;
            int longeurTotale = ((arg - 1) * 4) + 6 + ((arg - 2) * 2) + 1;
            

            if (arg == 1)
            {
                longeurTotale = 7;
            }
            float milieu = (longeurTotale / 2);
            int milieuTotale =  (int)Math.Ceiling(milieu);

            for (int i = 0; i < arg; i++)
            {
                ligne = "";
                for (int j = 0; j < longeurTotale; j++)
                {
                    ligne = ligne + " ";
                }
                ligneAsChars = ligne.ToCharArray();
                if (i == 0)
                {
                    ligneAsChars[milieuTotale] = '*';
                }
                else
                {
                    ligneAsChars[milieuTotale - i] = '*';
                    ligneAsChars[milieuTotale + i] = '*';
                }
                updateLigne = new string(ligneAsChars);
                Console.WriteLine(updateLigne);
            }
        }
        static void PointeBasse(int arg)
        {
            string ligne = "";
            string updateLigne = "";
            char[] ligneAsChars;
            int taille = (arg * 2) - 1;
            int longeurTotale = ((arg - 1) * 4) + 6 + ((arg - 2) * 2) + 1;


            if (arg == 1)
            {
                longeurTotale = 7;
            }
            float milieu = (longeurTotale / 2);
            int milieuTotale = (int)Math.Ceiling(milieu);

            for (int i = arg; i > 0; i--)
            {
                ligne = "";
                for (int j = longeurTotale; j > 0; j--)
                {
                    ligne = ligne + " ";
                }
                ligneAsChars = ligne.ToCharArray();
                if (i == 1)
                {
                    ligneAsChars[milieuTotale] = '*';
                }
                else
                {
                    ligneAsChars[milieuTotale - i + 1] = '*';
                    ligneAsChars[milieuTotale + i - 1] = '*';
                }
                updateLigne = new string(ligneAsChars);
                Console.WriteLine(updateLigne);
            }
        }
        static void Corp(int arg)
        {
            int tailleCorp = ((arg - 1) * 2) + 3;
            string ligne = "";
            string updateLigne = "";
            char[] ligneAsChars;
            int longeurTotale = ((arg - 1) * 4) + 6 + ((arg - 2) * 2) + 1;
            int espace = ((arg - 2) * 2) + 1;

            if (arg == 1)
            {
                longeurTotale = 7;
                espace = 1;
            }

            for (int i = 0; i < tailleCorp ; i++)
            {
                ligne = "";
                for (int j = 0; j < longeurTotale; j++)
                {
                    ligne = ligne + " ";
                }
                if (i == 0 || i == tailleCorp - 1)
                {
                    ligne = ligne.Replace(" ", "*");
                    ligneAsChars = ligne.ToCharArray();
                    for (int k = 0; k < espace; k++)
                    {
                        ligneAsChars[tailleCorp + k] = ' ';
                    }
                    updateLigne = new string(ligneAsChars);
                }
                else if(i < (tailleCorp/2) + 1)
                {
                    ligneAsChars = ligne.ToCharArray();
                    ligneAsChars[i] = '*';
                    ligneAsChars[longeurTotale - i - 1] = '*';
                    updateLigne = new string(ligneAsChars);
                    
                }
                else
                {
                    ligneAsChars = ligne.ToCharArray();
                    ligneAsChars[tailleCorp - (i+1)] = '*';
                    ligneAsChars[tailleCorp + espace + i] = '*';
                    updateLigne = new string(ligneAsChars);
                }

                Console.WriteLine(updateLigne);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamProject
{
    class MainClass
    {
        public static Int32[,] Matrix = new Int32[5, 5];
        public static int[,] Matrix2 = new int[5, 5];

        public static void init()
        {
            Random rand = new Random();
            for(int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                {
                    Matrix[i, k] = rand.Next(100);
                }
            display(Matrix);
            Console.WriteLine("");
        }

        public static void display(int[,] matr)
        {
            for(int i = 0; i < 5; i++)
                for (int k = 0; k < 5; k++)
                {
                    if (k < 4)
                    {
                        Console.Write("{0}\t", matr[i,k]);
                    }
                    if (k == 4)
                    {
                        Console.WriteLine("{0}", matr[i, k]);
                    }
                }
        }

        public static void select()
        {
            Console.Write("Чей проект выхотите запустить? (Парманов = p, Жилкин = z, Едапин = e)  ");
            string cons = Console.ReadLine();
            if (cons == "p")
            {
                Parmanov.Parm();
            }
        }

        public static void ext_sel()
        {
            Console.Write("Вы хотите продолжить? (y/n) ");
            string cont = Console.ReadLine();
            if (cont == "y")
            {
                select();
                ext_sel();
            }
            if (cont == "n")
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
            }
        }
    }
}

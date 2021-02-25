using System;

namespace Curs_1
{
    class World
    {
        /// <summary>
        /// Numarul de identificare al -World-
        /// Nefiind static el este de tip instanta si va exista cate unul pt fiecare obiect creat
        /// Spunem ca este o variabila la nivel de obiect
        /// </summary>
        private int id;

        /// <summary>
        /// Tine evidenta numarului obiecte de tip World create.
        /// Fiind static va exista o singura valoare pentru toate obiectele create.
        /// Spunem ca este o variabila la nivel de clasa
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Metoda constructor.
        /// Are acelasi nume ca si clasa
        /// Nu are tip return, nici macar void
        /// Initializeaza obiectul.
        /// Se apeleaza automat la crearea/instantierea unui obiect
        /// </summary>
        /// <param name="id"></param>
        public World(int id)
        {
            this.id = id;
            counter++;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from World {id}");
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }
    }
}
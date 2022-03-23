/*
        
       |   |   |
       |   |   |
    ___|___|___|___
       A   B   C

*/

using System;

namespace HanoiTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            HanoiTowers(n, 'A', 'B', 'C');
            Console.ReadKey();
        }
        static void HanoiTowers(int n, char fromTower, char toTower, char spareTower)
        {
            if (n ==1)//przypadek bazowy
            {
                Console.WriteLine($"dysk {n} z {fromTower} na {toTower}");
                return;
            }

            HanoiTowers(n - 1, fromTower, spareTower, toTower);//rekursja
            Console.WriteLine($"dysk {n} z {fromTower} na {toTower}");
            HanoiTowers(n - 1, spareTower, toTower, fromTower);//rekursja

        }

    }
}

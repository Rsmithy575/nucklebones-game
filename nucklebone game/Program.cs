using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace nucklebone_game
{
    internal class Program
    {
        static string dice1 = " ", dice2 = " ", dice3 = " ", dice4 = " ", dice5 = " ", dice6 = " ", dice7 = " ", dice8 = " ", dice9 = " ", dice10 = " ", dice11 = " ", dice12 = " ", dice13 = " ", dice14 = " ", dice15 = " ", dice16 = " ", dice17 = " ", dice18 = " ";
        static int Playerturn = 1;
        static bool kbgameActive = false;

        static void Main(string[] args)
        {
            nuckleBones();
        }
        static void nuckleBones()
        {
            if (kbgameActive==false)
            {
                Console.WriteLine("Welcome to nucklebones!");
                Console.WriteLine("to play you and an oponent take it in turns to roll a dice and choose a lane on your board to put the number. At the end of the game all numbers on your board are added up into your score, if you get multiple of the same number in a lane you gain a multiplier for that set. If you put a number in your lane that the oponent has in the same lane of theirs, their matching number is removed.");
                Console.WriteLine("Goodluck! press [enter] to begin");
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {
                    kbgameActive = true;
                }
            }
            while (kbgameActive == true)
            {

                Random kBDiceNumber = new Random();
                int nBnumber = kBDiceNumber.Next(1, 6);
                Console.Clear();
                nucklebonesVisual();
                if (Playerturn == 1)
                {
                    Console.WriteLine("Player1's turn, click [enter] to roll");
                    nbp1turn(nBnumber);
                }
                else if (Playerturn == 2)
                {
                    Console.WriteLine("Player2's turn, click [enter] to roll");
                    nbp2turn(nBnumber);
                }
                if (dice1 != " " && dice2 != " " && dice3 != " " && dice4 != " " && dice5 != " " && dice6 != " " && dice7 != " " && dice8 != " " && dice9 != " ")
                {
                    nbendgame();
                }
                if (dice10 != " " && dice11 != " " && dice12 != " " && dice13 != " " && dice14 != " " && dice15 != " " && dice16 != " " && dice17 != " " && dice18 != " ")
                {
                    nbendgame();
                }
            }
        }
        private static void nbendgame()
        {
            int D1s = 0, D2s = 0, D3s = 0, D4s = 0, D5s = 0, D6s = 0, D7s = 0, D8s = 0, D9s = 0, D10s = 0, D11s = 0, D12s = 0, D13s = 0, D14s = 0, D15s = 0, D16s = 0, D17s = 0, D18s = 0;
            if (dice1 != " ")
                D1s = Convert.ToInt32(dice1);
            if (dice2 != " ")
                D2s = Convert.ToInt32(dice2);
            if (dice3 != " ")
                D3s = Convert.ToInt32(dice3);
            if (dice4 != " ")
                D4s = Convert.ToInt32(dice4);
            if (dice5 != " ")
                D5s = Convert.ToInt32(dice5);
            if (dice6 != " ")
                D6s = Convert.ToInt32(dice6);
            if (dice7 != " ")
                D7s = Convert.ToInt32(dice7);
            if (dice8 != " ")
                D8s = Convert.ToInt32(dice8);
            if (dice9 != " ")
                D9s = Convert.ToInt32(dice9);
            if (dice10 != " ")
                D10s = Convert.ToInt32(dice10);
            if (dice11 != " ")
                D11s = Convert.ToInt32(dice11);
            if (dice12 != " ")
                D12s = Convert.ToInt32(dice12);
            if (dice13 != " ")
                D13s = Convert.ToInt32(dice13);
            if (dice14 != " ")
                D14s = Convert.ToInt32(dice14);
            if (dice15 != " ")
                D15s = Convert.ToInt32(dice15);
            if (dice16 != " ")
                D16s = Convert.ToInt32(dice16);
            if (dice17 != " ")
                D17s = Convert.ToInt32(dice17);
            if (dice18 != " ")
                D18s = Convert.ToInt32(dice18);


            #region(calculating multiples)
            if (D1s==D4s)
                D1s = D1s + (D4s*2);
            if (D1s == D7s)
                D1s = D1s + (D7s*2);
            if (D4s == D7s)
                D4s = D4s + (D7s * 2);
            if (D1s == D4s && D1s==D7s)
                D1s = D1s + D4s + (D7s * 4);

            if (D2s == D5s)
                D2s = D2s + (D5s * 2);
            if (D2s == D8s)
                D2s = D2s + (D8s * 2);
            if (D8s == D5s)
                D8s = D8s + (D5s * 2);
            if (D2s == D5s && D2s == D8s)
                D2s = D2s + D5s + (D8s * 4);

            if (D3s == D6s)
                D3s = D3s + (D6s* 2);
            if (D3s == D9s)
                D3s = D3s + (D9s * 2);
            if (D9s == D6s)
                D9s = D9s + (D6s * 2);
            if (D3s == D6s && D3s == D9s)
                D3s = D3s + D6s + (D9s * 4);


            if (D10s == D13s)
                D10s = D10s + (D13s * 2);
            if (D10s == D16s)
                D10s = D10s + (D16s * 2);
            if (D13s == D16s)
                D13s = D13s + (D16s * 2);
            if (D10s == D13s && D10s == D16s)
                D10s = D10s + D13s + (D16s * 4);

            if (D11s == D14s)
                D11s = D11s + (D14s * 2);
            if (D11s == D17s)
                D11s = D11s + (D17s * 2);
            if (D17s == D14s)
                D17s = D17s + (D14s * 2);
            if (D11s == D14s && D11s == D17s)
                D11s = D11s + D14s + (D17s * 4);

            if (D12s == D15s)
                D12s = D12s + (D15s * 2);
            if (D12s == D18s)
                D12s = D12s + (D18s * 2);
            if (D18s == D15s)
                D18s = D18s + (D15s * 2);
            if (D12s == D15s && D12s == D18s)
                D12s = D12s + D15s + (D18s * 4);
            #endregion


            int nbP1score = D1s + D2s + D3s + D4s + D5s + D6s + D7s + D8s + D9s;
            int nbP2score = D10s + D11s + D12s + D13s + D14s + D15s + D16s + D17s + D18s;
            Console.WriteLine("Player1's score was " + nbP1score + "!");
            Console.WriteLine("Player2's score was " + nbP2score + "!");
            if (nbP1score > nbP2score)
                Console.WriteLine("Player1 wins!");
            else if (nbP2score > nbP1score)
                Console.WriteLine("Player2 wins!");
            else
                Console.WriteLine("Draw!");
            kbgameActive = false;
            Thread.Sleep(50000);
            //put return script here

        }
        
        private static void nbp1turn(int nBnumber)
        {
            var key = Console.ReadKey(intercept: true).Key;
            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("You rolled a " + nBnumber + "!");
                Console.WriteLine("What space would you like to put it? (1-3)");
            }
            else
            {
                Console.WriteLine("click [enter] to roll");
                nbp1turn(nBnumber);
            }

                string nBstring = nBnumber.ToString();
            var key2 = Console.ReadKey(intercept: true).Key;
            if (key2 == ConsoleKey.D1)
            {
                if (dice7 == " ")
                {
                    Playerturn = 2;
                    dice7 = nBstring;
                }
                else if (dice4 == " ")
                {
                    Playerturn = 2;
                    dice4 = nBstring;
                }
                else if (dice1 == " ")
                {
                    Playerturn = 2;
                    dice1 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp1turn(nBnumber);
                }
                if (dice10 == nBstring)
                    dice10 = " ";
                if (dice13 == nBstring)
                    dice13 = " ";
                if (dice16 == nBstring)
                    dice16 = " ";
            }
            else if (key2 == ConsoleKey.D2)
            {
                if (dice8 == " ")
                {
                    Playerturn = 2;
                    dice8 = nBstring;
                }
                else if (dice5 == " ")
                {
                    Playerturn = 2;
                    dice5 = nBstring;
                }
                else if (dice2 == " ")
                {
                    Playerturn = 2;
                    dice2 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp1turn(nBnumber);
                }
                if (dice11 == nBstring)
                    dice11 = " ";
                if (dice14 == nBstring)
                    dice14 = " ";
                if (dice17 == nBstring)
                    dice17 = " ";
            }
            else if (key2 == ConsoleKey.D3)
            {
                if (dice9 == " ")
                {
                    Playerturn = 2;
                    dice9 = nBstring;
                }
                else if (dice6 == " ")
                {
                    Playerturn = 2;
                    dice6 = nBstring;
                }
                else if (dice3 == " ")
                {
                    Playerturn = 2;
                    dice3 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp1turn(nBnumber);
                }
                if (dice12 == nBstring)
                    dice12 = " ";
                if (dice15 == nBstring)
                    dice15 = " ";
                if (dice18 == nBstring)
                    dice18 = " ";
            }
            else
            {
                Console.WriteLine("pick one of the lanes");
                nbp2turn(nBnumber);
            }
        }
        private static void nbp2turn(int nBnumber)
        {
            var key = Console.ReadKey(intercept: true).Key;
            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("You rolled a " + nBnumber + "!");
                Console.WriteLine("What space would you like to put it? (1-3)");
            }
            else
            {
                Console.WriteLine("click [enter] to roll");
                nbp2turn(nBnumber);
            }
            string nBstring = nBnumber.ToString();
            var key2 = Console.ReadKey(intercept: true).Key;
            if (key2 == ConsoleKey.D1)
            {
                if (dice10 == " ")
                {
                    Playerturn = 1;
                    dice10 = nBstring;
                }
                else if (dice13 == " ")
                {
                    Playerturn = 1;
                    dice13 = nBstring;
                }
                else if (dice16 == " ")
                {
                    Playerturn = 1;
                    dice16 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp2turn(nBnumber);
                }
                if (dice1 == nBstring)
                    dice1 = " ";
                if (dice4 == nBstring)
                    dice4 = " ";
                if (dice7 == nBstring)
                    dice7 = " ";
            }
            else if (key2 == ConsoleKey.D2)
            {
                if (dice11 == " ")
                {
                    Playerturn = 1;
                    dice11 = nBstring;
                }
                else if (dice14 == " ")
                {
                    Playerturn = 1;
                    dice14 = nBstring;
                }
                else if (dice17 == " ")
                {
                    Playerturn = 1;
                    dice17 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp2turn(nBnumber);
                }
                if (dice2 == nBstring)
                    dice2 = " ";
                if (dice5 == nBstring)
                    dice5 = " ";
                if (dice8 == nBstring)
                    dice8 = " ";
            }
            else if (key2 == ConsoleKey.D3)
            {
                if (dice12 == " ")
                {
                    Playerturn = 1;
                    dice12 = nBstring;
                }
                else if (dice15 == " ")
                {
                    Playerturn = 1;
                    dice15 = nBstring;
                }
                else if (dice18 == " ")
                {
                    Playerturn = 1;
                    dice18 = nBstring;
                }
                else
                {
                    Console.WriteLine("Lane full, try again.");
                    nbp2turn(nBnumber);
                }
                if (dice3 == nBstring)
                    dice3 = " ";
                if (dice6 == nBstring)
                    dice6 = " ";
                if (dice9 == nBstring)
                    dice9 = " ";
            }
            else
            {
                Console.WriteLine("pick one of the lanes");
                nbp2turn(nBnumber);
            }    
        }

        private static void nucklebonesVisual()
        {
            Console.WriteLine("_______\n|" + dice1 + "|" + dice2 + "|" + dice3 + "|");
            Console.WriteLine("|" + dice4 + "|" + dice5 + "|" + dice6 + "|");
            Console.WriteLine("|" + dice7 + "|" + dice8 + "|" + dice9 + "|\n-------");
            Console.WriteLine("_______\n|" + dice10 + "|" + dice11 + "|" + dice12 + "|");
            Console.WriteLine("|" + dice13 + "|" + dice14 + "|" + dice15 + "|");
            Console.WriteLine("|" + dice16 + "|" + dice17 + "|" + dice18 + "|\n-------");
        }
    }
}
//giububub
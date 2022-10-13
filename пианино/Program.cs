using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int[] freqs = { };

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F1)
                {
                    freqs = Octave(1);
                    Console.WriteLine("Октава изменена на 1");
                    
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    freqs = Octave(2);
                    Console.WriteLine("Октава изменена на 2");
                    
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    freqs = Octave(3);
                    Console.WriteLine("Октава изменена на 3");

                }
                else if (key.Key == ConsoleKey.F4)
                {
                    freqs = Octave(4);
                    Console.WriteLine("Октава изменена на 4");

                }


                if (key.Key == ConsoleKey.Q)
                {
                    Beep(freqs[0]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Beep(freqs[1]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Beep(freqs[2]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.R)
                {
                    Beep(freqs[3]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Beep(freqs[4]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Beep(freqs[5]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Beep(freqs[6]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.I)
                {
                    Beep(freqs[7]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.O)
                {
                    Beep(freqs[8]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.P)
                {
                    Beep(freqs[9]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.A)
                {
                    Beep(freqs[10]);
                    Console.Clear();
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Beep(freqs[11]);
                    Console.Clear();
                }
            }
        }



        static void Beep(int freq)
        {
            Console.Beep(freq, 500);
        }



        static int[] Octave(int octave)
        {
            
            int[] odin = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] dva = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] tri = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] chetyre = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

            if (octave == 1)
            {
                return odin;
            }

            else if (octave == 2)
            {
                return dva;
            }

            else if (octave == 3)
            {
                return tri;
            }

            else if (octave == 4)
            {
                return chetyre;
            }

            else
            {
                return null;
            }
        }
    }
}


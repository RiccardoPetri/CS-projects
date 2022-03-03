using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace FirstProgramsSolution
{
    class Program
    {

        

        //static void Main(string[] args)
        static void Main()
        {
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter an operator: ");
            //string operation = Console.ReadLine();


            //Console.WriteLine("The result is " + SwitchMethod(operation, num1, num2));


            int[,] matrix = {
                {1,2,3},
                {4,5,6}

            };
            Console.WriteLine(matrix[0, 2]);





            try
            {
                int z = 0;
                int prova = 5 / z;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("a prescindere");
            }

            //IEnumerable<T> //most generic, only if i want to output data
            //ICollection<T> //it extends IEnumerable (i can manipulate more)
            IList<int> list = new List<int> { 1, 2, 3, 4, 5 }; //it extends ICollection (allow to index elements)
            foreach(var t in list)
            {
                Console.WriteLine(t);
            }

            //List<int> evenNumbers = new List<int>();
            var evenNumbers = new List<int>();

            foreach(var t in list)      //as suggestion, visual studio convert it as a LINQ
            {
                if(t % 2 == 0)
                    evenNumbers.Add(t);
            }

            //______________________________________________________________________________________________________________________________________
            //ENUMS NON VA

            //enum move { None, Up, Down, Right, Left}

            //foreach(String name in Enum.GetNames(typeof(Move)))
            //{
            //    Console.Write("{0}", name);
            //}

            //foreach(int value in Enum.GetValues(typeof(Move)))
            //{
            //    Console.Write("{0}", value);
            //}


            //______________________________________________________________________________________________________________________________________

            //STRUCTS (non può ereditare, ha sempre il costruttore di default (classi solo se non hanno un altro costruttore se no lo perdono)
                     //usare strutture se sono sicuro di fare qualcosa di immutato.


            int number1 = int.MaxValue;  //int is a struct and MaxValue is a property!
            string eleven = 11.ToString(); //string is class instead
            double d;
            double.TryParse(eleven, out d);
            Console.WriteLine(d);

            Point p1 = new Point(2, 3);
            Console.WriteLine(string.Format("p1: {0}", p1));
            Point p2 = new Point(); //default
            Console.WriteLine(string.Format("p2: {0}", p2));

            //______________________________________________________________________________________________________________________________________

            //EVENTS
            var rooster = new Rooster();
            var person = new Person();
            var person2 = new Person();
            rooster.DoCaw();    //the event caw has no subscribers yet
            rooster.Caw += person.SayImUp; //adding a subscriber ( a method that will be invoked)
            rooster.Caw += person2.SayImUp2;
            rooster.DoCaw();    //now it will invoke all of them

             //______________________________________________________________________________________________________________________________________


            Console.WriteLine(Radius2);

            Console.ReadKey();
        }


        //static int SwitchMethod(string operation, int num1, int num2)
        //{
        //    switch(operation)
        //    {
        //        case "+":
        //            return num1 + num2;
        //            break;
        //        case "-":
        //            return num1 - num2;
        //            break;
        //        case "/":
        //            return num1 / num2;
        //            break;
        //        case "*":
        //            return num1 * num2;
        //            break;
        //        default:
        //            return 0;
        //    }
        //}

        

        //______________________________________________________________________________________________________________________________________

        //THREADS

        //var thread = new Thread(run);
        //thread.Start();

        //for (int i = 0; i < 10; i++)
        //{
        //    Thread.Sleep(100);                          //in teoria uso due thread diversi
        //    Console.WriteLine("Hello from thread 1");
        //}
        //thread.Join(); //per essere sicuri che il thread termini(?)


        //______________________________________________________________________________________________________________________________________

        //GETTER AND SETTER ARE USED WITH PROPERTIES!!!!       per avere l'incapsulamento e un accesso al posto dei MODIFICATORI DI ACCESSO public private protected

        //private static double ciao;  //insert in the class program!!!
        //public double Radius2 {
        //    get {
        //        return ciao;
        //    }
        //    set {
        //        ciao = value;
        //    }
        //}

        //BECOME

        //public double Radius1 { get; private set; }
        public static double Radius2 { get; private set; } = 3.5;       //static only because i call it from main that is static!!!
                                                                        //public ClassType Radius2 { get; private set; } = 3.5;

        //______________________________________________________________________________________________________________________________________


        struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point (int x, int y) //constructor!!!
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({X},{Y})";        //$ to interpolate tostring!!
            }
        }

        //______________________________________________________________________________________________________________________________________

        class Rooster   //INNER CLASS
        {
            public event Action Caw;

            public void DoCaw()
            {
                if(Caw != null) //if i have at least one subscriber
                {
                    Console.WriteLine("not null");
                    Caw();
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }

        class Person
        {
            public void SayImUp()
            {
                Console.WriteLine("buongiornooo");
            }

            public void SayImUp2()
            {
                Console.WriteLine("buongiornooooooooooooo");
            }
        }




        private static void run()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Hello from thread 2");
            }
        }
    }
}




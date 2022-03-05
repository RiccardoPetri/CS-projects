using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using FirstProgram;

namespace FirstProgramsSolution
{
    class Program
    {


        


        //static void Main(string[] args)
        static void Main()
        {


            //Class1 class1 = Class1();

            //class1.


            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter an operator: ");
            //string operation = Console.ReadLine();


            //Console.WriteLine("The result is " + SwitchMethod(operation, num1, num2));

            //double[] arrayy = new double[0];
            
            //Array.Resize(ref arrayy, 10);
            //arrayy[0] = Convert.ToDouble(Console.ReadLine());
            //arrayy[0] = double.Parse(Console.ReadLine());
            //double.TryParse(Console.ReadLine(), out arrayy[0]);
            //double x = 9e6; //9000000
            //int y = 9_000_000;
            //Console.WriteLine(y);
            //double p = 3.1415;
            //p = Math.Round(p, 2);

            //Console.WriteLine(arrayy.Length);

            //Metodo(ref x);
            //Metodo(out int x);

            Class1 c = new Class1();
            Console.WriteLine(c.MyProperty);


            Console.WriteLine("Warming the egg pan...");
            Task.Delay(300).Wait();
            Console.WriteLine($"cracking  eggs");

            int[,] matrix = {
                {1,2,3},
                {4,5,6 }

            };
            Console.WriteLine(matrix[0, 2]);

            

            try
            {
                int z = 0;              //IT OUTPUT THE EXCEPTION IN THE OUTPUT CONSOLE!!!! BUT IT DOESNT STOP THE PROGRAM
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
            //______________________________________________________________________________________________________________________________________

            //INTERFACE IS A CONTRACT BETWEEN CLASSES
            //They contain definitions for a group of related functionalities
            //(they provide contracts that objects can use to work together (despite if i change one of two, like the  printer or even the pc)

            //interface IEquatable<T> //use I and use a noun that describe the behaviour
            //{ 
            //bool Equals(T obj);        //members are automatically public
            //}
            
            //class NewClass : BaseClasse, IEquatable, IEquatable2

            //i can use variable as interfaces
            //IEnumerable<T> //most generic, only if i want to output data
            //ICollection<T> //it extends IEnumerable (i can manipulate more)
            //IList<T> extends ICollection
            //IDictionary extends IList

            //a list that implement IList
            IList<int> list = new List<int> { 1, 2, 3, 4, 5 };

            foreach(var t in list)
            {

                Console.WriteLine(t);
            }

            //List<int> evenNumbers = new List<int>();
            var evenNumbers = new List<int>();

            foreach(var t in list)      //as suggestion, visual studio convert it as a LINQ
            {
                if(t % 2 == 0)
                {
                    evenNumbers.Add(t);
                }

            }
            //______________________________________________________________________________________________________________________________________
            // COLLECTIONS         System.Collections

            //(Collections cant be instantiate, but Class like List, yes!!!!!!!!  new List<int>()

            //ArrayList
            //Queue
            //Stack
            //Hashtable
            //SortedList

            //______________________________________________________________________________________________________________________________________
            //GENERIC COLLECTIONS   System.Collections.Generics


            //Use generic collections, because they perform better

            //List<T>
            //LinkedList<T>
            //Queue<T>
            //Stack<T> (it use Push and Pop)

            //all three implements IDictionary but using different data structures
            //Dictionary<Tkey,TValue>           hash table                              (ConcurrentDictionary is thread-safe, the method are locked!)
            //SortedList<TKey,TValue>           array of key-value pairs
            //SortedDictionary<Tkey,Tvalue>     binary search tree 


            //IList -> properties: Count, IsReadOnly, Item (x = myList[2] uses Item property to access myList and assign the third element to x)
            //      -> methods:    Add, Clear, Contains, CopyTo, Remove, IndexOf, insert, RemoveAt

            //IDictionary -> properties: Count, IsReadOnly, Item (n = phoneBook["Ben"]; providing the key inside the brackets and assign the value),   Keys, Values
            //            -> methods:    Add(T), Clear, Contains, CopyTo, Remove(T), Add(TKey,TValue), ContainsKey, Remove(TKey),TryGetValue


            //______________________________________________________________________________________________________________________________________



            //uso  int[] myNumbers = {5, 1, 8, 9}; 
            //se so a priori la grandezza che mi serve e soprattutto se so già tutti gli elementi ( un array non può essere resizable dinamicamente!!!


            //// Create an array of four elements, and add values later
            //string[] cars = new string[4];

            //// Create an array of four elements and add values right away 
            //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements without specifying the size 
            //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            //// Create an array of four elements, omitting the new keyword, and without specifying the size
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };


            //----
            // Declare an array
            //string[] cars;        //lo uso se comunque so che prima o poi in cars metto qualcosa di preciso!!! e soprattutto dello stesso tipo!!!

            //// Add values, using new
            //cars = new string[] { "Volvo", "BMW", "Ford" };

            //// Add values without using new (this will cause an error)
            //cars = { "Volvo", "BMW", "Ford"};




            //___________________________________________________________________________




            //then:


            //Self - resizing array based container

            //C++std::vector < T >
            //C#: List<T>





            //Doubly - linked list

            //C++std::list < T >
            //C#: LinkedList<T>



            //Thinking of a linked list as a list can be a bit misleading. It's more like a chain. 

            //In most cases, List<T> is more useful. LinkedList<T> will have less cost when
            //adding/removing items in the middle of the list, whereas List<T> can only cheaply
            //add/remove at the end of the list.

            //only if you plan on inserting several items and you also somewhere have the reference of 
            //where you plan to insert the item then use a linked list.Just because you have to insert
            //a lot of items it does not make it faster because searching the location where you will like 
            //to insert it takes time.



            //______________________________________________________________________________________



            //DICTIONARY:

            //Unordered hash-table based collection associating keys with values

            //C++ std::unordered_map<TKey, TValue>
            //C# Dictionary<TKey, TValue>


            //Ordered tree-based collection associating keys with values

            //C++std::map < TKey, TValue >
            //C# SortedDictionary<TKey, TValue>



            //Both lists and dictionaries are used to store collections of data.A Dictionary< int, T > and
            //List<T> are similar, both are random access data structures of the .NET framework
            //The Dictionary is based on a hash table, that means it uses a hash lookup, which is a rather 
            //efficient algorithm to look up things, on the other hand, a list you have to go element by 
            //element until it finds the result from beginning to the result each time.



            //But actually the list will be faster than the dictionary on the first item search because nothing to search in the first step
            //The larger the list, the longer it takes!!!!


            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //List<int> newList = new List<int>();

            //newList.Add(data);

            //dictionary.Add("first", 1);
            //dictionary.Add("second", 2);

            //foreach(KeyValuePair<string, int> items in dictionary)
            //{
            //    MessageBox.Show(items.Key.ToString() + "  -  " + items.Value.ToString());
            //}


            //A List dynamically resize, so ou do not need to manage the size on your own.

            //List<int> newList = new List<int>();
            //newList.Add(10);

            //foreach(string day in week)
            //{
            //    MessageBox.Show(day);
            //}

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


            //int number1 = int.MaxValue;  //int is a struct and MaxValue is a property!
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
            rooster.Caw += Person.SayImUp; //adding a subscriber ( a method that will be invoked)
            rooster.Caw += Person.SayImUp2;
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

            public Point(int x, int y) //constructor!!!
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
            public static void SayImUp()
            {
                Console.WriteLine("buongiornooo");
            }

            public static void SayImUp2()
            {
                Console.WriteLine("buongiornooooooooooooo");
            }
        }




        private static void Run()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("Hello from thread 2");
            }
        }
    }
}




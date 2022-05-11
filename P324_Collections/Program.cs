using System;
using System.Collections;
using System.Collections.Generic;

namespace P324_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Jamal");
            //arrayList.Add('A');
            //arrayList.Add(10);
            //arrayList.Add(10.5d);


            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(1);
            //arrayList1.Add(10.1);
            //arrayList1.Add("Test");

            //arrayList.AddRange(arrayList1);

            //arrayList.Add(arrayList1);
            ////arrayList.Remove(arrayList1);

            //arrayList.Clear();

            //arrayList.RemoveAt(2);
            //foreach (object item in arrayList)
            //{
            //    if(item is ArrayList)
            //    {
            //        ArrayList arrayList2 = (ArrayList)item;
            //        foreach (var listitem in arrayList2)
            //        {
            //            Console.WriteLine(listitem);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //SortedList sortedList = new SortedList();

            //sortedList.Add(1.1,"USA");
            //sortedList.Add(1.2,"France");
            //sortedList.Add(1.5,"TR");
            //sortedList.Add(1.4,"Yevlax");

            ////sortedList.RemoveAt()

            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //sortedList.Add(1, "USA");
            //sortedList.Add(2, "France");
            //sortedList.Add(3, "TR");
            //sortedList.Add(4, "Yevlax");

            //Console.WriteLine(sortedList[1]);

            //int[] arr = { 'a', 'b', 'c' };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            //keyValuePairs.Add("USA","Kentucky, Texas, Los Angeles");
            //keyValuePairs.Add("Germany","Berlin, Koln, Frankfurt");
            //keyValuePairs.Add("Azerbaijan","Yevlax, Gence, Ismayilli");
            //bool result  = keyValuePairs.TryAdd("Azerbaijan","Yevlax, Gence, Ismayilli");


            //if (result)
            //{
            //    Console.WriteLine("Added");
            //}
            //else
            //{
            //    Console.WriteLine("Can not add");
            //}
            //foreach (var item in keyValuePairs)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(2);
            //list.Add(4);

            //Console.WriteLine(list[0]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////Console.WriteLine(list.RemoveAll(x => x > 1));
            //list.RemoveRange(2,1);
            //Console.WriteLine("After remove");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue<string> queue = new Queue<string>();

            //queue.Enqueue("Khalil");
            //queue.Enqueue("Seymur");
            //queue.Enqueue("Ismayil");

            ////Console.WriteLine(queue.Dequeue());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());


            //Stack<string> stack = new Stack<string>();

            //stack.Push("Sabina");
            //stack.Push("Shakhrom");
            //stack.Push("Elshan");

            //Console.WriteLine(stack.Peek() + " Hazirlash");

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            int[,] arr = new int[3, 4] {



                    {1,2,3,4 },
                    {20,30,40,50 },
                    {400,500,600,700 },
            };

            int[,,] arr3d = new int[2, 3, 4];

            //for (int i = 0; i < arr3d.GetLength(0); i++)
            //{

            //    for (int j = 0; i < arr3d.GetLength(1); i++)
            //    {

            //        for (int k = 0; i < arr3d.GetLength(2); i++)
            //        {
            //            arr3d[i, j, k] = i + 5;
            //        }
            //    }
            //}

            //Console.WriteLine(arr.Rank);



            //Console.WriteLine(arr[1,1]);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arr.GetLength(2));

                //int[][,] jagged = new int[3][,] 
                //{ 
                //    new int[10,2],
                //    new int[5,3],
                //    new int[4,7]{
                //        { },
                //        { },
                //        { },
                //        { },
                //    },

                //};


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionСomparison cof = new CollectionСomparison();
            Console.WriteLine(">>>Add to collections<<<");
            Console.WriteLine($"Speed of List: {cof.SpeedOfListAdd()}");
            Console.WriteLine($"Speed of LinkedList: {cof.SpeedOfLinkedListAdd()}");
            Console.WriteLine($"Speed of Dictionary: {cof.SpeedOfDictionaryAdd()}");
            Console.WriteLine($"Speed of Queue: {cof.SpeedOfQueueAdd()}");
            Console.WriteLine($"Speed of Stack: {cof.SpeedOfStackAdd()}");
            Console.WriteLine($"Speed of SortedSet: {cof.SpeedOfSortedSetAdd()}");
            Console.WriteLine($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryAdd()}");
            Console.WriteLine(">>>Read from collections<<<");
            Console.WriteLine($"Speed of List: {cof.SpeedOfListRead()}");
            Console.WriteLine($"Speed of LinkedList: {cof.SpeedOfLinkedListRead()}");
            Console.WriteLine($"Speed of Dictionary: {cof.SpeedOfDictionaryRead()}");
            Console.WriteLine($"Speed of Queue: {cof.SpeedOfQueueRead()}");
            Console.WriteLine($"Speed of Stack: {cof.SpeedOfStackRead()}");
            Console.WriteLine($"Speed of SortedSet: {cof.SpeedOfSortedSetRead()}");
            Console.WriteLine($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryRead()}");
            Console.WriteLine(">>>Delete from collections<<<");
            Console.WriteLine($"Speed of List: {cof.SpeedOfListDel()}");
            Console.WriteLine($"Speed of LinkedList: {cof.SpeedOfLinkedListDel()}");
            Console.WriteLine($"Speed of Dictionary: {cof.SpeedOfDictionaryDel()}");
            Console.WriteLine($"Speed of Queue: {cof.SpeedOfQueueDel()}");
            Console.WriteLine($"Speed of Stack: {cof.SpeedOfStackDel()}");
            Console.WriteLine($"Speed of SortedSet: {cof.SpeedOfSortedSetDel()}");
            Console.WriteLine($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryDel()}");
            Console.ReadKey();
        }
    }
}

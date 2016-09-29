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
            List<string> output = new List<string>();
            CollectionСomparison cof = new CollectionСomparison();
            Console.WriteLine(">>>We are creating output file.<<<");
            Console.WriteLine(">>>Please wait...<<<");
            output.Add(">>>Add to collections<<<");
            output.Add($"Speed of List: {cof.SpeedOfListAdd()}");
            output.Add($"Speed of LinkedList: {cof.SpeedOfLinkedListAdd()}");
            output.Add($"Speed of Dictionary: {cof.SpeedOfDictionaryAdd()}");
            output.Add($"Speed of Queue: {cof.SpeedOfQueueAdd()}");
            output.Add($"Speed of Stack: {cof.SpeedOfStackAdd()}");
            output.Add($"Speed of SortedSet: {cof.SpeedOfSortedSetAdd()}");
            output.Add($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryAdd()}");
            output.Add(">>>Read from collections<<<");
            output.Add($"Speed of List: {cof.SpeedOfListRead()}");
            output.Add($"Speed of LinkedList: {cof.SpeedOfLinkedListRead()}");
            output.Add($"Speed of Dictionary: {cof.SpeedOfDictionaryRead()}");
            output.Add($"Speed of Queue: {cof.SpeedOfQueueRead()}");
            output.Add($"Speed of Stack: {cof.SpeedOfStackRead()}");
            output.Add($"Speed of SortedSet: {cof.SpeedOfSortedSetRead()}");
            output.Add($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryRead()}");
            output.Add(">>>Delete from collections<<<");
            output.Add($"Speed of List: {cof.SpeedOfListDel()}");
            output.Add($"Speed of LinkedList: {cof.SpeedOfLinkedListDel()}");
            output.Add($"Speed of Dictionary: {cof.SpeedOfDictionaryDel()}");
            output.Add($"Speed of Queue: {cof.SpeedOfQueueDel()}");
            output.Add($"Speed of Stack: {cof.SpeedOfStackDel()}");
            output.Add($"Speed of SortedSet: {cof.SpeedOfSortedSetDel()}");
            output.Add($"Speed of Sorted Dictionary: {cof.SpeedOfSortedDictionaryDel()}");
            cof.CreateOutputFile(output);
            Console.ReadKey();
        }
    }
}

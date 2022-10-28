// Sort Analyzer Start Code
#nullable disable
using System.Diagnostics;
using System;
using System.IO;
// Console.Clear();

class MainClass
{
    public static void Main(string[] args)
    {
        // LOAD DATA FILES INTO ARRAYS
        int[] randomData = loadDataArray("data-files/random-values.txt");
        int[] reversedData = loadDataArray("data-files/reversed-values.txt");
        int[] nearlySortedData = loadDataArray("data-files/nearly-sorted-values.txt");
        int[] fewUniqueData = loadDataArray("data-files/few-unique-values.txt");

        // VERIFY LOADED DATA BY PRINTING 50 ELEMENTS
        // printIntArray(randomData, 0, 50);
        // printIntArray(reversedData, 0, 50);
        // printIntArray(nearlySortedData, 0, 50);
        // printIntArray(fewUniqueData, 0, 50);

        // EXAMPLE OF TIMING DURATION OF A SORT ALGORITHM
        // var timer = new Stopwatch();
        // timer.Start();
        // bubbleSort(randomData);
        // timer.Stop();
        // Console.WriteLine($"Bubble Sort Random Data: {timer.Elapsed}");

        // Bubble Sort
        int bubbleSort<T>(IList<T> aList) where T : IComparable
        {
            for (int i = 0; i < aList.Count - 1; i++)
            {
                for (int j = 0; j < aList.Count - (i + 1); j++)
                {
                    int compare = aList[j].CompareTo(aList[j + 1]);
                    if (compare == 1)
                    {
                        T el = aList[j + 1];
                        aList[j + 1] = aList[j];
                        aList[j] = el;
                    }
                }
            }
            return -1;
        }

        // Selection Sort
        // int selectionSort<T>(IList<T> aList) where T : IComparable
        // {
        //     for (int i = 0; i < aList.Count - 1; i++)
        //     {
        //         int min_pos = i;
        //         for (int j = i + 1; j < aList.Count; j++)
        //         {
        //             int compare = aList[min_pos].CompareTo(aList[j]);
        //             if (compare == 1)
        //             {
        //                 min_pos = j;
        //             }
        //         }
        //         T el = aList[min_pos];
        //         aList[min_pos] = aList[i];
        //         aList[i] = el;
        //     }
        //     return -1;
        // }

        // // Insertion Sort
        // int insertionSort<T>(IList<T> aList) where T : IComparable
        // {
        //     for (int i = 1; i < aList.Count; i++)
        //     {
        //         T ins_value = aList[i];
        //         int ins_pos = i - 1;

        //         while (ins_pos >= 0 && aList[ins_pos].CompareTo(ins_value) == 1)
        //         {
        //             aList[ins_pos + 1] = aList[ins_pos];
        //             ins_pos = ins_pos - 1;
        //         }
        //         aList[ins_pos + 1] = ins_value;
        //     }
        //     return -1;
        // }

        var timer1 = new Stopwatch();
        var timer2 = new Stopwatch();
        var timer3 = new Stopwatch();
        var timer4 = new Stopwatch();
        var timer5 = new Stopwatch();
        var timer6 = new Stopwatch();
        var timer7 = new Stopwatch();
        var timer8 = new Stopwatch();
        var timer9 = new Stopwatch();
        var timer10 = new Stopwatch();

        timer1.Start();
        bubbleSort(randomData);
        timer1.Stop();

        timer2.Start();
        bubbleSort(randomData);
        timer2.Stop();

        timer3.Start();
        bubbleSort(randomData);
        timer3.Stop();

        timer4.Start();
        bubbleSort(randomData);
        timer4.Stop();

        timer5.Start();
        bubbleSort(randomData);
        timer5.Stop();

        timer6.Start();
        bubbleSort(randomData);
        timer6.Stop();

        timer7.Start();
        bubbleSort(randomData);
        timer7.Stop();

        timer8.Start();
        bubbleSort(randomData);
        timer8.Stop();

        timer9.Start();
        bubbleSort(randomData);
        timer9.Stop();

        timer10.Start();
        bubbleSort(randomData);
        timer10.Stop();



    }



    // Function to create an array of integers from provided data file
    public static int[] loadDataArray(string fileName)
    {
        // Read Text File by Line 
        string[] lines = File.ReadAllLines(fileName);

        // Create Array of Integers
        int[] tempData = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++)
        {
            tempData[i] = Convert.ToInt32(lines[i]);
        }

        // Return Array of Integers
        return tempData;
    }

    public static void printIntArray(int[] array, int start, int stop)
    {
        // Print out array elements at index values from start to stop 
        for (int i = start; i < stop; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
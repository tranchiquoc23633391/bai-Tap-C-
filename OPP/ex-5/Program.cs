using System;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime()
    {
        return (endTime - startTime).TotalMilliseconds;
    }


}



class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    static void Main()
    {
        const int size = 100000;
        int[] numbers = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(0, 100000);
        }

        Console.WriteLine("Bat dau sap xep 100000 so bang Selection Sort...");

        StopWatch stopwatch = new StopWatch();
        stopwatch.Start();

        SelectionSort(numbers);

        stopwatch.Stop();

        Console.WriteLine($"Thoi gian thuc thi: {stopwatch.GetElapsedTime()} ms");
    }
}

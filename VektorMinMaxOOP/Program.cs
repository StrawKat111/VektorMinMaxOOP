using System;

namespace VektorMinMaxOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VektorMinMax vektorMinMax = new VektorMinMax();

            int[] vektor = { 5, 1, 8, 7, 9 };
            vektorMinMax.SetVektor(vektor);
            vektorMinMax.SetMin();
            vektorMinMax.SetMax();
            
            (int minErtek, int minIndex, int maxErtek, int maxIndex) = vektorMinMax.GetMinMax();
            Console.WriteLine($"A legkisebb elem: {minErtek} (index: {minIndex})");
            Console.WriteLine($"A legnagyobb elem: {maxErtek} (index: {maxIndex})");
        }
    }
}

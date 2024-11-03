using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMinMaxOOP
{
    internal class VektorMinMax
    {
        private int[] vektor;
        private int minErtek;
        private int minIndex;
        private int maxErtek;
        private int maxIndex;

        
        public VektorMinMax() { }

        
        public VektorMinMax(int[] vektor)
        {
            SetVektor(vektor);
        }

        
        public void SetVektor(int[] vektor)
        {
            this.vektor = vektor;
        }

        
        public void SetMin()
        {
            minErtek = vektor[0];
            minIndex = 0;
            for (int i = 1; i < vektor.Length; i++)
            {
                if (vektor[i] < minErtek)
                {
                    minErtek = vektor[i];
                    minIndex = i;
                }
            }
        }

        
        public void SetMax()
        {
            maxErtek = vektor[0];
            maxIndex = 0;
            for (int i = 1; i < vektor.Length; i++)
            {
                if (vektor[i] > maxErtek)
                {
                    maxErtek = vektor[i];
                    maxIndex = i;
                }
            }
        }

        
        public (int ertek, int index) GetMin()
        {
            return (minErtek, minIndex);
        }

        
        public (int ertek, int index) GetMax()
        {
            return (maxErtek, maxIndex);
        }

        
        public (int minErtek, int minIndex, int maxErtek, int maxIndex) GetMinMax()
        {
            return (minErtek, minIndex, maxErtek, maxIndex);
        }
    }
}

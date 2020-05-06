using System;
using static System.Math;

namespace lab3
{
    class AonedimensionalArray
    {
        private readonly int[] arr = new int[10];

        public AonedimensionalArray(string line)
        {
            line = line.Trim();
            string[] tmp = line.Split(' ');
            int i = 0;
            if (tmp.Length > 0)
            {
                foreach (string o in tmp)
                {
                    arr[i] = Convert.ToInt32(o);
                    i++;
                }

                Array.Resize(ref arr, i);
            }
            else
            {
                Array.Resize(ref arr, 0);
            }
        }

        public int Lenght
        {
            get
            {
                return arr.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public int Search()
        {
            int count = 0;
            foreach(int i in arr)
            {
                if (i < 0)
                    count++;
            }

            return count;
        }

        public int Search(int x, int y)
        {
            int count = 0;
            for(int i=x;i<=y;i++)
            {
                if (arr[i] < 0)
                    count++;
            }

            return count;
        }

        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += Abs(arr[i]);
            }

            return sum;
        }

        public void Sort1()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = arr[i] * arr[i];
                }
            }

            Array.Sort(arr);
        }

        public void Sort2()
        {
            Sort1();
            Array.Reverse(arr);
        }
    }
}

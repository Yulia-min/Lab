using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Math;

namespace lab3
{
    static class AonedimensionalArray
    {
        public static int SearchNegativeElements(this List<int> collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                if (item < 0) count++;
            }

            return count;
        }

        public static int SearchNegativeElements(this List<int> collection, int x, int y)
        {
            int count = 0;
            for (var i = x; i <= y; i++)
            {
                if (collection[i] < 0) count++;
            }

            return count;
        }

        public static int Sum(this List<int> collection)
        {
            return collection.Select(item => Math.Abs(item)).Sum();
        }

        public static List<int> GetCollectionFromDataGridView(this DataGridView dataGridView)
        {
            var result = new List<int>();
            for (int i = 0; i < dataGridView.RowCount-1; i++)
            {
                var temp = dataGridView[0, i].Value.ToString().Trim();
                result.Add(int.Parse(dataGridView[0, i].Value.ToString().Trim()));
            }

            return result;
        }

        public static List<int> GetPositiveCollection(this List<int> collection)
        {
            var result = new List<int>();
            foreach (var item in collection)
            {
                if (item < 0)
                {
                    result.Add(item * item);
                }
                else
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static List<int> SortUp(this List<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i]<0)
                {
                    collection[i] *= collection[i];
                }
            }

            collection.Sort();

            return collection;
        }

        public static List<int> SortDown(this List<int> collection)
        {
            collection.SortUp();
            collection.Reverse();

            return collection;
        }
    }
}

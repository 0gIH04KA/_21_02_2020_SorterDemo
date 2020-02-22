using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    class SortBubble : Sorter
    {
        #region ---===    Override Method   ===---

        public override void Sort(int[] arr)
        {
            _start?.Invoke(DateTime.Now);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        ++_comparCount;
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }

            _stop?.Invoke(DateTime.Now);
        }

        #endregion
        
    }
}

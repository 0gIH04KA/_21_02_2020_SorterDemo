using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    class SortSelection : Sorter
    {
        #region ---===   Override Method   ===---

        public override void Sort(int[] arr)
        {
            _start?.Invoke(DateTime.Now);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int idxOfMin = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[idxOfMin] > arr[j])
                    {
                        ++_comparCount;
                        idxOfMin = j;
                    }
                }

                if (idxOfMin != i)
                {
                    ++_comparCount;
                    Swap(ref arr[i], ref arr[idxOfMin]);
                    idxOfMin = i;
                }
            }

            _stop?.Invoke(DateTime.Now);
        }

        #endregion

    }
}

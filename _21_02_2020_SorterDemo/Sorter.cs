using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    abstract class Sorter
    {
        #region ---===   Protected   ===---

        protected StartStopSort _start;
        protected StartStopSort _stop;

        protected int _swapCount;
        protected int _comparCount;

        #endregion

        #region ---===    Get / Set   ===---

        public int SwapCount
        {
            get
            {
                return _swapCount;
            }
        }

        public int ComparCount
        {
            get
            {
                return _comparCount;
            }
        }

        #endregion

        #region ---===   Abstract Method   ===---

        public abstract void Sort(int[] sourceArray);

        #endregion

        #region ---===   Method   ===---

        protected void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;

            ++_swapCount;
        }

        #endregion

    }
}

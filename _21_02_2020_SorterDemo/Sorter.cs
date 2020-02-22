using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    abstract class Sorter
    {
        private long _startTime;
        private long _stopTime;

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

        public void Start(DateTime date)
        {
             _startTime = date.Ticks;
        }
        

        public void Stop (DateTime date)
        {
             _stopTime = date.Ticks;
        }

        public long GetTimeSort
        {
            get
            {
                return _stopTime - _startTime;
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

        public void AddStart(StartStopSort start)
        {
            _start += start;
        }

        public void AddStop(StartStopSort stop)
        {
            _stop += stop;
        }



    }
}

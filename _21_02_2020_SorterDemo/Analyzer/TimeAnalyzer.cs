using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_02_2020_SorterDemo
{
    class TimeAnalyzer
    {
        #region ---===   Private   ===---

        private DateTime _start;
        private DateTime _stop;

        #endregion

        #region ---===   Get / Set   ===---

        public int GetTimeSort
        {
            get 
            {
                return _stop.Millisecond - _start.Millisecond;
            }
        }

        #endregion

        #region ---===   Method   ===---

        public void StartHandler(DateTime dateTime)
        {
            _start = dateTime;
        }

        public void StopHandler(DateTime dateTime)
        {
            _stop = dateTime;
        }

        #endregion

    }
}

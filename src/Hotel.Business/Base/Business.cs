using Hotel.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Base
{
    public class Business<T> : IBusiness<T>
    {
        private static List<T> _list;
        /* Objeto "burro", serve apenas para trancar as threads susequentes. As
         * threads subsequentes são Fifo.*/
        private static object _syncObj = new object();

        public Business()
        {
            if (_list == null)
                lock (_syncObj)
                    if (_list == null)
                        _list = new List<T>();
        }
        public bool Add(T t)
        {
            _list.Add(t);
            return true;
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}

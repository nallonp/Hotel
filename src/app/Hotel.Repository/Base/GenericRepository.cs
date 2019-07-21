using Hotel.Domain.Interfaces;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : IEntity
    {
        private static List<T> _list;
        private static ulong _nextId;
        /* Objeto "burro", serve apenas para trancar as threads susequentes. As
         * threads subsequentes são Fifo.*/
        private static object _syncObj_list = new object();
        private static object _syncObj_GetNextId = new object();
        public GenericRepository()
        {
            if (_list == null)
                lock (_syncObj_list)
                    if (_list == null)
                        _list = new List<T>();
        }
        public bool Insert(T t)
        {
            t.Guid = Guid.NewGuid();
            t.Id = GetNextId();
            _list.Add(t);
            return true;
        }
        public bool Update(T t)
        {
            _list.Where(x => x.Id == t.Id);
            return true;
        }

        public bool Delete(T t)
        {
            throw new NotImplementedException();
        }
        public List<T> GetList()
        {
            return _list;
        }
        private ulong GetNextId()
        {
            lock (_syncObj_GetNextId)
                return _nextId++;
        }
    }
}

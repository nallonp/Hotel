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
        public void Insert(T t)
        {
                t.Guid = Guid.NewGuid();
                t.Id = GetNextId();
                _list.Add(t);
        }
        public void Update(T t)
        {
            var obj = SelectById(t.Id);
            if (obj.Equals(null))
                throw new ArgumentException("Cliente não existe.");
            else
            {
                T queryObj = (from l in _list
                              where l.Id == t.Id
                              select l).SingleOrDefault();
                queryObj = obj;
            }
        }

        public void Delete(T t)
        {
            var obj = SelectById(t.Id);
            if (!obj.Equals(null))
            {
                _list.Remove(obj);
            }
        }
        public List<T> GetList()
        {
            return _list;
        }
        public T SelectById(ulong id)
        {
            return _list.Where(x => x.Id == id).FirstOrDefault();
        }
        private ulong GetNextId()
        {
            lock (_syncObj_GetNextId)
                return _nextId++;
        }
    }
}

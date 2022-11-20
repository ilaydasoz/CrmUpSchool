using System;
using System.Collections.Generic;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}

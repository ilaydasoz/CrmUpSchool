using System;
using CrmUpSchool.EntityLayer.Concrete;

namespace CrmUpSchool.DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        void GetProductByCategory();

    }
}

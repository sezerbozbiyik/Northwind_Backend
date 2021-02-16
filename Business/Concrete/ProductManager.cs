using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _prodcutDal;

        public ProductManager(IProductDal prodcutDal)
        {
            this._prodcutDal = prodcutDal;
        }

        public List<Product> GetAll()
        {
            return _prodcutDal.GetAll();
        }
    }
}

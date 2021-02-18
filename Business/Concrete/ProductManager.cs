using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Product> GetAllByCategoryId(int id)
        {
            return _prodcutDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _prodcutDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _prodcutDal.GetProductDetails();
        }
    }
}

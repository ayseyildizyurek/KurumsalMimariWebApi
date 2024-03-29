﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public IResult Add(Product product)
		{
			_productDal.Add(product);
			return new SuccessResult(Messages.ProductAdded);
		}

		public IResult Delete(Product product)
		{
			_productDal.Delete(product);
			return new SuccessResult(Messages.ProductDeleted);
		}

		public IDataResult<Product> GetById(int productId)
		{
			//try catch de errorlarda dönülebilir
			return new SuccessDataResult<Product>(_productDal.Get(x => x.ProductID == productId));
		}

		public IDataResult<List<Product>> GetList()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
		}

		public IDataResult<List<Product>> GetListByCategory(int categoryId)
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList(x => x.CategoryID == categoryId).ToList());
		}

		public IResult Update(Product product)
		{
			_productDal.Update(product);
			return new SuccessResult(Messages.ProductUpdated);
		}
	}
}

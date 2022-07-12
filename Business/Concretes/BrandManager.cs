using Business.Abstracts;
using Business.Constanst;
using Business.ValidationRules.FluentValidation;
using Core.Autofac.Validation;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            return BaseOperations(_brandDal.Add(brand).Success, Messages.Brand.Added);
        }

        public IResult Delete(int brandId)
        {
            return BaseOperations(_brandDal.Delete(new Brand { BrandId = brandId }).Success, Messages.Brand.Deleted);
        }

        public IDataResult<Brand> Get(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.BrandId == id), Messages.Brand.Listed);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.Brand.Listed);
        }

        public IResult Update(Brand brand)
        {
            return BaseOperations(_brandDal.Update(brand).Success, Messages.Brand.Updated);
        }
    }
}

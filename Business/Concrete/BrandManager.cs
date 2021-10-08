using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.DataResultOptions.ErrorDataResultOption;
using Core.Utilities.DataResultOptions.SuccessDataResultOption;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
           
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(b => b.BrandId == brandId));
        }
    }
}



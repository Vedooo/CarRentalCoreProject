using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.DataResultOptions.SuccessDataResultOption;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        EfColorDal _colorDal;

        public ColorManager(EfColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages. ColorListed);
        }

        public IDataResult<List<Color>> GetByColorId(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(co => co.ColorId == colorId));
        }
    }
}

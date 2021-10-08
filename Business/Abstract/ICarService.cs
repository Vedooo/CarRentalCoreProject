using Core.Utilities;
using Entities.Concrete;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByDailyPrice(decimal min);
        IDataResult<List<CarDetailDto>> GetCarDetailsDto();
        IResult Add(Car car);
    }
}

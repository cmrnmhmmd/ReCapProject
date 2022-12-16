using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colors;

        public ColorManager(IColorDal colors)
        {
            _colors = colors;
        }

        public IResult Add(Color color)
        {
            _colors.Add(color);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Color color)
        {
            _colors.Delete(color);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _colors.GetAll());
        }

        public IDataResult<Color> GetColorId(int colorId)
        {
            return new SuccessDataResult<Color>( _colors.Get(c => c.ColorId == colorId));
        }

        public IResult Update(Color color)
        {
            _colors.Update(color);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}

using Business.Abstracts;
using Business.Constanst;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using System;
using System.Collections.Generic;

namespace Business.Concretes
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult BaseOperations(bool success, string message)
        {
            if (success)
            {
                return new SuccessResult(message);
            }
            return new ErrorResult(Messages.ProcessFailed);
        }
        public IResult Add(Color color)
        {
            return BaseOperations(_colorDal.Add(color).Success, Messages.Color.Added);
        }

        public IResult Delete(int colorID)
        {
            return BaseOperations(_colorDal.Delete(new Color { ColorId = colorID }).Success, Messages.Color.Deleted);
        }

        public IDataResult<Color> Get(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.ColorId == id), Messages.Color.Listed);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Color.Listed);
        }

        public IResult Update(Color color)
        {
            return BaseOperations(_colorDal.Update(color).Success, Messages.Color.Updated);
        }
    }


}

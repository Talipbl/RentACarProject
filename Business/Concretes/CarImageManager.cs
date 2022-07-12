using Business.Abstracts;
using Business.Constanst;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;
        ICarService _carService;

        public CarImageManager(ICarImageDal carImageDal, ICarService carService)
        {
            _carImageDal = carImageDal;
            _carService = carService;
            _fileHelper = new FileHelper();
        }
        private IResult CheckIfCountOfCarImage(int carId)
        {
            var result = _carImageDal.GetAll(p => p.CarId == carId);
            if (result.Count >= 5)
            {
                return new ErrorResult(Messages.CarImage.CarImageLimitExceed);
            }
            return new SuccessResult();
        }
        private IResult CheckIfEmptyFile(IFormFile formFile)
        {
            if (formFile == null)
            {
                return new ErrorResult(Messages.Error.EmptyFile);
            }
            return new SuccessResult();
        }
        public IResult Add(IFormFile formFile, int carId)
        {
            var checkResult = BusinessRules.Run(CheckIfEmptyFile(formFile)
                , CheckIfCountOfCarImage(carId));
            if (checkResult == null)
            {
                var result = _fileHelper.Upload(formFile);
                if (result.Success)
                {
                    CarImage carImage = new CarImage()
                    {
                        CarId = carId,
                        ImagePath = result.Message
                    };
                    return _carImageDal.Add(carImage);
                }
            }
            return new ErrorResult(checkResult.Message);
        }

        public IResult Delete(int imageId)
        {
            return _carImageDal.Delete(new CarImage { ImageId = imageId });
        }

        public IDataResult<CarImage> GetFirst(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetFirst(p => p.CarId == id));
        }

        public IDataResult<List<CarImage>> GetAll(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c=>c.CarId==carId));
        }

        public IResult Update(CarImage carImage)
        {
            return _carImageDal.Update(carImage);
        }
    }
}

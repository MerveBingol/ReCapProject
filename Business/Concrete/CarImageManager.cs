using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(ChecImageLimitExceeded(carImage.CarId));
            if (result!=null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();


            
        }

       

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccesDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccesDataResult<CarImage>(_carImageDal.Get(ci => ci.Id == id));
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            return new SuccesDataResult<List<CarImage>>(CheckIfCarImageNull(carId));
        }

       

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(ChecImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(ci=>ci.Id==carImage.Id).ImagePath,file);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }


        private List<CarImage> CheckIfCarImageNull(int id)
        {
            string path = @"\Images\logo.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { Id=id,CarId = id, ImagePath = path, Date = DateTime.Now } };
            }
            return _carImageDal.GetAll(ci=>ci.CarId==id);
        }
        private IResult ChecImageLimitExceeded(int carId)
        {
            var carImageCount = _carImageDal.GetAll(ci=>ci.CarId==carId).Count;
            if (carImageCount >= 5)
            {
                return new ErrorResult(Messages.ChecImageLimitExceeded);
            }
            return new SuccessResult();
        }
    }
}

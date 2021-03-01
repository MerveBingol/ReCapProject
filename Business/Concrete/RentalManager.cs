using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            ValidationTool.Validate(new RentalValidator(),rental);
            
            //var result = _rentalDal.GetAll(r=>r.CarId==rental.CarId && r.ReturnDate==null);  Artık bunu Validation ile yaptık.
            //if (result.Count>0)
            //{
            //    return new ErrorResult(Messages.RentalInvalid);
            //}
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

      
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }


        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccesDataResult<Rental>(_rentalDal.Get(c=>c.RentalId==rentalId));
        }



        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccesDataResult<List<RentalDetailDto>>();
        }

        public IResult Update(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);


        }


    }
}

using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        // bu şöyle diyor ben ColorManagaer olarak veri erişim katmanına zayıf bağımlıyım 
        //çünkü referans (interface) üzerinden bağımlıyım.
        
        IColorDal _colorDal;

        public ColorManager(EfColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
            
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);

        }
    }
}

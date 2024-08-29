using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutdal;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutdal = aboutDAL;

        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public List<About> TGetList()
        {
           return _aboutdal.GetList();
        }

        public void TUpdate(About t)
        {
           _aboutdal.Update(t);
        }
    }
}

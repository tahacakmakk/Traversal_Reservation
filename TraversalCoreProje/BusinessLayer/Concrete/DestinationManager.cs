using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public Destination GetByID(int id)
        {
            return _destinationDal.GetById(id);
        }

        public List<Destination> GetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public void Tadd(Destination t)
        {
            _destinationDal.Insert(t);
        }


        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
           return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();   
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}

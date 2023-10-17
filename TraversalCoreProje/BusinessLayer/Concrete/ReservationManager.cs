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
	public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void ChangeToApprove(int id)
        {
            _reservationDal.ChangeToApprove(id);
        }

        public Reservation GetByID(int id)
        {
           return _reservationDal.GetById(id);    
        }

		public List<Reservation> GetListWithReservationByAccepted(int id)
		{
			return _reservationDal.GetListWithReservationByAccepted(id);
		}

        public List<Reservation> GetListWithReservationByAllAccepted()
        {
            return _reservationDal.GetListWithReservationByAllAccepted();
        }

        public List<Reservation> GetListWithReservationByAllPrevious()
        {
            return _reservationDal.GetListWithReservationByAllPrevious();
        }

        public List<Reservation> GetListWithReservationByAllWaitApproval()
        {
            return _reservationDal.GetListWithReservationByAllWaitApproval();
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
		{
            return _reservationDal.GetListWithReservationByPrevious(id);
		}

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
			return _reservationDal.GetListWithReservationByWaitApproval(id);
		}

		public void Tadd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}

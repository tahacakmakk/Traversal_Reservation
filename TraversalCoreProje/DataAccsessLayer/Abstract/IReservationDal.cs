using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAllWaitApproval();
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByAllAccepted();
        List<Reservation> GetListWithReservationByPrevious(int id);
        List<Reservation> GetListWithReservationByAllPrevious();
        void ChangeToApprove(int id);


    }
}

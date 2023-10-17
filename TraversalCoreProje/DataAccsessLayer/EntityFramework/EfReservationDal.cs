using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
	public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
	{
        public void ChangeToApprove(int id)
        {
            using (var context = new Context())
            {
               var value= context.Reservations.Find(id);
                value.Status = "Onaylandı";
                context.Update(value);
                context.SaveChanges();
            }
        }

        public List<Reservation> GetListWithReservationByAccepted(int id)
		{

			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserID == id).ToList();
			}
		}

        public List<Reservation> GetListWithReservationByAllAccepted()
        {
            using (var context = new Context())
            {
				 return context.Reservations.Include(x => x.Destination).Include(x => x.AppUser).Where(x => x.Status == "Onaylandı").ToList();
            }
        }

        public List<Reservation> GetListWithReservationByAllPrevious()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Include(x => x.AppUser).Where(x => x.Status == "Geçmiş Rezervasyon").ToList();
            }
        }

        public List<Reservation> GetListWithReservationByAllWaitApproval()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Include(x=>x.AppUser).Where(x => x.Status == "Onay Bekliyor").ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
		{

			using (var context = new Context())
			{
				return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserID == id).ToList();
			}
		}

		public List<Reservation> GetListWithReservationByWaitApproval(int id)
		{
			using(var context = new Context())
			{
				return context.Reservations.Include(x=>x.Destination).Where(x=>x.Status=="Onay Bekliyor" && x.AppUserID ==id).ToList();
			}

		}
	}
}

using KutuphaneProgrami.Data.Model;
using KutuphaneProgrami.Data.UnitOfWork;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KutuphaneProgrami.Tasks.Jobs
{
    public class CezaArttirmaDusurmeJob : IJob
    {
        UnitOfWork unitOfWork;
        public CezaArttirmaDusurmeJob() 
        {
            unitOfWork=new UnitOfWork();

        }
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                CezaArttir();
                CezaDusur();
                unitOfWork.SaveChanges();

            }
            catch { }
        }

        void CezaArttir() 
        {
            var oduncKitaplar = unitOfWork.GetRepository<OduncKitap>().GetAll(x => x.GetirdigiTarih == null && DateTime.Now > x.GetirecegiTarih);
            foreach (var oduncKitap in oduncKitaplar)
            {
                oduncKitap.Uye.Ceza += 1;
                unitOfWork.GetRepository<Uye>().Update(oduncKitap.Uye);
            }
        }
        void CezaDusur()
        {
            var oduncKitaplar = unitOfWork.GetRepository<OduncKitap>().GetAll(x => x.GetirdigiTarih != null && x.Uye.Ceza > 0);
            foreach (var oduncKitap in oduncKitaplar)
            {
                oduncKitap.Uye.Ceza -= 1;
                unitOfWork.GetRepository<Uye>().Update(oduncKitap.Uye);
            }
        }

        Task IJob.Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
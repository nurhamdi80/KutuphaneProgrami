using KutuphaneProgrami.Tasks.Jobs;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneProgrami.Tasks.Triggers
{
    public class CezaArttirmaDusurmeTrigger
    {
        public static void Baslat() 
        {
            //IScheduler zamanlayici = StdSchedulerFactory.GetDefaultScheduler();
            //if (!zamanlayici.IsStarted)
            //    zamanlayici.Start();
            //IJobDetail gorev = JobBuilder.Create<CezaArttirmaDusurmeJob>.Build();
            //ICronTrigger tetikleyici = (ICronTrigger)TriggerBuilder.Create()
            //    .WithIdentity("CezaArttirmaDusurmeJob", "null")
            //    .WithCronSchedule("0 0 0 * * ? *")
            //    .Build();
            //zamanlayici.ScheduleJob(gorev, tetikleyici);
        }
    }
}
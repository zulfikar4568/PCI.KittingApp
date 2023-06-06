using PCI.KittingApp.Config;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PCI.KittingApp
{
    public class Scheduler
    {
        private readonly IScheduler _scheduler;
        public Scheduler(IScheduler scheduler)
        {
            _scheduler = scheduler;
        }

        public void StartCronJob(Form form = null)
        {
            // Start the CronJob
            if (form != null) ScheduleJob(form);

            _scheduler.Start().ConfigureAwait(true).GetAwaiter().GetResult();
        }
        public void StopCronJob(object sender, EventArgs e)
        {
            _scheduler.Shutdown().ConfigureAwait(true).GetAwaiter().GetResult();
        }

        private void ScheduleJob(Form form = null)
        {   
            // Put the data form if exists!
            if (form != null) SchedulerCronJob<Job.CheckConnectionJob>(AppSettings.CheckConnectionCronExpression, form);
        }

        private void SchedulerCronJob<T>(string cronExpression, Form form = null) where T : IJob
        {
            var jobName = typeof(T).Name;

            var job = JobBuilder
                .Create<T>()
                .WithIdentity(jobName, $"{jobName}-Group")
                .Build();
            
            // Put the data form if exists!
            if (form != null ) job.JobDataMap.Put("MainForm", form);

            var trigger = TriggerBuilder.Create()
                .WithIdentity($"{jobName}-Trigger", $"{jobName}-TriggerGroup")
                .StartNow()
                .WithCronSchedule(cronExpression)
                .Build();

            _scheduler.ScheduleJob(job, trigger).ConfigureAwait(true).GetAwaiter().GetResult();
        }
    }
}

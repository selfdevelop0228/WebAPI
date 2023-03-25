using Application.Common.Interfaces.Repository;
using Application.Common.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.JobTaskServices
{
    public  class JobTaskService : ITaskServices
    {
        private readonly ITaskRepository _task;
        public JobTaskService  (ITaskRepository task)
        {
            _task = task;
        }

        public List<JobTask> GetJobTaskService()
        {
            List<JobTask> result = _task.GetJobTask();
            return result;
        }

        public List<JobTask> GetJobTaskByIdService(int taskID)
        {
            List<JobTask> result = _task.GetJobTaskById(taskID);
            return result;
        }

        public void CreateJobTaskService(JobTask jobTask)
        {
            _task.CreateJobTask(jobTask);
        }

        public void UpdateJobTaskService(JobTask jobTask)
        {
            _task.UpdateJobTask(jobTask);
        }

        public void DeleteJobTaskService(int Id)
        {
            _task.DeleteJobTask(Id);
        }

    }
}

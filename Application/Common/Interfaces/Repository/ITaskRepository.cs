using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Common.Interfaces.Repository
{
    public interface ITaskRepository
    {
        public List<JobTask> GetJobTask();

        public List<JobTask> GetJobTaskById(int taskID);

        public void CreateJobTask(JobTask jobTask);

        public void UpdateJobTask(JobTask jobTask);

        public void DeleteJobTask(int Id);
    }
}

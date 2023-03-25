using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Services
{
    public interface ITaskServices
    {
        public List<JobTask> GetJobTaskService();

        public List<JobTask> GetJobTaskByIdService(int taskID);

        public void CreateJobTaskService(JobTask jobTask);

        public void UpdateJobTaskService(JobTask jobTask);

        public void DeleteJobTaskService(int Id);

    }
}

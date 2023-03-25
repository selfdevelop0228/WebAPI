using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces.Repository;
using Domain.Entities;

namespace Infrastructure.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private List<JobTask> lstJobTask = new List<JobTask>();
        public TaskRepository(List<JobTask> jobTask)
        {

            lstJobTask = jobTask;
            //generate initial data
            for (int i = 0; i < 5; i++)
            {
                lstJobTask.Add(new JobTask()
                {
                    TaskID = i,
                    TaskName = "test" + i,
                    Description = "test description" + i,
                    Status = "Working on it",
                    Created = DateTime.Now,
                    End = DateTime.Now.AddDays(7),
                    Person = "test user" + i
                });
            }
        }

        public List<JobTask> GetJobTask()
        {
            return lstJobTask;
        }

        public List<JobTask> GetJobTaskById(int taskID)
        {
            var result = lstJobTask.Where(p => p.TaskID == taskID);
            return result.ToList();
        }

        public void CreateJobTask(JobTask jobTask)
        {
            lstJobTask.Add(new JobTask()
            {
                TaskID = jobTask.TaskID,
                TaskName = jobTask.TaskName,
                Description = jobTask.Description,
                Status = jobTask.Status,
                Created = jobTask.Created,
                End = jobTask.End,
                Person = jobTask.Person
            });
        }

        public void UpdateJobTask(JobTask jobTask)
        {
            var obj = lstJobTask.FirstOrDefault(p => p.TaskID == jobTask.TaskID);

            if (obj != null)
            {
                obj.TaskID = jobTask.TaskID;
                obj.TaskName = jobTask.TaskName;
                obj.Description = jobTask.Description;
                obj.Status = jobTask.Status;
                obj.Created = jobTask.Created;
                obj.End = jobTask.End;
                obj.Person = jobTask.Person;
            }

        }

        public void DeleteJobTask(int Id)
        {
            List<JobTask> data = lstJobTask;

            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i].TaskID == Id)
                {
                    data.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

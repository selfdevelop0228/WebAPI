using Application.Common.Interfaces.Repository;
using Application.Common.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private readonly ITaskServices _taskService;

        public TaskController(ITaskServices taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<List<JobTask>> GetJobTask()
        {
           var result= _taskService.GetJobTaskService();
            return Ok(result);
        }

        [HttpGet ("Id")]
        public ActionResult<List<JobTask>> GetJobTaskById(int id)
        {
            var result = _taskService.GetJobTaskByIdService(id);
            return Ok(result);
        }

        [HttpPost]
        public void CreateJobTask([FromForm] JobTask jobTask)
        {
           _taskService.CreateJobTaskService(jobTask);
        }

        [HttpPut]
        public void UpdateJobTask([FromForm] JobTask jobTask)
        {
            _taskService.UpdateJobTaskService(jobTask);
        }

        [HttpDelete]
        public void DeleteJobTask(int id)
        {
            _taskService.DeleteJobTaskService(id);
        }
    }
}

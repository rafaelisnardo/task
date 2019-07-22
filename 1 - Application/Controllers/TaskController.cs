using System;
using Microsoft.AspNetCore.Mvc;
using ddd.Domain.Entities;
using ddd.Service.Services;
using ddd.Service.Validators;

namespace ddd.Application.Controllers
{
    [Produces("application/json")]

    public class TaskController : Controller
    {
        private BaseService<Task> service = new BaseService<Task>();

        [HttpGet]
        [Route("api/Task")]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("api/Task/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("api/Task")]
        public IActionResult Post([FromBody] Task item)
        {
            try
            {
                item.DataCriacao = DateTime.Now;
                service.Post<TaskValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("api/EditTask")]
        public IActionResult EditTask([FromBody] Task item)
        {
            try
            {
                item.DataEdicao = DateTime.Now;
                service.Put<TaskValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("api/DeleteTask")]
        public IActionResult Delete([FromBody] Task item)
        {
            try
            {
                item.DataExclusao = DateTime.Now;
                item.TaskExcluida = true;
                service.Put<TaskValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("api/FinishTask")]
        public IActionResult Finish([FromBody] Task item)
        {
            try
            {
                item.DataConclusao = DateTime.Now;
                item.TaskConcluida = true;
                service.Put<TaskValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}

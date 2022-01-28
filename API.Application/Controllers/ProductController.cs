using API.Domain.DTOs;
using API.Domain.Interfaces.Services.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService _service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET api/<ProductController>/5
        /// <summary>
        /// Método Get
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "GetById")]
        public ActionResult Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(_service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Método Get All
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(_service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // POST api/<ProductController>
        /// <summary>
        /// Método Post
        /// </summary>
        /// <param name="product">Modelo</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ProductDTOCreate product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = _service.Post(product);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetById", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // PUT api/<ProductController>/5
        /// <summary>
        /// Método Put
        /// </summary>
        /// <param name="product">Modelo</param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult Put([FromBody] ProductDTOUpdate product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = _service.Put(product);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        // DELETE api/<ProductController>/5
        /// <summary>
        /// Método Delete
        /// </summary>
        /// <param name="id">Identificador</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}

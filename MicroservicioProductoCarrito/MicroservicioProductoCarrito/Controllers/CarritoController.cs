using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacion.Services;
using CapaDominio.DTOs;
using CapaDominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioProductoCarrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoController : ControllerBase
    {
        private readonly ICarritoServices _service;
        public CarritoController(ICarritoServices service)
        {
            _service = service;
        }

        [HttpPost]
        public Carrito Post(CarritoDTOs carrito)
        {
            return _service.CreateCarrito(carrito);
        }
        [HttpDelete]
        public Carrito Delete(CarritoDTOs carrito)
        {
            return _service.DeleteCarrito(carrito);
        }
        //[HttpPut]
        //public Carrito Update(CarritoProductoDTOs carrito)
        //{
        //    return _service.UpdateCarrito(carrito);
        //}
        //[HttpGet]
        //public IEnumerable<Carrito> Get()
        //{
        //    return _service.GetAll();
        //}
    }
}
using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            //Creacion de lista de productos//
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 Quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 Estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamon y Queso";

            //Agregamos productos a la lista //
            var listadePrductos = new List<ProductoModel>();
            listadePrductos.Add(producto1);
            listadePrductos.Add(producto2);
            listadePrductos.Add(producto3);

            return View(listadePrductos);
        }
    }
}
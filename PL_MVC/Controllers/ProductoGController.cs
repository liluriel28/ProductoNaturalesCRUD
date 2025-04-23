using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class ProductoGController : Controller
    {
        // GET: ProductoG
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            ML.Producto producto = new ML.Producto();
            producto.SubCategoria = new ML.SubCategoria();
            producto.SubCategoria.Categoria = new ML.Categoria();
            producto.SubCategoria.IdSubCategoria = 1;

            ML.Result result = BL.Producto.GetAll(producto);

            if (result.Success)
            {
                producto.Productos = result.Objects;
            }

            ML.Result CategoriaDDL = BL.Categoria.GetAll();
            producto.SubCategoria.Categoria.Categorias = CategoriaDDL.Objects;

            return View(producto);
        }
    }
}
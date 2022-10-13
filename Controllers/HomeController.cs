using Microsoft.AspNetCore.Mvc;
using Npgsql;
using pilotoPharma.Models;
using pilotoPharma.Models.Consultas;
using pilotoPharma.Models.DTOs;
using System.Diagnostics;

namespace pilotoPharma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            NpgsqlConnection conn = Models.Conexiones.PostgreSQL.ConnectionPostgreSQL.PostgreSQLConnection(Util.getHost(), Util.getPort(), Util.getUser(), Util.getPassw(), Util.getDb());
            Console.WriteLine("[INFO] -- Comprobando estado de conexion " + conn.State.ToString());


            try
            {

                //Insertamos el producto
                ConsultasInsert.InsertProducto(conn);
                //Realizamos la consulta y guardamos el resultado en una tabla
                List<ProductoDTO> listProductos = ConsultasSelect.ConsultaSelectAll(conn);

                //Leemos el resultado
                foreach (ProductoDTO p in listProductos)                
                    Console.WriteLine(p.getString());
                

            }
            catch (Exception e)
            {

                Console.WriteLine("[INFO] -- Controllers.HomeController.Index --  " + e.Message);
            }

            conn.Close();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
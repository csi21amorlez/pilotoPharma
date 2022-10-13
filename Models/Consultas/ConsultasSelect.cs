using Npgsql;
using pilotoPharma.Models.DTOs;

namespace pilotoPharma.Models.Consultas
{
    /*
     * QueriesSelect -> Clase que nos permite ejecutar diferentes queries del tipo select 
     */
    public class ConsultasSelect
    {

        //Metodo para recibir la consulta en una lista y facilitar su lectura
        public static List<ProductoDTO> ConsultaSelectAll(NpgsqlConnection conexionGenerada)
        {
            List<ProductoDTO> listProductos= new List<ProductoDTO>();
            try
            {
                conexionGenerada.Open();
                Console.WriteLine("[INFO] -- Entrando en -> pilotoPharma.Models.Consultas ");
                //Se define y ejecuta la consulta Select
                NpgsqlCommand consulta = new NpgsqlCommand("SELECT * FROM \"dlk_operacional_productos\".\"opr_cat_productos\"", conexionGenerada); ;
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();

                //Paso de DataReader a lista de alumnoDTO
                listProductos = DTOs.DTOtoList.ReaderAListProductoDTO(resultadoConsulta);
               
                conexionGenerada.Close();
                resultadoConsulta.Close();

            }
            catch (Exception e)
            {
                
                System.Console.WriteLine("[ERROR] -- pilotoPharma.Models.Consultas -- " + e);
                conexionGenerada.Close();

            }
            Console.WriteLine("[INFO] --Saliendo de --> pilotoPharma.Models.Consultas");
            return listProductos;
        }


    }
}

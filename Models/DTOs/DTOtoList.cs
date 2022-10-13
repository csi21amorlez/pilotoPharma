using Npgsql;

namespace pilotoPharma.Models.DTOs
{

    /*
     * DTOtoList --> Clase que nos permite pasar los resultados de una consulta a objetos almacenados en una lista para poder leerlos mas facilmente
     */
    public class DTOtoList
    {

        public static List<ProductoDTO> ReaderAListProductoDTO(NpgsqlDataReader resultadoConsulta)
        {
            Console.WriteLine("[INFO] -- Entrando en -> Modulos.DTOs.DTOtoList.ReaderAListProductoDTO");
            List<ProductoDTO> listAlumnos = new List<ProductoDTO>();
            while (resultadoConsulta.Read())
            {
                listAlumnos.Add(new ProductoDTO(resultadoConsulta[0].ToString(), null, (long)resultadoConsulta[2], resultadoConsulta[3].ToString(), resultadoConsulta[4].ToString(), resultadoConsulta[5].ToString(), resultadoConsulta[6].ToString(), resultadoConsulta[7].ToString(), null, null));

            }
            Console.WriteLine("[INFO] -- Saliendo de  -> Modulos.DTOs.DTOtoList.ReaderAListProductoDTO\"");
            return listAlumnos;
        }
        //Convertimos los datos de una consulta a la tabla Asignaturas a lista para poder leerlos


    }
}

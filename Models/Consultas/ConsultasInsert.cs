using Npgsql;

namespace pilotoPharma.Models.Consultas
{
    /*
     * ConsultasInsert -> Clase que nos permite ejecutar diferentes queries para insertar datos en la base de datos 
     */
    public class ConsultasInsert
    {
        public static void InsertProducto(NpgsqlConnection conn)
        {
            
            Console.WriteLine("[INFO] -- Entrando en -> pilotoPharma.Models.Consultas.ConsultasInsert.Insert");
            String sql = "Insert into \"dlk_operacional_productos\".\"opr_cat_productos\" VALUES (\'adf131029022fch12345\',null, DEFAULT, \'hig_p_gelf_f\', \'Gel de aceite de fresa, Farlane\', \'Propio\', \'Higiene\', \'Gel de aceite de fresa producido por marca propia Farlane\', null, null);";
            Console.WriteLine("[INFO] --> {0}", sql);
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                
                cmd.ExecuteNonQuery();
                Console.WriteLine("[INFO-- modelos.Queries.QueriesInsert.InsertAlumno] Alumno creado");


            }
            catch (Exception e)
            {
                // TODO: handle exception
                Console.WriteLine("[INFO]-- modelos.consultas.ConsultasInsert.InsertProducto] Error al insertar producto " + e.Message);
            }
            Console.WriteLine("[INFO] -- Saliendo de -> pilotoPharma.Models.Consultas.ConsultasInsert.InsertProducto");
            conn.Close();





        }

    }

}

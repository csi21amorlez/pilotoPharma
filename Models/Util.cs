using Microsoft.Extensions.Hosting;

namespace pilotoPharma.Models
{
    /*
     * Util --> Clase en la que guardaremos las variables de inicio de sesion que necesitamos para entra en la base de datos
     */
    public class Util
    {
        //	Declaramos las constantes y las inicializamos
        const string HOST = "localhost";
        const string PASSW = "root123";
        const int PORT = 5432;
        const string DB = "General";
        const string USER = "postgres";


        //	Definimos los metodos por los que accederemos a las constantes
        public static string getHost()
        {
            return HOST;
        }
        public static string getPassw()
        {
            return PASSW;
        }
        public static int getPort()
        {
            return PORT;
        }
        public static string getDb()
        {
            return DB;
        }
        public static string getUser()
        {
            return USER;
        }

    }
}

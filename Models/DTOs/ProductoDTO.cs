namespace pilotoPharma.Models.DTOs
{
    public class ProductoDTO
    {
        //	Atributos
        private string md_uuid;
        private DateTime md_fch;
        private int id_producto;
        private string cod_producto;
        private string nombre_producto;
        private string tipo_producto_origen;
        private string tipo_producto_clase;
        private string des_producto;
        private DateTime fch_alta_producto;
        private DateTime fch_baja_producto;

        //	Constructor
        public ProductoDTO(string md_uuid, DateTime md_fch, int id_producto, string cod_producto, string nombre_producto,
                string tipo_producto_origen, string tipo_producto_clase, string des_producto, DateTime fch_alta_producto,
                DateTime fch_baja_producto)
        {

            this.md_uuid = md_uuid;
            this.md_fch = md_fch;
            this.id_producto = id_producto;
            this.cod_producto = cod_producto;
            this.nombre_producto = nombre_producto;
            this.tipo_producto_origen = tipo_producto_origen;
            this.tipo_producto_clase = tipo_producto_clase;
            this.des_producto = des_producto;
            this.fch_alta_producto = fch_alta_producto;
            this.fch_baja_producto = fch_baja_producto;
        }

        //	Getters 
        public string getMd_uuid()
        {
            return md_uuid;
        }

        public DateTime getMd_fch()
        {
            return md_fch;
        }

        public int getId_producto()
        {
            return id_producto;
        }

        public string getCod_producto()
        {
            return cod_producto;
        }

        public string getNombre_producto()
        {
            return nombre_producto;
        }

        public string getTipo_producto_origen()
        {
            return tipo_producto_origen;
        }

        public string getTipo_producto_clase()
        {
            return tipo_producto_clase;
        }

        public string getDes_producto()
        {
            return des_producto;
        }

        public DateTime getFch_alta_producto()
        {
            return fch_alta_producto;
        }

        public DateTime getFch_baja_producto()
        {
            return fch_baja_producto;
        }

        //	Metodo tostring
       
    public string toString()
        {
            return "Producto [md_uuid=" + md_uuid + ", md_fch=" + md_fch + ", id_producto=" + id_producto
                    + ", cod_producto=" + cod_producto + ", nombre_producto=" + nombre_producto + ", tipo_producto_origen="
                    + tipo_producto_origen + ", tipo_producto_clase=" + tipo_producto_clase + ", des_producto="
                    + des_producto + ", fch_alta_producto=" + fch_alta_producto + ", fch_baja_producto=" + fch_baja_producto
                    + "]";
        }          

    }
}

namespace pilotoPharma.Models.DTOs
{
    public class ProductoDTO
    {
        //	Atributos
        private string md_uuid;
        private Nullable<DateTime> md_fch;
        private long id_producto;
        private string cod_producto;
        private string nombre_producto;
        private string tipo_producto_origen;
        private string tipo_producto_clase;
        private string des_producto;
        private Nullable<DateTime> fch_alta_producto;
        private Nullable<DateTime> fch_baja_producto;

        //	Constructor
        public ProductoDTO(string md_uuid, Nullable<DateTime> md_fch, long id_producto, string cod_producto, string nombre_producto,
                string tipo_producto_origen, string tipo_producto_clase, string des_producto, Nullable<DateTime> fch_alta_producto,
                Nullable<DateTime> fch_baja_producto)
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

        public Nullable<DateTime> getMd_fch()
        {
            return md_fch;
        }

        public long getId_producto()
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

        public Nullable<DateTime> getFch_alta_producto()
        {
            return fch_alta_producto;
        }

        public Nullable<DateTime> getFch_baja_producto()
        {
            return fch_baja_producto;
        }

        //	Metodo tostring
       
            
        public string getString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", getMd_uuid(), getMd_fch(), getId_producto(), getCod_producto(),getNombre_producto() ,getTipo_producto_origen(), getTipo_producto_clase(), getDes_producto(), getFch_alta_producto(), getFch_baja_producto());
        }

    }
}

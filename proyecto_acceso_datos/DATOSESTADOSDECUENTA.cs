using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
    class DATOSESTADOSDECUENTA
    {
        public static List<ESTADODECUENTA> MOSTRARESTADO()
        {
            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DE DATOS
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                //USAMOS LINQ. PARA QUE NOS MUESTRE TODAS LAS FACTURAS EXISTENTES
                var INFO = (from E in BD.ESTADODECUENTAS
                            select E).ToList();
                return INFO;
            }
        }
        //ESTE ES EL MÉTODO QUE SE LLAMA BUSCARNUMEROFACTURA
        public static List<ESTADODECUENTA> BUSCARPORNUMEROFACTURA(int numerofactura)
        {
            
        /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NUMERO
 DE LA FACTURA*/
 using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from E in BD.ESTADODECUENTAS
                            where E.NUMEROFACTURA == numerofactura
                            select E).ToList();
                return INFO;
            }
        }
        //ESTE ES EL MÉTODO QUE SE LLAMA BUSCARPORCODIGO
        public static List<ESTADODECUENTA> BUSCARPORCOIGO(int codigo)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL
            * CÓDIGO DEL PROVEEDOR EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from E in BD.ESTADODECUENTAS
                            where E.CODIGOPROVEEDOR == codigo
                            select E).ToList();
                return INFO;
            }
        }
    }
}

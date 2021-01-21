
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
     class DATOSFACTURAS
    {

        public static List<FACTURASPJ> BUSCARTODOS()
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {

                var INFO = (from F in BD.FACTURASPJs
                            select F).ToList();

                return INFO;
            }
        }


        public static List<FACTURASPJ> BUSCARELNUMERO(int numerofactura)
{
    using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ ())
    {
       
        var INFO = (from F in BD.FACTURASPJs
                    where F.NUMEROFACTURA == numerofactura
                    select F).ToList();
       
        return INFO;
    }
}
public static List<FACTURASPJ> BUSCARECODIGO(int codigo)
{
    using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
    {
        //USAMOS LINQ. PARA BUSCAR FACTURAS POR EL CODIGO DEL PROEEDOR
        var INFO = (from F in BD.FACTURASPJs
                    where F.CODIGOPROVEEDOR == codigo
                    select F).ToList();
        /*StartsWith HACE QUE VAYA MOSTRANDO LOS PROVEEDORES QUE
        EMPIEZEN CON LAS LETRAS QUE VAMOS ESCRIBIENDO*/
        return INFO;
    }
}

    }
    
   
}


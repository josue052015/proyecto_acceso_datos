using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
    class DATOSFACTURA2
    {
        public void INSERTARFACTURA
        (int ID_P, 
          decimal VALOR_FACTURA, 
          DateTime FECHA,
          DateTime FECHA_V

         )
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {

                BD.FACTURASPJs.Add(new FACTURASPJ
                {
                   CODIGOPROVEEDOR = ID_P,
                    VALORFACTURA = VALOR_FACTURA,
                    FECHAFACTURA = FECHA,
                    FECHAVENCIMIENTO = FECHA_V
                });

                BD.SaveChanges();
            }
        }

        public void MODIFICARFACTURA
    (
           int NUM_FACTURA,
           int CPROV,
           decimal VALORF,
           DateTime FECHAF,
           DateTime FECHAV
    )
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var MODIFICAR = (from P in BD.FACTURASPJs
                                 where P.NUMEROFACTURA == NUM_FACTURA
                                 select P).Single();
                MODIFICAR.NUMEROFACTURA = NUM_FACTURA;
                MODIFICAR.CODIGOPROVEEDOR = CPROV;
                MODIFICAR.VALORFACTURA = VALORF;
                MODIFICAR.FECHAFACTURA = FECHAF;
                MODIFICAR.FECHAFACTURA = FECHAV;


                BD.SaveChanges();


            }
        }

        public void ELIMINARFACTURA(int NUM_F)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var ELIMINAR = (from P in BD.FACTURASPJs
                               where P.NUMEROFACTURA == NUM_F
                               select P).Single();
                BD.FACTURASPJs.Remove(ELIMINAR);
                BD.SaveChanges();
            }
        }
       

    }
}

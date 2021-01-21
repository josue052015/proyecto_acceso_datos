using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
    class DATOSCHEQUES
    {
        public static List<CHEQUESPJ> MOSTRARCHEQUES()
        {
            
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                //MUESTRA TODOS LAS CHEQUES
                var INFO = (from C in BD.CHEQUESPJs
                            select C).ToList();
                return INFO;
            }
        }
        public static List<CHEQUESPJ> BUSCARELNUMERO(int numerocheque)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                
                var INFO = (from C in BD.CHEQUESPJs
                            where C.NUMEROCHEQUE == numerocheque
                            select C).ToList();
            
                return INFO;
            }
        }
        
        public static List<CHEQUESPJ> BUSCARNUMERO_FACTURA(int NUMERO_FACTURA)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
         
                var INFO = (from C in BD.CHEQUESPJs
                            where C.NUMEROFACTURA == NUMERO_FACTURA
                            select C).ToList();
                
                return INFO;
               }
}
        public static List<CHEQUESPJ> BUSCAR_VALOR(Decimal VALOR)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {

                var INFO = (from C in BD.CHEQUESPJs
                            where C.VALORCHEQUE == VALOR
                            select C).ToList();

                return INFO;
            }
        }

      



        public void AGREGARCHEQUE
       (int NUM_F,
         decimal VALOR_CHEQUE,
         DateTime FECHA_C
         

        )
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {

                BD.CHEQUESPJs.Add(new CHEQUESPJ
                {
                   NUMEROFACTURA = NUM_F,
                   VALORCHEQUE = VALOR_CHEQUE,
                   FECHACHEQUE = FECHA_C
                });

                BD.SaveChanges();
            }
        }

        public void MODIFICARCHEQUE
   (
            int NUM_C,
          int NUM_F,
         decimal VALOR_CHEQUE
        
   )
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var MODIFICAR = (from P in BD.CHEQUESPJs
                                 where P.NUMEROCHEQUE == NUM_C
                                 select P).Single();
                MODIFICAR.NUMEROFACTURA = NUM_F;
                MODIFICAR.VALORCHEQUE = VALOR_CHEQUE;


                BD.SaveChanges();


            }
        }
        public void ELIMINARCHEQUE(int NUM_C)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var ELIMINAR = (from P in BD.CHEQUESPJs
                                where P.NUMEROCHEQUE == NUM_C
                                select P).Single();
                BD.CHEQUESPJs.Remove(ELIMINAR);
                BD.SaveChanges();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
    class DATOSPROVEEDORES
    {
        public static List<PROVEEDORESPJ> MOSTRARDATOS()
        {
            //ESTA ES UNA INSTANCIA DE NUESTRO MODELO DE LA BASE DE DATOS
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from P in BD.PROVEEDORESPJs
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESPJ> BUSCARPORCODIGO(int codigo)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                /*USAMOS LINQ. PARA BUSCAR UN PROVEEDOR POR LA DIRECCIÓN
                EMPEZANDO CON CUALQUIER LETRA*/

             var INFO = BD.PROVEEDORESPJs.Where(X => X.CODIGOPROVEEDOR ==codigo ).ToList();

           //    var INFO = (from P in BD.PROVEEDORESPJs
          //                 where P.CODIGO_PROVEEDOR == codigo select P).ToList();
                
                return INFO;
            }
        }
        public static List<PROVEEDORESPJ> BUSCARNOMBRES(string nombres)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from P in BD.PROVEEDORESPJs
                            where P.NOMBRES.StartsWith(nombres)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESPJ> BUSCARPORAPELLIDOS(string apellidos)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from P in BD.PROVEEDORESPJs
                            where P.APELLIDOS.StartsWith(apellidos)
                            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESPJ> BUSCARPORDIRECCION(string direccion)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from P in BD.PROVEEDORESPJs

            where P.DIRECCION.StartsWith(direccion)
            select P).ToList();
                return INFO;
            }
        }
        public static List<PROVEEDORESPJ> BUSCARPORCIUDAD(string ciudad)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from P in BD.PROVEEDORESPJs
                            where P.CIUDAD.StartsWith(ciudad)
                            select P).ToList();
                return INFO;
            }
        }

       
            
            public void INSERTARPROVEEDOR
         (
        
         string nombres,
         string apellidos,
         string direccion,
        string ciudad,
        string telefono
         )
            {
                using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
                {

                BD.PROVEEDORESPJs.Add(new PROVEEDORESPJ
     {
     
         NOMBRES = nombres,
         APELLIDOS = apellidos,
         DIRECCION = direccion,
         CIUDAD = ciudad,
         TELEFONO= telefono
     });

                    BD.SaveChanges();
                }
                }


        public void MODIFICAR
     (
            int CODIGO,
     string nombres,
     string apellidos,
     string direccion,
    string ciudad,
    string telefono
     )
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var MODIFICAR = (from P in BD.PROVEEDORESPJs
                                 where P.CODIGOPROVEEDOR == CODIGO
                                 select P).Single();
                MODIFICAR.CODIGOPROVEEDOR = CODIGO;
                MODIFICAR.NOMBRES = nombres;
                MODIFICAR.APELLIDOS = apellidos;
                MODIFICAR.DIRECCION = direccion;
                MODIFICAR.CIUDAD = ciudad;

                BD.SaveChanges();


            }
        }
        public void ELIMINARPROVEEDOR(int CODIGO)
        {
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var ELIMINA = (from P in BD.PROVEEDORESPJs
                               where P.CODIGOPROVEEDOR == CODIGO
                               select P).Single();
                BD.PROVEEDORESPJs.Remove(ELIMINA);
                BD.SaveChanges();
            }
        }





    }
}

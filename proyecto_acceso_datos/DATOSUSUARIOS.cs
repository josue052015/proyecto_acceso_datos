using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_acceso_datos
{
    class DATOSUSUARIOS
    {
        public static List<USUARIOSPJ> MOSTRAR()
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from U in BD.USUARIOSPJs
                            select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSPJ> BUSCARPORUSUARIO(string usuario)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from U in BD.USUARIOSPJs
                            where U.USUARIO.StartsWith(usuario)
                            select U).ToList();
                return INFO;
            }
        }
        public static List<USUARIOSPJ> BUSCARPORCLAVE(string clave)
        {
            /*USAMOS LINQ. PARA BUSCAR UN USUARIO POR EL NOMBRE
            EMPEZANDO CON CUALQUIER LETRA*/
            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = (from U in BD.USUARIOSPJs
                            where U.CLAVE.StartsWith(clave)
                            select U).ToList();
                return INFO;
            }
        }
        
        /*
        public List<USUARIOSPJ> USUARIOACTUAL(string USUARIO_ACTUAL, string CONTRASEÑA_UACTUAL)
        {
            using (SCXPPJEntities BD = new SCXPPJEntities())
            {
                var INFO = BD.USUARIOSPJs. Where(X => X.USUARIO == USUARIO_ACTUAL).ToList();

                return INFO;
            }
        }
        */
        public List<USUARIOSPJ>BUSCAR_USUARIO_ACTUAL(string USUARIO_ACTUAL, string CONTRASEÑA_U_ACTUAL)
        {

            using (SCXPPJEntitiesPJ BD = new SCXPPJEntitiesPJ())
            {
                var INFO = BD.USUARIOSPJs.Where(X => X.USUARIO == USUARIO_ACTUAL && X.CLAVE == CONTRASEÑA_U_ACTUAL).ToList();
                return INFO;
            }
        }
     
    }
}

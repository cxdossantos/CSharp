using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Usuario entity)
        {
            contexto.Usuarios.Add(entity);
            contexto.SaveChanges();
        }

        public Usuario BuscarPorID(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Editar(Usuario entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Usuario usu = BuscarPorID(id);
            if(usu != null)
            {
                // 1a Forma
                //contexto.Entry(usu).State = System.Data.Entity.EntityState.Deleted;
                // 2a Forma
                contexto.Usuarios.Remove(usu);
            }
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            /*LINQ
            var usuarioComNome = from usu in contexto.Usuarios
                                 where usu.Nome == nome
                                 select usu;

            return usuarioComNome.ToList(); */

            /*LAMBDA*/
            return contexto.Usuarios.Where(Usuario => Usuario.Nome == nome).ToList();

        }

        public IList<Usuario> ListarTodos()
        {
            return contexto.Usuarios.ToList();
        }
    }
}

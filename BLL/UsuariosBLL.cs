using JuegoFinal.Data;
using JuegoFinal.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JuegoFinal.BLL
{
    public class UsuariosBLL
    {
        private Contexto contexto;

        public UsuariosBLL(Contexto _Contexto)
        {
            contexto = _Contexto;
        }

        public async Task<List<Usuarios>> GetList(Expression<Func<Usuarios, bool>> usuarios)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            try
            {
                Lista = await contexto.Usuarios.Where(usuarios).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }
    }
}

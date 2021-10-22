using EquiTool.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquiTool.Aplication
{
    public interface ITokenGmail
    {
        /// <summary>
        /// Métodos pertenecientes a la clase token
        /// </summary>
        /// <param name="token">Objeto/variable que se necesita para la utilización de los métodos</param>
        /// <returns>Booleano de acuerdo a si el método fue utilizado correctamente o no hubo errores</returns>
        public bool AddToken(tok_tokengmail token);

        public tok_tokengmail GetTokenUsuario(string userid);
    }
}

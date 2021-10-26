using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Equitool.Data;
using EquiTool.Aplication;
using EquiTool.infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;

namespace EquiTool.Domain
{
    public class Facturacion : IFacturacion
    {

        private readonly ApplicationDbContext _context;

        public Facturacion(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo para agregar a la base de datos una factura.
        /// </summary>
        /// <param name="facturacion">estructura de base de datos requeria para agregar</param>
        /// <returns>Retorna un booleano indicando si la operación fue exitosa</returns>
        public bool AddFacturacion(fac_facturacion facturacion)
        {
            try
            {
                var result = _context.fac_facturacion.Any(x => x.facn_id > 0);
                if (result)
                    facturacion.facn_id = (_context.fac_facturacion.ToList().LastOrDefault().facn_id + 1);
                else
                    facturacion.facn_id = 1;

                _context.fac_facturacion.Add(facturacion);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool deleteFacturacion(fac_facturacion borrar)
        {
            try
            {
                int registros = _context.fac_facturacion.ToList().Count();

                if (registros == 0)
                    return false;
                else
                {
                    var registroBorrar = _context.fac_facturacion.ToList().Find(x => x.facn_id == borrar.facn_id);
                    if (registroBorrar != null)
                    {
                        _context.fac_facturacion.Remove(registroBorrar);
                        _context.SaveChanges();
                        return true;
                    }
                    else
                        return false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updateFacturacion(fac_facturacion actualizar)
        {
            try
            {
                int registros = _context.fac_facturacion.ToList().Count();
                if (registros == 0)
                {
                    return false;
                }
                else
                {
                    var registroActualizar = _context.fac_facturacion.ToList().Find(x => x.facn_id == actualizar.facn_id);

                    if (registroActualizar != null)
                    {
                        registroActualizar.facc_descripcion = actualizar.facc_descripcion;
                        registroActualizar.facd_fechaactualizacion = DateTime.Now;
                        registroActualizar.facc_repositorio = actualizar.facc_repositorio;

                        _context.fac_facturacion.Update(registroActualizar);
                        _context.SaveChanges();
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<fac_facturacion> Adfacturas(List<fac_facturacion> facturasAgregar)
        {

            try
            {
                List<fac_facturacion> lista = new List<fac_facturacion>();

                var result = _context.fac_facturacion.Any(x => x.facn_id > 0);
                int fac_id = 0;
                if (result)
                    fac_id = (_context.fac_facturacion.ToList().LastOrDefault().facn_id + 1);
                else
                    fac_id = 1;
                int contador = 0;

                foreach (var factura in facturasAgregar)
                {
                    if (!_context.fac_facturacion.Any(x => x.facc_idcorreounico == factura.facc_idcorreounico))
                    {
                        factura.facn_id = (fac_id + contador);
                        _context.fac_facturacion.Add(factura);
                        lista.Add(factura);
                        contador += 1;
                    }
                }

                _context.SaveChanges();
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public List<fac_facturacion> GetFacturacion(string usuario)
        {
            List<fac_facturacion> lista = new List<fac_facturacion>();

            var registros = _context.fac_facturacion.Any(x => x.Aspnet_UserId == usuario);

            if (registros)
            {
                lista = _context.fac_facturacion.ToList().Where(x => x.Aspnet_UserId == usuario).ToList();

            }

            return lista;
        }


        public IdentityUser GetUserByEMail(string email)
        {
            try
            {
                IdentityUser userFind = null;

                if (_context.Users.Any(x => x.Email == email))
                    userFind = _context.Users.FirstOrDefault(x => x.Email == email);

                return userFind;
            }
            catch
            {
                throw;
            }
        }

        public string AddRol(string rol)
        {
            string strRespuesta = null;
            try
            {
                if (!_context.Roles.Any(x => x.Name.ToLower().Trim().Contains(rol.ToLower().Trim())))
                {
                    _context.Roles.Add(new IdentityRole()
                    {
                        ConcurrencyStamp = null,
                        Id = Guid.NewGuid().ToString(),
                        Name = rol.ToLower().Trim(),
                        NormalizedName = rol.ToLower().Trim()
                    });
                    _context.SaveChanges();
                    strRespuesta = "Rol adicionado correctamente";
                }
                else
                    strRespuesta = string.Concat("Ya existe un rol para: ", rol);
                return strRespuesta;
            }
            catch
            {

                throw;
            }
        }

        public string DeleteRol(string rol)
        {
            string strRespuesta = null;

            try
            {
                if (_context.Roles.Any(x => x.Name.ToLower().Trim().Contains(rol.ToLower().Trim())))
                {
                    var entityToRemove = _context.Roles.FirstOrDefault(x => x.Name.ToLower().Trim().Equals(rol.ToLower().Trim()));
                    _context.Roles.Remove(entityToRemove);

                    _context.SaveChanges();
                    strRespuesta = "Rol eliminado correctamente";
                }
                else
                    strRespuesta = string.Concat("No existe el: ", rol);
                return strRespuesta;

            }
            catch
            {

                throw;
            }
        }
    }
}

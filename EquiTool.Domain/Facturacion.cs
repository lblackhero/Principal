using System;
using System.Collections.Generic;
using System.Linq;
using Equitool.Data;
using EquiTool.Aplication;
using EquiTool.infrastructure;
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
                    factura.facn_id = (fac_id + contador);
                    _context.fac_facturacion.Add(factura);
                    lista.Add(factura);

                    contador += 1;
                }
                
                _context.SaveChanges();
                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}

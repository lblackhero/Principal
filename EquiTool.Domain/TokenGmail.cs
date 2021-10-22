using Equitool.Data;
using EquiTool.Aplication;
using EquiTool.Entities;
using EquiTool.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EquiTool.Domain
{
    public class TokenGmail : ITokenGmail
    {
        private readonly ApplicationDbContext _context;


        public TokenGmail(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddToken(tok_tokengmail token)
        {
            try
            {
                var result = _context.tok_tokengmail.Count();



                if (result > 0)
                {
                    var registro = _context.tok_tokengmail.ToList().Where(x => x.aspnet_userid == token.aspnet_userid);
                    if (registro != null)
                    {
                        DateTime ultimoRegistro = registro.LastOrDefault().tokd_fechacreacion;
                        if (DateTime.Now.Subtract(ultimoRegistro).Minutes > 25)
                        {

                            var registroBorrable = registro.LastOrDefault();

                            if (registroBorrable != null)
                            {
                                _context.tok_tokengmail.Remove(registroBorrable);
                            }

                            _context.tok_tokengmail.Add(token);

                            _context.SaveChanges();

                            return true;
                        }

                        else

                            return false;
                    }

                    else
                    {
                        _context.tok_tokengmail.Add(token);

                        _context.SaveChanges();

                        return true;
                    }

                }

                else
                {
                    _context.tok_tokengmail.Add(token);

                    _context.SaveChanges();

                    return true;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public tok_tokengmail GetTokenUsuario(string userid)
        {
            try
            {
                var result = _context.tok_tokengmail.ToList();
                if (result != null)
                {
                    var returntoken = result.Where(x => x.aspnet_userid == userid).FirstOrDefault();
                    return returntoken;
                }
                else
                {
                    return new tok_tokengmail();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}

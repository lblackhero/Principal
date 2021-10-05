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
                    DateTime ultimoRegistro = _context.tok_tokengmail.LastOrDefault().tokd_fechacreacion;
                    if (ultimoRegistro.Subtract(DateTime.Now).Minutes > 25)
                    {
                        _context.tok_tokengmail.Remove(_context.tok_tokengmail.LastOrDefault());

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
            catch (Exception)
            {
                throw;
            }
        }

    }
}

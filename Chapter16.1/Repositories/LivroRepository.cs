﻿using Chapter16._1.Contexts;
using Chapter16._1.Models;
using System.Collections.Generic;

namespace Chapter16._1.Repositories
{
    public class LivroRepository
    {
            private readonly SqlContext _context;
            public LivroRepository (SqlContext context)
            {
            _context = context;
            }
                public List <Livro> Listar()
            {
                return _context.Livros.ToList();
            }
    }
}

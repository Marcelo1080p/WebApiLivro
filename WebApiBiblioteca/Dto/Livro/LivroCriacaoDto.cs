﻿using WebApiBiblioteca.Dto.Vinculo;
using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }

    }
}

﻿using Dominio.Argumentos.Base;

namespace Dominio.Argumentos
{
    public class DisciplinaRequest : ArgumentoBase
    {
        public string Nome { get; set; }
        public int ProfessorId { get; set; }
        public int CursoId { get; set; }
    }
}

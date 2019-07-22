using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataEdicao { get; set; }
        public DateTime? DataExclusao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public bool TaskConcluida { get; set; }
        public bool TaskExcluida { get; set; }
    }
}

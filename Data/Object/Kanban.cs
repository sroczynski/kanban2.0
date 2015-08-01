using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Kanban
    {
        public List<Fases> Fases { get; set; }
        public List<TarefaIndex> Tarefas { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_manager_starter.Shared
{
    public sealed class PlayList
    {
        // created a playlist class with an id, name, and owner
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Owner { get; set; } = string.Empty;


    }
}

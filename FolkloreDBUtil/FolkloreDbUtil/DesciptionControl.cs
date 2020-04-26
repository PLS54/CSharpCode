using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolkloreOutaouais.Adhesions
{
    internal class DescriptionControl
    {
        internal string NomDuChamps { get; set; }
        internal string AliasDuChamp { get; set; }
        internal bool ChampEdite { get; set; }
        internal Type TypeOf { get; set; }
        internal DescriptionControl(string nomDuChamps, string alias)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = alias;
            ChampEdite = false;
            TypeOf = typeof(string);
        }
        internal DescriptionControl(string nomDuChamps, string alias, Type type)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = alias;
            ChampEdite = false;
            TypeOf = type;
        }
        internal DescriptionControl(string nomDuChamps)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = nomDuChamps;
            ChampEdite = false;
            TypeOf = typeof(string);
        }
        internal DescriptionControl(string nomDuChamps, Type type)
        {
            NomDuChamps = nomDuChamps;
            AliasDuChamp = nomDuChamps;
            ChampEdite = false;
            TypeOf = type;
        }
    }
}

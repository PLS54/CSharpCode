using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolkloreOutaouais.Adhesions
{
    public class StatusMembre
    {
        public string CodeDeStatus { get; private set; }
        public string Description { get; private set; }
        internal StatusMembre()
        {
        }
        internal StatusMembre(string codeDeStatus, string description)
        {
            CodeDeStatus = codeDeStatus;
            Description = description;
        }
        public override string ToString()
        {
            return Description;
        }
    }
}

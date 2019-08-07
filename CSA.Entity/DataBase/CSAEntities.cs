using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CSA.Entity.DataBase
{
    public class CSAEntities : DbContext
    {
        public CSAEntities() : base("CSAContext") { }

    }
}

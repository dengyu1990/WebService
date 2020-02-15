using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksService.Models
{
    public partial class QiubaoWorksEntities
    {
        public QiubaoWorksEntities(string password) : base("name=QiubaoWorksEntities")
        {
            this.Database.Connection.ConnectionString += $";Password={password}";
        }
    }
}
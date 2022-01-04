using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.TaskManager.API.Data.Configurations
{
    public class DataBaseConfig : IDataBaseConfig
    {
        public string DataBaseName { get ; set ; }
        public string ConnectionString { get; set; }
    }
}

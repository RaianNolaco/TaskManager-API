

namespace Projeto.TaskManager.API.Data.Configurations
{
    public interface IDataBaseConfig
    {

        string DataBaseName { get; set; }

        string ConnectionString { get; set; }

    }
}

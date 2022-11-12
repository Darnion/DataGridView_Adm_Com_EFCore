using Microsoft.EntityFrameworkCore.Design;

namespace DataGridView_Adm_Com
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        => new ApplicationContext(ConnectJSON.Option());
    }
}

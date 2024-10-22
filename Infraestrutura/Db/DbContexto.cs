using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Options;
using minimal_api.Domínio.Entidades;
namespace MinimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
    public DbSet<Administrador> Administradores { get ; set; } = default!;
    public DbSet<Veiculo> Veiculos { get ; set; } = default!;
    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
        new Administrador{
            Id =1 ,
            Email = "administrador@teste.com",
            Senha = "123456",
            Perfil = "Adm"
        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var stringConexao = _configuracaoAppSettings.GetConnectionString("ConexaoPadrao").ToString();
        
        optionsBuilder.UseSqlServer(
            stringConexao);
    
    }

}
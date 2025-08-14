using Commons.Data;

namespace CardManageApi.Cliente.Repository;

public class ClienteRepository
{
    public readonly EfDbContext _dbContext;

    public ClienteRepository(EfDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int Add(ClienteDto cliente)
    {
        var user = _dbContext.Clientes.FirstOrDefault(c => c.Email == cliente.Email);
        if (user != null)
        {
            throw new ArgumentException("Cliente com este email já existe.");
        }

        var clienteEntity = new Commons.Data.Models.Cliente
        {
            Email = cliente.Email,
            Nome = cliente.Nome,
            Password = cliente.Password
        };
        _dbContext.Clientes.Add(clienteEntity);
        _dbContext.SaveChanges();

        return clienteEntity.Id;
    }
}
using CardManageApi.Cliente.Repository;
using DevOne.Security.Cryptography.BCrypt;

namespace CardManageApi.Cliente.Service;

public class ClienteService
{
    public readonly ClienteRepository _clienteRepository;

    public ClienteService(ClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public void Validate(ClienteDto cliente)
    {
        if (string.IsNullOrWhiteSpace(cliente.Nome))
        {
            throw new ArgumentException("Nome do cliente é obrigatório.");
        }

        if (string.IsNullOrWhiteSpace(cliente.Email) || !cliente.Email.Contains("@"))
        {
            throw new ArgumentException("Email do cliente é inválido.");
        }

        if (string.IsNullOrWhiteSpace(cliente.Password) || cliente.Password.Length < 6)
        {
            throw new ArgumentException("Senha do cliente deve ter pelo menos 6 caracteres.");
        }

    }

    public bool Create(ClienteDto cliente)
    {
        cliente.Password = BCryptHelper.HashPassword(cliente.Password, BCryptHelper.GenerateSalt());
        _clienteRepository.Add(cliente);
        return true;
    }
}
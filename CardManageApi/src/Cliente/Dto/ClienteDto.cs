using CardManageApi.Cartao.Dto;

namespace CardManageApi.Cliente;

public record ClienteDto
{
    public string Nome { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public string Password { get; set; } = string.Empty;

}
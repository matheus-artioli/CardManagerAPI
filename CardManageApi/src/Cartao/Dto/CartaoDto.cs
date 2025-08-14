using CardManageApi.Cliente;

namespace CardManageApi.Cartao.Dto;

public record CartaoDto
{
    public string Numero { get; init; } = string.Empty;
    public string NomeTitular { get; init; } = string.Empty;
    public DateTime DataExpiracao { get; init; }
    public string CodigoSeguranca { get; init; } = string.Empty;

    public ClienteDto Cliente { get; init; } = new ClienteDto();
}
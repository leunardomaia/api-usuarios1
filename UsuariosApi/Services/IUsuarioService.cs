using UsuariosApi.Data.Dtos;

namespace UsuariosApi.Services
{
    public interface IUsuarioService
    {
        Task Cadastra(CreateUsuarioDto dto);
        Task<string> Login(LoginUsuarioDto dto);
    }
}
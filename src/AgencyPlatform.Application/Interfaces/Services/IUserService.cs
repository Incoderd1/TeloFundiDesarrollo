﻿using AgencyPlatform.Application.DTOs.Usuarios;
using AgencyPlatform.Core.Entities;
using AgencyPlatform.Core.Enums;

namespace AgencyPlatform.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<usuario> RegisterUserAsync(string email, string password, string tipoUsuario, string? phone = null);
        Task<(List<usuario> Usuarios, int Total)> GetAllUsersPagedAsync(int pagina, int elementosPorPagina); // Nuevo método

        Task<(string AccessToken, string RefreshToken)> LoginUserAsync(string email, string password, string ipAddress, string userAgent);

        Task<string> RefreshTokenAsync(string refreshToken, string ipAddress, string userAgent);

        Task RequestPasswordResetAsync(string email);
        Task ResetPasswordAsync(string token, string newPassword);

        Task<usuario> GetUserByIdAsync(int id);
        Task<List<usuario>> GetAllUsersAsync();
        Task UpdateUserAsync(int id, string email, string? phone, bool estaActivo);
        Task DeleteUserAsync(int id);
        Task NotificarAdminDeSolicitudAgenciaAsync();
        Task<UsuarioDto> GetByIdAsync(int id);




        //Acompanantes

        // Nuevo método para registro combinado de usuario y acompañante
        // Nuevo método para registro combinado de usuario y acompañante
        Task<(usuario Usuario, int AcompananteId)> RegisterUserAcompananteAsync(
            string email,
            string password,
            string telefono,
            string nombrePerfil,
            string genero,
            int edad,
            string? descripcion = null,
            string? ciudad = null,
            string? pais = null,
            string? disponibilidad = "Horario flexible",
            decimal? tarifaBase = null,
            string? moneda = "USD",
            List<int>? categoriaIds = null,
            string? whatsapp = null,
            string? emailContacto = null,
            int altura = 160,
            int peso = 60,
            string idiomas = "Español",
            string clientIp = null);  // oculto, fijo
    

    }
}

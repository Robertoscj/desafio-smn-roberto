using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAppRoberto2.Data
{
    public static class DbInitializer
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<Usuario>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync("Gestor"))
            {
                await roleManager.CreateAsync(new IdentityRole("Gestor"));
            }

            if (!await userManager.Users.AnyAsync())
            {
                var gestor = new Usuario
                {
                    UserName = "oportunidades@smn.com.br",
                    Email = "oportunidades@smn.com.br",
                    Nome = "Gestor Padrão",
                    DataNascimento = new DateTime(1980, 1, 1),
                    TelefoneFixo = "(11) 4002-8922",
                    TelefoneCelular = "(11) 99999-9999",
                    Endereco = "Rua dos Pastéis, 123 - São Paulo, SP"
                };

                await userManager.CreateAsync(gestor, "teste123");
                await userManager.AddToRoleAsync(gestor, "Gestor");
            }
        }
    }
}
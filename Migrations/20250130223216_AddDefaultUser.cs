using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_app_roberto.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Usuarios (Nome, Email, Senha, TelefoneFixo, TelefoneCelular, Endereco, Foto) 
                VALUES ('Admin', 'admin@example.com', '123456', '0000-0000', '99999-9999', 'Endereço Padrão', 'default.jpg');
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Usuarios WHERE Email = 'admin@example.com';");
        }
    }
}

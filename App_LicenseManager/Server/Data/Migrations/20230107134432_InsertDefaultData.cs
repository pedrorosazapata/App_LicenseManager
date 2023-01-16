using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLicenseManager.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class InsertDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Insert Data in AspNetUsers
            migrationBuilder.Sql($@" 
               
                INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], 
                                            [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], 
                                            [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) 
                             VALUES (N'ae57f1e3-4998-468a-9ff2-0c31ca1049dd', N'pedrorosa0604@gmail.com', 
                                     N'PEDROROSA0604@GMAIL.COM', N'pedrorosa0604@gmail.com', N'PEDROROSA0604@GMAIL.COM', 1, 
                                     N'AQAAAAIAAYagAAAAEOTDfpuJEKdS84/emIs3X5Pp0v7k74iT7/hYP/Sl0VP+PgP8clqLWg9Q/vFqiPz9Fg==', 
                                     N'4EY5FRJT6AHMMFMG3EKUQA6CYQUGV6JM', N'e6037072-cf59-4db9-923f-87852036b51a', NULL, 0, 0, 
                                     NULL, 1, 0)");
            //Insert Data in AspNetRoles
            migrationBuilder.Sql($@"
                        INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'ADMINISTRADOR', N'ADMINISTRADOR', N'ADMINISTRADOR', 
                                 N'60595c9d-275a-4305-b4f1-1f964dc7b8c3')
                        GO 
                        INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'USUARIOMAESTRO', N'USUARIOMAESTRO', N'USUARIOMAESTRO', 
                                 N'657636f0-aca5-497d-8535-8a04ef60d63d')");
            //Insert Data in AspNetUserRoles
            migrationBuilder.Sql($@"
                INSERT[dbo].[AspNetUserRoles]([UserId], [RoleId]) 
                  VALUES (N'ae57f1e3-4998-468a-9ff2-0c31ca1049dd', N'USUARIOMAESTRO')");
                

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

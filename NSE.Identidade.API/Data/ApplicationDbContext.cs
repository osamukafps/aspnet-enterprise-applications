using System;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NSE.Identidade.API.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}


		public static void TestConnection(string connectionString)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					Console.WriteLine($"Conexão aberta com sucesso!" +
					              $"Database: {connection.Database} connected!");
					connection.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
				}
			}
		}
	}
}


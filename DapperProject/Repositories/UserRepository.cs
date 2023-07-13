using System.Data;
using System.Data.Common;
using Dapper;
using DapperProject.Models;
using Microsoft.Data.SqlClient;

namespace DapperProject.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"
            select
                [User].*,
                [Role].*
            from
                [User]
            left join   
                [UserRole] on [UserRole].[UserId] = [User].[Id]
            left join
                [Role] on [UserRole].[RoleId] = [Role].[Id]
            ";

            var users = new List<User>();

            var items = _connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user; // Se nao encontramos o user vai ser igual ao objeto que passamos
                        if (role != null)
                            usr.Roles.Add(role); // Se ele ta vazio ele nao tem nenhuma role entao podemos adicionar
                        users.Add(usr); // Adicionamos ele a lista de usuarios
                    }
                    else // Se ja existe
                    {
                        usr.Roles.Add(role); // So adicionamos o role pra ele
                    }
                    return user;
                }, splitOn: "Id" // Divide com base no Id, quando chegar no segundo ID vai ser o role
            );

            return users;
        }
    }
}
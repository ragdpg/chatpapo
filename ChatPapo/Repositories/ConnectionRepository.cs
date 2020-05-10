using System.Collections.Generic;
using System.Linq;
using ChatPapo.Models;

namespace ChatPapo.Repositories
{
    public class ConnectionRepository
    {
        private readonly Dictionary<string, User> connections = new Dictionary<string, User>();

        public void Add(string uniqueId, User user)
        {
            if(!connections.ContainsKey(uniqueId))
                connections.Add(uniqueId, user);
        }

        public string GetUserId(long id)
        {
            return (from con in connections where con.Value.key == id select con.Key).FirstOrDefault();
        }

        public List<User> GetAllUsers()
        {
            return (from con in connections select con.Value).ToList();
        }
    }
}
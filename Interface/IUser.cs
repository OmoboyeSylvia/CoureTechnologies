using CoureTechnologies.Models;
using System.Collections;

namespace CoureTechnologies.Interface
{
    public interface IUser
    {
        Task <IEnumerable> UserCheck (User user);
    }
}

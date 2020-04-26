using EmpregosYoyotaAPI.Models;

namespace EmpregosYoyotaAPI.Repository
{
    public interface IMessageRepository
    {
         void Add(Message message);

         IEnumerable<Message> GetAll();

         Message Find(long id);

         void Remove(long id);

         void Update(Message message);
    }
}
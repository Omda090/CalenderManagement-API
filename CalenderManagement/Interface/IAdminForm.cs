using CalenderManagement.DTOs;
using CalenderManagement.Models;

namespace CalenderManagement.Interface
{
    public interface IAdminForm
    {
        Task<IEnumerable<AdminForm>> GetAllevent();

        Task<AdminForm> GetById(int id);

        //  Task<AdminForm> CreateEvent(AdminFormDto adminFormDto);

        //  void Remove(AdminForm adminForm);

        //  Task<bool> SaveChanges();

        void Add(AdminForm entity);
        Task<bool> SaveChanges();
        Task<bool> SaveAll();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieQueuee.Model
{
    public interface IMenu<T>
    {
        List<T> GetAllMenuItems();
        T GetMenuItemById(int id);
        void AddMenuItem(T item);
        void UpdateMenuItem(T item);
        void DeleteMenuItem(int id);


    }
}
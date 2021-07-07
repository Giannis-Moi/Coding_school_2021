
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCustomer.Model;

namespace CodingWebApp.Services
{
    public interface IItemStorage
    {
        public void AddItem(Customer customer);
        public void RemoveItem(int id);
        public List<Customer> GetAllItems();
        public Customer GetById(int id);
    }

        public class MemoryItemStorage : IItemStorage
        {
            private List<Customer> innerList { get; set; }

            public MemoryItemStorage()
            {
                innerList = new List<Customer>();
            }

            public void AddItem(Customer customer)
            {
                if (customer.Id == 0)
                {
                customer.Id = innerList.Count + 1;
                    innerList.Add(customer);
                    return;
                }

                var selectedItem = GetById(customer.Id);
                selectedItem.Surname = customer.Surname;
                selectedItem.Name = customer.Name;
                selectedItem.AFM = customer.AFM;
                selectedItem.Active = customer.Active;

        }

            public List<Customer> GetAllItems()
            {
                return innerList;
            }

            public Customer GetById(int id)
            {
                return innerList.FirstOrDefault(item => item.Id == id);
            }

            public void RemoveItem(int id)
            {
                var selectedItem = GetById(id);
                if (selectedItem == null)
                    throw new Exception(string.Format("Item with id '{0}' was not found.", id));

                innerList.Remove(selectedItem);
            }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCustomer.Model;

namespace WebApplicationCustomer.Pages
{
    public class ListModel : PageModel
    {
        public List<Customer> Items = new List<Customer>();

        private IItemStorage _storage { get; set; }

        public ListModel(IItemStorage storage) {
            _storage = storage;
        }

        public void OnGet() {
            Items = _storage.GetAllItems();
        }
    }
}


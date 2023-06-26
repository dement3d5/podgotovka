using podgotovka.DB;
using podgotovka.Models;
using podgotovka.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace podgotovka.VM
{
    public class ListPizzaVM : BaseVM
    {
     
        public List<Pizza> pizzas { get; set; }
        private Pizza listPizza;
        public Pizza ListPizza
        {
            get => listPizza;
            set
            {
                listPizza = value;
                Signal();
            }
        }

        public Pizza pizza { get; set; }

        public ListPizzaVM()
        {
            using (var db = new user1Context())
            {
               
                pizzas = db.Pizzas.ToList();
            }
          

        }


       
    }
}

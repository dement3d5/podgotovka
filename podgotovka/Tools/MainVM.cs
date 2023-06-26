using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace podgotovka.Tools
{
    public class MainVM : BaseVM
    {
        public Page currentPage;
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                Signal();
            }
        }
        public CommandVM Pizza1 { get; set; }
        public MainVM()
        {

            Pizza1 = new CommandVM(() =>
            {
                CurrentPage = new Piza();
            });


        }
    }
}

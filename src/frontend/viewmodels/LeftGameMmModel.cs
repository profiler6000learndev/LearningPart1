using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace frontend.viewmodels
{
    class LeftGameMmModel : BaseModel
            {
        public MenuItem _item { get; }
        public ObservableCollection<MenuItem> Items = new ObservableCollection<MenuItem>();
            
    
        public LeftGameMmModel()
        {
             _item = new MenuItem() { Header = null };
            Items.Add(_item);
        }
        

    }
}

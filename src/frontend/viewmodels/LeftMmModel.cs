using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.viewmodels
{
    public class LeftMmModel : BaseModel
    {
        public ObservableCollection<string> ButtonTextItem { get; set; }

        public LeftMmModel()
        {
            ButtonTextItem = new ObservableCollection<string>
            {
              "Neues Spiel",
              "Spiel Laden",
                "Einstellungen",
                "Anleitung",
                "Patchnotes",
            };
        }

    }
}

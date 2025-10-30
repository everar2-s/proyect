using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace CalcuNotifyChange {

    [AddINotifyPropertyChangedInterface]
    internal class MainPageViewModel {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }

        public ICommand SumarCommand => new Command(() => {
            Result = Num1 + Num2;
        });
     }
    }

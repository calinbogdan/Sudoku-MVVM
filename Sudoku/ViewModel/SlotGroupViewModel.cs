using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.ViewModel
{
    public class SlotGroupViewModel : ViewModelBase
    {
        private readonly SlotViewModel[,] _slotsViewModels = new SlotViewModel[3, 3];
    }
}

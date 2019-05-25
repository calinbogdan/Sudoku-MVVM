using System.Windows.Controls;

namespace Sudoku
{
    /// <summary>
    /// Interaction logic for SlotView.xaml
    /// </summary>
    public partial class SlotView : UserControl
    {
        public int SlotValue { get; set; }

        public SlotView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}

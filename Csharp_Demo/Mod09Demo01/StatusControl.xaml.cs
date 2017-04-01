using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod09Demo01
{
    /// <summary>
    /// Interaction logic for StatusControl.xaml
    /// </summary>
    public partial class StatusControl : UserControl
    {
        public StatusControl()
        {
            InitializeComponent();
        }
        public CustomerStatusEnum Status
        {
            get
            {
                if (Silver.IsChecked.Value) { return CustomerStatusEnum.Silver; }
                if (Gold.IsChecked.Value) { return CustomerStatusEnum.Gold; }
                return CustomerStatusEnum.Platinum;
            }
            set
            {
                RadioButton selected = (value == CustomerStatusEnum.Silver ? Silver : value == CustomerStatusEnum.Gold ? Gold : Platinum);
                selected.IsChecked = true;
            }
        }
        public enum CustomerStatusEnum
        {
            Silver,
            Gold,
            Platinum
        }
        public event EventHandler SelectionChanged;

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            RadioButton active = e.OriginalSource as RadioButton;
            if ((active != null) && (SelectionChanged != null))
            {
                SelectionChanged(this, new EventArgs());
            }
        }
    }
}


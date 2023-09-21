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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UcWorker.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;

            LbId.Content += worker.Id;

            LbBday.Content += worker.BDate.ToShortDateString();

            if(DateTime.Today.Month.Equals(worker.BDate.Month) && DateTime.Today.Day.Equals(worker.BDate.Day))
            {
                LbBday.Content += "🎁🎁🎁";
            }


            if (worker is GeneralManager)
            {
                LbRole.Content += "General Manager";
                brMain.Background = Brushes.Gold;
            }
            else if (worker is OperationManager)
            {
                LbRole.Content += "Operation Manager";
                brMain.Background = Brushes.Silver;
            }
            else
                LbRole.Content += "Operational Worker";
        }
    }
}

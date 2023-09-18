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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            GatherTeam();
            CreateRobots();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }

        private List<Worker> GatherTeam()
        {
            workers = new List<Worker>();

            workers.Add(new GeneralManager("Moshiko", "22222221", DateTime.Parse("06/09/1969"), "imCoolBoy12#", 100000000000000000));
            workers.Add(new OperationManager("moshe", "11111112", DateTime.Parse("1/4/1994"), "eldadyBoy12", 10000, 400));
            workers.Add(new OperationManager("moshik", "12112112", DateTime.Parse("7/8/1984"), "ELDADDDD1212", 10000, 400));
            workers.Add(new OperationalWorker("Yosef", "11111111", DateTime.Parse("1/1/1991"), "eldadIsEldad1", 10, 1000));
            workers.Add(new OperationalWorker("Bob", "1123411", DateTime.Parse("1/2/1981"), "SismaEldad", 10, 1000));
            workers.Add(new OperationalWorker("Omer", "33221123", DateTime.Parse("8/11/1981"), "PAssEldad111", 10, 1000));

            return workers;
        }
        private List<RobotSpy> CreateRobots()
        {
            activeRobots = new List<RobotSpy>();

            activeRobots.Add(new RobotQuad(DateTime.Now, 100));
            activeRobots.Add(new RobotQuad(DateTime.Now, 100));
            activeRobots.Add(new RobotQuad(DateTime.Now, 100));
            activeRobots.Add(new RobotFly(DateTime.Now, 100));
            activeRobots.Add(new RobotFly(DateTime.Now, 100));
            activeRobots.Add(new RobotFly(DateTime.Now, 100));
            activeRobots.Add(new RobotWheels(DateTime.Now, 100));
            activeRobots.Add(new RobotWheels(DateTime.Now, 100));
            
            return activeRobots;
        }




        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       

        private List<Mission> CreateMissionList()
        {
            activeMissions = new List<Mission>();

            activeMissions.Add(new Mission(DateTime.Parse("1/4/2024"), "create at least 7 more robots"));
            activeMissions.Add(new Mission(DateTime.Parse("2/4/2024"), "destroy at least 7 robots"));
            activeMissions.Add(new Mission(DateTime.Parse("3/4/2024"), "make a new feature to robotwheels"));
            activeMissions.Add(new Mission(DateTime.Parse("5/4/2024"), "make a new feature to robotQuad"));
            activeMissions.Add(new Mission(DateTime.Parse("6/4/2024"), "Repeat"));

            return activeMissions;
        }


        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            foreach (Worker w in workers)
            {
                if (tbxID.Text.Equals(w.GetIdNumber()) && tbxPassword.Password.Equals(w.GetPassword()))
                {
                    WndMain main = new WndMain(w, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                }
            }
            
          
        }
    }
}

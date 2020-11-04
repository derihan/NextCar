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

namespace NextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;
        public MainWindow()
        {
            InitializeComponent();
            AccubatteryController accubatteryController = new AccubatteryController();
            DoorControllers doorControllers = new DoorControllers();
            nextCar = new Car();
            nextCar.setAccubatteryController(accubatteryController);
            nextCar.setDoorController(doorControllers);
        }

        private void OnAccuButtonClikced(object sender, RoutedEventArgs e) {
            Boolean powerIsOn = nextCar.powerIsReady();

            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "No Power";
                this.AccuButton.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "Power is ready";
                this.AccuButton.Content = "On";
            }
        
        }

        private void OnDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean doorStatue = nextCar.doorIsOpen();
           
            if (doorStatue)
            {
                this.nextCar.doorIsUnlock();
                this.DoorState.Content = "Door is unlocked";
                this.DoorButton.Content = "OFF";
                
            }
            else
            {
                this.nextCar.doorIsLocked();
                this.DoorState.Content = "Door is locked";
                this.DoorButton.Content = "ON";
                
            }
        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
         
        }

        private void AccuButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

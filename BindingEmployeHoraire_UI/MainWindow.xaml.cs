using BindingEmployeHoraire_Affaires;
using System.Windows;
using System.Windows.Controls;

namespace BindingEmployeHoraire_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeHoraire _employe;
        public MainWindow()
        {
            InitializeComponent();
            _employe = new EmployeHoraire("Adam Bernard", 10.00m);
        }

        private void AjouterHeures_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            string chaine = b.Content.ToString().Split()[1];
            _employe.ajouterHeures(int.Parse(chaine));
        }
    }
}

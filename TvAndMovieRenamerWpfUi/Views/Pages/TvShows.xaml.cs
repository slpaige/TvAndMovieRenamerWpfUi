using System.Windows;
using System.Windows.Controls;

namespace TvAndMovieRenamerWpfUi.Views.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class TvShows : Page
    {
        public TvShows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //var parent = Window.GetWindow(this);
            var parent = App.Current.MainWindow;
            
            var modal = new Modal();
            modal.Top = parent.Top + 100;
            modal.Left = parent.Left + 100;
            //modal.Show();
            modal.ShowDialog();
        }
    }
}
using System.Diagnostics;
using GameFileBook.Domain;

namespace GameFileBook
{
    public partial class Games
    {
        public Games()
        {
            DataContext = new GamesViewModel();
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
            => Debug.WriteLine("Just checking we haven't suppressed the button.");

        private void PopupBox_OnOpened(object sender, RoutedEventArgs e)
            => Debug.WriteLine("Just making sure the popup has opened.");

        private void PopupBox_OnClosed(object sender, RoutedEventArgs e)
            => Debug.WriteLine("Just making sure the popup has closed.");

        private void CountingButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (CountingBadge.Badge == null || Equals(CountingBadge.Badge, string.Empty))
                CountingBadge.Badge = 0;

            var next = int.Parse(CountingBadge.Badge.ToString() ?? "0") + 1;

            CountingBadge.Badge = next < 21 ? (object)next : null;
        }
    }
}
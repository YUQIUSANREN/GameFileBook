using GameFileBook.Domain;

namespace GameFileBook
{
    public partial class ThemeSettings
    {
        public ThemeSettings()
        {
            DataContext = new ThemeSettingsViewModel();
            InitializeComponent();
        }
    }
}

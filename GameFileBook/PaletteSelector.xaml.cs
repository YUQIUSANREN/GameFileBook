using GameFileBook.Domain;

namespace GameFileBook
{
    public partial class PaletteSelector
    {
        public PaletteSelector()
        {
            DataContext = new PaletteSelectorViewModel();
            InitializeComponent();
        }
    }
}

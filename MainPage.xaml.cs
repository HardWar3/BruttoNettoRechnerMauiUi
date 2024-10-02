namespace BruttoNettoRechnerMauiUi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // TODO later check for updates
            // upcoming FIX #9150
            steuerklasse.SelectedIndex = 0;
            bundesland.SelectedIndex = 0;
            abrechungsjahr.SelectedIndex = 0;
            kinderfreibetrag.SelectedIndex = 0;
            krankenversicherung.SelectedIndex = 0;
            rentenversicherung.SelectedIndex = 0;
        }

        private void whenChildren(object sender, CheckedChangedEventArgs e)
        {
            if (radioButton_yesChildren.IsChecked)
            {
                layout_kinderfreibetrag.IsVisible = true;
            }
            else
            {
                layout_kinderfreibetrag.IsVisible = false;
            }
        }
        
        private void whenHealthInsuranceChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == 1)
            {
                layout_private_versicherungsbeitrag.IsVisible = true;
            } else
            {
                layout_private_versicherungsbeitrag.IsVisible = false;
            }
        }
    }

}

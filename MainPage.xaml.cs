﻿namespace BruttoNettoRechnerMauiUi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // lösung für contentpage höhe ändert sich durch
            // durch optionen auto resize

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
        private void only_Numbers(object sender, TextChangedEventArgs e)
        {
            var element = (Editor)sender;


            var text = element.Text;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c < '0' || c > '9')
                {
                    element.Text = text.Remove(i, 1);
                    break;
                } 
            }
        }
    }

}

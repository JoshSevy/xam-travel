using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class Homepage : TabbedPage
    {
        public Homepage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}

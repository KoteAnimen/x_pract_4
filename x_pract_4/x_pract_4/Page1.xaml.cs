using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace x_pract_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            frame1.IsEnabled = false;
        }

        private void rbt_Auto_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbt_Auto.IsChecked)
            {
                frame1.IsEnabled = true;
            }
        }
    }
}
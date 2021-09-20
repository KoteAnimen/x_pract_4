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
    public partial class Page2 : ContentPage
    {
        YearParts year;
        public Page2()
        {
            InitializeComponent();
            frame2.IsEnabled = false;
            year = new YearParts();
        }

        private void btn_Accept_Clicked(object sender, EventArgs e)
        {
            try
            {
                etr_FieldPartYear2.Text = year.GivePart(etr_FieldMonth2.Text);
            }
            catch
            {
                etr_FieldPartYear2.Text = "Такого месяца нет в базе";
            }
        }

        private void rbt_Hand_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbt_Hand.IsChecked)
            {
                frame2.IsEnabled = true;
            }
            else
            {
                frame2.IsEnabled = false;
            }
        }
    }
}
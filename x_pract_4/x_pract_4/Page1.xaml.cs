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
        YearParts year;

        public Page1()
        {
            InitializeComponent();
            rbt_AutoOn.IsChecked = true;
            year = new YearParts();
        }

        private void rbt_AutoOn_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (rbt_AutoOn.IsChecked)
            {
                frame1.IsEnabled = true;
            }
            else
            {
                frame1.IsEnabled = false;
            }
        }        

        private void etr_FieldMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                etr_FieldPartYear.Text = year.GivePart(etr_FieldMonth.Text);
            }
            catch
            {
                etr_FieldPartYear.Text = "Такого месяца нет в базе";
            }
            
        }
    }
}
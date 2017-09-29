using Xamarin.Forms;

namespace MyAppplications
{
    public partial class MyAppplicationsPage : ContentPage
    {
        public MyAppplicationsPage()
        {
            InitializeComponent();
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            salary.ValueChanged += Salary_ValueChanged;
        }

        void Salary_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}

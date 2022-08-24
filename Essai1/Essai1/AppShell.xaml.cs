
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Essai1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}
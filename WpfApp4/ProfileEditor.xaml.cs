using System.Windows.Controls;

namespace WpfApp4;

/// <summary>
/// Interaction logic for ProfileEditor.xaml
/// </summary>
public partial class ProfileEditor : UserControl
{
    public ProfileEditor(bool? useINotifyPropertyChangedViewModel)
    {
        InitializeComponent();
        DataContext = useINotifyPropertyChangedViewModel == true ? 
            new ProfileSettingsViewModelWithInterface() : 
            new ProfileSettingsViewModel();
    }
}

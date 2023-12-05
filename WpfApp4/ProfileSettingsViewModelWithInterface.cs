using System;
using System.ComponentModel;

namespace WpfApp4
{
    internal class ProfileSettingsViewModelWithInterface : INotifyPropertyChanged
    {
        private byte[] largeAllocation;

        public ProfileSettingsViewModelWithInterface()
        {
            myValue = "hello";
            largeAllocation = new byte[1024 * 1024 * 128];

            Random r = new Random();
            r.NextBytes(largeAllocation);
        }

        private string myValue;
        public string MyValue
        {
            get => myValue;
            set
            {
                if (myValue == value) return;

                myValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyValue)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

using System;

namespace WpfApp4
{
    internal class ProfileSettingsViewModel
    {
        private byte[] largeAllocation;

        public ProfileSettingsViewModel()
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
                MyValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler MyValueChanged;
    }
}

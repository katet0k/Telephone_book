using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone_book
{
    public class Contact : INotifyPropertyChanged
    {
        private string ?_fullName;
        private string ?_address;
        private string ?_phoneNumber;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                    _address = value;
                    OnPropertyChanged(nameof(Address));
                
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                
            }
        }
        public Contact(string? fullName, string? address, string? phoneNumber)
        {
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

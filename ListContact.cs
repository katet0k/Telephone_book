using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Telephone_book
{
    public class ListContact : INotifyPropertyChanged
    {
       public List<Contact>? contacts = null;
        private Contact selectedContact;

        public Contact SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

       public ListContact()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts?.Add(contact);
        }
        public void RemoveContact(Contact contact)
        {
            contacts?.Remove(contact);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

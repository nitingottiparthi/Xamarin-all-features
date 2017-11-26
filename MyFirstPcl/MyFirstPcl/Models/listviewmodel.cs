using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPcl.Models
{
   public class listviewmodel:INotifyPropertyChanged
    {
        public string name { get; set; }
        public int Id { get; set; }

        string _Branch;
        public string Branch {
        get
            {
                return _Branch;
            }
            set
            {
                _Branch = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Branch"));
            }
        }
        public int Result{ get; set; }
        public string Student { get; set; }
        public string Subject { get; set; }
        public string Tutor { get; set; }
        public string FirstRank { get; set; }
        public int Total { get; set; }
        public string Sports { get; set; }
        public string Hod { get; set; }
        public string Principal { get; set; }

        string _backColor = "White";
        public string BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BackColor"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

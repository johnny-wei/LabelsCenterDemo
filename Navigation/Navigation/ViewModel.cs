using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Navigation
{
   public class labelResult : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int _total;
        public int Total {
            get { return _total; }
            set {
                if (_total != value) {
                    _total = value;
                    //触发事件
                    RaisePropertyChanged("Total");
                }
            }
        }
        public List<LabelBean> _Labels;
        public List<LabelBean> Labels
        {
            get
            {
                return _Labels;
            }
            set
            {
                if (_Labels != value)
                {
                    _Labels = value;
                    RaisePropertyChanged("Labels");
                }
            }
        }
        public labelResult()
        {
            Labels = new List<LabelBean>();
        }
        public void RaisePropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

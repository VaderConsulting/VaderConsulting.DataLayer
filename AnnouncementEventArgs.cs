using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VaderConsulting.DataLayer
{
    public class AnnouncementEventArgs : EventArgs
    {
        private string _Text = "";
        private DateTime _Time = DateTime.Now;
        private object _RelatedObject = null;

        public AnnouncementEventArgs(string Text, object RelatedObject)
        {
            _Text = Text;
            _RelatedObject = RelatedObject;
        }

        public string Text
        {
            get
            {
                return _Text;
            }
        }

        public DateTime Time
        {
            get
            {
                return _Time;
            }
        }

        public object RelatedObject
        {
            get
            {
                return _RelatedObject;
            }
            set
            {
                _RelatedObject = value;
            }
        }

    }
}

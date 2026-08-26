using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VaderConsulting.Dependency;
using VaderConsulting.Helper;

namespace VaderConsulting.DataLayer
{
    public class DataLayer
    {
        #region Classes

        public class ObjectChanges
        {
            // This breaks my normal convention of creating Classes inside their own file, 
            // but in this instance 'ObjectChanges' 100% belongs here

            #region Fields

            private string _TimeStampID = "";
            private string _DateCreated = "";    // Saved as a string to allow milliseconds from SQL to be captured
            private int _CreatedBy = -1;
            private string _LastModified = "";   // Saved as a string to allow milliseconds from SQL to be captured
            private int _LastModifiedBy = -1;
            private string _LastValidDate = "";  // Saved as a string to allow milliseconds from SQL to be captured
            private string _LastValidStatus = "";
            private string _Username = "";
            private string _ObjectName = "[UNKNOWN OBJECT]";

            #endregion

            #region Properties

            public string TimeStampID
            {
                get
                {
                    return _TimeStampID;
                }
                set
                {
                    _TimeStampID = value;
                }
            }

            public string DateCreated
            {
                get
                {
                    return _DateCreated;
                }
                set
                {
                    _DateCreated = value;
                }
            }

            public int CreatedBy
            {
                get
                {
                    return _CreatedBy;
                }
                set
                {
                    _CreatedBy = value;
                }
            }

            public string LastModified
            {
                get
                {
                    return _LastModified;
                }
                set
                {
                    _LastModified = value;
                }
            }

            public int LastModifiedBy
            {
                get
                {
                    return _LastModifiedBy;
                }
                set
                {
                    _LastModifiedBy = value;
                }
            }

            public string LastValidDate
            {
                get
                {
                    return _LastValidDate;
                }
                set
                {
                    _LastValidDate = value;
                }
            }

            public string Username
            {
                get
                {
                    return _Username;
                }
                set
                {
                    _Username = value;
                }
            }

            public string ObjectName
            {
                get
                {
                    return _ObjectName;
                }
                set
                {
                    _ObjectName = value;
                }
            }

            public string LastValidStatus
            {
                get
                {
                    return _LastValidStatus;
                }
                set
                {
                    _LastValidStatus = value;
                }
            }

            #endregion
        }

        #endregion

        #region Delegates

        public delegate void AnnouncementEventHandler(object Sender, VaderConsulting.DataLayer.AnnouncementEventArgs e);

        #endregion

        #region Events

        public event AnnouncementEventHandler AnnouncementHandler;

        #endregion

        #region Fields

        private List<VaderConsulting.Helper.Attribute> _Attributes = new List<VaderConsulting.Helper.Attribute>();

        #endregion

        #region Constructors

        public DataLayer()
        {
            
        }

        #endregion

        #region Properties

        public List<VaderConsulting.Helper.Attribute> Attributes
        {
            get
            {
                return _Attributes;
            }

            set
            {
                _Attributes = value;
            }
        }

        #endregion

        #region How to consume events

        //private void iServer_AnnouncementReceived(object Sender, VaderConsulting.DataLayer.AnnouncementEventArgs e)
        //{
        //    Debug.WriteLine(e.Message);
        //}

        //iServer iServer = new VaderConsulting.Orbus.iServer();

        //iServer.RaiseAnnouncement += new VaderConsulting.Orbus.iServer.AnnouncementEventHandler(iServer_AnnouncementReceived); // Add connection to NewMessage event of iServer object
        

        //iServer.AddAttribute(new VaderConsulting.Orbus.Attribute("Name","Value","Tag"));

        #endregion

        #region Public Methods

        public virtual List<BusinessApplication> GetBusinessApplications()
        {
            List<BusinessApplication> Results = new List<BusinessApplication>();

            return Results;
        }

        public void AddAttribute(VaderConsulting.Helper.Attribute Attribute)
        {
            _Attributes.Add(Attribute);

            RaiseAnnouncement("New attribute added", null);  // <-- how to raise an event
        }

        #endregion

        #region Event creation methods

        public virtual void RaiseAnnouncement(string Text, object RelatedObject) // Call this method to raise the 'Announcement' Event
        {
            AnnouncementEventHandler Raiser = AnnouncementHandler;

            VaderConsulting.DataLayer.AnnouncementEventArgs e = new VaderConsulting.DataLayer.AnnouncementEventArgs(Text, RelatedObject);

            if (Raiser != null)
            {
                Raiser(this, e);
            }
        }

        #endregion
    }
}

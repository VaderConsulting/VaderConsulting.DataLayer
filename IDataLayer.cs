using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VaderConsulting.Dependency;
using VaderConsulting.Helper;

namespace VaderConsulting.DataLayer
{
    public interface IDataLayer
    {

        List<BusinessApplication> GetBusinessApplications();

    }
}

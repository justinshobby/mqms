using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MQMS.Views.Maintenance
{
    public partial class Uom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string UOMID = (string)(Page.RouteData.Values["id"]);

        }
    }
}
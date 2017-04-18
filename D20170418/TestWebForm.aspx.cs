using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace D20170418
{
    public partial class TestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Calendar.Style["visibility"] = "hidden";
        }

        protected void ToggleCalendar(Object sender, EventArgs e)
        {
            if(this.Calendar.Style["visibility"].Equals("hidden"))
            {
                this.Calendar.Style["visibility"] = "visible";
            }
            else
            {
                this.Calendar.Style["visibility"] = "hidden";
            }
        }
    }
}
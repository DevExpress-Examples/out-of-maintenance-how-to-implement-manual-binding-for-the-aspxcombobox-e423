using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ManualBinding {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // emulating an external data source
            if(Session["RegionID"] == null)
                Session["RegionID"] = 1;
        }

        protected void ASPxComboBox1_PreRender(object sender, EventArgs e) {
            // fetch a value from a data source
            int regionID = (int)Session["RegionID"];
            // manually assing the value to the ComboBox
            ASPxComboBox1.Value = regionID;
        }

        protected void ASPxComboBox1_ValueChanged(object sender, EventArgs e) {
            // get a new value
            int regionID = (int)ASPxComboBox1.Value;
            // save it to a data source
            Session["RegionID"] = regionID;

            //ASPxComboBox1.DataBind();
        }

        protected void ASPxButton1_Click(object sender, EventArgs e) {
            // emulate an external change of a data source
            Session["RegionID"] = 2;
        }

    }
}

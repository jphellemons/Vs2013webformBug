using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public string GetSideCart(bool showButton)
        {
            System.Web.UI.Page page = new System.Web.UI.Page();
            WebUserControl1 ctl =
              (WebUserControl1)page.LoadControl("~/WebUserControl1.ascx");
            page.Controls.Add(ctl);

            System.IO.StringWriter writer = new System.IO.StringWriter();
            try
            {
                HttpContext.Current.Server.Execute(page, writer, false);
                page.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return writer.ToString();
        }
    }
}

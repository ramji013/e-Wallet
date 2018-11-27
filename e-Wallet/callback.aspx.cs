using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FintechAPI;

namespace Project5
{
    public partial class callback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Instantiate an OAuth2 object
            OAuth2 oAuth2 = new OAuth2();

            //Configure the parameters and callback URL
            oAuth2.client_id = "f01805e4766ebdc5";
            oAuth2.client_secret = "be744c6869ffac80f421742f9aff0732";
            oAuth2.redirect_uri = "http://localhost:3000/callback.aspx";

            //request if OAuth2 server has granted a code
            string code = Request.QueryString["code"];
            
            //Instantiate a status object
            APIAccess.Result status = new APIAccess.Result();
            status.result = -1;
            status.value = "";

            //Instantiate a APIAccess object
            APIAccess fidorapi = new APIAccess();

            //Status returned from GetAccessToken API
            status = fidorapi.GetAccessToken(oAuth2, code);

            if (status.result == 0)
            {
                //save the access token
                Session["AccessToken"] = status.value;
                //go to a main page
                Response.Redirect("Index.aspx");
            }            
        }
    }
}
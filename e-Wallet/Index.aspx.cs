using eWallet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_Wallet
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Access Token obtained?
            if (Session["AccessToken"] != null)
            {
                //access token found
                string access_token = (string)Session["AccessToken"];

                //contruct a simple html header 
                string message = string.Format("<h4 style='font-family:verdana;'>" +
                                               "Access Token: {0} </h4>",
                                               access_token);
                //write to screen
                Response.Write(message);
            }
            else
            {
                Response.Redirect("callback.aspx");
            }
        }

        protected async void btnGetAccount_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            HttpClient httpclient = new HttpClient();

            httpclient.DefaultRequestHeaders.Add("Accept", "application/vnd.fidor.de; version=1,text/json");
            string access_token = (string)Session["AccessToken"];
            httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", access_token);
            response = await httpclient.GetAsync("https://api.np.sandbox.fidor.com/accounts");

            string data = await response.Content.ReadAsStringAsync();
            Accounts a = new Accounts();
            a = JsonConvert.DeserializeObject<Accounts>(data);

            string account_number = a.data[0].account_number;
            string currency = a.data[0].currency;
            Double balance = a.data[0].balance / 100.0; // cents
            string message1 = string.Format("<h4 style='font-family:verdana;'>Your Account Number: {0}</h4>", account_number);
            string message2 = string.Format("<h4 style='font-family:verdana;'>Your Balance: {0:C2} {1}</h4>", balance, currency);
            Response.Write(message1);
            Label1.Text = message1;
        }
    }

}
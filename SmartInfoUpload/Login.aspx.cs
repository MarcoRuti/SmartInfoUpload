using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Runtime.Remoting.Channels;

namespace SmartInfoUpload
{
    public partial class Login : System.Web.UI.Page
    {

        public string test;

        /*protected void Page_Load(object sender, EventArgs e)
        {
            string user = username.Text;
        }
        */
       
        protected void submitButton_Click(object sender, EventArgs e)
        {

            //PULIZIA STRINGHE
            /*
             * char[] charToTrim = { '@', '#', ' ', '.', ',', ';', '-', '+', '_', '?', '!', '&', '%', 'è', 'ò', 'à', 'ù', '+', '*', '[', ']', '{', '}' };
             * string user = username.Text.Trim(charToTrim);
             * string pass = password.Text.Trim(charToTrim);
            */
            



            //CONTROLLO USER / PASS PRESENTI SUL DB
            SmartInfoUploadEntities db = new SmartInfoUploadEntities();

            usersTable usersTb = db.usersTable.Where((X)=> X.username == username.Text && X.password == password.Text).FirstOrDefault();

            //GESTIONE LOGIN - REDIRECT
            Session["utenteAutenticato"] = usersTb;
            if (usersTb != null)
            {
                Response.Redirect("Home.aspx");

            }
           

        }

    }
}
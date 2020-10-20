using System;
using System.Linq;

namespace SmartInfoUpload
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submitSignInButton_Click(object sender, EventArgs e)
        {
            if ((username.Text.Length <= 3) || (password.Text.Length <= 3) || (username.Text.Length >= 25) || (username.Text.Length >= 25))
                    Response.Write("Username o Password troppo lunghe");
            
            //INSERIMENTO USER / PASS SUL DB
            SmartInfoUploadEntities db = new SmartInfoUploadEntities();

            usersTable usersTb = new usersTable(); //= db.usersTable.Select((X) => X.username == username.Text && X.password == password.Text).FirstOrDefault();
            usersTb.username     = username.Text;
            usersTb.password     = password.Text;
            db.usersTable.Add(usersTb);
            db.SaveChanges();
            Response.Redirect("Login.aspx");
        }

    }
}
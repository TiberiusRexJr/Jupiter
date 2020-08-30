using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jupiter.DataLayer;

namespace Jupiter
{
    
    public partial class LogIn : System.Web.UI.Page
    {
        DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            string userEmail = TextBoxEmail.Text;
            string password = TextBoxEmail.Text;

            db.RetrieveById


        }
    }
}
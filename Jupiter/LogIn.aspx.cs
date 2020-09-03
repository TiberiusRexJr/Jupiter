using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jupiter.DataLayer;
using Jupiter.Models;

namespace Jupiter
{
    public partial class LogIn : System.Web.UI.Page
    {
        DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["USR"].Value != null && Request.Cookies["PWD"].Value != null)
                {
                    TextBoxEmail.Text = Response.Cookies["USR"].Value;
                    TextBoxPassword.Attributes["value"] = Response.Cookies["PWD"].Value;
                    CheckBoxRememberPassword.Checked = true;
                }
            }
           
            /*if (Session["password"] != null)
            {
                TextBoxPassword.Text = Session["password"].ToString();
            }*/
        }

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            bool valid = db.Validate(TextBoxEmail.Text, TextBoxPassword.Text);
            if (!valid)
            {
                LabelWarning.Text = "Invalid Credentials!";

            }
            else
            {
                Worker worker = db.RetrieveByEmail(TextBoxEmail.Text);
                /*LabelWarning.Text = "Welcome" +worker.FirstName;*/

                Session["email"] = worker.Email;
                Session["password"] = worker.Password;
                Session["firstName"] = worker.FirstName;
                Session["lastName"] = worker.LastName;
                Session["usertype"] = worker.UserType;

                if (CheckBoxRememberPassword.Checked)
                {
                    Request.Cookies["PWD"].Value = worker.Password;
                    Request.Cookies["PWD"].Expires = DateTime.Now.AddDays(7);
                    Request.Cookies["USR"].Value = worker.Email;
                    Request.Cookies["USR"].Expires = DateTime.Now.AddDays(7);

                    
                }
                else
                {

                    Request.Cookies["USR"].Expires = DateTime.Now.AddDays(-1);
                    Request.Cookies["PWD"].Expires = DateTime.Now.AddDays(-1);

                }

                if (worker.UserType == "u")
                {
                    Response.Redirect("default.aspx");
                }
                else if (worker.UserType == "a")
                {
                    Response.Redirect("AdminHome.aspx");
                }
                
            }



                

            }
            /*   if (db.ValidateEmail(TextBoxEmail.Text))
               {
                   LabelWarning.Text = "duh";

               }
               else
               {
                   LabelWarning.Text = "fuck";

               }*/


        }
    }

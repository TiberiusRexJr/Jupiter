﻿using System;
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
            if (Session["email"]!=null)
            {
                TextBoxEmail.Text = Session["email"].ToString();
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
                LabelWarning.Text = "Welcome" +worker.FirstName;

                if (CheckBoxRememberPassword.Checked)
                {
                    Session["email"] = worker.Email;
                    Session["password"] = worker.Password;
                    Session["firstName"] = worker.FirstName;
                    Session["lastName"] = worker.LastName;
                }



                Response.Redirect("default.aspx");

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
}
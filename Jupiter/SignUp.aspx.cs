﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using Jupiter.DataLayer;
using Jupiter.Models;
using System.Drawing;

namespace Jupiter
{
    public partial class SignUp : System.Web.UI.Page
    {
        private DataBase db = new DataBase();
        protected void Page_Load(object sender, EventArgs e)
        {
           
             
        }

        protected void Button_OnClick_Submit(object sender,EventArgs eventArgs)
        {
            bool response;
            if (TextBoxFirstName != null && TextBoxLastName != null && TextBoxEmail.Text != null && TextBoxPassword.Text != null && TextBoxConfirmPassword != null)
            {
                TextBoxFirstName.BorderColor = System.Drawing.Color.Empty;
                TextBoxLastName.BorderColor = System.Drawing.Color.Empty;
                TextBoxEmail.BorderColor = System.Drawing.Color.Empty;
                TextBoxPassword.BorderColor = System.Drawing.Color.Empty;


                LabelWarningMessage.Text = string.Empty;


                if (TextBoxPassword.Text == TextBoxConfirmPassword.Text)
                {
                    Worker worker = new Worker { FirstName = TextBoxFirstName.Text, LastName = TextBoxLastName.Text, Email = TextBoxEmail.Text, Password = TextBoxPassword.Text };
                    if (response = db.Create(worker))
                    {
                        Session["firstName"] = worker.FirstName;
                        Session["lastName"] = worker.LastName;
                        Session["email"] = worker.Email;
                        Session["password"] = worker.Password;

                        /*LabelWarningMessage.Text = "Welcome!" + worker.FirstName + "!"+response.ToString();*/
                     /*   LabelWarningMessage.ForeColor = System.Drawing.Color.Green;*/

                        TextBoxPassword.BorderColor = System.Drawing.Color.Empty;
                        TextBoxConfirmPassword.BorderColor = System.Drawing.Color.Empty;

                        Response.Redirect("Login.aspx");
                    }
                    else
                    {
                        LabelWarningMessage.Text = "That Email is already in use!"+response.ToString();
                        TextBoxEmail.BorderColor = System.Drawing.Color.Red;
                    }

                    

                   
                }
                else
                {
                    TextBoxPassword.BorderColor = System.Drawing.Color.Red;
                    TextBoxConfirmPassword.BorderColor = System.Drawing.Color.Red;
                    LabelWarningMessage.Text = "Passwords do not match";
                    LabelWarningMessage.ForeColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                TextBoxFirstName.BorderColor = System.Drawing.Color.Red;
                TextBoxLastName.BorderColor = System.Drawing.Color.Red;
                TextBoxEmail.BorderColor = System.Drawing.Color.Red;
                TextBoxPassword.BorderColor = System.Drawing.Color.Red;
                LabelWarningMessage.Text = "All Feilds are required";
                LabelWarningMessage.ForeColor = System.Drawing.Color.Red;
                
                

            }
            
                
                


            

        }

       
    }
}
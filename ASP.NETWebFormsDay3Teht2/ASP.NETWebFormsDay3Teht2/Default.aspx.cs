﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETWebFormsDay3Teht2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKlikkaa_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts",
                "<script>alert('Kirjoita nimesi alla olevaan kenttään ja klikkaa OK.');</script>");
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            msgBox("Hei, " + TxtBox.Text + "!");
        }

        //luodaan msgBox metodi, jota käytetään Button1_click 
        public void msgBox(String msg)
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "Message Box",
                "<script language='javascript'>alert('" + msg + "')</script>");
        }
    }
}
﻿using System;
using System.Configuration; //Web.configin lukemista varten 
using System.Data; //Dataa ja yleisiä Ado.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tyontekijat : System.Web.UI.Page
{
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        //haetaan web.configista xml- tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["xmlfilu"];
        lblMessages.Text = xmlfilu;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //haetaan XML-data DataView- olioon, jotka kytketään GridVieweh
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfilu)); //huom MapPath muuttaa viittauksen suuntaa
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();

    }
}
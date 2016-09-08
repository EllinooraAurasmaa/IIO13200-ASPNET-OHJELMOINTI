using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Makkara : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnTervehdi_Click(object sender, EventArgs e)
    {
        //luetaan käyttäkän antama syöte
        string inPut = "Terve:" + txtNimi.Text;

        //näytetään käyttäjälle
        lblTulos.Text = inPut;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string password = txtPassword.Text;

        if ("adelgado".Equals(usuario) && "4ug02000".Equals(password))
            Response.Write("<script>alert('Usuario correcto!')</script>");
        else
            Response.Write("<script>alert('Usuario incorrecto!')</script>");
    }
}
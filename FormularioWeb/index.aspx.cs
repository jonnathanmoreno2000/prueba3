using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Calcular_Click(object sender, EventArgs e)
        {
            ServicioCalculo.TrabajoClient calculo = new ServicioCalculo.TrabajoClient();

            try
            {
                string total = Convert.ToString(calculo.ObtenerModulo
                                (Convert.ToInt32(tb_Dividendo.Text),
                                Convert.ToInt32(tb_Divisor.Text)));

                LB_Resultado.Text = total;
            }
            catch (Exception)
            {
                LB_Resultado.Text = "Error, ingresar numeros enteros";
            }
        }
    }
}
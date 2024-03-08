using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AREAServicioWeb
{
    /// <summary>
    /// Descripción breve de AREAService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AREAService : System.Web.Services.WebService
    {

       
        [WebMethod]
        public string AreaCuadrado(int side)
        {
            var area = side * side;//Realiza la operación del calculo del area del cuadrado a partir del lado proporcionado

            return "Hola,el area de tu cuadrado es de: " + area.ToString();//da un mensaje con e resultado


        }

        [WebMethod]
        public string AreaCirculo(int radius)
        {
            var area = Math.PI * radius;//Realiza la operación del calculo del area del circulo a partir del radio proporcionado

            return "Hola,el area de tu circulo es de: " + area.ToString();//da un mensaje con e resultado


        }

        [WebMethod]
        public string AreaTriangulo(int SideBase, int SideHeight)
        {
            var area = (SideBase * SideHeight) / 2;//Realiza la operación del calculo del area del triangulo a partir de la base y la altura escrita, dividido entre 2

            return "Hola, el área de tu triángulo es de: " + area.ToString();//da un mensaje con e resultado
        }

        [WebMethod]
        public string AreaRectangulo(int SideBase, int SideHeight)
        {
            var area = (SideBase * SideHeight);//Realiza la operación del calculo del area del rectangulo a partir de la base y la altura escrita

            return "Hola, el área de tu rectangulo es de: " + area.ToString();//da un mensaje con e resultado
        }
    }
}

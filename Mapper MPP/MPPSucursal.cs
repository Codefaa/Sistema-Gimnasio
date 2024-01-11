using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;
using Entidad_BE;

namespace Mapper_MPP
{
    public class MPPSucursal
    {
        public List<BESucursal> LeerXML()
        {
            var consulta =
                from sucursal in XElement.Load("Sucursal.XML").Elements("sucursal")
                select new BESucursal
                {
                    CodigoSucursal = Convert.ToInt32(Convert.ToString(sucursal.Attribute("codigo").Value).Trim()),
                    NombreSucursal = Convert.ToString(sucursal.Element("nombre").Value).Trim(),
                    DireccionSucursal = Convert.ToString(sucursal.Element("direccion").Value).Trim(),
                    TelefonoSucursal = Convert.ToString(sucursal.Element("telefono").Value).Trim(),
                };

            List<BESucursal> listaSucursales = consulta.ToList<BESucursal>();

            return listaSucursales;
        }
        public void AgregarXML(BESucursal unaSucursal)
        {
            XDocument xmlDoc = XDocument.Load("Sucursal.xml");

            xmlDoc.Element("sucursales").Add(new XElement("sucursal",
                                             new XAttribute("codigo", unaSucursal.CodigoSucursal),
                                             new XElement("nombre", unaSucursal.NombreSucursal),
                                             new XElement("direccion", unaSucursal.DireccionSucursal),
                                             new XElement("telefono", unaSucursal.TelefonoSucursal)));
            xmlDoc.Save("Sucursal.xml");
        }
        public void ModificarXML(BESucursal unaSucursal)
        {
            XDocument xmlDoc = XDocument.Load("Sucursal.xml");

            var consulta = from sucursal in xmlDoc.Descendants("sucursal")
                           where sucursal.Attribute("codigo").Value == unaSucursal.CodigoSucursal.ToString()
                           select sucursal;

            foreach (XElement EModificar in consulta)
            {
                EModificar.Element("nombre").Value = unaSucursal.NombreSucursal;
                EModificar.Element("direccion").Value = unaSucursal.DireccionSucursal;
                EModificar.Element("telefono").Value = unaSucursal.TelefonoSucursal;
            }

            xmlDoc.Save("Sucursal.xml");
        }
        public void BorrarXML(BESucursal unaSucursal)
        {
            XDocument xmlDoc = XDocument.Load("Sucursal.xml");

            var consulta = from sucursal in xmlDoc.Descendants("sucursal")
                           where sucursal.Attribute("codigo").Value == unaSucursal.CodigoSucursal.ToString()
                           select sucursal;

            consulta.Remove();
            xmlDoc.Save("Sucursal.xml");
        }
        public List<BESucursal> BuscarXML(string direccion)
        {
            var consulta = 
                from sucursal in XElement.Load("Sucursal.xml").Elements("sucursal")
                where (string)sucursal.Element("direccion") == direccion.ToString().Trim()
                select new BESucursal
                {
                    CodigoSucursal = Convert.ToInt32(Convert.ToString(sucursal.Attribute("codigo").Value).Trim()),
                    NombreSucursal = Convert.ToString(sucursal.Element("nombre").Value).Trim(),
                    DireccionSucursal = Convert.ToString(sucursal.Element("direccion").Value).Trim(),
                    TelefonoSucursal = Convert.ToString(sucursal.Element("telefono").Value).Trim()
                };

            List<BESucursal> listaSucursales = consulta.ToList<BESucursal>();

            return listaSucursales;
        }
    }
}

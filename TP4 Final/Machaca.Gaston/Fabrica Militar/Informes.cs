using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Fabrica_Militar
{ 
    public class Informes<T>
    {
        private string mensaje;
        public void GenerarInformeXML(T dato)
        {
            mensaje = typeof(T).Name;
            XmlSerializer s = new XmlSerializer(typeof(T));

            using (TextWriter tw = new StreamWriter($"{mensaje}.xml"))
            {
                s.Serialize(tw, dato);
            }
        }
    }


}

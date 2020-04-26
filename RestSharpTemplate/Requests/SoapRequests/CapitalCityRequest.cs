using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RestSharpTemplate.Requests.SOAP
{
    public class CapitalCityRequest : RequestSoapBase
    {
        public CapitalCityRequest()
        {
           
        }

        public void SetXmlBody(string isoCode)
        {
            xmlBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Xmls/CapitalCityXML.xml", Encoding.UTF8);
            xmlBody = xmlBody.Replace("$isoCode", isoCode);
        }
    }
}

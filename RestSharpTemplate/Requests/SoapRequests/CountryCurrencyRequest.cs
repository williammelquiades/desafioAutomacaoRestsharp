using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace RestSharpTemplate.Requests.SOAP
{
    public class CountryCurrencyRequest : RequestSoapBase
    {
        public CountryCurrencyRequest()
        {
            
        }

        public void SetXmlBody(string isoCode)
        {
            xmlBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Xmls/CountryCurrencyXML.xml", Encoding.UTF8);
            xmlBody = xmlBody.Replace("$isoCode", isoCode);
        }
    }
}

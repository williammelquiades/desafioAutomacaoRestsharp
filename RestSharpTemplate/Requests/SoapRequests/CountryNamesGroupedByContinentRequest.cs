using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpTemplate.Requests.SoapRequests
{
    public class CountryNamesGroupedByContinentRequest : RequestSoapBase
    {
        public CountryNamesGroupedByContinentRequest()
        {
            
        }

        public void SetXmlBody()
        {
            xmlBody = File.ReadAllText(GeneralHelpers.ReturnProjectPath() + "Xmls/CountryNamesGroupedByContinentXML.xml", Encoding.UTF8);
        }
    }
}

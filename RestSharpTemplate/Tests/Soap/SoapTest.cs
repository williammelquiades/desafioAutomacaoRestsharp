﻿using NUnit.Framework;
using RestSharp;
using RestSharpTemplate.Bases;
using RestSharpTemplate.Helpers;
using RestSharpTemplate.Requests.SOAP;
using RestSharpTemplate.Requests.SoapRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;

namespace RestSharpTemplate.Tests.Soap
{
    [TestFixture]
    public class SoapTest : TestBase
    {
        [Test]
        public void CountryCurrencyTest()
        {
            #region Parameters
            string codeCountry = "US";
            #endregion

            #region ExpectedValues
            string moeda = "Dollars";
            #endregion

            CountryCurrencyRequest soapRequest = new CountryCurrencyRequest();
            soapRequest.SetXmlBody(codeCountry);

            IRestResponse<dynamic> response = soapRequest.ExecuteRequest();

            XmlNodeList moedaNode = RestSharpHelpers.getElementXml(response, "m:sName");

            Assert.AreEqual(moeda, moedaNode[0].InnerXml.ToString());
        }

        [Test]
        public void CapitalCityTest()
        {
            #region Parameters
            string codeCountry = "BR";
            #endregion

            #region ExpectedValues
            string capital = "Brasilia";
            #endregion

            CapitalCityRequest soapRequest = new CapitalCityRequest();
            soapRequest.SetXmlBody(codeCountry);

            IRestResponse<dynamic> response = soapRequest.ExecuteRequest();

            XmlNodeList capitalNode = RestSharpHelpers.getElementXml(response, "m:CapitalCityResult");

            Assert.AreEqual(capital, capitalNode[0].InnerText.ToString());
        }

        [Test]
        public void CountryNamesGroupedByContinentTest()
        {
            #region Parameters
            #endregion

            #region ExpectedValues
            string continentCode = "AF";
            string countryCode = "DZ";
            string countryName = "Algeria";
            #endregion

            CountryNamesGroupedByContinentRequest countryNamesGroupedByContinentRequest = new CountryNamesGroupedByContinentRequest();
            countryNamesGroupedByContinentRequest.SetXmlBody();

            IRestResponse<dynamic> response = countryNamesGroupedByContinentRequest.ExecuteRequest();

            XmlNodeList continentCodeNode = RestSharpHelpers.getElementXml(response, "m:sCode");
            XmlNodeList countryCodeNode = RestSharpHelpers.getElementXml(response, "m:sISOCode");
            XmlNodeList countryNameNode = RestSharpHelpers.getElementXml(response, "m:sName");

            Assert.Multiple(() =>
            {
                Assert.AreEqual(continentCode, continentCodeNode[0].InnerText.ToString());
                Assert.AreEqual(countryCode, countryCodeNode[0].InnerText.ToString());
                Assert.AreEqual(countryName, countryNameNode[1].InnerText.ToString());
            });
        }
    }
}

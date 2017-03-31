using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace ParseTheParcel
{
    public static class xmlReader
    {
        public static string GetPackageName(string packageName)
        {
            XmlDocument xmlDoc;
            try
            {
                xmlDoc = new XmlDocument();
                string path = AppDomain.CurrentDomain.BaseDirectory + "ParseTheParcel.xml";
                xmlDoc.Load(path);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes(packageName + "/PackageName");
                return nodeList[0].InnerText.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xmlDoc = null;
            }
        }
        public static string GetPackageCost(string packageName)
        {
            XmlDocument xmlDoc;
            try
            {
                xmlDoc = new XmlDocument();
                string path = AppDomain.CurrentDomain.BaseDirectory + "ParseTheParcel.xml";
                xmlDoc.Load(path);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes(packageName + "/Cost");
                return nodeList[0].InnerText.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xmlDoc = null;
            }
        }
        public static string GetPackageWeight(string packageName)
        {
            XmlDocument xmlDoc;
            try
            {
                xmlDoc = new XmlDocument();
                string path = AppDomain.CurrentDomain.BaseDirectory + "ParseTheParcel.xml";
                xmlDoc.Load(path);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes(packageName + "/Weight");
                return nodeList[0].InnerText.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xmlDoc = null;
            }
        }
        public static string GetPackageDimension(string packageName, string side)
        {
            XmlDocument xmlDoc;
            try
            {
                xmlDoc = new XmlDocument();
                string path = AppDomain.CurrentDomain.BaseDirectory + "ParseTheParcel.xml";
                xmlDoc.Load(path);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes(packageName + "/Dimension/" + side);
                return nodeList[0].InnerText.Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                xmlDoc = null;
            }
        }
    }
}
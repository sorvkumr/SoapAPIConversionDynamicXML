using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml;

namespace SOAP_API_Conversion.Utilities;

public static class ConvertXmlToJsonFormat
{
    public static string ConvertXmlToJson(string xml)
    {
        try
        {
            var doc = new XmlDocument();
            doc.LoadXml(RemoveXmlDeclaration(xml));
            RemoveNamespaces(doc.DocumentElement);
            RemoveUnwantedNodes(doc.DocumentElement);
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None, false);
            var cleanedJson = RemoveUnwantedPartsFromJson(json);

            return cleanedJson;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"XML to JSON conversion error: {ex.Message}");
            return null;
        }
    }

    private static string RemoveXmlDeclaration(string xml)
    {
        if (xml.StartsWith("<?xml"))
        {
            int index = xml.IndexOf("?>");
            if (index != -1)
            {
                xml = xml.Substring(index + 2).Trim();
            }
        }
        return xml;
    }

    private static void RemoveNamespaces(XmlNode node)
    {
        if (node == null) return;
        if (node.Attributes != null)
        {
            var nsAttributes = node.Attributes.Cast<XmlAttribute>()
                .Where(attr => attr.Name.StartsWith("xmlns:") || attr.Name == "xmlns")
                .ToList();

            foreach (var attr in nsAttributes)
            {
                node.Attributes.Remove(attr);
            }
        }
        foreach (XmlNode childNode in node.ChildNodes)
        {
            RemoveNamespaces(childNode);
        }
    }

    private static void RemoveUnwantedNodes(XmlNode node)
    {
        if (node == null) return;
        foreach (XmlNode childNode in node.ChildNodes)
        {
            RemoveUnwantedNodes(childNode);
        }
    }

    private static string RemoveUnwantedPartsFromJson(string json)
    {
        try
        {
            json = json.Replace("<string>", "").Replace("</string>", "").Trim();
            json = json.Trim('\"', '<', '>', ' ');
            var jObject = JObject.Parse(json);
            if (jObject.ContainsKey("S:Envelope"))
            {
                var envelopeNode = jObject["S:Envelope"];
                jObject.Remove("S:Envelope");
                jObject["Envelope"] = envelopeNode;
            }
            return jObject.ToString(Newtonsoft.Json.Formatting.None);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"JSON cleanup error: {ex.Message}");
            return json;
        }
    }
}

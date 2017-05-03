using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

using System.Xml;

namespace App_Components.Methods
{
    public class Methods
    {
        public static string ObjectForXML(Classes.Books bks)
        {
            string st_XML = string.Empty;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Classes.Books));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, bks);
                }
                st_XML = textWriter.ToString(); //This is the output as a string
            }

            return st_XML;
        }

        public static string ObjectForXML(Classes.Novatec bks)
        {
            string st_XML = string.Empty;

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Classes.Novatec));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, bks);
                }
                st_XML = textWriter.ToString(); //This is the output as a string
            }

            return st_XML;
        }

        public static string ObjectForXML(Integracao.Produtos_Lista Produtos)
        {
            string st_XML = Utils.MTD_LerArquivoTexto("Produtos.txt");

            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Integracao.Produtos_Lista));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false); // no BOM in a .NET string
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, Produtos);
                }
                st_XML = textWriter.ToString(); //This is the output as a string
            }

            return st_XML;
        }

        public static void XMLForObject(Classes.Novatec classe)
        {
            using (TextReader reader = new StringReader(Utils.MTD_LerArquivoTexto("Livros.txt")))
            {
                System.Xml.Serialization.XmlSerializer serializer_ = new System.Xml.Serialization.XmlSerializer(typeof(Classes.Novatec));

                var lista = (Integracao.Produtos_Lista)serializer_.Deserialize(reader);
            }
        }

        public static void XMLForObject(Integracao.Produtos_Lista classe)
        {
            using (TextReader reader = new StringReader(Utils.MTD_LerArquivoTexto("Produtos.txt")))
            {
                System.Xml.Serialization.XmlSerializer serializer_ = new System.Xml.Serialization.XmlSerializer(typeof(Integracao.Produtos_Lista));

                var lista = (Integracao.Produtos_Lista)serializer_.Deserialize(reader);
            }
        }
    }
}
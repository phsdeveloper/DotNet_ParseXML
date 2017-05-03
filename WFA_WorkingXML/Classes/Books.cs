using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Xml.Serialization;

namespace App_Components.Classes
{
    [XmlRoot("books")]
    public class Books
    {
        [XmlElement("bookNum")]
        public int bookNum { get; set; }

        [XmlRoot("book")]
        public class book
        {
            [XmlElement("name")]
            public string name { get; set; }

            [XmlRoot("record")]
            public class record
            {
                [XmlElement("borrowDate")]
                public string borrowDate { get; set; }

                [XmlElement("returnDate")]
                public string returnDate { get; set; }
            }

            [XmlArray("borrowRecords")]
            [XmlArrayItem("record")]
            public record[] records { get; set; }
        }

        [XmlArray("booksList")]
        [XmlArrayItem("book")]
        public book[] books_ { get; set; }
    }


    [XmlRoot("novatec")]
    public class Novatec
    {
        public List<Categoria>  categorias { get; set; }
    }

    [XmlRoot("categoria")]
    public class Categoria
    {
        [XmlElement("categoria")]
        public string categoria { get; set; }
        [XmlElement("Livros")]
        public List<Livro> Livros { get; set; }
    }

    public class Livro
    {
        public int ano { get; set; }
        public string autor { get; set; }
        public string capa { get; set; }
        public int paginas { get; set; }
        public string titulo { get; set; }
    }
}
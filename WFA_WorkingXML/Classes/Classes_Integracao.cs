using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integracao
{
    [System.Xml.Serialization.XmlRoot("Produtos")]
    public class Produtos_Lista
    {
        
        
        [System.Xml.Serialization.XmlElement("Produtos")]
        //[System.Xml.Serialization.XmlArrayItem("booksProduto")]
        public Produto[] Produto { get; set; }
    }

    [System.Xml.Serialization.XmlRoot("Produto")]
    public class Produto
    {

       
        [System.Xml.Serialization.XmlElement("codigo")]
        public string codigo { get; set; }

        [System.Xml.Serialization.XmlElement("fabricanteId")]
        public int fabricanteId { get; set; }

        [System.Xml.Serialization.XmlElement("fabricanteNome")]
        public string fabricanteNome { get; set; }

        [System.Xml.Serialization.XmlElement("departamentoId")]
        public int departamentoId { get; set; }
        [System.Xml.Serialization.XmlElement("departamentoNome")]
        public string departamentoNome { get; set; }
        [System.Xml.Serialization.XmlElement("categoriaId")]
        public int categoriaId { get; set; }
        [System.Xml.Serialization.XmlElement("categoriaNome")]
        public string categoriaNome { get; set; }
        [System.Xml.Serialization.XmlElement("preco")]
        public string preco{ get; set; }
        [System.Xml.Serialization.XmlElement("precoDe")]
        public string precoDe { get; set; }
        [System.Xml.Serialization.XmlElement("produtoNome")]
        public string produtoNome { get; set; }
        [System.Xml.Serialization.XmlElement("descricao")]
        public string descricao { get; set; }
        [System.Xml.Serialization.XmlElement("habilitado")]
        public string habilitado { get; set; }
        [System.Xml.Serialization.XmlElement("Fotos")]
        public Fotos Fotos { get; set; }
        [System.Xml.Serialization.XmlElement("Dimensoes")]
        public Dimensoes Dimensoes { get; set; }
        [System.Xml.Serialization.XmlElement("frete")]
        public string frete { get; set; }
        [System.Xml.Serialization.XmlElement("Estoque")]
        public Estoque Estoque { get; set; }
    }

    [System.Xml.Serialization.XmlRoot("Fotos")]
    public class Fotos
    {
        [System.Xml.Serialization.XmlElement("p")]
        /// <summary>
        /// Imagem pequena
        /// </summary>
        public string p { get; set; }
        [System.Xml.Serialization.XmlElement("m")]
        /// <summary>
        /// Imagem média
        /// </summary>
        public string m { get; set; }
        [System.Xml.Serialization.XmlElement("g")]
        /// <summary>
        /// Imagem Grande
        /// </summary>
        public string g { get; set; }
    }
    [System.Xml.Serialization.XmlRoot("Dimensoes")]
    public class Dimensoes
    {
        [System.Xml.Serialization.XmlElement("altura")]
        public string altura { get; set; }

        [System.Xml.Serialization.XmlElement("largura")]
        public string largura { get; set; }

        [System.Xml.Serialization.XmlElement("profundidade")]
        public string profundidade { get; set; }

        [System.Xml.Serialization.XmlElement("peso")]
        public string peso { get; set; }
    }
    [System.Xml.Serialization.XmlRoot("Estoque")]
    public class Estoque
    {
        [System.Xml.Serialization.XmlElement("controle_estoque")]
        public string controle_estoque { get; set; }
    }
}
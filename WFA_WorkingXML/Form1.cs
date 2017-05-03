using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;

namespace WFA_WorkingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MTD_XmlForClass()
        {
            Integracao.Produtos_Lista produtos = null;
            App_Components.Methods.Methods.XMLForObject(produtos);

        }

        private void MTD_ClassForXML()
        {

        }

        private void MTD_LinkToXML()
        {
            string caminhoArquivo = App_Components.Utils.MTD_ObterCaminhoArquivo("Livros.txt");
            System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Load(caminhoArquivo);
            var itens = from dados in xdoc.Descendants("categoria")
                        select new
                        {
                            Header = dados.Value,
                            chidren = dados.Descendants("livros")
                        };

            foreach (var item in xdoc.Elements())
            {
                string st_valor = item.Value;
            }

        }


        #region # M É T O D O S  P A R A  C O N V E R S Ã O
        /// <summary>
        /// Realiza a leitura do XML item a item em um Loop
        /// </summary>
        private void MTD_LerXML_01()
        {
            string caminhoArquivo = App_Components.Utils.MTD_ObterCaminhoArquivo(cbo_Arquivos.Text);
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(caminhoArquivo);
            System.Text.StringBuilder stb_dados = new StringBuilder();


            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.None:
                        stb_dados.AppendFormat("Tipo: None   Name = {0} | Value = {1}", reader.Name, reader.Value);

                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Element:
                        stb_dados.AppendFormat("Tipo: Element   Name = {0} | Value = {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Attribute:
                        stb_dados.AppendFormat("Tipo: Attribute   Name = {0} | Value = {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Text:
                        stb_dados.AppendFormat("Tipo: text   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.CDATA:
                        stb_dados.AppendFormat("Tipo: CDATA   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.EntityReference:
                        stb_dados.AppendFormat("Tipo: EntityReference   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Entity:
                        stb_dados.AppendFormat("Tipo: Entity   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.ProcessingInstruction:
                        stb_dados.AppendFormat("Tipo: ProcessingInstruction   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Comment:
                        stb_dados.AppendFormat("Tipo: Comment   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Document:
                        stb_dados.AppendFormat("Tipo: Document   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.DocumentType:
                        stb_dados.AppendFormat("Tipo: DocumentType   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.DocumentFragment:
                        stb_dados.AppendFormat("Tipo: DocumentFragment   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Notation:
                        stb_dados.AppendFormat("Tipo: Notation   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.Whitespace:
                        stb_dados.AppendFormat("Tipo: Whitespace   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.SignificantWhitespace:
                        stb_dados.AppendFormat("Tipo: SignificantWhitespace   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.EndElement:
                        stb_dados.AppendFormat("Tipo: EndElement   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.EndEntity:
                        stb_dados.AppendFormat("Tipo: EndEntity   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    case System.Xml.XmlNodeType.XmlDeclaration:
                        stb_dados.AppendFormat("Tipo: XmlDeclaration   Name = {0} | Value {1}", reader.Name, reader.Value);
                        stb_dados.Append(Environment.NewLine);
                        break;
                    default:
                        break;
                }
            }
            txt_saida.Text = stb_dados.ToString();



        }
        /// <summary>
        /// Obter um item pelo nó do XML
        /// </summary>
        private void MTD_XmlDocumento()
        {
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            string st_caminhoXML = App_Components.Utils.MTD_ObterCaminhoArquivo(cbo_Arquivos.Text);
            xmlDoc.Load(st_caminhoXML);

            string valor1 = xmlDoc.SelectSingleNode("Produto").ChildNodes[0].InnerText;
            string valor2 = xmlDoc.SelectSingleNode("Produto").ChildNodes[1].InnerText;
            string valor3 = xmlDoc.SelectSingleNode("Produto").ChildNodes[2].InnerText;

            txt_saida.Text = valor1 + Environment.NewLine + valor2 + Environment.NewLine + valor3;

        }

        private void MTD_ConvertForClass()
        {
            using (System.IO.TextReader reader = new System.IO.StringReader(App_Components.Utils.MTD_LerArquivoTexto(cbo_Arquivos.Text)))
            {
                System.Xml.Serialization.XmlSerializer serializer_ = new System.Xml.Serialization.XmlSerializer(typeof(Integracao.Produtos_Lista));
                var lista = (Integracao.Produtos_Lista)serializer_.Deserialize(reader);

                if (lista != null)
                {
                    if (lista.Produto == null)
                        txt_saida.Text = "Não foi realizado o Deserialize do XML";
                    else
                        txt_saida.Text = lista.Produto[0].departamentoId.ToString();
                }
                else
                    txt_saida.Text = "Não há valores na lista";

            }
        }

        #endregion # M É T O D O S  P A R A  C O N V E R S Ã O

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_Arquivos.Items.Add("Livros.txt");
            cbo_Arquivos.Items.Add("Produtos.txt");

            cbo_TipoLeitura.Items.Add("Link To XML");
            cbo_TipoLeitura.Items.Add("Varredura Elementos (XmlTextReader)");
            cbo_TipoLeitura.Items.Add("Varredura Elementos (XMLDocument)");
            cbo_TipoLeitura.Items.Add("Parse XML");
        }

        private void btn_executarCodigo_Click(object sender, EventArgs e)
        {
            switch (cbo_TipoLeitura.Text)
            {
                case "Link To XML":
                    MTD_LinkToXML();
                    break;
                case "Varredura Elementos (XmlTextReader)":
                    MTD_LerXML_01();
                    break;
                case "Varredura Elementos (XMLDocument)":
                    MTD_XmlDocumento();
                    break;
                case "Parse XML":
                    MTD_ConvertForClass();
                    break;
                default:
                    break;
            }
        }

        private void cbo_TipoLeitura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoLeitura.Text.Equals("Parse XML"))
            {
                cbo_Arquivos.Text = "Produtos.txt";
                cbo_Arquivos.Enabled = false;
            }
            else
            {
                cbo_Arquivos.Enabled = true;
            }
        }
    }
}

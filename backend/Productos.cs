using Personas.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.BE
{
    public class Productos
    {
        public DataTable DAT { get; set; } = new DataTable();

        public Productos()
        {
            DAT.TableName = "Productos";
            DAT.Columns.Add("Id",typeof(string));
            DAT.Columns.Add("Nombre",typeof(string));
            DAT.Columns.Add("Stock", typeof(int));
            DAT.Columns.Add("Precio",typeof (decimal));
            DAT.Columns.Add("Vendidos", typeof(int));
            ReadTab();
        }

        public bool CargProd(Producto producto)
        {
            bool est = false;

            if (!ValProd(producto))
            {
                DAT.Rows.Add();
                int i = DAT.Rows.Count - 1;
                DAT.Rows[i]["Id"] = producto.Id;
                DAT.Rows[i]["Nombre"] = producto.Nombre;
                DAT.Rows[i]["Stock"] = producto.Stock;
                DAT.Rows[i]["Precio"] = producto.Precio;
                DAT.Rows[i]["Vendidos"] = producto.Vendidos;

                DAT.WriteXml(@"Productos.xml");
                est = true;
            }

            return est;
        }

        public void Cargven(Producto producto)
        {
            DAT.Rows.Add();
            int i = DAT.Rows.Count - 1;
            DAT.Rows[i]["Id"] = producto.Id;
            DAT.Rows[i]["Nombre"] = producto.Nombre;
            DAT.Rows[i]["Stock"] = producto.Stock;
            DAT.Rows[i]["Precio"] = producto.Precio;
            DAT.Rows[i]["Vendidos"] = producto.Vendidos;

            DAT.WriteXml(@"Productos.xml");
        }


        public Producto Buscar(string id)
        {
            Producto producto = new Producto();

            for (int i = 0; i < DAT.Rows.Count; i++)
            {
                if (DAT.Rows[i]["id"].ToString() == id)
                {
                    producto.Id = DAT.Rows[i]["id"].ToString();
                    producto.Nombre = DAT.Rows[i]["Nombre"].ToString();
                    producto.Stock = System.Convert.ToInt32(DAT.Rows[i]["Stock"]);
                    producto.Precio = System.Convert.ToDecimal(DAT.Rows[i]["Precio"]);
                    producto.Vendidos = System.Convert.ToInt32(DAT.Rows[i]["Vendidos"]);
                    break;
                }
            }
            return producto;
        }

        public bool BorProd(string id)
        {
            bool est = false;
            int fil = FilProd(id);

            if (fil != -1)
            {
                DAT.Rows[fil].Delete();
                DAT.WriteXml(@"Productos.xml");
                est=true;
            }
            return est;
        }

        public bool ValProd(Producto producto)
        {
            bool est =false;
            int fil = FilProd(producto.Id);

            if (fil != -1)
            {
                est = true;
            }
            return est;
        }

        public int FilProd(string id)
        {
            int fil = -1;

            for (int i = 0; i < DAT.Rows.Count; i ++)
            {
                if (DAT.Rows[i]["Id"].ToString() == id)
                {
                    fil = i;
                    break;
                }
            }
            return fil;
        }

        public void ReadTab()
        {
            if (System.IO.File.Exists(@"Productos.XML"))
            {
                DAT.ReadXml(@"Productos.XML");
            }
        }
    }
}

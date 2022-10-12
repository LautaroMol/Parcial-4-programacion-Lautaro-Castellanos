using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.BE
{
    public class Personas
    {
        public DataTable DT { get ; set; } = new DataTable();

        public Personas()
        {
            DT.TableName = "Personas";
            DT.Columns.Add("DNI", typeof(string));
            DT.Columns.Add("Nombre", typeof(string));
            DT.Columns.Add("Apellido", typeof(string));
            DT.Columns.Add("Edad", typeof(int));
            DT.Columns.Add("Ventas",typeof(int));

            LeerTab();
        }

        public bool CargaEmp(Persona persona)
        {
            bool est = false;

            if (!Valid(persona))
            {
                DT.Rows.Add();
                int i = DT.Rows.Count - 1;
                DT.Rows[i]["DNI"] = persona.DNI;
                DT.Rows[i]["Nombre"] = persona.Nombre;
                DT.Rows[i]["Apellido"] = persona.Apellido;
                DT.Rows[i]["Edad"] = persona.Edad;
                DT.Rows[i]["Ventas"] = persona.Ventas;

                DT.WriteXml(@"Personas.xml");

                est = true;
            }
            return est;
        }

        public void CargaVen(Persona persona)
        {
            DT.Rows.Add();
            int i = DT.Rows.Count - 1;
            DT.Rows[i]["DNI"] = persona.DNI;
            DT.Rows[i]["Nombre"] = persona.Nombre;
            DT.Rows[i]["Apellido"] = persona.Apellido;
            DT.Rows[i]["Edad"] = persona.Edad;
            DT.Rows[i]["Ventas"] = persona.Ventas;

            DT.WriteXml(@"Personas.xml");
        }

        public Persona Buscar(string dni)
        {
            Persona persona = new Persona();
            
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i]["DNI"].ToString() == dni)
                {
                    persona.DNI = DT.Rows[i]["DNI"].ToString();
                    persona.Nombre = DT.Rows[i]["Nombre"].ToString();
                    persona.Apellido = DT.Rows[i]["Apellido"].ToString();
                    persona.Edad = System.Convert.ToInt32(DT.Rows[i]["Edad"]);
                    persona.Ventas = System.Convert.ToInt32(DT.Rows[i]["Ventas"]);
                    break;
                }
            }
            return persona;
        }

        public int filPer(string dni)
        {
            int fila = -1;

            for (int i= 0; i < DT.Rows.Count; i++)
            {
                if (DT.Rows[i]["DNI"].ToString() == dni)
                {
                    fila = i;
                    break;
                }
            }
            return fila;
        }

        public bool borrarper(string dni)
        {
            bool est = false;
            int fila = filPer(dni);

            if (fila != -1)
            {
                DT.Rows[fila].Delete();
                DT.WriteXml(@"Personas.xml");
                est = true;
            }
            return est;
        }

        private void LeerTab()
        {
            if (System.IO.File.Exists(@"Personas.XML"))
            {
                DT.ReadXml(@"Personas.XML");
            }
        }

        private bool Valid(Persona persona)
        {
            bool est = false;
            int fila = filPer(persona.DNI);

            if (fila != -1)
            {
                est = true;
            }
            return est;
        }
    }
}

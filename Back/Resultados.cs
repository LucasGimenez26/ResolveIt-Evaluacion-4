using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Back
{
    public class Resultados
    {
        public DataTable ListaRes { get; set; } = new DataTable();

        public Resultados()
        {
            ListaRes.TableName = "Historial";
            ListaRes.Columns.Add("Resultados anteriores", typeof(double));
            leerArchivo();
        }

        public void leerArchivo()
        {
            if(System.IO.File.Exists("Resultados.xml"))
            {
                ListaRes.Clear();
                ListaRes.ReadXml("Resultados.xml");
            }
        }

        public void InsertRes(Resultado aRes)
        {
            ListaRes.Rows.Add(); 
            int NuevoRenglon = ListaRes.Rows.Count - 1; 
            ListaRes.Rows[NuevoRenglon]["Resultados anteriores"] = aRes.Res; 

            ListaRes.WriteXml("Resultados.xml");
        }
    }
}

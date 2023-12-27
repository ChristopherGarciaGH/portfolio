using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTecnicas
{
    public class ResultadoRutaSimplificada()
    {
        public String Resultado { get; set; } = "";
    }
    internal class SimplifyPath
    {
        private String _path { get; } = "";

        public SimplifyPath(string path)
        {
            _path = path;
        }

        public ResultadoRutaSimplificada RutaCanonica()
        {
            ResultadoRutaSimplificada resultadoRutaSimplificada = new ResultadoRutaSimplificada();
            String[] Ruta = _path.Split('/');
            Stack<String> RutaStack = new Stack<String>();

            foreach (String item in Ruta)
            {
                if (item == "..")
                {
                    if (RutaStack.Count > 0)
                    {
                        RutaStack.Pop();
                    }
                }
                else if(!string.IsNullOrEmpty(item)) 
                {
                    RutaStack.Push(item);
                }
            }

            if (RutaStack.Count == 0)
            {
                resultadoRutaSimplificada.Resultado = "/";
                return resultadoRutaSimplificada;
            }
            else
            {
                String[] RutaLista = RutaStack.ToArray();
                resultadoRutaSimplificada.Resultado = "/" + String.Join("/", RutaLista);
                return resultadoRutaSimplificada;
            }
        }
    }
}

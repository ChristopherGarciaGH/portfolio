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
            Stack<String> RutaStack = AgregarPila(Ruta);
            resultadoRutaSimplificada.Resultado = ConstruirRuta(RutaStack);
            return resultadoRutaSimplificada;
            
        }
        
        private Stack<String> AgregarPila(String[] Ruta)
        {
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
                else if (!string.IsNullOrEmpty(item))
                {
                    RutaStack.Push(item);
                }
            }
            return RutaStack;
        }

        private String ConstruirRuta(Stack<String> RutaStack)
        {
            if (RutaStack.Count == 0)
            {
                return "/";
            }
            else
            {
                String[] RutaLista = RutaStack.ToArray();
                return "/" + string.Join("/", RutaLista);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_TextoColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string lorem = "dfhkadsjgfoaihpa[eonijhfdkgruji]jdhfkdhkghdfgh \n"+
                "dfhgjsghslaekjjkgfhsdlfsbjsdkbljlknj \n"+
                "jhgfdgjkkdgfhksdghoseigurheshs";
            string loremColor= "dfhkadsjgfoaih  ^red{paeonijhfdkg}  rujijdhfkdhkghdfgh \n" +
                "dfhgjsghslaekjjkgfhsdlfsbjsdkbljlknj \n" +
                "jhgfdgjkkdgfhksdghoseigurheshs";

            string ejemplo = loremColor;

            string [] renglones = ejemplo.Split('\n');



                for (int i=0; i<renglones.Length;i++) {

                //renglon
                Console.WriteLine(renglones[i]);
                string [] campo = renglones[i].Split('^');

                    for (int   j= 0; j < campo.Length;  j++)
                    {
                      //es un campo
                        if (campo [j].Contains("}"))
                        {
                        string subcampo = campo[j].Split('}');

                        string[] colorTexto = subcampo[0].Split('{');

                        //colorTexto[0] contiene el color, y colorTexto[1] contiene el texto
                        switch (colorTexto[0])
                        {
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;

                                break;
                        }
                        Console.Write(colorTexto[1]);
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.Write(campo[j]);
                    }
                   
                }



            }
            Console.ForegroundColor = ConsoleColor.Red;
    

            Console.ReadLine();
        }
    }
}

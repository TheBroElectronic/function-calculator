using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   //=================================================//
  //podria utilizar librerias para hacerlo mas facil //f
 //PERO ESTOY PARA APREDER CARAJO!                  //
//=================================================//

namespace graficador_de_funciones
{
    class interpretador
    {
        public static string UP = "";
        public static string DWN = "";
        public static string function = "";
        
        int par = 0;
        bool div = false, div2 = false; 
        
        public void interpretar(string F)
        {
            limpieza();//limpiar todo
            for (int i = 0; i < F.Length;i++ )
            {
                separador(F[i], i);//ordenar todo
            }
            muestreo();//mostrar funcion tomada
        }
        
        void separador(char ch, int i)
        {
            switch (ch)
            {
                default:
                    if (div2 == true) {
                        DWN += ch;
                    } 
                    else UP += ch;
                    break;
                case '(':
                    if (i == 0 && ch == '(') div = true;
                    if (div2 == false) UP += '(';
                    else DWN += '(';
                    par++;
                    break;
                case ')':
                    if (par > 0) par--;
                    if (div2 == false) UP += ')';
                    else DWN += ')';
                    break;
                case '/':
                    if (div == true && par == 0 && div2 == false) div2 = true;
                    else if (div2 == false) UP += ch;
                    else  DWN += ch;
                    break;
                case ' ':
                    break;
            }
        }//separar cuenta entre dividendo y divisor

        void muestreo()
        {
            function = "f(x)= ";
            for (int i = 0; i < UP.Length; i++)
            {
                if (UP[i] != '\0')function = function + UP[i];
            }

            if(DWN != "") {
                function = function + "/";
                for (int i = 0; i < DWN.Length; i++)
                {
                    if(DWN[i] != '\0') function = function + DWN[i];
                }
            }
        }//muestra la funcion en forma de string

        void limpieza()
        {
            div = false;
            div2 = false;
            par = 0;
            UP = "";
            DWN = "";
            function = "";
        }//borrar todos los datos auxiliares
    }
}
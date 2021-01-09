using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//=================================================//
//podria utilizar librerias para hacerlo mas facil //
//PERO ESTOY PARA APREDER CARAJO!                  //
//=================================================//

//llamar funcion de calcular

namespace graficador_de_funciones
{
    class interpretador
    {
        char[] UP = new char[20];
        char[] DWN = new char[20];

        bool par = false, div = false, div2 = false;
        
        int mov = 0;
        public double interpretar(string F)
        {
            if (F[0] == '(')div = true;
            return 0;
        }
        //separar y ordenar dentro de una matriz
        void separador(char ch,int i)
        {
            switch (ch)
            {
                default:
                    if (div == true && par == false && UP[0] != '/0' )
                    {
                        DWN[i] = ch;
                    }
                    else UP[i]= ch;
                    break;
                case '(':
                    par = true;

                    break;
                case ')':
                    
                    break;
            }
        }
    }
}
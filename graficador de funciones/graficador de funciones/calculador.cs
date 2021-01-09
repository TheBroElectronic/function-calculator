using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficador_de_funciones
{
    class calculador
    {
        double cuentaA = 0, cuentaB = 0;
        string aux = "", aux2 = "", sig2 = "";
        public double resultado = 0;
        bool div = false, pot = false, resta = false, multi = false;
        int par = 0;

        public void calcular(double XD)
        {
            clear();
            for (int i = 0; i < interpretador.UP.Length; i++)
            {
                operacion(interpretador.UP[i], true, XD);
            }
            opFinal(true);
            if (interpretador.DWN != "")
            {
                for (int i = 0; i < interpretador.DWN.Length; i++)
                {
                    operacion(interpretador.DWN[i], false, XD);
                }
                opFinal(false);
            }
            else cuentaB = 1;
            resultado = cuentaA/cuentaB;
        }
        void operacion(char ch, bool A, double X)
        {
            switch (ch)
            {
                default:
                    if (div == false && pot == false && multi == false) aux += ch;
                    else if (div == true || multi == true) aux2 += ch;
                    else if (pot == true) aux2 += ch;
                    break;
                case '^':
                    sig2 = "^";
                    pot = true;
                    break;
                case '+':
                    cuenta(A);
                    if (A == true && aux != "") cuentaA += Convert.ToDouble(aux);
                    else if (aux != "") cuentaB += Convert.ToDouble(aux);
                    aux = "";
                    sig2 = "+";
                    break;
                case '-':
                    cuenta(A);
                    if (A == true && aux != "" && resta == false) cuentaA += Convert.ToDouble(aux);
                    else if (aux != "" && resta == false) cuentaB += Convert.ToDouble(aux);
                    resta = true;
                    aux = "";
                    sig2 = "-";
                    break;
                case 'x':
                    aux += X;
                    break;
                case '*':
                    cuenta(A);
                    multi = true;
                    aux = "";
                    sig2 = "*";
                    break;
                case '/':
                    cuenta(A);
                    if (A == true && aux != "") cuentaA +=Convert.ToDouble(aux);
                    else if (aux != "") cuentaB += Convert.ToDouble(aux);
                    div = true;
                    aux = "";
                    sig2 = "/";
                    break;
                case '(':
                    par++;
                    cuenta(A);
                    break;
                case ')':
                    par--;
                    cuenta(A);
                    break;
            }
        }
        void opFinal(bool A)
        {
            if (sig2 != "" || aux!= "")
            {
                switch (sig2)
                {
                    default:
                    case "+":
                        if (A == true) cuentaA += Convert.ToDouble(aux);
                        else cuentaB += Convert.ToDouble(aux);
                        aux = "";
                        sig2 = "";
                        break;
                    case "-":
                        if (A == true && resta == true) cuentaA -= Convert.ToDouble(aux);
                        else cuentaB -= Convert.ToDouble(aux);
                        resta = false;
                        aux = "";
                        sig2 = "";
                        break;
                    case "*":
                        break;
                    case "/":
                        if (div == true && aux2 != "")
                        {
                            if (A == true) cuentaA = cuentaA / Convert.ToDouble(aux2);
                            else cuentaB = cuentaB / Convert.ToDouble(aux2);
                            div = false;
                            aux2 = "";
                        }
                        break;
                    case "^":
                        if (pot == true)
                        {
                            if (A == true && aux2 != "")
                                cuentaA += Math.Pow(Convert.ToDouble(aux), Convert.ToDouble(aux2));
                            else if (aux2 != "")
                                cuentaB += Math.Pow(Convert.ToDouble(aux), Convert.ToDouble(aux2));
                            pot = false;
                            aux = "";
                            aux2 = "";
                        }
                        break;
                }
            }
            else if (aux != "")
            {
                if (A == true)
                {
                    cuentaA += Convert.ToDouble(aux);
                    cuentaB = 1;
                }
                else cuentaB += Convert.ToDouble(aux);
            }
            sig2 = "";
        }
        void cuenta(bool A)
        {
            if (div == true && aux2 != "")
            {
                if (A == true) cuentaA = cuentaA / Convert.ToDouble(aux2);
                else cuentaB = cuentaB / Convert.ToDouble(aux2);
                div = false;
                aux2 = "";
            }
            else if (resta == true)
            {
                if (A == true) cuentaA -= Convert.ToDouble(aux);
                else cuentaB -= Convert.ToDouble(aux);
                resta = false;
                aux = "";
            }
            else if (pot == true)
            {
                if (A == true) cuentaA += Math.Pow(Convert.ToDouble(aux), Convert.ToDouble(aux2));
                else cuentaB += Math.Pow(Convert.ToDouble(aux), Convert.ToDouble(aux2));
                pot = false;
                aux = "";
                aux2 = "";
            }
            else if (multi == true)
            {
                if (A == true) cuentaA += Convert.ToDouble(aux) * Convert.ToDouble(aux2);
                else ;
            }
        }
        void clear()
        {
            resultado = 0;
            cuentaA = 0;
            cuentaB = 0;
            par = 0;
            aux = "";
            aux2 = "";
            sig2 = "";
            div = false;
            pot = false;
            resta = false;
            multi = false;
        }
    }
}
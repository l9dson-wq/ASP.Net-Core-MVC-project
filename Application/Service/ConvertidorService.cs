using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ConvertidorService
    {
        double resultado; 
        public void Convert(ConvertidorViewModel cm)
        {
            resultado = 0.0;
            if (cm.Cantidad != 0 && cm.Cantidad >= 1)
            {
                //Peso Dominicano.
                if( cm.Tipo_Convertir == (int)Moneda.DOMINICAN_PESO && cm.Tipo == (int)Moneda.DOMINICAN_PESO)
                {
                    resultado = 1 * cm.Cantidad;

                }else if ( cm.Tipo_Convertir == (int)Moneda.AMERICAN_DOLAR && cm.Tipo == (int)Moneda.DOMINICAN_PESO)
                {
                    resultado = 0.0187 * cm.Cantidad;

                }else if( cm.Tipo_Convertir == (int)Moneda.EURO && cm.Tipo == (int)Moneda.DOMINICAN_PESO)
                {
                    resultado = 0.0187 * cm.Cantidad;
                }
                // Dolar estado unidense.
                else if (cm.Tipo_Convertir == (int)Moneda.DOMINICAN_PESO && cm.Tipo == (int)Moneda.AMERICAN_DOLAR)
                {
                    resultado = 52.4212 * cm.Cantidad;

                }
                else if (cm.Tipo_Convertir == (int)Moneda.AMERICAN_DOLAR && cm.Tipo == (int)Moneda.AMERICAN_DOLAR)
                {
                    resultado = 1 * cm.Cantidad;

                }
                else if (cm.Tipo_Convertir == (int)Moneda.EURO && cm.Tipo == (int)Moneda.AMERICAN_DOLAR)
                {
                    resultado = 0.99983 * cm.Cantidad;
                }

                // Euro
                else if (cm.Tipo_Convertir == (int)Moneda.DOMINICAN_PESO && cm.Tipo == (int)Moneda.EURO)
                {
                    resultado = 52.4216 * cm.Cantidad;

                }
                else if (cm.Tipo_Convertir == (int)Moneda.AMERICAN_DOLAR && cm.Tipo == (int)Moneda.EURO)
                {
                    resultado = 1.00001 * cm.Cantidad;

                }
                else if (cm.Tipo_Convertir == (int)Moneda.EURO && cm.Tipo == (int)Moneda.EURO)
                {
                    resultado = 1 * cm.Cantidad;
                }


            }
            
        }

        public double GetAll()
        {
            return resultado; 
        }
    }
}

using Application.Enums;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ZodiacoService
    {
        public ZodiacoViewModel ZodiacoViewModel { get; set; }
        string SignoZodiaco;

        public void SetZodiaco(ZodiacoViewModel zv)
        {
            SignoZodiaco = string.Empty;

            if (zv.Dia > 0 && zv.Mes > 0)
            {
                switch (zv.Mes)
                {
                    case (int)Meses.ENERO:
                        _ = zv.Dia > 20 ? SignoZodiaco = "Acuario" : SignoZodiaco = "Capricornio";
                        break;
                    case (int)Meses.DICIEMBRE:
                        _ = zv.Dia < 22 ? SignoZodiaco = "Sagitario" : SignoZodiaco = "Capricornio";
                        break;
                    case (int)Meses.FEBRERO:
                        _ = zv.Dia < 20 ? SignoZodiaco = "Acuario" : SignoZodiaco = "Aries";
                        break;
                    case (int)Meses.MARZO:
                        _ = zv.Dia < 20 ? SignoZodiaco = "Acuario" : SignoZodiaco = "Piscis";
                        break;
                    case (int)Meses.ABRIL:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Aries" : SignoZodiaco = "Tauro";
                        break;
                    case (int)Meses.MAYO:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Tauro" : SignoZodiaco = "Geminis";
                        break;
                    case (int)Meses.JUNIO:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Geminis" : SignoZodiaco = "Cancer";
                        break;
                    case (int)Meses.JULIO:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Cancer" : SignoZodiaco = "Leo";
                        break;
                    case (int)Meses.AGOSTO:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Leo" : SignoZodiaco = "Virgo";
                        break;
                    case (int)Meses.SEPTIEMBRE:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Virgo" : SignoZodiaco = "Libra";
                        break;
                    case (int)Meses.OCTUBRE:
                        _ = zv.Dia < 21 ? SignoZodiaco = "Libra" : SignoZodiaco = "Escorpion";
                        break;
                    case (int)Meses.NOVIEMBRE:
                        _ = zv.Dia < 22 ? SignoZodiaco = "Escorpion" : SignoZodiaco = "Sagitario";
                        break;
                }
            }
        }

        public string GetAll()
        {
            return SignoZodiaco;
        }
    }
}

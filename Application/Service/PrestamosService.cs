using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class PrestamosService
    {
        public string testing = string.Empty;

        //tasas
        int TASA_PERSONAL = 22;
        int TASA_AUTOMOVIL = 12;
        int TASA_HIPOTECARIO = 8;

        double resultado_tasa = 0;
        double monto_tasa = 0;
        double resultado_final = 0; 

        public void SetPrestamo(PrestamosViewModel pm)
        {
            if(pm != null && pm.Monto > 0)
            {
                if(pm.Tipo_Prestamo == 1)
                {
                    resultado_tasa = (pm.Monto * TASA_PERSONAL) / 100;
                    monto_tasa = pm.Monto + resultado_tasa;
                    resultado_final = monto_tasa / pm.Meses;
                }else if(pm.Tipo_Prestamo == 2)
                {
                    resultado_tasa = (pm.Monto * TASA_AUTOMOVIL) / 100;
                    monto_tasa = pm.Monto + resultado_tasa;
                    resultado_final = monto_tasa / pm.Meses;
                }else if(pm.Tipo_Prestamo == 3)
                {
                    resultado_tasa = (pm.Monto * TASA_HIPOTECARIO) / 100;
                    monto_tasa = pm.Monto + resultado_tasa;
                    resultado_final = monto_tasa / pm.Meses;
                }
            }
        }

        public double GetAll()
        {
            return resultado_final;
        }
    }
}

using System;

namespace RastreoPaqueteria.Mensajes
{
    public class TiempoTranscurridoMes : AbstractTiempoTranscurridoHandler
    {

        public override double RangoTiempoMaximo => 30;

        public override string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido)
        {
            string mensaje = string.Empty;
            double dias = tiempoTranscurrido.TotalDays;
            if (dias < RangoTiempoMaximo)
            {
                if (Next != null)
                {
                    mensaje = Next.ObtenerMensajeTiempoTranscurrido(tiempoTranscurrido);
                }
            }
            else
            {
                int mes = (int)(dias / RangoTiempoMaximo);
                mensaje = string.Format("{0} mes{1}", mes, (mes > 1) ? "es" : "");
            }


            return mensaje;
        }
    }
}

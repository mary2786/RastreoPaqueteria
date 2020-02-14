using System;

namespace RastreoPaqueteria.Mensajes
{
    public class TiempoTranscurridoHora : AbstractTiempoTranscurridoHandler
    {
        public override double RangoTiempoMaximo => 60;

        public override string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido)
        {
            string mensaje = string.Empty;
            double minutos = tiempoTranscurrido.TotalMinutes;
            if (minutos < RangoTiempoMaximo)
            {
                if (Next != null)
                {
                    mensaje = Next.ObtenerMensajeTiempoTranscurrido(tiempoTranscurrido);
                }
            }
            else
            {
                int hora = (int)(minutos / RangoTiempoMaximo);
                mensaje = string.Format("{0} hora{1}", hora, (hora > 1) ? "s" : "");
            }


            return mensaje;
        }
    }
}
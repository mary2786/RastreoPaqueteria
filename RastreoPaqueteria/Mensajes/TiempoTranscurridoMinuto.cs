using System;

namespace RastreoPaqueteria.Mensajes
{
    public class TiempoTranscurridoMinuto : AbstractTiempoTranscurridoHandler
    {
        public override double RangoTiempoMaximo => 60;

        public override string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido)
        {
            double segundos = tiempoTranscurrido.TotalSeconds;
            string mensaje = string.Empty;
            if (segundos < RangoTiempoMaximo)
            {
                if (Next != null)
                {
                    mensaje = Next.ObtenerMensajeTiempoTranscurrido(tiempoTranscurrido);
                }
            }
            else
            {
                int minutos = (int)(segundos / RangoTiempoMaximo);
                mensaje = string.Format("{0} minuto{1}", minutos, (minutos > 1) ? "s" : "");
            }


            return mensaje;
        }
    }
}
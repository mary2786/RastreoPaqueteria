using System;

namespace RastreoPaqueteria.Mensajes
{
    public class TiempoTranscurridoDia : AbstractTiempoTranscurridoHandler
    {

        public override double RangoTiempoMaximo => 24;

        public override string ObtenerMensajeTiempoTranscurrido(TimeSpan tiempoTranscurrido)
        {
            string mensaje = string.Empty;
            double horas = tiempoTranscurrido.TotalHours;
            if (horas < RangoTiempoMaximo)
            {
                if (Next != null)
                {
                    mensaje = Next.ObtenerMensajeTiempoTranscurrido(tiempoTranscurrido);
                }
            }
            else
            {
                int dia = (int)(horas / RangoTiempoMaximo);
                mensaje = string.Format("{0} día{1}", dia, (dia > 1) ? "s" : "");
            }


            return mensaje;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class TiempoTranscurridoHoraTests
    {

        [TestMethod()]
        [DataRow(1, 59, 59)]
        [DataRow(0, 60, 59)]
        [DataRow(0, 0, 3600)]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAUnaHora_RegresaMensajeQueIndicaUnaHora(int hours, int minutes, int seconds)
        {
            //Arrange
            string mensajeExp = "1 hora";
            TimeSpan timeSpan = new TimeSpan(hours, minutes, seconds);

            //Act
            TiempoTranscurridoHora tiempoTranscurrido = new TiempoTranscurridoHora();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMasDeUnaHora_RegresaMensajeQueIndicaHoras()
        {
            //Arrange
            string mensajeExp = "2 horas";
            TimeSpan timeSpan = new TimeSpan(2, 59, 59);

            //Act
            TiempoTranscurridoHora tiempoTranscurrido = new TiempoTranscurridoHora();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMenosDeUnaHora_RegresaMensajeVacio()
        {
            //Arrange
            string mensajeExp = "";
            TimeSpan timeSpan = new TimeSpan(0, 0, 59, 3);

            //Act
            TiempoTranscurridoHora tiempoTranscurrido = new TiempoTranscurridoHora();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }
    }
}
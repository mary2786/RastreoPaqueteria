using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class TiempoTranscurridoMinutoTests
    {
        [TestMethod()]
        [DataRow(1, 59)]
        [DataRow(0, 60)]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAUnMinuto_RegresaMensajeQueIndicaUnMinuto(int minutos, int segundos)
        {
            //Arrange
            string mensajeExp = "1 minuto";
            TimeSpan timeSpan = new TimeSpan(0, minutos, segundos);

            //Act
            TiempoTranscurridoMinuto tiempoTranscurrido = new TiempoTranscurridoMinuto();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMasDeUnMinuto_RegresaMensajeQueIndicaMinutos()
        {
            //Arrange
            string mensajeExp = "10 minutos";
            TimeSpan timeSpan = new TimeSpan(0, 10, 59);

            //Act
            TiempoTranscurridoMinuto tiempoTranscurrido = new TiempoTranscurridoMinuto();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMenosDeUnMinuto_RegresaMensajeVacio()
        {
            //Arrange
            string mensajeExp = "";
            TimeSpan timeSpan = new TimeSpan(0, 0, 59);

            //Act
            TiempoTranscurridoMinuto tiempoTranscurrido = new TiempoTranscurridoMinuto();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }
    }
}
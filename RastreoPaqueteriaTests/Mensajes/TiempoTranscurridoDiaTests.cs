using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RastreoPaqueteria.Mensajes.Tests
{
    [TestClass()]
    public class TiempoTranscurridoDiaTests
    {
        [TestMethod()]
        [DataRow(1, 10, 2, 3)]
        [DataRow(0, 24, 59, 59)]
        [DataRow(0, 0, 1440, 59)]
        [DataRow(0, 0, 0, 86400)]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAUnDia_RegresaMensajeQueIndicaUnDia(int days, int hours, int minutes, int seconds)
        {
            //Arrange
            string mensajeExp = "1 día";
            TimeSpan timeSpan = new TimeSpan(days, hours, minutes, seconds);

            //Act
            TiempoTranscurridoDia tiempoTranscurrido = new TiempoTranscurridoDia();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMasDeUnDia_RegresaMensajeQueIndicaDias()
        {
            //Arrange
            string mensajeExp = "15 días";
            TimeSpan timeSpan = new TimeSpan(15, 10, 2, 3);

            //Act
            TiempoTranscurridoDia tiempoTranscurrido = new TiempoTranscurridoDia();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

        [TestMethod()]
        public void ObtenerMensajeTiempoTranscurrido_TimespanEquivalenteAMenosDeUnDia_RegresaMensajeVacio()
        {
            //Arrange
            string mensajeExp = "";
            TimeSpan timeSpan = new TimeSpan(0, 10, 2, 3);

            //Act
            TiempoTranscurridoDia tiempoTranscurrido = new TiempoTranscurridoDia();
            string mensajeAct = tiempoTranscurrido.ObtenerMensajeTiempoTranscurrido(timeSpan);

            //Assert
            Assert.AreEqual(mensajeExp, mensajeAct);
        }

    }
}
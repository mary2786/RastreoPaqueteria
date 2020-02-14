using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RastreoPaqueteria.Archivos.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace RastreoPaqueteria.Servicios.Tests
{
    [TestClass()]
    public class ArchivoServiceTests
    {
        private Mock<IFileWrapper> _fileWrapper;
        private Mock<ILectorArchivo> _lectorArchivo;
        private ArchivoService _archivoService;

        [TestInitialize]
        public void Setup()
        {
            _fileWrapper = new Mock<IFileWrapper>();
            _lectorArchivo = new Mock<ILectorArchivo>();
            _archivoService = new ArchivoService(_fileWrapper.Object, _lectorArchivo.Object);
        }

        [TestMethod()]
        public void ArchivoService_ArchivoExiste_LeeArchivoCorrectamente()
        {
            //Arrange
            string path = "";
            _fileWrapper.Setup(s => s.ValidarRutaArchivo(It.IsAny<string>())).Returns(true);
            _lectorArchivo.Setup(s => s.LeerLineas(It.IsAny<string>())).Returns(It.IsAny<List<string>>());

            //Act
            _archivoService.ObtenerLineas(path);

            //Assert
            _fileWrapper.Verify(v => v.ValidarRutaArchivo(It.IsAny<string>()), Times.Once);
            _lectorArchivo.Verify(v => v.LeerLineas(It.IsAny<string>()), Times.Once);
        }

        [TestMethod()]
        public void ArchivoService_ArchivoNoExiste_ThrowDirectoryNotFoundException()
        {
            //Arrange
            string path = "";
            string mensajeExp = "No se encontró el archivo.";
            _fileWrapper.Setup(s => s.ValidarRutaArchivo(It.IsAny<string>())).Returns(false);

            //Act
            DirectoryNotFoundException exception = Assert.ThrowsException<DirectoryNotFoundException>(() => _archivoService.ObtenerLineas(path));

            //Assert
            Assert.AreEqual(mensajeExp, exception.Message);
        }
    }
}
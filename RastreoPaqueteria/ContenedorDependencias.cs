using Microsoft.Extensions.DependencyInjection;
using RastreoPaqueteria.Archivos;
using RastreoPaqueteria.Archivos.Interfaces;
using RastreoPaqueteria.ConfiguracionPaqueterias;
using RastreoPaqueteria.Envio;
using RastreoPaqueteria.Mensajes;
using RastreoPaqueteria.Servicios;
using RastreoPaqueteria.Servicios.Interfaces;
using System;

namespace RastreoPaqueteria
{
    public class ContenedorDependencias
    {
        public IServiceProvider GetServiceProvider()
        {
            IServiceProvider serviceProvider = new ServiceCollection()
           .AddScoped<IFileWrapper, FileWrapper>()
           .AddScoped<ILectorArchivo, LectorArchivo>()
           .AddScoped<IArchivoService, ArchivoService>()
           .AddSingleton<IEnvioService, EnvioService>()
           .AddSingleton<IReloj, Reloj>()
           .AddScoped<IGeneradorMensaje, GeneradorMensaje>()
           .AddScoped<ITiempoTranscurrido, TiempoTranscurrido>()
           .AddScoped<IConvertidorDouble, ConvertidorDouble>()
           .AddScoped<IConvertidorFecha, ConvertidorFecha>()
           .AddScoped<IRastreoService, RastreoService>()
           .AddScoped<IValidadorFormatoPedido, ValidadorFormatoPedido>()
           .AddScoped<IAdministradorMensaje, AdministradorMensaje>()
           .AddScoped<IImpresoraMensaje, ImpresoraMensaje>()
            .AddScoped<IPaqueteriasRepositorio, PaqueteriasRepositorio>()
           .AddScoped<ITransporteService, TransporteService>()
           .AddScoped<IPaqueteriasService, PaqueteriasService>()
           .BuildServiceProvider();

            return serviceProvider;
        }
    }
}

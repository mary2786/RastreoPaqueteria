using Microsoft.Extensions.DependencyInjection;
using RastreoPaqueteria.ConfiguracionPaqueterias;
using RastreoPaqueteria.Dtos;
using RastreoPaqueteria.Paqueterias.Interfaces;
using RastreoPaqueteria.Servicios;
using RastreoPaqueteria.Servicios.Interfaces;
using RastreoPaqueteria.Transportes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace RastreoPaqueteria
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContenedorDependencias contenedor = new ContenedorDependencias();

            IArchivoService archivoService = contenedor.GetServiceProvider().GetService<IArchivoService>();
            IValidadorFormatoPedido validadorFormatoPedido = contenedor.GetServiceProvider().GetService<IValidadorFormatoPedido>();
            IRastreoService rastreoService = contenedor.GetServiceProvider().GetService<IRastreoService>();
            IImpresoraMensaje impresoraMensaje = contenedor.GetServiceProvider().GetService<IImpresoraMensaje>();
            ITransporteService transporteService = contenedor.GetServiceProvider().GetService<ITransporteService>();
            IPaqueteriasService paqueteriasService = contenedor.GetServiceProvider().GetService<IPaqueteriasService>();
            string path = Directory.GetCurrentDirectory() + "/../../../Pedidos.txt";
            try
            {
                List<string> lineas = archivoService.ObtenerLineas(path);
                PedidoDto pedido;
                MensajeDto mensajeDto;
                if (lineas != null)
                {
                    foreach (string linea in lineas)
                    {
                        pedido = validadorFormatoPedido.ValidarFormatoPedido(linea);
                        mensajeDto = new MensajeDto() { Color = ConsoleColor.Red };
                        IPaqueteria paqueteria = paqueteriasService.BuscarPaqueteria(pedido.Paqueteria);
                        if (paqueteria == null)
                        {
                            mensajeDto.Mensaje = string.Format("La Paquetería: [{0}] no se encuentra registrada en nuestra red de distribución.", pedido.Paqueteria);
                        }
                        else
                        {
                            ITransporte transporte = transporteService.BuscarTransporte(paqueteria, pedido.Transporte);
                            if (transporte == null)
                            {
                                mensajeDto.Mensaje = string.Format("La paqueteria: [{0}] no ofrece el servicio de transporte [{1}], te recomendamos cotizar en otra empresa.", pedido.Paqueteria, pedido.Transporte);
                            }
                            else
                            {
                                mensajeDto = rastreoService.ObtenerMensajeRastreo(pedido, paqueteria, transporte);
                            }
                        }

                        impresoraMensaje.ImprimirMensaje(mensajeDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}

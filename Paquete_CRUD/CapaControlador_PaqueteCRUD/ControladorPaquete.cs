using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CapaModelo_PaqueteCRUD.Contratos;
using CapaModelo_PaqueteCRUD.Entidades;
using CapaModelo_PaqueteCRUD.Repositorios;

namespace CapaControlador_PaqueteCRUD
{
    public class ControladorPaquete
    {
        private int idPaquete;
        private int idPedido;
        private string codigoRastreo;
        private decimal peso;
        private decimal alto;
        private decimal ancho;
        private decimal largo;
        private string descripcion;
        private string esFragil;
        private decimal valorDeclarado;
        private string tipo;
        private string estado;

        private readonly IPaqueteRepositorio repo;
        private List<ControladorPaquete> ultimaLista;

        public OperacionCrud OperacionActual { private get; set; }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }

        [Required(ErrorMessage = "El campo Pedido es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El id de pedido debe ser un numero valido")]
        public int IdPedido { get => idPedido; set => idPedido = value; }

        [Required(ErrorMessage = "El codigo de rastreo es requerido")]
        [RegularExpression("^[A-Za-z0-9-]+$", ErrorMessage = "El codigo de rastreo solo admite letras, numeros y guiones")]
        [StringLength(maximumLength: 30, MinimumLength = 5, ErrorMessage = "El codigo de rastreo debe tener entre 5 y 30 caracteres")]
        public string CodigoRastreoPaquete { get => codigoRastreo; set => codigoRastreo = value; }

        [Range(0.01, 10000, ErrorMessage = "El peso debe ser un numero mayor a 0")]
        public decimal PesoPaquete { get => peso; set => peso = value; }

        [Range(0.01, 1000, ErrorMessage = "El alto debe ser un numero mayor a 0")]
        public decimal AltoPaquete { get => alto; set => alto = value; }

        [Range(0.01, 1000, ErrorMessage = "El ancho debe ser un numero mayor a 0")]
        public decimal AnchoPaquete { get => ancho; set => ancho = value; }

        [Range(0.01, 1000, ErrorMessage = "El largo debe ser un numero mayor a 0")]
        public decimal LargoPaquete { get => largo; set => largo = value; }

        [Required(ErrorMessage = "La descripcion es requerida")]
        [StringLength(maximumLength: 255, MinimumLength = 3, ErrorMessage = "La descripcion debe tener entre 3 y 255 caracteres")]
        public string DescripcionPaquete { get => descripcion; set => descripcion = value; }

        [Required(ErrorMessage = "Indique si el paquete es fragil")]
        [RegularExpression("^(SI|NO)$", ErrorMessage = "El campo Fragil solo admite SI o NO")]
        public string FragilPaquete { get => esFragil; set => esFragil = value; }

        [Range(0, 1000000, ErrorMessage = "El valor declarado debe ser un numero positivo")]
        public decimal ValorDeclaradoPaquete { get => valorDeclarado; set => valorDeclarado = value; }

        [Required(ErrorMessage = "El tipo de paquete es requerido")]
        [StringLength(maximumLength: 25, ErrorMessage = "El tipo no puede superar 25 caracteres")]
        public string TipoPaquete { get => tipo; set => tipo = value; }

        [Required(ErrorMessage = "El estado del paquete es requerido")]
        [StringLength(maximumLength: 20, ErrorMessage = "El estado no puede superar 20 caracteres")]
        public string EstadoPaquete { get => estado; set => estado = value; }

        public ControladorPaquete()
        {
            repo = new PaqueteRepositorio();
        }

        public string GuardarInformacion()
        {
            string mensaje;
            try
            {
                Paquete datos = new Paquete();
                datos.IdPaquete = idPaquete;
                datos.IdPedido = idPedido;
                datos.CodigoRastreoPaquete = codigoRastreo;
                datos.PesoPaquete = peso;
                datos.AltoPaquete = alto;
                datos.AnchoPaquete = ancho;
                datos.LargoPaquete = largo;
                datos.DescripcionPaquete = descripcion;
                datos.FragilPaquete = esFragil;
                datos.ValorDeclaradoPaquete = valorDeclarado;
                datos.TipoPaquete = tipo;
                datos.EstadoPaquete = estado;

                switch (OperacionActual)
                {
                    case OperacionCrud.Agregado:
                        repo.Agregar(datos);
                        mensaje = "Grabacion exitosa";
                        break;
                    case OperacionCrud.Modificado:
                        repo.Editar(datos);
                        mensaje = "Actualizacion exitosa";
                        break;
                    case OperacionCrud.Borrado:
                        repo.Eliminar(datos);
                        mensaje = "Eliminacion exitosa";
                        break;
                    default:
                        mensaje = "No se definio ninguna accion";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }

        public List<ControladorPaquete> ConsultarTodos()
        {
            IEnumerable<Paquete> filas = repo.ObtenerTodos();
            ultimaLista = new List<ControladorPaquete>();
            foreach (Paquete item in filas)
            {
                ultimaLista.Add(new ControladorPaquete
                {
                    idPaquete = item.IdPaquete,
                    idPedido = item.IdPedido,
                    codigoRastreo = item.CodigoRastreoPaquete,
                    peso = item.PesoPaquete,
                    alto = item.AltoPaquete,
                    ancho = item.AnchoPaquete,
                    largo = item.LargoPaquete,
                    descripcion = item.DescripcionPaquete,
                    esFragil = item.FragilPaquete,
                    valorDeclarado = item.ValorDeclaradoPaquete,
                    tipo = item.TipoPaquete,
                    estado = item.EstadoPaquete
                });
            }
            return ultimaLista;
        }

        public IEnumerable<ControladorPaquete> FiltrarRegistros(string texto)
        {
            if (ultimaLista == null) return new List<ControladorPaquete>();
            if (string.IsNullOrEmpty(texto)) return ultimaLista;

            return ultimaLista.FindAll(p =>
                p.idPaquete.ToString().Contains(texto) ||
                (p.codigoRastreo != null && p.codigoRastreo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0));
        }
    }
}

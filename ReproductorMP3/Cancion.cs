using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReproductorMP3
{
    internal class Cancion
    {
        private string nombre;
        private string ruta;
        private string ubicacion;
        private string carpetaContenedora;
        private long tamaño;
        private DateTime fechaCreacion;
        private string ultimoAcceso;
        private long duracion;
        private long frecuencia;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string CarpetaContenedora
        {
            get { return carpetaContenedora; }
            set { carpetaContenedora = value; }
        }
        public long Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public string UltimoAcceso
        {
            get { return ultimoAcceso; }
            set { ultimoAcceso = value; }
        }
        public long Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public long Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }

        public override string ToString()
        {
            return Nombre; 
        }
    }
}

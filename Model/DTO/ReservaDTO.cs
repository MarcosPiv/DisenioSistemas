﻿using Model.Enums;
namespace Model.DTO
{
    public abstract class ReservaDTO
    {
        public int idReserva { get; set; }
        public string profesor { get; set; }
        public string nombreCatedra { get; set; }
        public string correoElectronico { get; set; }
        public TipoPeriodo tipoPeriodo { get; set; }
        public int cantidadAlumnos { get; set; }

        public ReservaDTO() { }


        public ReservaDTO(int idReserva, string profesor, string nombreCatedra, string correoElectronico, TipoPeriodo tipoPeriodo, int cantidad_alumnos)
        {
            this.idReserva = idReserva;
            this.profesor = profesor;
            this.nombreCatedra = nombreCatedra;
            this.correoElectronico = correoElectronico;
            this.tipoPeriodo = tipoPeriodo;
            this.cantidadAlumnos = cantidad_alumnos;
        }
    }
}

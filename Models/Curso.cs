using System;
using System.Collections.Generic;


namespace project.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Dirección { get; set; }
        
        public void LimpiarLugar()
        {
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoPuertos.Dto
{
    internal class VehiculoDto
    {
        string matricula = "aaaaa";
        char vehiculoTipo = 'A';
        bool esPuertaSur = false;
        bool esPuertaNorte = false;
        bool esPuertaEste = false;
        bool esPuertaOste = false;
        bool esPuertaPIF = false;
        bool llevaMercancia = false;
        bool mercanciaApta = false;
        DateTime fechaPuertaSur = new DateTime(1999, 12, 31);
        DateTime fechaPuertaNorte = new DateTime(1999, 12, 31);
        DateTime fechaPuertaEste = new DateTime(1999, 12, 31);
        DateTime fechaPuertaOeste = new DateTime(1999, 12, 31);
        DateTime fechaPuertaPIF = new DateTime(1999, 12, 31);

        //constructor vacio
        public VehiculoDto()
        {
        }

        //Constructor de puerta sur
        public VehiculoDto(string matricula, char vehiculoTipo, bool esPuertaSur, bool llevaMercancia, DateTime fechaPuertaSur)
        {
            this.matricula = matricula;
            this.vehiculoTipo = vehiculoTipo;
            this.esPuertaSur = esPuertaSur;
            this.llevaMercancia = llevaMercancia;
            this.fechaPuertaSur = fechaPuertaSur;
        }


        public string Matricula { get => matricula; set => matricula = value; }
        public char VehiculoTipo { get => vehiculoTipo; set => vehiculoTipo = value; }
        public bool EsPuertaSur { get => esPuertaSur; set => esPuertaSur = value; }
        public bool EsPuertaNorte { get => esPuertaNorte; set => esPuertaNorte = value; }
        public bool EsPuertaEste { get => esPuertaEste; set => esPuertaEste = value; }
        public bool EsPuertaPIF { get => esPuertaPIF; set => esPuertaPIF = value; }
        public bool LlevaMercancia { get => llevaMercancia; set => llevaMercancia = value; }
        public bool MercanciaApta { get => mercanciaApta; set => mercanciaApta = value; }
        public DateTime FechaPuertaSur { get => fechaPuertaSur; set => fechaPuertaSur = value; }
        public DateTime FechaPuertaNorte { get => fechaPuertaNorte; set => fechaPuertaNorte = value; }
        public DateTime FechaPuertaEste { get => fechaPuertaEste; set => fechaPuertaEste = value; }
        public DateTime FechaPuertaOeste { get => fechaPuertaOeste; set => fechaPuertaOeste = value; }
        public bool EsPuertaOste { get => esPuertaOste; set => esPuertaOste = value; }
        public DateTime FechaPuertaPIF { get => fechaPuertaPIF; set => fechaPuertaPIF = value; }
    }
}

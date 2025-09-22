using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula7
{
    internal class Carro
    {
        private string chassis;
        private string licensePlate;
        private string cor;
        private string motor; 

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            this.chassis = chassis;
            this.licensePlate = licensePlate;
            this.cor = cor;
            this.motor = motor;
        }
        public string Chassi { get => chassis; set => chassis = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Motor { get => motor; set => motor = value; }
       
    }
}

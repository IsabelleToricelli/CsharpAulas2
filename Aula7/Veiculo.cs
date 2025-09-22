using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    internal class Veiculo
    {
        private string placa;
        //Outra forma de criar o get e sette, clicar com o botão direito na variavel, em seguida na opção Quick Actions.., e depois a primeira opção de encapsulate field

        private int codFabrica; // Nunca é possivel instanciar um veiculo sem código de fabrica.

        public Veiculo(int codFabrica)
        {
            this.codFabrica = codFabrica;
        }

        public string Placa { get => placa; set => placa = value; }

        //Acesso para a variavel privada
        /*
        public void SetPlaca(string placa)
        {
            this.placa = placa;
        }
        */

        
        public void Ligar()
        {
            Console.WriteLine("ligado");
        }
    }
}

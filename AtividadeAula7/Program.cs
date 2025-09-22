using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Lista de carros 
          List<string> carList = new List<string>();
            //Adicionar carros na lista com todas as propriedades preenchidas 
            carList.Add("Chassis:Sendan , Placa: ABC-1234, Cor: Vermelho, Motor: V8");
            carList.Add("Chassis:SUV , Placa: DEF-5678, Cor: Azul, Motor: V6");
            carList.Add("Chassis:Hatch , Placa: GHI-9012, Cor: Preto, Motor: I4");
            carList.Add("Chassis:Pickup , Placa: JKL-3456, Cor: Branco, Motor: V8");
            carList.Add("Chassis:Conversivel , Placa: MNO-7890, Cor: Amarelo, Motor: V6");
            carList.Add("Chassis:Minivan , Placa: PQR-2345, Cor: Prata, Motor: I4");
            carList.Add("Chassis:Coupe , Placa: STU-6789, Cor: Verde, Motor: V8");
            carList.Add("Chassis:Roadster , Placa: VWX-0123, Cor: Laranja, Motor: V6");
            carList.Add("Chassis:Station Wagon , Placa: YZA-4567, Cor: Cinza, Motor: I4");
            carList.Add("Chassis:Microcar , Placa: BCD-8901, Cor: Roxo, Motor: I4");

            //Exibir a lista de carros em um loop foreach
            foreach (string car in carList)
            {
                Console.WriteLine(car);
            }




        }
    }
}

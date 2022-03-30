using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Best_Fuel
{
    class Part_1
    {
        public int Distancia;
        public double Combustivel, Preço_0, Preço_1, Média, Tanque;

        public void Calc(double média, double preço, int distancia, double tanque)
        {
            Tanque = tanque;
            Média = média;
            Combustivel = preço;
            Distancia = distancia;
            Combustivel = distancia / média;
            Preço_0 = Combustivel * preço;
            Preço_1 = Preço_0 * 2;
            Tanque = (Combustivel / tanque) * 2;
        }

        public override string ToString()
        {
            return "Em média será gasto nessa viagem: R$ " + Preço_0.ToString("f2", CultureInfo.InvariantCulture) +
                " e para ida e volta será R$ " + Preço_1.ToString("f2", CultureInfo.InvariantCulture) +
                ", o total de tanques utilizados em média serão " + Tanque.ToString("f1", CultureInfo.InvariantCulture);
        }
    }
}

using System;

namespace programa_6 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Este programa te ayudara a comprobar cuantos digitos tiene 2 digitos, digite un numero del 1-99: ");
			try
			{
				var numero = Convert.ToInt32 (Console.ReadLine());
				if(numero <= 0)
				{
					Console.WriteLine("el numero debe ser positivo");
					return;
				}

				var digitos = Convert.ToString(numero).Length;

				if (digitos < 3)
				{
					Console.WriteLine($"el numero {numero} tiene {digitos} digito es valido ");
				}
				else
				{
					Console.WriteLine($"el numero {numero} tiene {digitos} digitos, no es valido ");
				}

			}catch (Exception ex)
			{
                Console.WriteLine($"ha ocurrido un error: {ex.Message}");
            }
		}
	}
}
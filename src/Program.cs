using System;

namespace Samples.Basics.Enums
{
	class Program
	{
		public static int Main(string[] args)
		{
			Console.WriteLine(ImprimeDia(DiasSemana.Martes));
			Console.WriteLine(ImprimeDia(DiasSemana.Sabado));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			return 0;
		}
		
		static string ImprimeDia(DiasSemana ds)
		{
			string s = null;
			switch(ds)
			{
				case DiasSemana.Lunes:
					s = "Tengo que levantarme temprano";
					break;
				case DiasSemana.Martes:
					s = "Aún no me recupero";
					break;
				case DiasSemana.Miercoles:
					s = "Faltan 2 días";
					break;
				case DiasSemana.Jueves:
					s = "Falta un día solamente";
					break;
				case DiasSemana.Viernes:
					s = "Por fin es viernes";
					break;
				case DiasSemana.Sabado:
					s = "Es el mejor día de la semana";
					break;
				case DiasSemana.Domingo:
					s = "Ya mañana es lunes de nuevo";
					break;
			}
			return s;
		}
	}
}
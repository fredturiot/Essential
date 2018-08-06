using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
	class Program
	{
		static void Main(string[] args)
		{
			// Liste et tableau
			List<string> stringList = new List<string>();
			stringList.Add("test");

			String[] stringTab = new string[] { };
			String[] stringTab2 = new string[10];
			String[] stringTab3 = new string[] { "a", "b", "c" } ;
			stringTab2[0] = "test";



			// if, else if, else
			string condition = "qqchose";
			if ( condition == "qqChose")
				{ }
			else if (condition == "qqChoseDAutre")
				{ }
			else

			// for
			for(int i=0; i <100; i++)
				{ }

			// foreach
			foreach (string test in stringList)
				{ }

			//while
			while (condition== "qqChose")
				{ }

			//switch

			switch(condition)
			{
				case "1":
					break;
				case "2":
					break;
				case "3":
					break;
				default:
					break;
			}
			//Do While
			do
			{ }
			while (condition == "qqChose");

			// appel fonction
			Fonction("param");

			// Dictionnaire
			var dictionnaire = new Dictionary<int, string>();
			dictionnaire[5] = "test";
			dictionnaire[150] = "test2";
			dictionnaire.Add(151, "test3");
			Console.WriteLine(dictionnaire[5]);
			Console.WriteLine(dictionnaire[150]);
			Console.WriteLine(dictionnaire[151]);

			// appel enumeration
			var evenement = new Evenement();
			evenement.JourSemaine = JourSemaine.Lundi;
			do
			{
				Console.WriteLine(evenement.JourSemaine);
				evenement.JourSemaine = (JourSemaine) ((int) evenement.JourSemaine+1);
				
			}
			while (evenement.JourSemaine != JourSemaine.Dimanche) ;

			//try catch
			try
			{ }
			catch (DivideByZeroException exception)
			{ }//a executer si plante
			catch (Exception exception) 
			{
				throw exception;
				throw new Exception("pas content");
			}
			catch // (Exception exception) attrape TOUTES les exceptions
			{ }
			finally
			{ }//tjs executé
				

			Console.ReadLine();
			Console.ReadKey();
		}

		static void Fonction(string param)
		{ }

		// declarationd de class et liens entre elles
		public class ClassTest:Parent
			{
			public string info { get; set; } = "par defaut";
			public ClassGroupeDeTest groupe { get; set; }

		}

		public class Parent { }

		public class ClassGroupeDeTest
		{
			static string info { get; set; } = "par defaut";

			public List<ClassTest> ListeDeTest { get; set; }

		}


		
		// enumeration
		
		public class Evenement
		{
			public JourSemaine JourSemaine { get; set; }
		}
		public enum JourSemaine:int
		{
			Lundi =1,
			Mardi =2,
			Mercredi=3,
			jeudi=4,
			vendredi=5,
			samedi=6,
			Dimanche=7,

		}

	}
}

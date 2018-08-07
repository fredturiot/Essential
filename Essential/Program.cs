using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Essential
{
	class Program
	{
		static void Main(string[] args)
		{
			// Liste et tableau
			List<string> stringList = new List<string>();
			stringList.Add("test");

			String[] stringTab = new string[7] {"","","","","","","" };
			String[] stringTab2 = new string[10];
			String[] stringTab3 = new string[] { "a", "b", "c" } ;
			String[] stringTab4 = new string[] { };//NW!
			List<Ville> villes = new List<Ville>
			{
			new Ville { Nom = "Paris", CodePostal = "75013" },
			new Ville { Nom = "Bordeaux", CodePostal = "33000" },
			new Ville { Nom = "Sarlat-La-Canéda", CodePostal = "24200" },
			new Ville { Nom = "Marseille", CodePostal = "13000" },
			};
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

			//Lecture ecriture de fichier

			//System.IO.File.ReadAllText("chemin du fichier");
			//System.IO.File.WriteAllText("chemin du fichier","contenu");

			

			//lire fichier
			var cheminFichier = @"C:\Temp\villes.txt";
			if(File.Exists(cheminFichier))
			{
				IEnumerable<string> lignesFichier = File.ReadAllLines(cheminFichier);
				var villesDansFichier = new List<Ville>();
				foreach (var ligneFichier in lignesFichier)
				{
					string[] champs = ligneFichier.Split(';');
					var ville = new Ville();
					ville.Nom = champs[0];
					ville.CodePostal = champs[1];

					villesDansFichier.Add(ville);
				}
			}
			else
			{
				//ecrire

				var contenuFichier = new StringBuilder();
				foreach (var ville in villes)
				{
					contenuFichier.AppendLine($"{ville.Nom};{ville.CodePostal}");
					// ou
					contenuFichier.AppendLine(string.Join(";",ville.Nom,ville.CodePostal));
				}

				File.WriteAllText(cheminFichier, contenuFichier.ToString());
			}






			Console.ReadLine();
			Console.ReadKey();



		}

		static void Fonction(string param)
		{ }

		// declarationd de class et liens entre elles
		public class ClassTest:Parent
			{
			public string Info { get; set; } = "par defaut";
			public ClassGroupeDeTest groupe { get; set; }

		}

		public class Parent { }

		public class ClassGroupeDeTest
		{
			static string Info { get; set; } = "par defaut";

			public List<ClassTest> ListeDeTest { get; set; }

		}
		public class Ville
		{
			public string Nom { get; set; }
			public string CodePostal { get; set; }
			public string Departement
			{
				get { return this.CodePostal.Substring(0, 2); }
			}

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

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
	//public static bool nuevojuego=true;
	control_datosGlobalesPersonalizacion cdgP;
	Game datos;

	public void Save()
	{
		//savedGames.Add(Game.current);
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		print ("guardamos");
		datos = new Game ();
		guardamosDatos ();
		Stream file = File.Open ("SavedGame.sg", FileMode.Create); //creamos archivo de guardado
		BinaryFormatter bformatter = new BinaryFormatter ();
		bformatter.Serialize (file, datos);//guardamos las variables
		file.Close ();
	}

	public void Load()
	{
		if (File.Exists ("SavedGame.sg")) 
		{
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

			print("cargamos");
			datos= new Game ();
			Stream file = File.Open ("SavedGame.sg", FileMode.Open); //creamos archivo de guardado
			BinaryFormatter bformatter = new BinaryFormatter ();
			datos = (Game)bformatter.Deserialize(file);
			cargarDatos();
			file.Close ();
		}
	}

	void guardamosDatos()
	{
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

		datos.nuevoJuego = cdgP.nuevoJuego;
		datos.sexo = cdgP.Sexo;
		datos.pelo = cdgP.posicion_pelo;
		datos.piel = cdgP.posicion_piel;
		datos.piernas = cdgP.posicion_piernas;
		datos.camiseta = cdgP.posicion_camiseta;
	}

	void cargarDatos()
	{
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		
		cdgP.nuevoJuego=datos.nuevoJuego;
		cdgP.Sexo=datos.sexo;
		cdgP.posicion_pelo=datos.pelo;
		cdgP.posicion_piel=datos.piel;
		cdgP.posicion_piernas=datos.piernas;
		cdgP.posicion_camiseta=datos.camiseta;
	}
}

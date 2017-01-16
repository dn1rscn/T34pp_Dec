using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
	public static SaveLoad cont;

	//public static bool nuevojuego=true;
	control_datosGlobalesPersonalizacion cdgP;
	ControlDatosGlobales_Mundo3D cdg_3d;
	Game datos;

	void Start () 
	{
		DontDestroyOnLoad (this);
		//guardamosDatos ();
	}
	void Awake ()
	{
		
		if (cont == null) {
			cont = this;
			DontDestroyOnLoad (gameObject);
		} else if (cont != this) {
			Destroy(gameObject);
		}
	}

	public void Save()
	{
		//savedGames.Add(Game.current);
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		print ("guardamos");
		datos = new Game ();
		guardamosDatos ();
		FileStream file = File.Create (Application.persistentDataPath + "SavedGame.sg"); //creamos archivo de guardado
		BinaryFormatter bformatter = new BinaryFormatter ();
		bformatter.Serialize (file, datos);//guardamos las variables
		file.Close ();
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "SavedGame.sg")) 
		{
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

			print("cargamos");
			datos= new Game ();
			FileStream file = File.Open (Application.persistentDataPath + "SavedGame.sg", FileMode.Open); //leemos el archivo de guardado
			BinaryFormatter bformatter = new BinaryFormatter ();
			datos = (Game)bformatter.Deserialize(file); //decodificamos/cargamos el archivo
			cargarDatos();
			file.Close ();
		}
	}

	void guardamosDatos()
	{
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();

		datos.nuevoJuego = cdgP.nuevoJuego;
		datos.sexo = cdgP.Sexo;
		datos.pelo = cdgP.posicion_pelo;
		datos.piel = cdgP.posicion_piel;
		datos.piernas = cdgP.posicion_piernas;
		datos.camiseta = cdgP.posicion_camiseta;

		datos.IslaMec = cdg_3d.IslaMec_Desbloqueada;
		datos.IslaFantas = cdg_3d.IslaFantasma_Desbloqueada;
		datos.Altar = cdg_3d.Altar_Desbloqueado;
		//datos.IKKI = cdg_3d.IKKI;
		datos.destinoHuevo = cdg_3d.destinoHuevo;
		datos.huevoInvisible = cdg_3d.huevoInvisible;
		datos.TutoBosque_Visto = cdg_3d.hemosVisto_TutorialIslaBosque;
		datos.HabladoDino = cdg_3d.hemosHabladoConDino;
		datos.HabladoFant = cdg_3d.hemosHabladoConFantasma;
		datos.HabladoRobot = cdg_3d.hemosHabladoConRobot;
		datos.tenemosHuevo = cdg_3d.tenemosHuevoDino;
		datos.huevoDinoEntregado = cdg_3d.huevoDinoEntregado;
		datos.check_partesGafas = cdg_3d.check_partesGafas;
		datos.tenemosGafas = cdg_3d.tenemosGafasFantasma;
		datos.gafasEntregadas = cdg_3d.gafasFantasmaEntregadas;
		datos.check_bateriasRobot = cdg_3d.check_bateriasRobot;
		datos.tenemosBat = cdg_3d.tenemosBateriasRobot;
		datos.robotAreglado = cdg_3d.robotArreglado;
	}

	void cargarDatos()
	{
		cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		
		cdgP.nuevoJuego=datos.nuevoJuego;
		cdgP.Sexo=datos.sexo;
		cdgP.posicion_pelo=datos.pelo;
		cdgP.posicion_piel=datos.piel;
		cdgP.posicion_piernas=datos.piernas;
		cdgP.posicion_camiseta=datos.camiseta;

		cdg_3d.IslaMec_Desbloqueada=datos.IslaMec;
		cdg_3d.IslaFantasma_Desbloqueada=datos.IslaFantas;
		cdg_3d.Altar_Desbloqueado=datos.Altar;
		//cdg_3d.IKKI=datos.IKKI;
		cdg_3d.destinoHuevo=datos.destinoHuevo;
		cdg_3d.huevoInvisible=datos.huevoInvisible;
		cdg_3d.hemosVisto_TutorialIslaBosque=datos.TutoBosque_Visto;
		cdg_3d.hemosHabladoConDino=datos.HabladoDino;
		cdg_3d.hemosHabladoConFantasma=datos.HabladoFant;
		cdg_3d.hemosHabladoConRobot=datos.HabladoRobot;
		cdg_3d.tenemosHuevoDino=datos.tenemosHuevo;
		cdg_3d.huevoDinoEntregado=datos.huevoDinoEntregado;
		cdg_3d.check_partesGafas=datos.check_partesGafas;
		cdg_3d.tenemosGafasFantasma=datos.tenemosGafas;
		cdg_3d.gafasFantasmaEntregadas=datos.gafasEntregadas;
		cdg_3d.check_bateriasRobot=datos.check_bateriasRobot;
		cdg_3d.tenemosBateriasRobot=datos.tenemosBat;
		cdg_3d.robotArreglado=datos.robotAreglado;
	}
}

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
	Control_PuntuacionObjetos PObjetos;
	ControlMisiones Misiones;
	DatosDesbloqueo DDesbloqueo;
	Control_monedas Monedas;
	ControlSecuencias Secuencias;
	ControlEmociones Emociones;

	void Start () 
	{
		DontDestroyOnLoad (this);

		//CREAMOS ARCHIVO VARIABLES DEFAULT
		//Default();
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
		if(GameObject.Find ("datosGlobalesPersonalizacion")){
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
		}

		print ("guardamos");
		datos = new Game ();
        FileStream file = null;
        guardamosDatos ();
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.Android)
        {
            file = File.Open(Application.persistentDataPath + "SavedGame.sg",FileMode.Create); //creamos archivo de guardado
        }
#if UNITY_IOS
            file = File.Open(Application.persistentDataPath + "SavedGame.sg",FileMode.Create);
#endif


        BinaryFormatter bformatter = new BinaryFormatter ();
		bformatter.Serialize (file, datos);//guardamos las variables
		file.Close ();

	}

	public void Default()
	{
		print ("guardamos Default");
		datos = new Game ();
		guardamosDatos ();
        FileStream file = null;
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.Android)
        {
            file = File.Create(Application.persistentDataPath + "Default.sg"); //creamos archivo de guardado
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            file = File.Create(Application.dataPath + "Default.sg");
        }
		BinaryFormatter bformatter = new BinaryFormatter ();
		bformatter.Serialize (file, datos);//guardamos las variables
		file.Close ();
	}

	public void Load()
	{
        //FileStream file = null;
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.Android)
        {
            if (File.Exists(Application.persistentDataPath + "SavedGame.sg"))
            {
                //cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
                print("cargamos");
                datos = new Game();
                FileStream file = File.Open(Application.persistentDataPath + "SavedGame.sg", FileMode.Open); //leemos el archivo de guardado
                BinaryFormatter bformatter = new BinaryFormatter();
                datos = (Game)bformatter.Deserialize(file); //decodificamos/cargamos el archivo
                cargarDatos();
                file.Close();
            }
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (File.Exists(Application.dataPath + "SavedGame.sg"))
            {
                //cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
                print("cargamos");
                datos = new Game();
                FileStream file = File.Open(Application.dataPath + "SavedGame.sg", FileMode.Open); //leemos el archivo de guardado
                BinaryFormatter bformatter = new BinaryFormatter();
                datos = (Game)bformatter.Deserialize(file); //decodificamos/cargamos el archivo
                cargarDatos();
                file.Close();
            }
        }
        
	}

	public void LoadDefault()
	{
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.Android)
        {
            if (File.Exists(Application.persistentDataPath + "Default.sg"))
            {
                //cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

                print("cargamos Default");
                datos = new Game();
                FileStream file = File.Open(Application.persistentDataPath + "Default.sg", FileMode.Open); //leemos el archivo de guardado
                BinaryFormatter bformatter = new BinaryFormatter();
                datos = (Game)bformatter.Deserialize(file); //decodificamos/cargamos el archivo
                cargarDatos();
                file.Close();
            }
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (File.Exists(Application.dataPath + "Default.sg"))
            {
                //cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
                print("cargamos Default");
                datos = new Game();
                FileStream file = File.Open(Application.dataPath + "Default.sg", FileMode.Open); //leemos el archivo de guardado
                BinaryFormatter bformatter = new BinaryFormatter();
                datos = (Game)bformatter.Deserialize(file); //decodificamos/cargamos el archivo
                cargarDatos();
                file.Close();
            }
        }
       
	}

	void guardamosDatos()
	{
		datos.Idioma=languageDictionary.lang;

		if(GameObject.Find ("datosGlobalesPersonalizacion")){
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

			Game.nuevoJuego = cdgP.nuevoJuego;
			datos.sexo = cdgP.Sexo;
			datos.pelo = cdgP.posicion_pelo;
			datos.piel = cdgP.posicion_piel;
			datos.piernas = cdgP.posicion_piernas;
			datos.camiseta = cdgP.posicion_camiseta;
		}
		if(GameObject.Find ("ControlDatosGlobales")){
			cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();

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
		if(GameObject.Find ("PuntuacionObjetos")){
			PObjetos = GameObject.Find ("PuntuacionObjetos").GetComponent<Control_PuntuacionObjetos> ();

			datos.GafasRecogidas = PObjetos.GafasRecogidas;
			datos.bateriasRecogidas = PObjetos.EnergiaRecogida;
		}
		if(GameObject.Find ("Misiones")){
			Misiones = GameObject.Find ("Misiones").GetComponent<ControlMisiones> ();

			datos.Dado1_Completado = Misiones.Dado1_Completado;
			datos.Sonidos1_Completado = Misiones.Sonidos1_Completado;
			datos.ejerB_3Estrellas = Misiones.ejerB_3estrellas;
			datos.ejerF_3Estrellas = Misiones.ejerF_3estrellas;
			datos.ejerM_3Estrellas = Misiones.ejerM_3estrellas;
			datos.misionDinoCompletada = Misiones.misionDinoCompletada;
			datos.misionFantasmaCompletada = Misiones.misionFantasmaCompletada;
			datos.misionRobotCompletada = Misiones.misionRobotCompletada;
		}
		if(GameObject.Find ("ctrDesbloqueo")){
			DDesbloqueo = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();

			datos.Nivel2Dado = DDesbloqueo.Nivel2Dado;
			datos.Nivel2Sonidos = DDesbloqueo.Nivel2Sonidos;
			datos.Nivel3Sonidos = DDesbloqueo.Nivel3Sonidos;
			datos.secuencia1 = DDesbloqueo.secuencia1;
			datos.Canasta = DDesbloqueo.Canasta;
			datos.ADado = DDesbloqueo.ADado;
			datos.ASonidos = DDesbloqueo.ASonidos;
			datos.AEmpatia = DDesbloqueo.AEmpatia;
		}
		if(GameObject.Find ("controlMonedas")){
			Monedas = GameObject.Find ("controlMonedas").GetComponent<Control_monedas> ();

			datos.monedas = Monedas.monedas;
		}
		if(GameObject.Find ("DatosGlobalesSecuencias")){
			Secuencias = GameObject.Find ("DatosGlobalesSecuencias").GetComponent<ControlSecuencias> ();

			datos.Asecuencias = Secuencias.Asecuencias;
		}
		if(GameObject.Find ("ctrEmociones")){
			Emociones = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();

			datos.ASocialNivel1 = Emociones.ASocialNivel1;
			datos.ASocialNivel3 = Emociones.ASocialNivel3;
			datos.AEmociones = Emociones.AEmociones;
			datos.emociones1_Completado = Emociones.emociones1_completado;
			datos.empatia1_Completado = Emociones.empatia1_completado;
		}
	}

	void cargarDatos()
	{
		languageDictionary.stringList.Clear();

		languageDictionary.lang=datos.Idioma;
		languageDictionary.Lenguaje();

		print("idioma guardado "+datos.Idioma);
		print("idioma cargado "+languageDictionary.lang);

		if(GameObject.Find ("datosGlobalesPersonalizacion")){
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();

			cdgP.nuevoJuego=Game.nuevoJuego;
			cdgP.Sexo=datos.sexo;
			cdgP.posicion_pelo=datos.pelo;
			cdgP.posicion_piel=datos.piel;
			cdgP.posicion_piernas=datos.piernas;
			cdgP.posicion_camiseta=datos.camiseta;
		}
		if(GameObject.Find ("ControlDatosGlobales")){
			cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();

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
		if(GameObject.Find ("PuntuacionObjetos")){
			PObjetos = GameObject.Find ("PuntuacionObjetos").GetComponent<Control_PuntuacionObjetos> ();

			PObjetos.GafasRecogidas = datos.GafasRecogidas;
			PObjetos.EnergiaRecogida = datos.bateriasRecogidas;
		}
		if(GameObject.Find ("Misiones")){
			Misiones = GameObject.Find ("Misiones").GetComponent<ControlMisiones> ();

			Misiones.Dado1_Completado = datos.Dado1_Completado;
			Misiones.Sonidos1_Completado = datos.Sonidos1_Completado;
			Misiones.ejerB_3estrellas = datos.ejerB_3Estrellas;
			Misiones.ejerF_3estrellas = datos.ejerF_3Estrellas;
			Misiones.ejerM_3estrellas = datos.ejerM_3Estrellas;
			Misiones.misionDinoCompletada = datos.misionDinoCompletada;
			Misiones.misionFantasmaCompletada = datos.misionFantasmaCompletada;
			Misiones.misionRobotCompletada = datos.misionRobotCompletada;
		}
		if(GameObject.Find ("ctrDesbloqueo")){
			DDesbloqueo = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();

			DDesbloqueo.Nivel2Dado = datos.Nivel2Dado;
			DDesbloqueo.Nivel2Sonidos = datos.Nivel2Sonidos;
			DDesbloqueo.Nivel3Sonidos = datos.Nivel3Sonidos;
			DDesbloqueo.secuencia1 = datos.secuencia1;
			DDesbloqueo.Canasta = datos.Canasta;
			DDesbloqueo.ADado = datos.ADado;
			DDesbloqueo.ASonidos = datos.ASonidos;
			DDesbloqueo.AEmpatia = datos.AEmpatia;
		}
		if(GameObject.Find ("controlMonedas")){
			Monedas = GameObject.Find ("controlMonedas").GetComponent<Control_monedas> ();

			Monedas.monedas = datos.monedas;
		}
		if(GameObject.Find ("DatosGlobalesSecuencias")){
			Secuencias = GameObject.Find ("DatosGlobalesSecuencias").GetComponent<ControlSecuencias> ();

			Secuencias.Asecuencias = datos.Asecuencias;
		}
		if(GameObject.Find ("ctrEmociones")){
			Emociones = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();

			Emociones.ASocialNivel1 = datos.ASocialNivel1;
			Emociones.ASocialNivel3 = datos.ASocialNivel3;
			Emociones.AEmociones = datos.AEmociones;
			Emociones.emociones1_completado = datos.emociones1_Completado;
			Emociones.empatia1_completado = datos.empatia1_Completado;
		}
	}
}

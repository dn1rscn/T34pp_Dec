using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game 
{
	//control_datosGlobalesPersonalizacion cdgp;

	//DATOS PERSONALIZACION

	public static bool nuevoJuego;

	public int sexo;

	public int pelo;
	public int piel;
	public int piernas;
	public int camiseta;

	//DATOS DATOS GLOBALES
	public bool IslaMec=false;
	public bool IslaFantas=false;
	public bool Altar=false;

	//public bool IKKI=true;

	public int destinoHuevo=1;
	public bool huevoInvisible=false;

	public bool TutoBosque_Visto;

	public bool HabladoDino;
	public bool HabladoFant;
	public bool HabladoRobot;

	public bool tenemosHuevo;
	public bool huevoDinoEntregado;

	public bool[] check_partesGafas;
	public bool tenemosGafas;
	public bool gafasEntregadas;

	public bool[] check_bateriasRobot;
	public bool tenemosBat;
	public bool robotAreglado;


	//DATOS OBJETOS
	public int GafasRecogidas;
	public int bateriasRecogidas;

	//MISIONES
	public bool Dado1_Completado;
	public bool Sonidos1_Completado;

	public bool[] ejerB_3Estrellas;
	public bool[] ejerF_3Estrellas;
	public bool[] ejerM_3Estrellas;

	public bool misionDinoCompletada;
	public bool misionFantasmaCompletada;
	public bool misionRobotCompletada;

	//EJERCICIOS desbloqueo
	public bool Nivel2Dado;

	public bool Nivel2Sonidos;
	public bool Nivel3Sonidos;

	public bool secuencia1;
	public bool Canasta;

	public bool[] ADado;
	public bool[] ASonidos;
	public bool[] AEmpatia;
	public bool[] Asecuencias;
	public bool[] ASocialNivel1;
	public bool[] ASocialNivel3;
	public bool[] AEmociones;

	//MONEDAS
	public int monedas;

	public bool emociones1_Completado;
	public bool empatia1_Completado;
}

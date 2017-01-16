using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game 
{
	//control_datosGlobalesPersonalizacion cdgp;

	//DATOS PERSONALIZACION

	public bool nuevoJuego;

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
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
	GameObject m_oGameObject;

	#region Constructors
	public Entity(string sName)
	{
		m_oGameObject = new GameObject(sName);
	}

	public Entity(GameObject oTemplate)
	{
		m_oGameObject = Object.Instantiate(oTemplate);
	}
	#endregion

	#region Getter
	//Param�tres:
	//fAnchor: Coordonn�e x sur l'objet (point d'ancrage), represent� en ratio (compris entre 0 et 1)
	//'0' repr�sente le point le plus � gauche et '1' le point le plus � droite

	//Return: Position locale x en unit du point pass� en param�tre

	//Ex: pour un objet d'une taille 5,5 positionn� en 0,0
	//GetLocalX(0.5f)	=> 0f
	//GetLocalX(0f)		=> -2.5f
	//GetLocalX(1f)		=> 2.5f
	public float GetLocalX(float fAnchor)
	{
		//TODO
		return -1f;
	}

	//Param�tres:
	//fAnchor: Coordonn�e y sur l'objet (point d'ancrage), represent� en ratio (compris entre 0 et 1)
	//'0' repr�sente le point le plus bas et '1' le point le plus haut

	//Return: Position locale y en unit du point pass� en param�tre

	//Ex: pour un objet d'une taille 5,5 positionn� en 0,0
	//GetLocalX(0.5f)	=> 0f
	//GetLocalX(0f)		=> -2.5f
	//GetLocalX(1f)		=> 2.5f
	public float GetLocalY(float fAnchor)
	{
		//TODO
		return -1f;
	}

	//Return: Taille local x en unit
	public float GetLocalWidth()
	{
		//TODO
		return -1f;
	}

	//Return: Taille local y en unit
	public float GetLocalHeight()
	{
		//TODO
		return -1f;
	}


	//Param�tres:
	//fAnchor: Coordonn�e x sur l'objet, represent� en ratio (compris entre 0 et 1)

	//Return: Position globale x en unit du point pass� en param�tre
	public float GetGlobalX(float fAnchor)
	{
		//TODO
		return -1f;
	}

	//Param�tres:
	//fAnchor: Coordonn�e y sur l'objet represent� en ratio (compris entre 0 et 1)

	//Return: Position globale y en unit du point pass� en param�tre
	public float GetGlobalY(float fAnchor)
	{
		//TODO
		return -1f;
	}

	//Return: Taille global x en unit
	public float GetGlobalWidth()
	{
		//TODO
		return -1f;
	}

	//Return: Taille global y en unit
	public float GetGlobalHeight()
	{
		//TODO
		return -1f;
	}
	#endregion

	#region Setter

	//Param�tres:
	//oParent: Nouveau parent � setter au GameObject
	public void SetParent(Entity oParent)
	{
		//TODO
	}

	//Param�tres:
	//fX: Position x en unit
	//fY: Position y en unit
	public void SetPosition(float fX, float fY)
	{
		//TODO
	}

	//Param�tres:
	//fWidth: Taille x en unit
	//fHeight: Taille y en unit
	public void SetSize(float fWidth, float fHeight)
	{
		//TODO
	}

	//Param�tres:
	//oEntity: Objet � ajouter
	//fRatioX: Position x en ratio
	//fRatioY: Position y en ratio
	//fAnchorX: Point d'ancrage x en ratio
	//fAnchorY: Point d'ancrage y en ratio
	//fRatioWidth: Taille x en ratio
	//fRatioHeight: Taille y en ratio

	//Ajoute l'objet en enfant, le positionne et le dimensionne par rapport au parent
	public void Add(Entity oEntity, float fRatioX, float fRatioY, float fAnchorX, float fAnchorY, float fRatioWidth = -1f, float fRatioHeight = -1f)
	{
		//TODO
	}
	#endregion
}

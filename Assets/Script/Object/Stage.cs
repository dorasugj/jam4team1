using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour 
{
	// PlayerDataGet
	private Player	m_PlayerScr;
	
	// CharData
	public GameObject m_Enemy;
	private Enemy m_Enemyscr;

	public GameObject m_Item;
	private Item m_Itemscr;

	
	
	public void Initialize()
	{
		if(!m_PlayerScr)
			m_PlayerScr = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

		m_Itemscr = m_Item.GetComponent<Item> ();
		m_Enemyscr = m_Enemy.GetComponent<Enemy> ();

		m_PlayerScr.Initialize ();
		m_Itemscr.Initialize ();
		m_Enemyscr.Initialize ();
	}
	
	public void End()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

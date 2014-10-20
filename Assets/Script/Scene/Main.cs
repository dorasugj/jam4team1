using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour 
{
	// player
	public GameObject	m_Player;
	private Player		m_PlayerScr = null;
	
	// Stage
	public GameObject	m_Stage;
	private	Stage		m_StageScr = null;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	public void Initialize()
	{
		// Get Script
		if(! m_PlayerScr)
			m_PlayerScr = m_Player.GetComponent<Player>();
	
		if(! m_StageScr)
			m_StageScr = m_Stage.GetComponent<Stage>();
		
		// Initialize
		m_PlayerScr.Initialize();
		m_StageScr.Initialize();
		
	}
	
	public void End()
	{
		m_PlayerScr.End();
		m_StageScr.End();
	}
	
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	
	
	public static void Clear()
	{
		
	}
}

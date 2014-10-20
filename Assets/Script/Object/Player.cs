using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public const int WAITING = 0;
	public const int BUTTON_TOUCH = 1;
	public const int GOAL = 2;
	public const int GAME_OVER = 3;

	public float Speed;
	
	private Vector3	m_Pos;
	private static int		m_nPhase;

	private Vector3 InitPos;

	private void Awake()
	{
		InitPos = transform.localPosition;
	}
	
	public void Initialize()
	{
		m_nPhase = WAITING;

		transform.localPosition = InitPos;
	}
	
	public void End()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(m_nPhase)
		{
		case WAITING:

			if(Input.GetKeyDown(KeyCode.Space))
			{
				Debug.Log("hit");
				m_nPhase = BUTTON_TOUCH;
			}

			break;
			
		case BUTTON_TOUCH:

			Vector3 BUF = transform.localPosition;
			BUF.y += Speed;
			transform.localPosition = BUF;

			break;

		case GOAL:

			Manager.SceneChange(Manager.SCENE_RESULT);

			break;
			
		}
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("test");
		if (col.gameObject.tag == "goal") 
		{
			Manager.nClear = GOAL;
			m_nPhase = GOAL;
		}

		if (col.gameObject.tag == "enemy") 
		{
			Manager.nClear = GAME_OVER;
			Manager.SceneChange(Manager.SCENE_RESULT);
		}

		if (col.gameObject.tag == "item") 
		{
			col.gameObject.SendMessage("Hit");
		}
	}
	
	
	
	public  static int GetPhase(){return m_nPhase;}


}


using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour 
{
	public const int SCENE_TITLE = 0;
	public const int SCENE_MAIN = 1;
	public const int SCENE_RESULT = 2;

	public static int nClear = 0;

	public GameObject	m_Title;
	private Title		m_TitleScr;
	public GameObject 	m_Main;
	private Main		m_MainScr;
	public GameObject 	m_Result;
	private Result		m_ResultScr;

	private static int	m_nNextScene;
	private static int	m_nCurrentScene;
	
	
	void Awake()
	{
		m_nNextScene = m_nCurrentScene = SCENE_TITLE;
	}
	
	
	// Use this for initialization
	void Start () 
	{
		// get script
		m_TitleScr = GameObject.Find("Title").GetComponent<Title>();
		m_MainScr = GameObject.Find("Main").GetComponent<Main>();
		m_ResultScr = GameObject.Find("Result").GetComponent<Result>();
		
		m_Title.SetActive(false);
		m_Main.SetActive(false);
		m_Result.SetActive(false);
		
		switch(m_nCurrentScene)
		{
		case SCENE_TITLE:
			m_Title.SetActive(true);
			m_TitleScr.Initialize();
			break;
			
		case SCENE_MAIN:
			m_Main.SetActive(true);
			m_MainScr.Initialize();
			break;
			
		case SCENE_RESULT:
			m_Result.SetActive(true);
			m_ResultScr.Initialize();
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(m_nNextScene != m_nCurrentScene)
		{
			// Scene Initializer
			switch(m_nNextScene)
			{
			case SCENE_TITLE:
				m_Title.SetActive(true);
				m_TitleScr.Initialize();
				break;
			
			case SCENE_MAIN:
				m_Main.SetActive(true);
				m_MainScr.Initialize();
				break;
				
			case SCENE_RESULT:
				m_Result.SetActive(true);
				m_ResultScr.Initialize();
				break;
			}
			
			
			switch(m_nCurrentScene)
			{
			case SCENE_TITLE:
				m_TitleScr.End();
				m_Title.SetActive(false);
				break;
			
			case SCENE_MAIN:
				m_MainScr.End();
				m_Main.SetActive(false);
				break;
				
				
			case SCENE_RESULT:
				m_ResultScr.End();
				m_Result.SetActive(false);
				break;
			}

			m_nCurrentScene = m_nNextScene;
		}
	}
	
	
	public static void SceneChange(int nNext)
	{
		if(m_nNextScene == nNext)
			return;
		
		m_nNextScene = nNext;
	}
}

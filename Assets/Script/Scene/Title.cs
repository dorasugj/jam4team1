using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour 
{
	// Use this for initialization
	void Start () {
	
	}
	
	public void Initialize()
	{
		
	}
	
	
	public void End()
	{
		
	}
	
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Z)) {
			Manager.SceneChange(Manager.SCENE_MAIN);
				}

	}
}

using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour {

	public GameObject ResultGood;
	public GameObject ResultBad;

	// Use this for initialization
	void Start () {
	
	}
	
	
	public void Initialize()
	{
		if (Manager.nClear == Player.GOAL) {
						ResultBad.SetActive (false);	
						ResultGood.SetActive (true);
				} 

		else {
			ResultBad.SetActive(true);
			ResultGood.SetActive(false);
				}

	}
	
	
	public void End()
	{
		
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			Manager.SceneChange(Manager.SCENE_TITLE);
		}
	}
}

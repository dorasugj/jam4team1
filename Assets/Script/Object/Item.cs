using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private const int Right = 0;
	private const int RightStop = 1;
	private const int Left = 2;
	private const int LeftStop = 3;
	private const int Max = 4;
	
	private float Timer = 0.0f;

	public GameObject HitObject;

	public float RightLim;
	public float LeftLim;
	
	public int MoveType; 
	
	public float speed;

	private Vector3 InitPos;
	
	private void Awake()
	{
		InitPos = transform.localPosition;
	}

	public void Initialize()
	{
		Timer = 0.0f;

		transform.localPosition = InitPos;

		HitObject.SetActive (false);
	}
	
	public void End()
	{
		
	}

	
	// Update is called once per frame
	void Update () {

				if (Player.GetPhase() != Player.WAITING)
						return;
		
				Vector3 BUF = transform.localPosition;
		
				switch (MoveType) {
				case Right:
						BUF.x += speed;
			
						if (BUF.x > RightLim) {
								BUF.x = RightLim;
				
								MoveType = RightStop;
						}
						break;
			
				case RightStop:
						Timer += Time.deltaTime;
						if (Timer > 0.25f) {
								Timer = 0;
								MoveType = Left;
						}
			
						break;
			
				case Left:
						BUF.x -= speed;
			
						if (BUF.x < LeftLim) {
								BUF.x = LeftLim;
				
								MoveType = LeftStop;
						}
						break;
			
				case LeftStop:
						Timer += Time.deltaTime;
						if (Timer > 0.2f) {
								Timer = 0;
								MoveType = Right;
						}
						break;
			
				case Max:
			
						MoveType = 0;
			
						break;

				}
		transform.localPosition = BUF;
		}

	private void Hit()
	{
		HitObject.SetActive (true);
		HitObject.transform.localPosition = transform.localPosition;
	}
}
using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject Player;
	private Transform CharacterPosition;
	private Camera MainCamera = new Camera();
	private Vector3 PlayerLocation;
	private Vector3 CameraLocation;

	// Use this for initialization
	void Start () 
	{
		
		MainCamera.GetComponent<Camera> ();
		MainCamera.ViewportToScreenPoint (PlayerLocation);
		MainCamera.ScreenPointToRay (PlayerLocation);
	
		//MainCamera.transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () 
	{


	
	}
}

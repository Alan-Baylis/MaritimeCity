using UnityEngine;
using System.Collections;

public class CameraFollowBrendan : MonoBehaviour {

	public GameObject Brendan;
	private Camera MainCamera;

	void Awake()
	{
		MainCamera = GetComponent<Camera> ();

	}

	// Use this for initialization
	void Start () 
	{
	


	}
	
	// Update is called once per frame
	void Update () {

		MainCamera.transform.LookAt (Brendan.gameObject.transform.position);
		Vector3.Lerp (MainCamera.transform.position, Brendan.transform.position, 5.0f);
		//MainCamera.WorldToScreenPoint (Brendan.gameObject.transform.position
	}
}

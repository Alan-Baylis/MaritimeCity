using UnityEngine;
using System.Collections;

public class MainCharacterCamera : MonoBehaviour {

	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	private Camera NewCamera;


	// Use this for initialization
	void Start () 
	{
		gameObject.AddComponent<Camera> ();
		NewCamera = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		Vector3 Point = NewCamera.WorldToViewportPoint (target.position);
		Vector3 delta = target.position - NewCamera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, Point.z));
		Vector3 destination = NewCamera.transform.position + delta;
		NewCamera.transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, dampTime);

	}
}

using UnityEngine;
using System.Collections;

public class NavigationReceiveObject : NavigationInfrastructure, INavigation {

	private GameObject NavigationGameObject;

	// Use this for initialization
	void Start () {
	
		NavigationGameObject = gameObject;
		NavigationGameObject = GameObject.CreatePrimitive (PrimitiveType.Sphere);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{

		Debug.Log ("This has been trespassed");
	}

	#region INavigation implementation
	public void Stop ()
	{
		throw new System.NotImplementedException ();
	}
	public void Play (string StateName)
	{
		throw new System.NotImplementedException ();
	}

	public string GetName(){


		return gameObject.name;

	}
	#endregion
}

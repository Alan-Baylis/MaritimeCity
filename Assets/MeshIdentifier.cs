using UnityEngine;
using System.Collections;

public class MeshIdentifier : MonoBehaviour {


	private GameObject Mesh;

	// Use this for initialization
	void Start () {
	
	}


	void Awake(){

		Mesh = this.gameObject;
		Mesh =  GameObject.CreatePrimitive(PrimitiveType.Sphere);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

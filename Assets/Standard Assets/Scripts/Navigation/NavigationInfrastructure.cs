using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CoreSystems;

public class NavigationInfrastructure : Core {


	List<INavigation> NavInfrastructureList;

	// Use this for initialization
	void Start () {
	
		NavInfrastructureList = new List<INavigation> (10);
		this.gameObject.AddComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Test(){

		foreach (INavigation Nav in NavInfrastructureList) {


			if (Nav.GetName() == "FrontDoor") {


			}


		}


	}


}


interface INavigation{

	void Stop ();

	void Play (string StateName);

	string GetName();

}


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using CoreSystems;


/// <summary>
/// Add the Navigation Infrastructure to each of the characters
/// </summary>
public class NavigationInfrastructure : Core {


    public static NavigationObject[] NavigationObjects;
	List <INavigation> NavInfrastructureList;

	// Use this for initialization
	void Start () {

        NavigationObjects = FindObjectsOfType<NavigationObject>();
		NavInfrastructureList = new List<INavigation> (10);
		this.gameObject.AddComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Test()
    {

		foreach (INavigation Nav in NavInfrastructureList) 
        {

            if (Nav.GetName() == "Front Door")
            {
                //Add a float to decide for how long the subject should walk
                Nav.Play("Walking");

            }

            else if (Nav.GetName() == "Bottom of Stairs")
            {


            }

            else if (Nav.GetName() == "Top of Stairs")
            {

            }

            else if (Nav.GetName() == "Living Room Door")
            {


            }

            else if (Nav.GetName() == "Elli Standing Position")
            {


            }

            else if (Nav.GetName() == "Lawn")
            {


            }


		}


	}


}

interface INavigation{

	void Stop ();

	void Play (string StateName);

	string GetName();

    Vector3 GetPosition();

}


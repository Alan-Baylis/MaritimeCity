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


    public NavigationInfrastructure()
    {



    }

	// Use this for initialization
	void Start () {

        NavigationObjects = FindObjectsOfType<NavigationObject>();
		NavInfrastructureList = new List<INavigation> (10);
		this.gameObject.AddComponent<BoxCollider> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}

public interface INavigation{

    string GetName();

    Vector3 GetPosition();

}

public interface INavigationCommunicationBridge
{

    void PlayAnimation(ICharacterSystem Character, Collider Target, string AnimationState);

    NavigationObject GetObject(string ObjectName);

}


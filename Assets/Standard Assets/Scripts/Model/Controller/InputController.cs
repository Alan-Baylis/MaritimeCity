using UnityEngine;
using System.Collections;


[System.Obsolete]
public class InputController : MonoBehaviour
{
	private static int LocationIterator = 0;
	public static GameObject[] SubdivisionEntities = new GameObject[100];
	RaycastHit NewHit;
	Ray NewRay;
	public GameObject Player = new GameObject();


	// Use this for initialization
	void Start ()
	{
	
		int a = 0;
		int b = 0;

		NewRay.direction = gameObject.transform.position;
		NewRay.origin = Player.gameObject.transform.position;
		Physics.Raycast (NewRay);
		Animator NewAnimator = (Animator)GetComponent("Brendan Animator");


		foreach(GameObject go in SubdivisionEntities)
		{
			go.AddComponent<SphereCollider> ();

		}

	
		//If entities position is equal to one and other, change this 
		if (SubdivisionEntities[a].transform.position == SubdivisionEntities[b].transform.position) 
		{
			//The ray will originate from the first Sub-Division entities
			NewRay.origin = SubdivisionEntities [a].transform.position;
		
			if (Physics.Linecast (SubdivisionEntities [a].transform.position, SubdivisionEntities [a].transform.forward)) 
			{

				Debug.Log (NewHit.ToString());

			}
				
			foreach (GameObject go in SubdivisionEntities) 
			{
				a++;
				b++;

				//Iterates over all the entities
				SubdivisionEntities [a].transform.position -= SubdivisionEntities [b].transform.forward;

			}

		}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}


	//May not be used
	public void TransferLocations(GameObject[] GameLocationsArray, Vector3[] SceneLocationsArray)
	{
		GameLocationsArray = new GameObject[10];
		SceneLocationsArray = new Vector3[10];

		foreach (GameObject obj in GameLocationsArray) 
		{
			LocationIterator++;
			SceneLocationsArray [LocationIterator] = GameLocationsArray [LocationIterator].transform.position;
		}

	}


	void DetectTag()
	{

		int MAXCOUNT = 100;
		Ray NewRay = new Ray();

		Physics.Raycast (NewRay);

		Vector3 Instantiate;

		for(int n = 0; n < MAXCOUNT; n++)
		{
			Vector3[] SceneLocations = new Vector3[MAXCOUNT];
			    //Add Vector to the array for each count 
			SceneLocations[n] = gameObject.transform.position;

			foreach(Vector3 _vector in SceneLocations)
			{
				//prints a ball at the required location 
				//Instantiate(Sphere Object, _vector)

			}

		}

	}
		
	public int GetLocationIterator()
	{
		return LocationIterator;
	}


}


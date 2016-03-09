using UnityEngine;
using CoreSystems;
using DialogueSystems;
using System.Collections;




public class FrontDoor : Core {

    public static GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
    private static AudioSource FrontDoorSource;
    public AudioClip DoorBell;
	Ray FrontDoorRay;
	RaycastHit FrontDoorInfo;


	void Awake()
	{
		FrontDoorGameObject = this.gameObject;

	}


	// Use this for initialization
	[RuntimeInitializeOnLoadMethod]
	void Start ()
    {
		FrontDoorRay = new Ray (FrontDoorGameObject.transform.localPosition, FrontDoorGameObject.transform.forward);
        FrontDoorGameObject = gameObject;
        FrontDoorGameObject.AddComponent<AudioSource>();
        FrontDoorSource = GetComponent<AudioSource>();
        FrontDoorSource.clip = DoorBell;
		BoxFrontDoor = GetComponent<BoxCollider> ();

    }

    void OnTriggerEnter(Collider other)
    {
		other.Raycast(FrontDoorRay, out FrontDoorInfo, 10.0f);

		if (FrontDoorInfo.distance < BrendanPOVController.BrendanInstance.transform.position.x) {

			PlayDoorBell ();
		}

    }

	void ResetDirection(Vector3 A, Vector3 B)
	{
		Quaternion.FromToRotation (A, B);

	}

    public static void PlayDoorBell()
    {
        FrontDoorSource.PlayDelayed(delay: 1.0f);
    }

    public static bool IsDoorBellFinished()
    {
        if (FrontDoorSource.isPlaying == false)
        {
            return true;

        } else if (FrontDoorSource.isPlaying == true)
        {
            return false;

        }

        return false;
    }
	
	// Update is called once per frame
	void Update () {


		Debug.Log ("This was the collider that was hit " + FrontDoorInfo.collider);
	
	}
}

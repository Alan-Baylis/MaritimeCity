using UnityEngine;
using CoreSystems;
using DialogueSystems;
using System.Collections;




public class FrontDoor : Core {

    public static GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
    public static AudioSource FrontDoorSource;
    public AudioClip DoorBell;
	Ray FrontDoorRay;
	RaycastHit FrontDoorInfo;


	void Awake()
	{
		FrontDoorGameObject = gameObject;
		FrontDoorRay = new Ray (FrontDoorGameObject.transform.localPosition, FrontDoorGameObject.transform.forward);
		FrontDoorGameObject.AddComponent<AudioSource>();
		FrontDoorSource = FrontDoorGameObject.GetComponent<AudioSource>();
		FrontDoorSource.clip = DoorBell;
		BoxFrontDoor = GetComponent<BoxCollider> ();
	}


	// Use this for initialization
	[RuntimeInitializeOnLoadMethod]
	void Start ()
    {
		

    }

    void OnTriggerEnter(Collider other)
    {
		other.Raycast(FrontDoorRay, out FrontDoorInfo, 10.0f);

		Destroy (this.gameObject);

    }

	void ResetDirection(Vector3 A, Vector3 B)
	{
		gameObject.transform.rotation = Quaternion.FromToRotation (A, B);

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

		IsDoorBellFinished ();
		Debug.Log ("This was the collider that was hit " + FrontDoorInfo.collider);
	
	}
}

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

    Transform FrontDoorTransform;



    void Awake()
	{
		FrontDoorGameObject = gameObject;
		FrontDoorRay = new Ray (FrontDoorGameObject.transform.localPosition, FrontDoorGameObject.transform.forward);
		FrontDoorGameObject.AddComponent<AudioSource>();
		FrontDoorSource = FrontDoorGameObject.GetComponent<AudioSource>();
		FrontDoorSource.clip = DoorBell;
		BoxFrontDoor = GetComponent<BoxCollider> ();
	}



	void Start ()
    {
 
        StartCoroutine(mUpdate());
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Front Door trigger entered");

		other.Raycast(FrontDoorRay, out FrontDoorInfo, 10.0f);

        StartCoroutine(MaritimeRuntimeInfrastructure.cFrontDoorBell());

		Destroy (other.gameObject);

    }

	void ResetDirection(Vector3 A, Vector3 B)
	{
		//gameObject.transform.rotation = Quaternion.FromToRotation (A, B);

	}

    public static Vector3 GetPosition()
    {
        Vector3 FrontDoorPosition = FrontDoorGameObject.transform.position;

        return FrontDoorPosition;
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
	
    IEnumerator mUpdate()
    {

        //transform.rotation = Quaternion.Lerp(Quaternion.Euler(FrontDoorTransform.eulerAngles), Quaternion.Euler(x: 0, y: 90, z: 0), Time.time / 50);

        PlayDoorBell();

        float DoorBellLength = FrontDoorSource.clip.length * 1.2f;

        yield return new WaitForSeconds(DoorBellLength);

        Quaternion FrontDoorRotation = new Quaternion(0, 0, 0, 0);
        Vector3 FrontDoorPosition = new Vector3(-66.58f, 3.57476f, -22.88f);

        //Two step verification to make sure scene advances correctly
        yield return new WaitUntil(() => FrontDoorSource.isPlaying == false);

        transform.rotation = Quaternion.Slerp(transform.rotation, FrontDoorRotation, Time.time / 30);
        transform.position = Vector3.LerpUnclamped(transform.position, FrontDoorPosition, Time.time);

        //Debug.Log ("This was the collider that was hit " + FrontDoorInfo.collider);

        if (MaritimeRuntimeInfrastructure.RuntimeID == MaritimeRuntimeInfrastructure.SceneID.Start)
        {

            if (IsDoorBellFinished() == true)
            {

                State = CoreDialogueSystems.ConversationState.Active;
                DialogueBoxUI.SetDialogBoxActive();

            }

        }

    }

	// Update is called once per frame
	void Update () {

	
	}
}

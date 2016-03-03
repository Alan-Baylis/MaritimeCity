using UnityEngine;
using CoreSystems;
using DialogueSystems;
using System.Collections;

public class FrontDoor : Core {

    private GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
    private static AudioSource FrontDoorSource;
    public AudioClip DoorBell;

	// Use this for initialization
	void Start ()
    {
		    
        FrontDoorGameObject = gameObject;
        FrontDoorGameObject.AddComponent<AudioSource>();
        FrontDoorSource = GetComponent<AudioSource>();
        FrontDoorSource.clip = DoorBell;
        BoxFrontDoor = GetComponent<BoxCollider>();

    }

    void OnTriggerEnter(Collider other)
    {
      if (BoxFrontDoor.isTrigger == true)
      {
            GetCoreDialogueSystemObject().ConversationStateID = CoreDialogueSystems.ConversationState.Active;
      }

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
	
	}
}

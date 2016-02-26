using UnityEngine;
using CoreSystems;
using DialogueSystems;
using System.Collections;

public class FrontDoor : Core {

    private GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
    private AudioSource FrontDoorSource;
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

    public void PlayDoorBell()
    {
        FrontDoorSource.PlayDelayed(delay: 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using CoreSystems;
using DialogueSystems;
using System.Collections;

public class FrontDoor : Core.CoreEventSystem {

    private GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
    private AudioSource FrontDoorSource;
    public AudioClip DoorBell;

	// Use this for initialization
	void Start () {
		

        
        FrontDoorGameObject = CoreEventObject.CoreNestedType.gameObject;
        FrontDoorGameObject.AddComponent<AudioSource>();
        FrontDoorSource = CoreEventObject.CoreNestedType.GetComponent<AudioSource>();
        FrontDoorSource.clip = DoorBell;
        BoxFrontDoor = CoreEventObject.CoreNestedType.GetComponent<BoxCollider>();
 
  
    }

    void OnTriggerEnter(Collider other)
    {
      if (BoxFrontDoor.isTrigger == true)
      {
            CoreDialogueSystemNestedType.ConversationStateID = Core.CoreDialogueSystems.ConversationState.Active;
      }

    }


    public void PlayDoorBell()
    {
        FrontDoorSource.PlayDelayed(delay: 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

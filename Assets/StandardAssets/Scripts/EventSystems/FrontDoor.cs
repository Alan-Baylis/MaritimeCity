using UnityEngine;
using DialogueSystems;
using System.Collections;

public class FrontDoor : CoreEventSystems {

    private GameObject FrontDoorGameObject;
    private BoxCollider BoxFrontDoor;
	private AudioSource FrontDoorSource;
    private CoreDialogueSystems Core;
    public AudioClip DoorBell;

	// Use this for initialization
	void Start () {
		
        FrontDoorGameObject = this.gameObject;
        FrontDoorGameObject.AddComponent<AudioSource>();
		FrontDoorSource = GetComponent<AudioSource> ();
        FrontDoorSource.clip = DoorBell;
        BoxFrontDoor = GetComponent<BoxCollider>();
        Core = GameObject.FindGameObjectWithTag("Core").GetComponent<CoreDialogueSystems>();
  
    }

    void OnTriggerEnter(Collider other)
    {
      if (BoxFrontDoor.isTrigger == true)
      {
            Core.ConversationStateID = CoreDialogueSystems.ConversationState.Active;
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

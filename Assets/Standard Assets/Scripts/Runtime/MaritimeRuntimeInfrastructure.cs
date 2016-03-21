using UnityEngine;
using CoreSystems;
using System.Collections;
using DialogueSystems;


public class MaritimeRuntimeInfrastructure : MonoBehaviour {


	int MaritimeDialogueIterator = 0;
	GameObject BrendanInstanceObject;

	public Transform[] Locations = new Transform[10];



    

    // Use this for initialization
    void Start () {
	
		BrendanInstanceObject = BrendanPOVController.BrendanSingletonObjectInstance.gameObject;

		StartCoroutine(OpeningSequence_FrontDoorBell ());

	}

	// Update is called once per frame
	void Update () {
		
		MaritimeDialogueIterator = Core.CoreDialogueSystems.MaritimeDialogueIterator;


		if (MaritimeDialogueIterator == 0) {

			LerpOpeningSequence ();

		}

	}


	/// <summary>
	/// When the scene first starts
	/// </summary>
	IEnumerator OpeningSequence_FrontDoorBell() {

		if (MaritimeDialogueIterator == 0) {

			FrontDoor.PlayDoorBell ();

			yield return new WaitForSeconds (FrontDoor.FrontDoorSource.clip.length * 1.1f);

			Quaternion FrontDoorOpen = FrontDoor.FrontDoorGameObject.transform.rotation;

			FrontDoorOpen = Quaternion.FromToRotation (FrontDoor.FrontDoorGameObject.transform.parent.right, FrontDoor.FrontDoorGameObject.transform.up);

			Core.State = Core.CoreDialogueSystems.ConversationState.Active;

		}
	}

	void LerpOpeningSequence() 
	{
		

		BrendanPOVController.BrendanSingletonObjectInstance.transform.localPosition = Vector3.LerpUnclamped(Locations[0].transform.position, Locations[1].transform.position, Time.time / 10);
	}


	IEnumerator Sequence_DogBarking() {


		yield return null;
	}
}

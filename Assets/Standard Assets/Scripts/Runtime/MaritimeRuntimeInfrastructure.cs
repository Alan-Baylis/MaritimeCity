using UnityEngine;
using CoreSystems;
using System.Collections;
using DialogueSystems;


public class MaritimeRuntimeInfrastructure : MonoBehaviour {


	int MaritimeDialogueIterator = 0;
	GameObject BrendanInstanceObject;


	// Use this for initialization
	void Start () {
	
		BrendanInstanceObject = BrendanPOVController.BrendanInstance;

		StartCoroutine(OpeningSequence_FrontDoorBell ());

	}

	// Update is called once per frame
	void Update () {
		
		MaritimeDialogueIterator = Core.CoreDialogueSystems.MaritimeDialogueIterator;

	}


	/// <summary>
	/// When the scene first starts
	/// </summary>
	IEnumerator OpeningSequence_FrontDoorBell() {

		if (MaritimeDialogueIterator == 0) {

			FrontDoor.PlayDoorBell ();
			BrendanPOVController.BrendanInstance.transform.position = Vector3.Lerp(BrendanInstanceObject.transform.position, FrontDoor.FrontDoorGameObject.transform.position, 1.0f);

			yield return new WaitForSeconds (FrontDoor.FrontDoorSource.clip.length * 1.1f);


			Quaternion FrontDoorOpen = FrontDoor.FrontDoorGameObject.transform.rotation;

			FrontDoorOpen = Quaternion.FromToRotation (FrontDoor.FrontDoorGameObject.transform.parent.right, FrontDoor.FrontDoorGameObject.transform.up);

			Core.State = Core.CoreDialogueSystems.ConversationState.Active;

		}
	}


	IEnumerator Sequence_DogBarking() {


		yield return null;
	}
}

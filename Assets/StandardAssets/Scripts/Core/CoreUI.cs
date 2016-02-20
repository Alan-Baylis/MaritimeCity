using UnityEngine;
using System.Collections;

public class CoreUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    public void DialogueBoxOpen()
    {
        GameObject DialogueBox = GameObject.Find("Dialog Box");

        DialogueBox.gameObject.SetActive(true);

        //NewDialogueUIState = DialogueControllerState.Open;
    }

    public void DialogueBoxClose()
    {
        GameObject DialogueBox = GameObject.Find("Dialog Box");

        DialogueBox.gameObject.SetActive(false);

        //NewDialogueUIState = DialogueControllerState.Closed;
    }


}


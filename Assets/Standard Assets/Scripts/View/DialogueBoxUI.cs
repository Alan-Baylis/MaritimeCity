using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueBoxUI : MonoBehaviour {

    private static GameObject DialogBoxGameObject;
	public Canvas DialogueBox;

	// Use this for initialization
	void Start () 
	{

        DialogBoxGameObject = DialogueBox.gameObject;

		DialogueBox.gameObject.SetActive (false);
	
	}
	

    public static void SetDialogBoxActive()
    {
        DialogBoxGameObject.gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {

		if (Time.time > 5.0f) 
		{

			DialogueBox.gameObject.SetActive (true);

		}
	
	}
}

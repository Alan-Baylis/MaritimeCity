using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueBoxUI : MonoBehaviour {


	public Canvas DialogueBox;

	// Use this for initialization
	void Start () 
	{

		DialogueBox.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.deltaTime > 5.0f) 
		{

			DialogueBox.gameObject.SetActive (true);

		}
	
	}
}

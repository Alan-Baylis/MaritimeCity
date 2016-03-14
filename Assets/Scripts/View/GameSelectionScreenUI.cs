using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSelectionScreenUI : MonoBehaviour {

	public Canvas GameSelectionScreen;

	// Use this for initialization
	void Start () {
	
		GameSelectionScreen.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetKeyDown(KeyCode.O))
		{
			GameSelectionScreen.gameObject.SetActive (true);
			Debug.Log ("Keyboard Event Fired");
		}

	}


	void FixedUpdate(){

		if(Input.GetKeyDown(KeyCode.O))
		{
			GameSelectionScreen.gameObject.SetActive (true);

		}

	}
}

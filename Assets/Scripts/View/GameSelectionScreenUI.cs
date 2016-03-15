using UnityEngine;
using CoreSystems;
using UnityEngine.UI;
using System.Collections;

public class GameSelectionScreenUI : MonoBehaviour {

    private GameObject GameSelectionScreenGameObject;
	public Canvas GameSelectionScreen;

	// Use this for initialization
	void Start () {


        GameSelectionScreenGameObject = GameSelectionScreen.gameObject;

		//GameSelectionScreen.gameObject.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	

		if(Core.MaritimeInternalIterator == 1)
		{
            GameSelectionScreenGameObject.gameObject.SetActive(true);
		}

	}


	void FixedUpdate(){

		if(Input.GetKeyDown(KeyCode.O))
		{
			GameSelectionScreen.gameObject.SetActive (true);

		}

	}
}

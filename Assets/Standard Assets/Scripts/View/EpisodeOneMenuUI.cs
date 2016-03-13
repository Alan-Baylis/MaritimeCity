using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EpisodeOneMenuUI : MonoBehaviour {

	public Canvas Menu;
    private static GameObject MenuGameObject;

	// Use this for initialization
	void Start ()
    {
      
        MenuGameObject = Menu.gameObject;

        gameObject.SetActive(false);
	}

    public static void SetGameActive()
    {
        MenuGameObject.SetActive(true);
    }

    public static void SetGameInactive()
    {
        GameObject NewObject = MenuGameObject;

        MenuGameObject.SetActive(false);

        MenuGameObject = NewObject;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSelectionScreenComponent : MonoBehaviour {


    GameObject GameSelectionScreenObject; 
    Canvas GameSelectionScreenCanvas;
    public Button Pause;
    public Button Discussion;

    void Awake()
    {
        GameSelectionScreenObject = new GameObject("Object1");

        GameSelectionScreenCanvas  = GameSelectionScreenObject.GetComponent<Canvas>();
       // Pause = GameSelectionScreenObject.GetComponentInChildren<Button>();
       // Discussion = GameSelectionScreenObject.GetComponentInChildren<Button>();

        Pause.gameObject.SetActive(false);
        Discussion.gameObject.SetActive(false);

        //GameSelectionScreenCanvas.gameObject.SetActive(false);
    }

    void SelectionScreenActive()
    {
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            Pause.gameObject.SetActive(true);
            Discussion.gameObject.SetActive(true);

        }
    }

    void SelectionScreenInactive()
    {
        if (Input.GetKey(KeyCode.P))
        { 
            Pause.gameObject.SetActive(false);
            Pause.gameObject.SetActive(false);
        }

    }

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Edit as needed

        /*
        if(3.0f < Time.realtimeSinceStartup)
        {
            Pause.gameObject.SetActive(true);
        }

        SelectionScreenActive();
        SelectionScreenInactive();

        */
	}

    void FixedUpdate()
    {
        //Testing 
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Keypad Enter Works");
        }



    }
}

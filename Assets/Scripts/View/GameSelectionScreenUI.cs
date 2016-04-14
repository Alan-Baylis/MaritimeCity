using UnityEngine;
using CoreSystems;
using UnityEngine.UI;
using System.Collections;

public class GameSelectionScreenUI : MonoBehaviour {

    private GameObject GameSelectionScreenGameObject;
	public Canvas GameSelectionScreen;
    public Image Pause;
    public Image Discussion;

    enum PulseUI {Clear, Solid};

    PulseUI PulseID;

	// Use this for initialization
	void Start () {

        PulseID = PulseUI.Solid;


        GameSelectionScreenGameObject = GameSelectionScreen.gameObject;

        //GameSelectionScreen.gameObject.SetActive (false);


        StartCoroutine(mPulse());
        StartCoroutine(mPulseID());


    }

    // Update is called once per frame
    void Update () {
	

		if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 1)
		{
            GameSelectionScreenGameObject.gameObject.SetActive(true);
		}


	}




    //Suffering from Stack Over Flow, fix later
    IEnumerator mPulse()
    {
        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator > 1)
        {
            if (PulseID == PulseUI.Solid)
            {
                //Make Discussion Clear
                Discussion.CrossFadeAlpha(50.0f, 0.2f, true);

                yield return new WaitForSeconds(5.0f);
            }

            if (PulseID == PulseUI.Clear)
            {
                //Make Discussion Solid
                Discussion.CrossFadeAlpha(255.0f, 0.2f, true);

                yield return new WaitForSeconds(5.0f);
            }

            StartCoroutine(mPulse());
        }

        StartCoroutine(mPulse());

    }


    IEnumerator mPulseID()
    {
        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 1)
        {

            if (Discussion.color.a == 255.0f)
            {
                PulseID = PulseUI.Solid;

            }

            if (Discussion.color.a == 50.0f)
            {
                PulseID = PulseUI.Clear;
            }


        }

        yield return new WaitForSeconds(1);

        StartCoroutine(mPulseID());
    }


	void FixedUpdate(){

		if (Input.GetKeyDown(KeyCode.O))
		{
			GameSelectionScreen.gameObject.SetActive (true);

		}

	}
}

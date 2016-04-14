using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiscussionBoxUI : MonoBehaviour {


	DiscussionBoxUI DiscussionBoxUISingletonObject;

	private DiscussionBoxUI()
	{



	}

	private string[] DiscussionBoxDialog;

	[SerializeField] private Canvas DiscussionBox;
	[SerializeField] private Text DiscussionBoxTextQuestion1;
	[SerializeField] private Text DiscussionBoxTextQuestion2;
	[SerializeField] private Text DiscussionBoxTextQuestion3;
	[SerializeField] private Image DiscussionBoxImage;

	// Use this for initialization
	void Start ()
    {
	
		DiscussionBoxUISingletonObject = FindObjectOfType<DiscussionBoxUI> ();

		DiscussionBoxImage = DiscussionBox.GetComponentInChildren<Image> ();

		DiscussionBoxDialog = new string[20];

		PopulateDiscussionBoxes ();


	}

	void CrossFadeAlphaDiscussionBoxImage(float alpha, float duration)
	{

		DiscussionBoxImage.CrossFadeAlpha (alpha, duration, false);

	}

	void CrossFadeAlphaDiscussionBoxText(float alpha, float duration)
	{
		DiscussionBoxTextQuestion1.CrossFadeAlpha (alpha, duration, false);
		DiscussionBoxTextQuestion2.CrossFadeAlpha (alpha, duration, false);
		DiscussionBoxTextQuestion3.CrossFadeAlpha (alpha, duration, false);

	}


	//This is where we will implement our questions 
	void PopulateDiscussionBoxes()
	{
		DiscussionBoxDialog [0] = "What would you be thinking at this point";
		DiscussionBoxDialog [1] = "Consider the purpose of the visit and what your strategy be for approaching the situation from now on?";
		//After entering the Lounge and meeting Luke - before the decision point to look at Liam or look at Tara
		DiscussionBoxDialog [2] = "Now that you have entered the home enviroment how are you feeling?";
		DiscussionBoxDialog [3] = "How do you intend to engage with the individuals in the home from this point";
		DiscussionBoxDialog [4] = "What are your thoughts about the behaviours of the individual and the situation";
		DiscussionBoxDialog [5] = "What are the warning signs or triggers, if any?";
		DiscussionBoxDialog [6] = "What protective factors can be identified";
		DiscussionBoxDialog [7] = "Please describe the interactions (if any) between the children and the adults in the home - do you have any concerns and what are they?";

		//On leaving the Home
		DiscussionBoxDialog [8] = "What would you do now and how would you be feeling?";

	}
	
	// Update is called once per frame
	void Update () 
	{

		//DiscussionBoxImage.CrossFadeColor (Color.gray, 10.0f, false, false);

	}
}

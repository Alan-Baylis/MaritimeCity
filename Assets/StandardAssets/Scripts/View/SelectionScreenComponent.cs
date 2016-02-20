using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class SelectionScreenComponent : MonoBehaviour
{
    public Text MenuText;
    public Button ContinueButton;
    public Button ReturnToMenuButton;
    public Button ExitButton;

    public AnimationClip ContinueButtonFadeIn;
    public AnimationClip ContinueButtonFadeOut;
    public AnimationClip ReturnToMenuButtonFadeIn;
    public AnimationClip ReturnToMenuButtonFadeOut;
    public AnimationClip ExitButtonFadeIn;
    public AnimationClip ExitButtonFadeOut;

    

    Animation Animation_ContinueButtonFadeIn = new Animation();
    Animation Animation_ContinueButtonFadeOut = new Animation();
    Animation Animation_ReturnToMenuButtonFadein = new Animation();
    Animation Animation_ReturnToMenuButtonFadeOut = new Animation();
    Animation Animation_ExitButtonFadeIn = new Animation();
    Animation Animation_ExitButtonFadeOut = new Animation();

    // Use this for initialization
    void Start()
    {

        Text.print("Selection Screen Component Operational");

        MenuText.gameObject.SetActive(false);
        ContinueButton.gameObject.SetActive(false);
        ReturnToMenuButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false);

        InitializeAnimation(Animation_ContinueButtonFadeIn, ContinueButtonFadeIn, "Continue Button Fade In");
        InitializeAnimation(Animation_ContinueButtonFadeOut, ContinueButtonFadeOut, "Continue Button Fade Out");
        InitializeAnimation(Animation_ReturnToMenuButtonFadein, ReturnToMenuButtonFadeIn, "Return To Menu Fade In");
        InitializeAnimation(Animation_ReturnToMenuButtonFadeOut, ReturnToMenuButtonFadeOut, "Return To Menu Fade Out");
        InitializeAnimation(Animation_ExitButtonFadeIn, ExitButtonFadeIn, "Exit Button Fade In");
        InitializeAnimation(Animation_ExitButtonFadeOut, ExitButtonFadeOut, "Exit Button Fade Out");
      
        /*
		AnimationEvent ContinueButtonFadeOut_AnimationEvent = new AnimationEvent();
		ContinueButtonFadeOut_AnimationEvent.functionName = "Return To Game";
		ContinueButtonFadeOut.AddEvent (ContinueButtonFadeOut_AnimationEvent);

		AnimationEvent ReturnToMenuButtonFadeOut_AnimationEvent = new AnimationEvent ();
		ReturnToMenuButtonFadeOut_AnimationEvent.functionName = "Return To Menu Screen";
		ReturnToMenuButtonFadeOut.AddEvent (ReturnToMenuButtonFadeOut_AnimationEvent);

		AnimationEvent ExitButtonFadeOut_AnimationEvent = new AnimationEvent ();
		ExitButtonFadeOut_AnimationEvent.functionName = "Exit Game";
		ExitButtonFadeOut.AddEvent (ExitButtonFadeOut_AnimationEvent);
	    */
    }

    void InitializeAnimation(Animation AssignedAnimation, AnimationClip AssignedClip, string AssignedString)
    {
        AssignedAnimation.AddClip(AssignedClip, AssignedString);
    }

    void DefineAnimationClipForButtons()
    {
        //Alternative way #2 of alterating Colors
        ColorBlock cb = ContinueButton.colors;
        cb.normalColor = new Color(0.0f, 0.75f, 1.00f, 0.0f);
        ContinueButton.colors = cb;

        //Alternative way #3 of alterating Colors
        //We will invoke UnityEvents to meet the correct coniditions 
        Color.Lerp(new Color(0.0f, 0.75f, 1.00f, 0.0f), new Color(0.0f, 0.75f, 1.00f, 255.0f), 5.0f);
        ContinueButtonFadeIn.frameRate = 30.0f;

    }

    // Update is called once per frame
    void Update()
    {



    }






}

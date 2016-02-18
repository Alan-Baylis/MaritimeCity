using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


public class Core : MonoBehaviour {


	//UnityAction StartButton = new UnityAction(GUIEvent_StartButtonEvent());


	/// <summary>
	/// Dialogue Element: Signifies when the Conversation has Ended
	/// </summary>
	public UnityEvent UnityEvent_ConversationFinished = new UnityEvent();


	/// <summary>
	/// Dialogue Element: Signifies when Brendan knocks on the Door, the Dog starts barking
	/// </summary>
	public UnityEvent UnityEvent_DogBarking = new UnityEvent();


	/// <summary>
	/// GUI Element: Signifies when the Discussion Box Appears
	/// </summary>
	public UnityEvent UnityEvent_DiscussionBoxAppears = new UnityEvent();

	/// <summary>
	/// GUI Element: Signifies when the Discussion Box Disappears
	/// </summary>
	public UnityEvent UnityEvent_DiscussionBoxDisappears = new UnityEvent();

	/// <summary>
	/// GUI Element: Signifies when the User is interacting with Objects
	/// </summary>
	public UnityEvent UnityEvent_InteractObjectClick = new UnityEvent();

	/// <summary>
	/// GUIElement: Signifies when the User has pressed the Start Button
	/// </summary>
	public UnityEvent UnityEvent_StartButtonEvent = new UnityEvent();

	/// <summary>
	/// GUIElement: Signifies when the User has pressed the Options Button
	/// </summary>
	public UnityEvent UnityEvent_OptionsButtonEvent = new UnityEvent();


	/// <summary>
	/// GUIElement: Signifies when the User has pressed the Exit Button
	/// </summary>
	public UnityEvent UnityEvent_ExitButtionEvent = new UnityEvent();

	RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

	public Core()
	{
		if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor) {

			Debug.Log ("Optimised for Windows");

		} else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer) {

			Debug.Log ("Optimised for Windows");

		}


			
	}
		
	virtual public void SceneEvent_BrendanKnocksDoor()
	{


	}

	virtual public void SceneEvent_EllieKnocksDoor()
	{


	}

	virtual public void SceneEvent_DogStartsBarking()
	{
		

	}


	virtual public void GUIEvent_DiscussionBoxOpen()
	{
		gameObject.SetActive (true);

	}


	virtual public void GUIEvent_DiscussionBoxClose()
	{
		gameObject.SetActive (false);

	}

	virtual public void GUIEvent_InteractObject()
	{
       //Implement click handler code here


		//Include mechnanism for showing us if the mouse is over the GUI Box
		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			//etc

		}

		if (Input.GetKeyUp (KeyCode.Mouse0)) {

			AnimationClip KeyUp_ = new AnimationClip();
			Animation NewAnimation = new Animation();
			NewAnimation.AddClip (KeyUp_, "Key Up Animation");
			NewAnimation.Play ();

		} else if (Input.GetKeyUp (KeyCode.Mouse0)) {

			//Animation NewAnimation = GameObject.Find ("SecondObject_Interact_Demo");
			//NewAnimation.Play ();
		}

	}

	virtual public void GUIEvent_StartButtonEvent()
	{


	}
		

	virtual public void GUIEvent_ExitButtonEvent()
	{


	}


	// Use this for initialization
	void Start () 
	{

		UnityEvent_StartButtonEvent.Invoke ();

	}
	
	// Update is called once per frame
	void Update () 
	{


	}

}

/// <summary>
/// Work on this later, could be useful
/// </summary>
public class G_Array<T> : MonoBehaviour
{
	T[] Backend_G_Array = new T[20];
	

	public G_Array()
	{


	}
		
	public T Add(T ElementType)
	{
		T a = default(T);

		return ElementType;
	
	}

	public void Append(G_Array <T> OtherElement)
	{


	}

	public T AddUnique (T ElementType)
	{

		return ElementType;
	}

}
	

public interface IKeyEvents : IEventSystemHandler
{

	void SceneEvent_BrendanKnocksDoor();

	void SceneEvent_EllieKnocksDoor();

	void SceneEvent_DogStartsBarking();

	void GUIEvent_DiscussionBox();

	void GUIEvent_InteractObject();

	void GUIEvent_StartButtonEvent();

	void GUIEvent_OptionsButtonEvent();

	void GUIEvent_ExitButtonEvent();


}
	


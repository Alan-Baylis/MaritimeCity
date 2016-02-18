using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

//Events will be activated when the Audio array has reached a specific moment in time
//An example would be if the AudioIterator triggered four, this would trigger certain events that would happen 
//Within a Callback that we would specify;  
public class MaritimeEventSystem : Core
{

	//Unity Event is a way of allowing callbacks to be processed in the editor 
	//Unity Action is a way of allowing events to be processed within the code
	//Add Listener within Unity Event does the same thing 
	//You can even add multiple listeners to trigger multiple events

    UnityEventCallState NewCallState = UnityEventCallState.Off;
	public enum SceneState {Cutscene, Dicussion_Box, Conversation, MainMenu};
	//Prototype code for the Unity Interface Messaging System

	void Awake()
	{
		NewCallState = UnityEventCallState.EditorAndRuntime;
		InitializeListeners ();
	}


	void InitializeListeners()
	{

		//UnityEvent_ConversationFinished.AddListener ("tbd");
		UnityEvent_DogBarking.AddListener(SceneEvent_DogStartsBarking);
		UnityEvent_DiscussionBoxAppears.AddListener (GUIEvent_DiscussionBoxOpen);
		UnityEvent_DiscussionBoxDisappears.AddListener (GUIEvent_DiscussionBoxClose);
		UnityEvent_StartButtonEvent.AddListener (GUIEvent_StartButtonEvent);
		UnityEvent_OptionsButtonEvent.AddListener (GUIEvent_ExitButtonEvent);
		UnityEvent_InteractObjectClick.AddListener (GUIEvent_InteractObject);

		//Initialize the call states
		UnityEvent_OptionsButtonEvent.SetPersistentListenerState (1, NewCallState);

	}

	// Use this for initialization
	void Start ()
	{
	

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}


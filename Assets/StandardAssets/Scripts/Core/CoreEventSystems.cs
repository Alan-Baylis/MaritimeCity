using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using System.Collections;

public class CoreEventSystems : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("Core Event Systems Active");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public UnityEvent Test = new UnityEvent();

    public struct SceneEvents
    {
        public UnityEvent DogBarking;
        public UnityEvent OpenDoor;
        public UnityEvent WalkDogUpstairs;
        public UnityEvent Doorbell;
        public UnityAction Action_DogBarking;
        public UnityAction Action_OpenDoor;
        public UnityAction Action_WalkDogUpstairs;
        public UnityAction Action_Doorbell;


        void StructAddPersistantListeners(UnityEventBase unityEvent, UnityAction call)
        {
            UnityEventTools.AddVoidPersistentListener(unityEvent: unityEvent, call: call);
        }

    }

    public struct GUIEvents
    {
        public UnityEvent MainMenuStartButtonEvent;
        public UnityEvent MainMenuOptionsButtonEvent;
        public UnityEvent MainMenuExitButtonEvent;
        public UnityEvent GameSelectionScreenPauseButton;
        public UnityEvent GameSelectionScreenDiscussionButton;

    }

    GUIEvents GUIObject = new GUIEvents();
    SceneEvents SceneObject = new SceneEvents();

    //UnityEventCallState MaritimeCallState = UnityEventCallState.Off;

    void Awake()
    {

        //MaritimeCallState = UnityEventCallState.EditorAndRuntime;

    }
}

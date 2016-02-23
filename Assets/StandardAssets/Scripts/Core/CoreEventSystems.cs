using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using System.Collections;

public class CoreEventSystems : MonoBehaviour {


    public FrontDoor FrontDoorObject;
    public GUIEvents GUIObject = new GUIEvents();
    public SceneEvents SceneObject = new SceneEvents();

    public struct SceneEvents
    {
        public UnityEvent DogBarking;
        public UnityEvent OpenDoor;
        public UnityEvent WalkDogUpstairs;
        public UnityEvent FrontDoor;
        public UnityEvent Doorbell;
        public UnityAction Action_DogBarking;
        public UnityAction Action_OpenDoor;
        public UnityAction Action_WalkDogUpstairs;
        public UnityAction Action_Doorbell;

        public void StructAddPersistantListeners(UnityEventBase unityEvent, UnityAction call)
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

    public void InitializeListeners()
    {
        SceneObject.StructAddPersistantListeners(unityEvent: SceneObject.FrontDoor, call: FrontDoorObject.PlayDoorBell);

    
    }


    // Use this for initialization
    void Start()
    {

        Debug.Log("Core Event Systems Active");
        FrontDoorObject = GameObject.FindGameObjectWithTag("Front Door").GetComponent<FrontDoor>();


        InitializeListeners();

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    //UnityEventCallState MaritimeCallState = UnityEventCallState.Off;

    void Awake()
    {

        //MaritimeCallState = UnityEventCallState.EditorAndRuntime;

    }
}

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using System.Collections;

public class CoreEventSystems : MonoBehaviour {


    public FrontDoor FrontDoorObject;
    public GUIEvents GUIObject = new GUIEvents();
    public SceneEvents SceneObject = new SceneEvents();
    public ColliderFunctions ColliderObject = new ColliderFunctions();
    public AnimationFunctions AnimationObject = new AnimationFunctions();

    public struct SceneEvents
    {
        public UnityEvent DogBarking;
        public UnityEvent OpenDoor;
        public UnityEvent FrontDoor;
        public UnityEvent Doorbell;    
        public UnityEvent ComeDownstairs;
        public UnityEvent WalkDogUpstairs;
        public UnityEvent EnterLivingRoom;
        public UnityEvent CheckCot;
        public UnityEvent ElliLukeCheckCot;
        public UnityEvent BrendanChecksBottle;
        public UnityEvent BrendanPicksBottle;
        public UnityEvent PointsToBrokenGlass;
        public UnityEvent BrendanLeavesHouse;
    

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

    public struct ColliderFunctions
    {
        public bool ElliFinishedTakingDogUpstairs()
        {
            //Do some trigger code here
            return false;
        }

        public bool ElliComesBackDownStairs()
        {
            //Do some trigger code here
            return false;
        }

        public bool ElliEntersLivingRoom()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanEntersLivingRoom()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanChecksCotCollider()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanFrontDoor()
        {
            //Do some trigger code here
            return false;
        }



    }

    public struct AnimationFunctions
    {

        public bool LukePointsFinger()
        {
            //Do some animation code here
            return false;
        }

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

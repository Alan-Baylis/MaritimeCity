using UnityEngine;
using UnityEngine.Events;
using UnityEditor.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace CoreSystems
{

    public class Core : MonoBehaviour
    {


		//public List<string> DialogueIDSequencer = new List<string>();
		public string[] DialogueIDSequencer = new string[108];


	
		public enum ConversationState { Active, Inactive };
		public ConversationState ConversationStateID = ConversationState.Inactive;
		public Text DialogueText;
		public enum ScriptID { Elli, Brendan, Luke };
		public int MaritimeDialogueIterator = 0;

		public bool bWaitUntilPreviousDialogueFinished = false;

        public int newone;

        public enum SceneState { Cutscene, Dicussion_Box, Conversation, MainMenu };

        //UnityAction StartButton = new UnityAction(GUIEvent_StartButtonEvent());



        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

        public Core()
        {
           

        }

        // Use this for initialization
        void Start()
        {
            Debug.Log("Core Active");


            if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor)
            {

                Debug.Log("Optimised for Windows");

            }
            else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer)
            {

                Debug.Log("Optimised for Windows");

            } else if (MaritimeRuntimePlatform == RuntimePlatform.OSXEditor)
            {

                Debug.Log("Not optimized for this platform");

            }

        }


		//public FrontDoor FrontDoorObject;
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


		void StructInitializers()
		{

			SceneObject.DogBarking = new UnityEvent ();
			SceneObject.OpenDoor = new UnityEvent ();
			SceneObject.FrontDoor = new UnityEvent ();
			SceneObject.Doorbell = new UnityEvent ();

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

			Animation NewAnimation;
			//SceneObject.StructAddPersistantListeners(unityEvent: SceneObject.FrontDoor, call: FrontDoorObject.PlayDoorBell);

		}

        // Update is called once per frame
        void Update()
        {


        }



		/// <summary>
		/// We wait for a response from the character in question
		/// </summary>
		public class WaitForResponse : CustomYieldInstruction 
		{
			public override bool keepWaiting {
				get {
					throw new System.NotImplementedException ();
				}
			}


		}
    }

	/// <summary>
	/// We wait for a response from the character in question
	/// </summary>
	public class WaitForResponse : CustomYieldInstruction 
	{
		public override bool keepWaiting {
			get {
				throw new System.NotImplementedException ();
			}
		}


	}

}

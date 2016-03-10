using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using UnityEditor.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DialogueSystems;
using System;

namespace CoreSystems
{
    [InitializeOnLoad]
    public class Core : MonoBehaviour
    {


        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;


        public enum ScriptState
        {
            Elli,
            Brendan,
            Luke,
            Mable,
            NULL
        }

        ;


        public Core()
        {
            MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

        }

        [SerializeField]
        public static ScriptState ScriptStateID = ScriptState.NULL;

        /*

        public static void SetScriptStateIDToMable()
        {
            ScriptStateID = ScriptState.Mable;
        }

        public static void SetScriptStateIDToElli()
        {
            ScriptStateID = ScriptState.Elli;
        }

        public static void SetScriptStateIDToBrendan()
        {
            ScriptStateID = ScriptState.Brendan;
        }

        */

        //Custom modules
        public struct AutomatedCoreDialogueSystem
        {

            Text DialogueText;
            int InternalIterator;


            public void DisplayScript()
            {

            }

            public AutomatedCoreDialogueSystem(Text IDText, int InternalIterator, UnityEvent DisplayScriptDelegate)
            {
                DialogueText = IDText;
                this.InternalIterator = InternalIterator;
                DisplayScriptDelegate = new UnityEvent();
                DisplayScriptDelegate.AddListener(DisplayScript);


                for (int a = 0; a > 100; a++)
                {

                    AutomatedCoreDialogueSystem[] StructArray = new AutomatedCoreDialogueSystem[a];

                    if (StructArray[a].InternalIterator == 1)
                    {

                        //StructCoreDialogueSystem(IDText, 1, );

                    }

                }

            }

        }

        public static class AutomatedNavigationSystem : object
        {

            public static void Walk(Animator CharacterAnimator)
            {
                if (CharacterAnimator.isHuman)
                {



                }

            }

            /// <summary>
            /// Intended to be used within the Update function block
            /// </summary>
            /// <param name="RefTransform">Reference transform.</param>
            /// <param name="Target">Target.</param>
            /// <param name="CharacterAnimator">Character animator.</param>
            /// <param name="TimeWalking">Time walking.</param>
            /// <param name="StateName">State name.</param>
            public static void Walk(Transform RefTransform, Vector3 Target, Animator CharacterAnimator, float TimeWalking, string StateName)
            {

                if (CharacterAnimator.isHuman)
                {

                    //Character looks at the object in question and walks towards it
                    RefTransform.localRotation.SetLookRotation(Target);


                    CharacterAnimator.Play(stateName: StateName);

                    if (Time.deltaTime > TimeWalking)
                    {

                        CharacterAnimator.Stop();


                    }

                }

            }


            public static void TravelTo(Transform From, Transform To, float Speed)
            {

                Vector3.Lerp(From.position, To.position, Speed);

            }

        }

        public static CoreDialogueSystems.ConversationState State = CoreDialogueSystems.ConversationState.Active;

        public static int MaritimeInternalIterator = 0;



        /*

        public enum CoroutineID : short { Elli, Brendan, Luke };

       
        public class SendResponse : CustomYieldInstruction
        {
            public override bool keepWaiting
            {
                get
                {
                    throw new NotImplementedException();
                }
            }
        }

		
        /// <summary>
        /// Designed to receive a Response from Character
        /// </summary>
        public class ReceiveResponse : CustomYieldInstruction
        {
            public CoroutineID response;
            ElliController ElliObject;
            LukeController LukeObject;
            BrendanPOVController BrendanObject;

            int BrendanInternalIterator = 0;
            int ElliInternalIterator = 0;
            int LukeInternalIterator = 0;
          


            public ReceiveResponse(ElliController ElliObject, LukeController LukeObject, BrendanPOVController BrendanObject)
            {
                this.ElliObject = ElliObject;
                this.LukeObject = LukeObject;
                this.BrendanObject = BrendanObject;

                BrendanInternalIterator = BrendanPOVController.GetInternalIterator();
                ElliInternalIterator = ElliController.GetInternalIterator();
                LukeInternalIterator = LukeController.GetInternalIterator();
            }


            public ReceiveResponse(CoroutineID response)
            {
                this.response = response;


                if (this.response == CoroutineID.Brendan)
                {
                    BrendanObject.StartCoroutine(BrendanObject.BrendanDialogueIterator());
                }

                if(this.response == CoroutineID.Elli)
                {
                    ElliObject.StartCoroutine(ElliObject.DialogueIterator());
                }

                if(this.response == CoroutineID.Luke)
                {
                    LukeObject.StartCoroutine(LukeObject.DialogueIterator());
                }
            }

           

            public override bool keepWaiting
            {
                get
                {
                    throw new NotImplementedException();
                }

                

            }
            
			*/


        // Use this for initialization
        void Start()
        {
            Debug.Log("Core Active");


            if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor)
            {

                Debug.Log("Optimized for Windows");

            }
            else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer)
            {

                Debug.Log("Optimized for Windows");

            }
            else if (MaritimeRuntimePlatform == RuntimePlatform.OSXEditor)
            {

                Debug.Log("Not optimized for this platform");

            }


            //BrendanObject = GameObject.FindGameObjectWithTag("Brendan Player").GetComponent<BrendanPOVController>();
            //LukeObject = GameObject.FindGameObjectWithTag("/Luke").GetComponent<LukeController>();
            //ElliObject = GameObject.FindGameObjectWithTag("/Elli").GetComponent<ElliController>();

        }

        /*
		public class MaritimeListSystem<T> : CollectionBase
		{

			T[] InternalList;
			readonly int Size;
			int ListIterator;


			public MaritimeListSystem ()
			{



			}

			public MaritimeListSystem (T[] InternalList, int Size)
			{

				this.InternalList = InternalList;
				this.Size = Size;
				ListIterator = 0;

				Initialize (this.Size);

			}

        
			public void Initialize (int Size)
			{
				InternalList = new T[100];
			}

			public T Find (T Value)
			{
				for (int a = 0; a > 10; a++) {
					if (InternalList [a].Equals (Value)) {
						return Value;
					} else
						return default(T);
				}

				return default(T);
			}

		
            public void Add(T Value)
            {

                //Alternative >>> List.Add();

                if (InternalList[ListIterator] == null)
                {
                    InternalList[ListIterator] = Value;
                    ListIterator++;

                }
                else if (InternalList[ListIterator] != null)
                {

                }

               
            }

			public void Remove (int Index)
			{

               
			}
         
            

		}

*/

        public static class CoreEventSystem
        {

            public static FrontDoor FrontDoorObject;


            //Struct Object





            public static class SceneEvents
            {
                public static UnityEvent DogBarking;
                public static UnityEvent OpenDoor;
                public static UnityEvent FrontDoor;
                public static UnityEvent Doorbell;
                public static UnityEvent ComeDownstairs;
                public static UnityEvent WalkDogUpstairs;
                public static UnityEvent EnterLivingRoom;
                public static UnityEvent CheckCot;
                public static UnityEvent ElliLukeCheckCot;
                public static UnityEvent BrendanChecksBottle;
                public static UnityEvent BrendanPicksBottle;
                public static UnityEvent PointsToBrokenGlass;
                public static UnityEvent BrendanLeavesHouse;


                public static void StructAddPersistantListeners(UnityEventBase unityEvent, UnityAction call)
                {
                    UnityEventTools.AddVoidPersistentListener(unityEvent: unityEvent, call: call);
                }


            }


            static void ClassEventInitializers()
            {
                SceneEvents.DogBarking = new UnityEvent();
                SceneEvents.OpenDoor = new UnityEvent();
                SceneEvents.FrontDoor = new UnityEvent();
                SceneEvents.Doorbell = new UnityEvent();

            }

            public static class GUIEvents
            {
                public static UnityEvent MainMenuStartButtonEvent;
                public static UnityEvent MainMenuOptionsButtonEvent;
                public static UnityEvent MainMenuExitButtonEvent;
                public static UnityEvent GameSelectionScreenPauseButton;
                public static UnityEvent GameSelectionScreenDiscussionButton;

            }

            public static class ColliderFunctions
            {
                public static bool ElliFinishedTakingDogUpstairs()
                {
                    //Do some trigger code here
                    return false;
                }

                public static bool ElliComesBackDownStairs()
                {
                    //Do some trigger code here
                    return false;
                }

                public static bool ElliEntersLivingRoom()
                {
                    //Do some trigger code here
                    return false;
                }

                public static bool BrendanEntersLivingRoom()
                {
                    //Do some trigger code here
                    return false;
                }

                public static bool BrendanChecksCotCollider()
                {
                    //Do some trigger code here
                    return false;
                }

                public static bool BrendanFrontDoor()
                {
                    //Do some trigger code here
                    return false;
                }

            }

            public static class AnimationFunctions
            {

                public static bool LukePointsFinger()
                {
                    //Do some animation code here
                    return false;
                }

            }


            public static void InitializeListeners()
            {

                SceneEvents.StructAddPersistantListeners(unityEvent: SceneEvents.FrontDoor, call: FrontDoor.PlayDoorBell);

            }

        }


        public static class CoreDialogueSystems
        {

            //Dialog types
            public static string[] DialogueIDSequencer = new string[108];
            public static Text DialogueText;
            public static int MaritimeDialogueIterator = 0;

            //Custom enums & bools
            public enum ScriptID
            {
                Elli,
                Brendan,
                Luke
            };

            public enum ConversationState
            {
                Active,
                Inactive

            };


            //Custom type objects
            private static ConversationState ConversationStateID = ConversationState.Inactive;

            public static void SetConversationStateInactive()
            {

                ConversationStateID = ConversationState.Inactive;
            }

            public static void SetConversationStateActive()
            {

                ConversationStateID = ConversationState.Active;
            }


            static void Awake()
            {
                InitializeDialogueIterator();

            }


            static void Start()
            {

            }

            static void Update()
            {

            }

            public static void InitializeDialogueIterator(string[] DialogueIDSequencer)
            {

                DialogueIDSequencer[0] = "B1_S1";
                DialogueIDSequencer[1] = ("B1_S2");
                DialogueIDSequencer[2] = ("B1_S3");
                DialogueIDSequencer[3] = ("B1_S4");
                DialogueIDSequencer[4] = ("E1_S1");
                DialogueIDSequencer[5] = ("E1_S2");
                DialogueIDSequencer[6] = ("E1_S3");
                DialogueIDSequencer[7] = ("E1_S4");
                DialogueIDSequencer[8] = ("E1_S5");
                DialogueIDSequencer[9] = ("B2_S1");
                DialogueIDSequencer[10] = ("B2_S2");
                DialogueIDSequencer[11] = ("B2_S3");
                DialogueIDSequencer[12] = ("B2_S3");
                DialogueIDSequencer[13] = ("E2_S1");
                DialogueIDSequencer[14] = ("E2_S2");
                DialogueIDSequencer[15] = ("B3_S1");
                DialogueIDSequencer[16] = ("B3_S2");
                DialogueIDSequencer[17] = ("B3_S3");
                DialogueIDSequencer[18] = ("E3_S1");
                DialogueIDSequencer[19] = ("E3_S2");
                DialogueIDSequencer[20] = ("E3_S3");
                DialogueIDSequencer[21] = ("B4_S1");
                DialogueIDSequencer[22] = ("B4_S2");
                DialogueIDSequencer[23] = ("E4_S1");
                DialogueIDSequencer[24] = ("B5_S1");
                DialogueIDSequencer[25] = ("B6_S1");
                DialogueIDSequencer[26] = ("B6_S2");
                DialogueIDSequencer[27] = ("B6_S3");
                DialogueIDSequencer[28] = ("B6_S4");
                DialogueIDSequencer[29] = ("L1_T1_S1");
                DialogueIDSequencer[30] = ("B7_S1");
                DialogueIDSequencer[31] = ("B7_S2");
                DialogueIDSequencer[32] = ("E7_S1");
                DialogueIDSequencer[33] = ("B8_S1");
                DialogueIDSequencer[34] = ("E8_S1");
                DialogueIDSequencer[35] = ("L2_S1");
                DialogueIDSequencer[36] = ("B9_S1");
                DialogueIDSequencer[37] = ("L3_S1");
                DialogueIDSequencer[38] = ("B10_S1");
                DialogueIDSequencer[39] = ("B10_S2");
                DialogueIDSequencer[40] = ("B10_S3");
                DialogueIDSequencer[41] = ("B10_S4");
                DialogueIDSequencer[42] = ("E8_S1");
                DialogueIDSequencer[43] = ("B11_S1");
                DialogueIDSequencer[44] = ("E9_S1");
                DialogueIDSequencer[45] = ("B12_S1");
                DialogueIDSequencer[46] = ("E10_S1");
                DialogueIDSequencer[47] = ("E10_S2");
                DialogueIDSequencer[48] = ("E10_S3");
                DialogueIDSequencer[49] = ("B13_S1");
                DialogueIDSequencer[50] = ("E11_S1");
                DialogueIDSequencer[51] = ("E11_S1");
                DialogueIDSequencer[52] = ("B14_S1");
                DialogueIDSequencer[53] = ("E12_S1");
                DialogueIDSequencer[54] = ("E12_S2");
                DialogueIDSequencer[55] = ("B15_S1");
                DialogueIDSequencer[56] = ("E13_S1");
                DialogueIDSequencer[57] = ("B16_S1");
                DialogueIDSequencer[58] = ("B16_S2");
                DialogueIDSequencer[59] = ("L4_S1");
                DialogueIDSequencer[60] = ("B17_S1");
                DialogueIDSequencer[61] = ("E14_S1");
                DialogueIDSequencer[62] = ("E14_S2");
                DialogueIDSequencer[63] = ("L5_S1");
                DialogueIDSequencer[64] = ("B18_S1");
                DialogueIDSequencer[65] = ("B18_S2");
                DialogueIDSequencer[66] = ("B18_S3");
                DialogueIDSequencer[67] = ("L6_S1");
                DialogueIDSequencer[68] = ("B19_S1");
                DialogueIDSequencer[69] = ("L7_S1");
                DialogueIDSequencer[70] = ("B20_S1");
                DialogueIDSequencer[71] = ("L8_S1");
                DialogueIDSequencer[72] = ("E15_S1");
                DialogueIDSequencer[73] = ("E15_S2");
                DialogueIDSequencer[74] = ("E15_S3");
                DialogueIDSequencer[75] = ("B21_S1");
                DialogueIDSequencer[76] = ("E16_S1");
                DialogueIDSequencer[77] = ("B22_S1");
                DialogueIDSequencer[78] = ("E17_S1");
                DialogueIDSequencer[79] = ("B23_S1");
                DialogueIDSequencer[80] = ("E18_S1");
                DialogueIDSequencer[81] = ("E18_S2");
                DialogueIDSequencer[82] = ("L9_S1");
                DialogueIDSequencer[83] = ("L9_S2");
                DialogueIDSequencer[84] = ("L9_S3");
                DialogueIDSequencer[85] = ("L9_S4");
                DialogueIDSequencer[86] = ("L9_S5");
                DialogueIDSequencer[87] = ("B24_S1");
                DialogueIDSequencer[88] = ("L10_S1");
                DialogueIDSequencer[89] = ("B25_S1");
                DialogueIDSequencer[90] = ("L11_S1");
                DialogueIDSequencer[91] = ("E19_S1");
                DialogueIDSequencer[92] = ("E19_S2");
                DialogueIDSequencer[93] = ("E19_S3");
                DialogueIDSequencer[94] = ("B26_S1");
                DialogueIDSequencer[95] = ("B26_S2");
                DialogueIDSequencer[96] = ("L12_S1");
                DialogueIDSequencer[97] = ("B27_S1");
                DialogueIDSequencer[98] = ("B27_S2");
                DialogueIDSequencer[99] = ("B27_S3");
                DialogueIDSequencer[100] = ("L13_S1");
                DialogueIDSequencer[101] = ("E20_S1");
                DialogueIDSequencer[102] = ("B28_S1");
                DialogueIDSequencer[103] = ("E21_S1");
                DialogueIDSequencer[104] = ("B29_S1");
                DialogueIDSequencer[105] = ("B29_S2");
                DialogueIDSequencer[106] = ("B29_S3");
                DialogueIDSequencer[107] = ("B29_S4");


            }


            public static void InitializeDialogueIterator()
            {

                DialogueIDSequencer[0] = "B1_S1";
                DialogueIDSequencer[1] = ("B1_S2");
                DialogueIDSequencer[2] = ("B1_S3");
                DialogueIDSequencer[3] = ("B1_S4");
                DialogueIDSequencer[4] = ("E1_S1");
                DialogueIDSequencer[5] = ("E1_S2");
                DialogueIDSequencer[6] = ("E1_S3");
                DialogueIDSequencer[7] = ("E1_S4");
                DialogueIDSequencer[8] = ("E1_S5");
                DialogueIDSequencer[9] = ("B2_S1");
                DialogueIDSequencer[10] = ("B2_S2");
                DialogueIDSequencer[11] = ("B2_S3");
                DialogueIDSequencer[12] = ("B2_S3");
                DialogueIDSequencer[13] = ("E2_S1");
                DialogueIDSequencer[14] = ("E2_S2");
                DialogueIDSequencer[15] = ("B3_S1");
                DialogueIDSequencer[16] = ("B3_S2");
                DialogueIDSequencer[17] = ("B3_S3");
                DialogueIDSequencer[18] = ("E3_S1");
                DialogueIDSequencer[19] = ("E3_S2");
                DialogueIDSequencer[20] = ("E3_S3");
                DialogueIDSequencer[21] = ("B4_S1");
                DialogueIDSequencer[22] = ("B4_S2");
                DialogueIDSequencer[23] = ("E4_S1");
                DialogueIDSequencer[24] = ("B5_S1");
                DialogueIDSequencer[25] = ("B6_S1");
                DialogueIDSequencer[26] = ("B6_S2");
                DialogueIDSequencer[27] = ("B6_S3");
                DialogueIDSequencer[28] = ("B6_S4");
                DialogueIDSequencer[29] = ("L1_T1_S1");
                DialogueIDSequencer[30] = ("B7_S1");
                DialogueIDSequencer[31] = ("B7_S2");
                DialogueIDSequencer[32] = ("E7_S1");
                DialogueIDSequencer[33] = ("B8_S1");
                DialogueIDSequencer[34] = ("E8_S1");
                DialogueIDSequencer[35] = ("L2_S1");
                DialogueIDSequencer[36] = ("B9_S1");
                DialogueIDSequencer[37] = ("L3_S1");
                DialogueIDSequencer[38] = ("B10_S1");
                DialogueIDSequencer[39] = ("B10_S2");
                DialogueIDSequencer[40] = ("B10_S3");
                DialogueIDSequencer[41] = ("B10_S4");
                DialogueIDSequencer[42] = ("E8_S1");
                DialogueIDSequencer[43] = ("B11_S1");
                DialogueIDSequencer[44] = ("E9_S1");
                DialogueIDSequencer[45] = ("B12_S1");
                DialogueIDSequencer[46] = ("E10_S1");
                DialogueIDSequencer[47] = ("E10_S2");
                DialogueIDSequencer[48] = ("E10_S3");
                DialogueIDSequencer[49] = ("B13_S1");
                DialogueIDSequencer[50] = ("E11_S1");
                DialogueIDSequencer[51] = ("E11_S1");
                DialogueIDSequencer[52] = ("B14_S1");
                DialogueIDSequencer[53] = ("E12_S1");
                DialogueIDSequencer[54] = ("E12_S2");
                DialogueIDSequencer[55] = ("B15_S1");
                DialogueIDSequencer[56] = ("E13_S1");
                DialogueIDSequencer[57] = ("B16_S1");
                DialogueIDSequencer[58] = ("B16_S2");
                DialogueIDSequencer[59] = ("L4_S1");
                DialogueIDSequencer[60] = ("B17_S1");
                DialogueIDSequencer[61] = ("E14_S1");
                DialogueIDSequencer[62] = ("E14_S2");
                DialogueIDSequencer[63] = ("L5_S1");
                DialogueIDSequencer[64] = ("B18_S1");
                DialogueIDSequencer[65] = ("B18_S2");
                DialogueIDSequencer[66] = ("B18_S3");
                DialogueIDSequencer[67] = ("L6_S1");
                DialogueIDSequencer[68] = ("B19_S1");
                DialogueIDSequencer[69] = ("L7_S1");
                DialogueIDSequencer[70] = ("B20_S1");
                DialogueIDSequencer[71] = ("L8_S1");
                DialogueIDSequencer[72] = ("E15_S1");
                DialogueIDSequencer[73] = ("E15_S2");
                DialogueIDSequencer[74] = ("E15_S3");
                DialogueIDSequencer[75] = ("B21_S1");
                DialogueIDSequencer[76] = ("E16_S1");
                DialogueIDSequencer[77] = ("B22_S1");
                DialogueIDSequencer[78] = ("E17_S1");
                DialogueIDSequencer[79] = ("B23_S1");
                DialogueIDSequencer[80] = ("E18_S1");
                DialogueIDSequencer[81] = ("E18_S2");
                DialogueIDSequencer[82] = ("L9_S1");
                DialogueIDSequencer[83] = ("L9_S2");
                DialogueIDSequencer[84] = ("L9_S3");
                DialogueIDSequencer[85] = ("L9_S4");
                DialogueIDSequencer[86] = ("L9_S5");
                DialogueIDSequencer[87] = ("B24_S1");
                DialogueIDSequencer[88] = ("L10_S1");
                DialogueIDSequencer[89] = ("B25_S1");
                DialogueIDSequencer[90] = ("L11_S1");
                DialogueIDSequencer[91] = ("E19_S1");
                DialogueIDSequencer[92] = ("E19_S2");
                DialogueIDSequencer[93] = ("E19_S3");
                DialogueIDSequencer[94] = ("B26_S1");
                DialogueIDSequencer[95] = ("B26_S2");
                DialogueIDSequencer[96] = ("L12_S1");
                DialogueIDSequencer[97] = ("B27_S1");
                DialogueIDSequencer[98] = ("B27_S2");
                DialogueIDSequencer[99] = ("B27_S3");
                DialogueIDSequencer[100] = ("L13_S1");
                DialogueIDSequencer[101] = ("E20_S1");
                DialogueIDSequencer[102] = ("B28_S1");
                DialogueIDSequencer[103] = ("E21_S1");
                DialogueIDSequencer[104] = ("B29_S1");
                DialogueIDSequencer[105] = ("B29_S2");
                DialogueIDSequencer[106] = ("B29_S3");
                DialogueIDSequencer[107] = ("B29_S4");

            }


            public interface IDialogueSystems
            {

                void PlayAudio(string AudioID);

                void DisplayScript(string ScriptID);

                void PopulateScript();


            }

        }

        public static class CoreInput
        {


            public static AnimationClip BrendanWalk = new AnimationClip();

            // Use this for initialization

            public static void SetBodyPosition(Animator animator, Vector3 Position)
            {
                animator.bodyPosition = Position;

            }

            public static void SetBodyRotation(Animator animator, Quaternion Rotation)
            {
                animator.bodyRotation = Rotation;
            }

            interface IControllerBase
            {
                //Defines where the controller should walk to and how 
                void WalkTo();



            }


        }


        public class CoreUI : IEventSystemHandler
        {

            // Use this for initialization
            void Start()
            {

                Debug.Log("Core UI Active");

            }

            // Update is called once per frame
            void Update()
            {

            }

            public static void DialogueBoxOpen()
            {
                GameObject DialogueBox = GameObject.Find("Dialog Box");

                DialogueBox.gameObject.SetActive(true);

                //NewDialogueUIState = DialogueControllerState.Open;
            }

            public static void DialogueBoxClose()
            {
                GameObject DialogueBox = GameObject.Find("Dialog Box");

                DialogueBox.gameObject.SetActive(false);

                //NewDialogueUIState = DialogueControllerState.Closed;
            }


        }

    }



    public interface ICommunciation
	{

		void PlayAudio (string AudioID);

		void DisplayScript (string ScriptID);

		IEnumerator DialogueIterator ();


	}

    public interface IAnimatorBase
    {

  

    }

    public interface INavigationInfrastructure
    {

        void TurnToSpecifiedAngle();

        void WalkTo(Vector3 Position);

        void Stop();

        void SendCoordinates(Vector3 Coordinates);

        void ReceiveCoordinates(Vector3 Coordinates);


        //This string will identify itself according to which GameObject that it is in
        string IdentificationProcess();

    }

    [InitializeOnLoad]
    public class NavigationSystem : Core, INavigationInfrastructure
    {

        GameObject CurrentObject;
        GameObject[] ObjectColliders = new GameObject[10];

        void Start()
        {

            //Assigns object the script is loaded to CurrentObject
            CurrentObject = GameObject.FindGameObjectWithTag(gameObject.name);
            CurrentObject.AddComponent<BoxCollider>().isTrigger = true;

        }


        void Update()
        {




        }

        //Provide a list of the gameObjects so we know what they are

        public void OnTriggerEnter(Collider other)
        {
            if (other.name == "Elli" && CurrentObject.name == "FrontDoor")
            {   
                //Walk to living room
                WalkTo(ObjectColliders[1].transform.position);
            }

        }

        public string IdentificationProcess()
        {
            string ID = gameObject.name;
            return ID;
        }

        public void ReceiveCoordinates(Vector3 Coordinates)
        {
            throw new NotImplementedException();
        }

        public void SendCoordinates(Vector3 Coordinates)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void TurnToSpecifiedAngle()
        {
            throw new NotImplementedException();
        }

        public void WalkTo(Vector3 Position)
        {
            throw new NotImplementedException();
        }
    }

}
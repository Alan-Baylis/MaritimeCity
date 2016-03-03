using UnityEngine;
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

    public class Core : MonoBehaviour
    {
        public enum SceneState { Cutscene, Dicussion_Box, Conversation, MainMenu };
        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;


        public enum ScriptState { Elli, Brendan, Luke, Mable, NULL };
        

        public Core()
        {
            MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;
            
        }

        private CoreDialogueSystems CoreDialogueObject;
        private CoreEventSystem CoreEventSystemObject;
        private CoreInput CoreInputObject;
        private CoreUI CoreUIObject;

        public static CoreDialogueSystems.ConversationState State = CoreDialogueSystems.ConversationState.Active;
        public static int MaritimeInternalIterator = 0;

        public ElliController ElliObject;
        public LukeController LukeObject;
        public BrendanPOVController BrendanObject;


        public bool bBrendanFinishedTalking = false;
        public bool bElliFinishedTalking = false;
        public bool bLukeFinishedTalking = false;

        /*

        public enum CoroutineID : short { Elli, Brendan, Luke };

         /// <summary>
         /// Designed to send a response to Character
         /// </summary>
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

        public CoreUI GetCoreUIObject()
        {
            return CoreUIObject;
        }

        public CoreUI GetCoreUIObject(CoreUI Object)
        {
            return Object;
        }

        public CoreInput GetCoreInputObject()
        {
            return CoreInputObject;
        }

        public CoreInput GetCoreInputObject(CoreInput Object)
        {
            return Object;
        }

        public CoreEventSystem GetCoreEventSystemObject()
        {
            return CoreEventSystemObject;
        }

        public CoreEventSystem GetCoreEventSystemObject(CoreEventSystem Object)
        {
            return Object;
        }

        public CoreDialogueSystems GetCoreDialogueSystemObject()
        {
            return CoreDialogueObject;
        }

        public CoreDialogueSystems GetCoreDialogueSystemObject(CoreDialogueSystems Object)
        {
            return Object;

        }

       
        //Object constructors

        Core (CoreDialogueSystems CoreDialogueObject)
        {
            this.CoreDialogueObject = CoreDialogueObject;
        }

        Core (CoreEventSystem CoreEventSystemObject)
        {
            this.CoreEventSystemObject = CoreEventSystemObject;
        }

        Core (CoreInput CoreInputObject)
        {
            this.CoreInputObject = CoreInputObject;
        }

        Core(CoreUI CoreUIObject)
        {
            this.CoreUIObject = CoreUIObject;
        }
    



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

            } else if (MaritimeRuntimePlatform == RuntimePlatform.OSXEditor)
            {

                Debug.Log("Not optimized for this platform");

            }


            //BrendanObject = GameObject.FindGameObjectWithTag("Brendan Player").GetComponent<BrendanPOVController>();
            //LukeObject = GameObject.FindGameObjectWithTag("/Luke").GetComponent<LukeController>();
            //ElliObject = GameObject.FindGameObjectWithTag("/Elli").GetComponent<ElliController>();

        }


        public class MaritimeListSystem<T> : CollectionBase
        {

            T[] InternalList;
            readonly int Size;
            int ListIterator;


            public MaritimeListSystem()
            {



            }

           public MaritimeListSystem(T[] InternalList, int Size)
           {

                this.InternalList = InternalList;
                this.Size = Size;
                ListIterator = 0;

                Initialize(this.Size);

           }

        
            public void Initialize(int Size)
            {
                InternalList = new T[100];
            }

            public T Find(T Value)
            {
                for (int a = 0; a > InternalList.Length; a++)
                {
                    if (InternalList[a].Equals(Value))
                    {
                        return Value;
                    }

                    else return default(T);
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

            public void Remove(int Index)
            {

               
            }
         
            

        }

        public class CoreEventSystem
        {

            public FrontDoor FrontDoorObject;


            //Struct Object
            public GUIEvents GUIObject = new GUIEvents();
            public SceneEvents SceneObject = new SceneEvents();
            public ColliderFunctions ColliderObject = new ColliderFunctions();
            public AnimationFunctions AnimationObject = new AnimationFunctions();

            /// <summary>
            /// This a nested type to allow for access to Core functions and variables
            /// </summary>
    

            public CoreEventSystem()
            {

            }



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

                SceneObject.DogBarking = new UnityEvent();
                SceneObject.OpenDoor = new UnityEvent();
                SceneObject.FrontDoor = new UnityEvent();
                SceneObject.Doorbell = new UnityEvent();

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

                SceneObject.StructAddPersistantListeners(unityEvent: SceneObject.FrontDoor, call: FrontDoor.PlayDoorBell);

            }

  


        }


        public class CoreDialogueSystems 
        {

            //Dialog types
            public static string[] DialogueIDSequencer = new string[108];
            public static Text DialogueText;
            public static int MaritimeDialogueIterator = 0;

            //Custom enums & bools
            public enum ScriptID { Elli, Brendan, Luke };
            public enum ConversationState { Active, Inactive };
            public bool bWaitUntilPreviousDialogueFinished = false;


            //Custom type objects
            public Core CoreNestedType;
            public CoreEventSystem CoreEventSystemNestedType;
            public CoreDialogueSystems CoreDialogueObject;
            public ConversationState ConversationStateID = ConversationState.Inactive;


    
            public CoreDialogueSystems()
            {

            }

            public CoreDialogueSystems(Core CoreNestedType)
            {
                this.CoreNestedType = CoreNestedType;
            }

            public CoreDialogueSystems (CoreEventSystem CoreEventSystemNestedType)
            {
                this.CoreEventSystemNestedType = CoreEventSystemNestedType;
            }



            void Awake()
            {
                InitializeDialogueIterator();

            }


            void Start()
            {

            }

            void Update()
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

        public class CoreInput 
        {


            public AnimationClip BrendanWalk = new AnimationClip();

            // Use this for initialization
            void Start()
            {

                Debug.Log("Core Input Active");

            }

            // Update is called once per frame
            void Update()
            {

            }
        }


        public class CoreUI : MonoBehaviour
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



            public void DialogueBoxOpen()
            {
                GameObject DialogueBox = GameObject.Find("Dialog Box");

                DialogueBox.gameObject.SetActive(true);

                //NewDialogueUIState = DialogueControllerState.Open;
            }

            public void DialogueBoxClose()
            {
                GameObject DialogueBox = GameObject.Find("Dialog Box");

                DialogueBox.gameObject.SetActive(false);

                //NewDialogueUIState = DialogueControllerState.Closed;
            }


        }

    }



    public interface ICommunciation
    {

        void PlayAudio(string AudioID);

        void DisplayScript(string ScriptID);

        ICommunciation ReturnType();

        void ReceiveResponse(ICommunciation CharacterType);

        IEnumerator DialogueIterator();


    }

}
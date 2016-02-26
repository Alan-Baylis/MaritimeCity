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

namespace CoreSystems
{

    public class Core : MonoBehaviour
    {

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

        public class CoreEventSystem
        {

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

                Animation NewAnimation;
                SceneObject.StructAddPersistantListeners(unityEvent: SceneObject.FrontDoor, call: FrontDoorObject.PlayDoorBell);

            }

            int test;


        }
        public class CoreDialogueSystems 
        {


            

            //public List<string> DialogueIDSequencer = new List<string>();
            public string[] DialogueIDSequencer = new string[108];

            public Core CoreNestedType;
            public CoreEventSystem CoreEventSystemNestedType;
            private ElliController Elli;
            private BrendanPOVController BrendanObject;
            private LukeController Luke;

           
            public enum ConversationState { Active, Inactive };
            public ConversationState ConversationStateID = ConversationState.Inactive;
            public Text DialogueText;
            public enum ScriptID { Elli, Brendan, Luke };
            public int MaritimeDialogueIterator = 0;
            public CoreDialogueSystems CoreObject;
            public bool bWaitUntilPreviousDialogueFinished = false;


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

        

            void Start()
            {
                Debug.Log("Core Dialog Systems Active");

            }

            void Update()
            {
                 CoreNestedType.StartCoroutine(DialogueIterator());
               
                //PassCurrentAudio();

                //BrendanObject.Update ();
                //Elli.Update ();
                //Luke.Update ();
               

                //PassCurrentScript();
            }



            void Awake()
            {
                InitializeDialogueIterator();
  

                DialogueIDSequencer.Initialize();

                //Elli = GameObject.FindGameObjectWithTag(tag: "Elli").GetComponent<ElliController>();
                //Luke = GameObject.FindGameObjectWithTag(tag: "Luke").GetComponent<LukeController>();
                //BrendanObject = GameObject.FindGameObjectWithTag ("Brendan Player").GetComponent<BrendanPOVController> ();
                

                if (Elli == null)
                {
                    Debug.Log("Elli is not working and is null");

                }

                if (Luke == null)
                {
                    Debug.Log("Luke is not working and is null");
                }


            }

            public void InitializeDialogueIterator()
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



        // Update is called once per frame
        void Update()
        {


        }

    }

}
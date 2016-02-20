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

        public enum SceneState { Cutscene, Dicussion_Box, Conversation, MainMenu };

        //UnityAction StartButton = new UnityAction(GUIEvent_StartButtonEvent());



        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

        public Core()
        {
            if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor)
            {

                Debug.Log("Optimised for Windows");

            }
            else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer)
            {

                Debug.Log("Optimised for Windows");

            }

        }

        // Use this for initialization
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {


        }

    }


    namespace UI
    {
        public class CoreUI : Core
        {

            public CoreUI()
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

    namespace EventSystems
    {
        public class CoreEventSystems : Core

        {

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

    }

    namespace DialogueSystem
    {

        public class CoreDialogueSystems : Core
        {

            //Non Serialized Types
            [System.NonSerialized]
            public List<AudioClip> LukeAudio = new List<AudioClip>(30);
            [System.NonSerialized]
            public List<AudioClip> ElliAudio = new List<AudioClip>(30);
            [System.NonSerialized]
            public List<AudioClip> BrendanAudio = new List<AudioClip>(30);

            //Dialogue Types
            [System.NonSerialized]
            public List<string> DialogueIDSequencer;
            [System.NonSerialized]
            public int MaxScript = 100;
            [System.NonSerialized]
            public int MaritimeDialogueIterator = 0;
            [System.NonSerialized]
            public GameObject DialogueObject;

            public static List<string> BrendanScript = new List<string>(50);

            public static List<string> ElliScript = new List<string>(50);

            public static List<string> LukeScript = new List<string>();


            [System.NonSerialized]
            public AudioSource PrimarySource;
            [System.NonSerialized]
            public AudioSource ElliSource;
            [System.NonSerialized]
            public AudioSource LukeSource;
            [System.NonSerialized]
            public Dictionary<string, UnityAction> SequenceOfEvents;


            public List<AudioClip> BrendanAudioDialogue = new List<AudioClip>(10);

            public List<AudioClip> LukeAudioDialogue = new List<AudioClip>(10);

            public List<AudioClip> ElliAudioDialogue = new List<AudioClip>(10);

            public enum ConversationState { Start, Active, End };

            //Defined Types
            public ElliController Elli = new ElliController();
            public LukeController Luke = new LukeController();
            public BrendanPOVController Brendan = new BrendanPOVController();
            public Text DialogueText;
            public enum ScriptID { Elli, Brendan, Luke };
            public enum DialogueStateID { None, Elli, Brendan, Luke };
            public DialogueStateID DialogueState;
            private int SequencerIterator = 0;


            /// <summary>
            /// Need's to be revamped
            /// </summary>
            /// <param name="Elli"></param>
            /// <param name="Brendan"></param>
            /// <param name="Luke"></param>
            void EventIdentifier(AudioClip[] Elli, AudioClip[] Brendan, AudioClip[] Luke)
            {
                //Dog Barkiing Iterator
                if ("E4_S1" == Elli[MaritimeDialogueIterator].ToString())
                {
                    //UnityEvent_DogBarking.Invoke();
                }

            }


            public IEnumerator ScriptIDDefinition(ScriptID ScriptIdentification, string DefineScript)
            {
                    //Use logger to check conditions, use iterators for dymanic functions
                    //int BrendanScriptLogger = 0;
                    //BrendanScriptLogger++;

                    if (BrendanScript[MaritimeDialogueIterator] == "")
                    {
                        BrendanScript[MaritimeDialogueIterator] = DefineScript;
                        DialogueText.text = BrendanScript[MaritimeDialogueIterator];
                    //Makes sure that the entry point is in the next array
                    //Sneak in Co-routine to evaluate the term by seeing if the Audio is finished first

                    yield return new WaitUntil(() => PrimarySource == QueryAudioSource());

                    MaritimeDialogueIterator++;

                }
            }

            /// <summary>
            /// Checks to see which Audio Source is playing 
            /// </summary>
            /// <returns></returns>
            public AudioSource QueryAudioSource()
            {

                if (PrimarySource.isPlaying == true)
                {
                    return PrimarySource;
                    
                } else if (LukeSource.isPlaying == true)
                {
                    return LukeSource;

                } else if (ElliSource.isPlaying == true)
                {

                    return ElliSource;
                }


                return null;
            }

            public void ScriptIDDefinition (List<string> DynamicDialogueScript, string Script)
            {
                if (DynamicDialogueScript.Capacity > 1)
                {
                    DynamicDialogueScript.Capacity = 100;
                }


                if (DynamicDialogueScript[MaritimeDialogueIterator] == "")
                {
                    DynamicDialogueScript[MaritimeDialogueIterator] = Script;
                    DialogueText.text = DynamicDialogueScript[MaritimeDialogueIterator];

                    //Same as above
                    //MaritimeDialogueIterator++;
                }

            }

            void Awake()
            {
                DialogueIDSequencer.Capacity = MaxScript;
                DialogueObject = GameObject.Find("Dialog Text");
                DialogueText = GetComponent<Text>();
                DialogueObject.AddComponent<AudioSource>();
                DialogueObject.AddComponent<AudioSource>();
                DialogueObject.AddComponent<AudioSource>();

                DialogueIDSequencer.Add("B1_S1");
                DialogueIDSequencer.Add("B1_S2");
                DialogueIDSequencer.Add("B1_S3");
                DialogueIDSequencer.Add("B1_S4");

            }


            void DialogueIterator()
            {
                if (DialogueIDSequencer[1] == BrendanScript[MaritimeDialogueIterator])
                {
                    //Add relevant Dialogue code

                }
                else if (DialogueIDSequencer[1] == ElliScript[MaritimeDialogueIterator])
                {
                    Elli.PlayAudio(AudioID: "E1_S1");
                    Elli.DisplayScript(ScriptID: "E1_S1");

                }
                else if (DialogueIDSequencer[1] == LukeScript[MaritimeDialogueIterator])
                {

                    Luke.PlayAudio(DialogueID: "L1_S1");
                    Luke.DisplayScript(ScriptID: "E1_S1");

                }

                SequencerIterator++;

            }

            void InitializeDialogueEvents()
            {
                UnityAction ElliWalkMableUpstairs = null;
                SequenceOfEvents.Add("B4_S2", ElliWalkMableUpstairs);

            }


            //Needs changing 
            public AudioClip PassCurrentAudio()
            {
                if (DialogueState == DialogueStateID.Brendan)
                {
                    return BrendanAudio[MaritimeDialogueIterator];

                }
                else if (DialogueState == DialogueStateID.Elli)

                {
                    return ElliAudio[MaritimeDialogueIterator];

                }
                else if (DialogueState == DialogueStateID.Luke)

                {
                    return LukeAudio[MaritimeDialogueIterator];
                }

                return null;

            }



            //Needs changing 
            public string PassCurrentScript()
            {

                if (DialogueState == DialogueStateID.Brendan)
                {
                    return BrendanScript[MaritimeDialogueIterator];

                }
                else if (DialogueState == DialogueStateID.Elli)

                {
                    return ElliScript[MaritimeDialogueIterator];

                }
                else if (DialogueState == DialogueStateID.Luke)

                {
                    return LukeScript[MaritimeDialogueIterator];
                }

                return null;
            }

            void Start()
            {

            }

            void Update()
            {

                DialogueIterator();
                PassCurrentAudio();
                PassCurrentScript();

            }

        }


        public interface IDialogueSystems
        {

            void PlayAudio(string AudioID);

            void DisplayScript(string ScriptID);

            void PopulateScript();

        }


    }


    namespace InputSystems
    {

        public class CoreInput : Core
        {

            void Start()
            {


            }

            void Update()
            {

            }


        }


    }

}
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace CoreSystems {

    public class Core : MonoBehaviour {
        
        public enum SceneState { Cutscene, Dicussion_Box, Conversation, MainMenu };

        //UnityAction StartButton = new UnityAction(GUIEvent_StartButtonEvent());

    

        RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;

        public Core()
        {
            if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor) {

                Debug.Log("Optimised for Windows");

            } else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer) {

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
            public CoreEventSystems()
            {

            }

            UnityEventCallState MaritimeCallState = UnityEventCallState.Off;

            void Awake()
            {
                MaritimeCallState = UnityEventCallState.EditorAndRuntime;
                InitializeListeners();
            }


            void InitializeListeners()
            {
                //UnityEvent_ConversationFinished.AddListener ("tbd");
                UnityEvent_DogBarking.AddListener(SceneEvent_DogStartsBarking);
                UnityEvent_DiscussionBoxAppears.AddListener(GUIEvent_DiscussionBoxOpen);
                UnityEvent_DiscussionBoxDisappears.AddListener(GUIEvent_DiscussionBoxClose);
                UnityEvent_StartButtonEvent.AddListener(GUIEvent_StartButtonEvent);
                UnityEvent_OptionsButtonEvent.AddListener(GUIEvent_ExitButtonEvent);
                UnityEvent_InteractObjectClick.AddListener(GUIEvent_InteractObject);

                //Initialize the call states
                UnityEvent_OptionsButtonEvent.SetPersistentListenerState(1, MaritimeCallState);

            }

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
            public UnityEvent UnityEvent_ExitButtonEvent = new UnityEvent();


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
                gameObject.SetActive(true);

            }


            virtual public void GUIEvent_DiscussionBoxClose()
            {
                gameObject.SetActive(false);

            }

            virtual public void GUIEvent_InteractObject()
            {
                //Implement click handler code here


                //Include mechnanism for showing us if the mouse is over the GUI Box
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    //etc

                }

                if (Input.GetKeyUp(KeyCode.Mouse0))
                {

                    AnimationClip KeyUp_ = new AnimationClip();
                    Animation NewAnimation = new Animation();
                    NewAnimation.AddClip(KeyUp_, "Key Up Animation");
                    NewAnimation.Play();

                }
                else if (Input.GetKeyUp(KeyCode.Mouse0))
                {

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


        }

    }

    namespace DialogueSystem
    {

        public class CoreDialogueSystems : Core
        {

            //Non Serialized Types
            [System.NonSerialized]
            public List<string> LukeDialogue = new List<string>(30);
            [System.NonSerialized]
            public List<string> DialogueIDSequencer;
            [System.NonSerialized]
            public List<string> ElliDialogue = new List<string>(30);
            [System.NonSerialized]
            public int MaxScript = 100;
            [System.NonSerialized]
            public static int AudioIterator = 0;
            [System.NonSerialized]
            public static int ScriptIterator = 0;
            [System.NonSerialized]
            public GameObject DialogueObject;
            [System.NonSerialized]
            public static string[] BrendanScript = new string[50];
            [System.NonSerialized]
            public static string[] ElliScript = new string[50];
            [System.NonSerialized]
            public static string[] LukeScript = new string[50];
            [System.NonSerialized]
            public Dictionary<string, UnityAction> SequenceOfEvents;

            //Defined Types
            public ElliController Elli = new ElliController();
            public LukeController Luke = new LukeController();
            public Text DialogueText;
            public enum ScriptID { Elli, Brendan, Luke };
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
                if ("E4_S1" == Elli[AudioIterator].ToString())
                {
                    //UnityEvent_DogBarking.Invoke();
                }

           }


            public void ScriptIDDefinition(ScriptID ScriptIdentification, string DefineScript)
            {
                if (ScriptIdentification == ScriptID.Brendan)
                {
                    //Use logger to check conditions, use iterators for dymanic functions
                    //int BrendanScriptLogger = 0;
                    //BrendanScriptLogger++;

                    if (BrendanScript[ScriptIterator] == "")
                    {
                        BrendanScript[ScriptIterator] = DefineScript;
                        DialogueText.text = BrendanScript[ScriptIterator];
                        //Makes sure that the entry point is in the next array
                        ScriptIterator++;
                    }

                }

                /*
                else if (ScriptIdentification == ScriptID.Elli)
                {
                    //Move to the higher level code

                    ScriptIterator = 0;
                    if (ElliScript[ScriptIterator] == "")
                    {
                        ElliScript[ScriptIterator] = _DefineScript;
                        DialogueText.alignment = TextAnchor.MiddleCenter;
                        DialogueText.text = ElliScript[ScriptIterator];
                        ScriptIterator++;

                    }

                    else if (ElliScript[ScriptIterator] != "")
                    {
                        ScriptIterator++;
                    }

                */

                //}

            }

            public void ScriptIDDefinition(List <string> DynamicDialogueScript, string Script)
            {
                if (DynamicDialogueScript.Capacity > 1)
                {
                    DynamicDialogueScript.Capacity = 100;
                }

         
                if (DynamicDialogueScript[ScriptIterator] == "")
                {
                    DynamicDialogueScript[ScriptIterator] = Script;
                    DialogueText.text = DynamicDialogueScript[ScriptIterator];
                    ScriptIterator++; 
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
                if (DialogueIDSequencer[1] == BrendanScript[ScriptIterator])
                {

                } else if (DialogueIDSequencer[1] == ElliScript[ScriptIterator])
                {
                    Elli.PlayAudio(AudioID:"E1_S1");
                    Elli.DisplayScript(ScriptID:"E1_S1");

                } else if (DialogueIDSequencer[1] == LukeScript[ScriptIterator])
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

           void PassCurrentAudio()
           {

           }

           void PassCurrentScript()
           {

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


    }


    }

    }
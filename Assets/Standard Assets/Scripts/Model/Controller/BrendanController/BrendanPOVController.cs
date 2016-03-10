using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;
using System.Threading;
using CoreSystems;
using System;

namespace DialogueSystems
{

    public class BrendanPOVController : Core, ICommunciation
    {



		private BrendanPOVController()
		{
			
		}

		private static GameObject BrendanObject;

		public static GameObject BrendanInstance
		{

			get { return BrendanObject; }

		}


        public Transform[] GameObjectPoints = new Transform[15];


        //Core types
        private int InternalIterator = 0;
		
        private Camera BrendanCamera;
        private static int ScriptLogger = 0;
        public static int BrendanIterator = 0;
        [SerializeField] string[] DialogueIDSequencer = new string[108];
        private string FileName;
		[SerializeField] private Animation[] AdHocCameraAnimations = new Animation[10];
		[SerializeField] private AnimationClip[] AdHocCameraAnimationClips = new AnimationClip[10];

        //Reference types
        public static CapsuleCollider BrendanCollider;
        public List<string> BrendanScript = new List<string>(50);
        public Text LinkDialogueText;
        public AudioClip[] BrendanAudio = new AudioClip[50];
		public static AudioSource BrendanSource;
        public static Vector3 PlayerPosition;
        private static AutomatedCoreDialogueSystem ACDSObject;

        /*prototype, intended to replace arrays with our own lists because Microsoft lists don't work as intended
        private MaritimeListSystem<string> MLS_Dialogue_List = new MaritimeListSystem<string>();
        private MaritimeListSystem<int> MLS_Iterator_List = new MaritimeListSystem<int>();
        private MaritimeListSystem<bool> MLS_Conditions_List = new MaritimeListSystem<bool>();
        */
       
	

		void Awake()
		{
		
			BrendanObject = this.gameObject;

			PopulateScript();
			PlayerPosition = gameObject.transform.position;

			CoreDialogueSystems.InitializeDialogueIterator(DialogueIDSequencer: DialogueIDSequencer);

		}


        public static int GetInternalIterator()
        {
            return BrendanIterator;
        }

		public void PlayAnimation(string AnimationID){

		

		}

        public void PlayAudio(string AudioID)
        {
            if (AudioID == "B1_S1")
            {
                BrendanSource.clip = BrendanAudio[0];
                BrendanSource.PlayDelayed(0.5f);
            }

            if (AudioID == "B1_S2")
            {
                BrendanSource.clip = BrendanAudio[1];
                BrendanSource.PlayDelayed(0.5f);
            }

            if (AudioID == "B1_S3")
            {
                BrendanSource.clip = BrendanAudio[2];
                BrendanSource.PlayDelayed(0.5f);
            }

            if (AudioID == "B1_S4")
            {
                BrendanSource.clip = BrendanAudio[3];
                BrendanSource.PlayDelayed(0.5f);
            }

            if (AudioID == "B2_S1")
            {
                BrendanSource.clip = BrendanAudio[4];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B2_S2")
            {
                BrendanSource.clip = BrendanAudio[5];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B2_S3")
            {
                BrendanSource.clip = BrendanAudio[6];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B3_S1")
            {
                BrendanSource.clip = BrendanAudio[7];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B3_S2")
            {
                BrendanSource.clip = BrendanAudio[8];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B3_S3")
            {
                BrendanSource.clip = BrendanAudio[9];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B4_S1")
            {
                BrendanSource.clip = BrendanAudio[10];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B4_S2")
            {
                BrendanSource.clip = BrendanAudio[11];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B5_S1")
            {
                BrendanSource.clip = BrendanAudio[12];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B6_S1")
            {
                BrendanSource.clip = BrendanAudio[13];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B6_S2")
            {
                BrendanSource.clip = BrendanAudio[14];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B6_S3")
            {
                BrendanSource.clip = BrendanAudio[15];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B6_S4")
            {
                BrendanSource.clip = BrendanAudio[16];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B7_S1")
            {
                BrendanSource.clip = BrendanAudio[17];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B7_S2")
            {
                BrendanSource.clip = BrendanAudio[18];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B8_S1")
            {
                BrendanSource.clip = BrendanAudio[19];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B9_S1")
            {
                BrendanSource.clip = BrendanAudio[20];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B10_S1")
            {
                BrendanSource.clip = BrendanAudio[21];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B10_S2")
            {
                BrendanSource.clip = BrendanAudio[22];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B10_S3")
            {
                BrendanSource.clip = BrendanAudio[23];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B11_S1")
            {
                BrendanSource.clip = BrendanAudio[24];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B12_S1")
            {
                BrendanSource.clip = BrendanAudio[25];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B13_S1")
            {
                BrendanSource.clip = BrendanAudio[26];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B14_S1")
            {
                BrendanSource.clip = BrendanAudio[27];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B15_S1")
            {
                BrendanSource.clip = BrendanAudio[28];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B16_S1")
            {
                BrendanSource.clip = BrendanAudio[29];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B16_S2")
            {
                BrendanSource.clip = BrendanAudio[30];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B17_S1")
            {
                BrendanSource.clip = BrendanAudio[31];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B18_S1")
            {
                BrendanSource.clip = BrendanAudio[32];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B18_S2")
            {
                BrendanSource.clip = BrendanAudio[33];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B18_S3")
            {
                BrendanSource.clip = BrendanAudio[34];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B19_S1")
            {
                BrendanSource.clip = BrendanAudio[35];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B20_S1")
            {
                BrendanSource.clip = BrendanAudio[36];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B21_S1")
            {
                BrendanSource.clip = BrendanAudio[37];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B22_S1")
            {
                BrendanSource.clip = BrendanAudio[38];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B23_S1")
            {
                BrendanSource.clip = BrendanAudio[39];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B24_S1")
            {
                BrendanSource.clip = BrendanAudio[40];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B25_S1")
            {
                BrendanSource.clip = BrendanAudio[41];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B26_S1")
            {
                BrendanSource.clip = BrendanAudio[42];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B26_S2")
            {
                BrendanSource.clip = BrendanAudio[43];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B27_S1")
            {
                BrendanSource.clip = BrendanAudio[44];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B27_S2")
            {
                BrendanSource.clip = BrendanAudio[45];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B27_S3")
            {
                BrendanSource.clip = BrendanAudio[46];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B28_S1")
            {
                BrendanSource.clip = BrendanAudio[47];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B29_S1")
            {
                BrendanSource.clip = BrendanAudio[48];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B29_S2")
            {
                BrendanSource.clip = BrendanAudio[49];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B29_S3")
            {
                BrendanSource.clip = BrendanAudio[50];
                BrendanSource.PlayDelayed(1);
            }

            if (AudioID == "B29_S4")
            {
                BrendanSource.clip = BrendanAudio[51];
                BrendanSource.PlayDelayed(1);
            }


        }


       

    
   
        public void DisplayScript(string ScriptID)
        {
            if (ScriptID == "B1_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

           else if (ScriptID == "B1_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

           else if (ScriptID == "B1_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

           else if (ScriptID == "B1_S4")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

           else if (ScriptID == "B2_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

           else if (ScriptID == "B2_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B2_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B3_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B3_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B3_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B4_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B4_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B5_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B6_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B6_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B6_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B6_S4")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B7_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B7_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B8_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B9_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B10_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B10_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B10_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B11_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B12_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B13_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B14_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B15_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B16_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B16_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B17_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B18_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B18_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B18_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B19_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B20_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B21_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B22_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B23_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B24_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B25_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B26_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B26_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B27_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B27_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B27_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B28_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B29_S1")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B29_S2")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B29_S3")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

            if (ScriptID == "B29_S4")
            {
                LinkDialogueText.text = BrendanScript[InternalIterator];
                InternalIterator++;
            }

        }

        // Use this for initialization
        void Start()
        {
            string UITag = "UI";

            BrendanCollider = GetComponent<CapsuleCollider>();
            BrendanSource = GetComponent<AudioSource>();

            CoreDialogueSystems.InitializeDialogueIterator(DialogueIDSequencer);

            StartCoroutine(DialogueIterator());

            State = CoreDialogueSystems.ConversationState.Active;

            CoreDialogueSystems.SetConversationStateInactive();


        }

        public static CapsuleCollider ReturnCollider()
        {
            return BrendanCollider;
        }


        void DefineColliderParameters()
        {

            BrendanCollider.isTrigger = true;
        }

        void DefineCameraParameters()
        {
            //BrendanPOV.GetComponent<Camera>();
            //BrendanPOV.ViewportToScreenPoint(position: from);
            //BrendanPOV.ScreenPointToRay(position: from);
        }

        public IEnumerator ScriptIDDefinition(CoreDialogueSystems.ScriptID ScriptIdentification, string DefineScript)
        {

            //int MaritimeDialogueIterator = 0;

            ScriptLogger++;
            print("Result for Script Logger is " + ScriptLogger);

            if (ScriptIdentification == CoreDialogueSystems.ScriptID.Brendan)
            {
                BrendanScript.Add(DefineScript);

                //BrendanInternalIterator++;

                //MaritimeDialogueIterator++;

                yield return new WaitForSeconds(0.1f);

            }

        }

        

        public IEnumerator DialogueIterator()
        {
            

            if(State == CoreDialogueSystems.ConversationState.Active)

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B1_S1")
            {

				//AdHocCameraAnimations [1].Play ();
		

				yield return new WaitUntil (() => AdHocCameraAnimations [1].isPlaying == false);

                //Invokes Doorbell Function
                //CoreEventSystemNestedType.SceneEvents.Doorbell.Invoke();
                //CoreEventSystemNestedType.SceneEvents.OpenDoor.Invoke();

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

				MaritimeInternalIterator++;

                

            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B1_S2")
            {
                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B1_S3")
            {
                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B1_S4")
            {
                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);


                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

                ScriptStateID = ScriptState.Elli;

            }

          

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B2_S1")
            {

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B2_S2")
            {

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B2_S3")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B3_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B3_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B3_S3")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B4_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B4_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B5_S1")
            {
                //SceneEvents.WalkDogUpstairs.Invoke();
				yield return new WaitUntil(() => CoreEventSystem.ColliderFunctions.ElliFinishedTakingDogUpstairs());

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B6_S1")
            {
				CoreEventSystem.SceneEvents.EnterLivingRoom.Invoke();
				yield return new WaitUntil(() => CoreEventSystem.ColliderFunctions.ElliEntersLivingRoom());
				yield return new WaitUntil(() => CoreEventSystem.ColliderFunctions.BrendanEntersLivingRoom());

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                //Invoke relevant Event here!

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B6_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B6_S3")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B6_S4")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B7_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B7_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B8_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B9_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B10_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B10_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B10_S3")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B11_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;

            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B12_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B13_S1")
            {

				//Not implemented
				CoreEventSystem.SceneEvents.CheckCot.Invoke();

                //BrendanObject checks cot
				yield return new WaitUntil(() => CoreEventSystem.ColliderFunctions.BrendanChecksCotCollider());
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B14_S1")
            {
				CoreEventSystem.SceneEvents.BrendanChecksBottle.Invoke();

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B15_S1")
            {
				CoreEventSystem.SceneEvents.BrendanPicksBottle.Invoke();

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B16_S1")
            {
				CoreEventSystem.SceneEvents.PointsToBrokenGlass.Invoke();

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B17_S1")
            {
                //CoreEventSystemNestedType.SceneEvents.PointsToBrokenGlass.Invoke();

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B18_S1")
            {
                //CoreEventSystemNestedType.SceneEvents.PointsToBrokenGlass.Invoke();

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B18_S2")
            {


                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B18_S3")
            {


                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B19_S1")
            {


                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B20_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B21_S1")
            {

                //BrendanObject checks cot
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B22_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B23_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }

            if (DialogueIDSequencer[MaritimeInternalIterator] == "B24_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B25_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B26_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B27_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B27_S2")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B27_S3")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


            if (DialogueIDSequencer[MaritimeInternalIterator] == "B28_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B29_S1")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B29_S2")
            {
				CoreEventSystem.SceneEvents.BrendanLeavesHouse.Invoke();

				yield return new WaitUntil(() => CoreEventSystem.ColliderFunctions.BrendanFrontDoor());

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }



            if (DialogueIDSequencer[MaritimeInternalIterator] == "B29_S3")
            {

                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[MaritimeInternalIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[MaritimeInternalIterator]);

                yield return new WaitUntil(() => BrendanSource.isPlaying == false);

                MaritimeInternalIterator++;
            }


			yield return new WaitForSeconds (3);
			StartCoroutine (DialogueIterator());

        }
			

        public void PopulateScript()
        {
            FileName = BrendanAudio[0].ToString();

            if (FileName.Contains("B1_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Hi name is Brendan from Maritime Children's Services Safeguarding Team"));
                Debug.Log("B1_S1 Active");
            }

            //Brendan First Paragraph

            FileName = BrendanAudio[1].ToString();

            if (FileName.Contains("B1_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Are you Ms Grove...Elli?"));
                Debug.Log("B1_S2 Active");
            }

            FileName = BrendanAudio[2].ToString();

            if (FileName.Contains("B1_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "We have had an referral from an anonymous source raising concerns about the children living here"));
                Debug.Log("B1_S3 Active");

            }

            FileName = BrendanAudio[3].ToString();

            if (FileName.Contains("B1_S4"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Can I come in and talk to you about this"));
                Debug.Log("B1_S4 Active");
            }

            //Brendan Second Paragraph

            FileName = BrendanAudio[4].ToString();

            if (FileName.Contains("B2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Erm sorry, no I can't"));
                Debug.Log("B2_S1 Active");
            }

            FileName = BrendanAudio[5].ToString();

            if (FileName.Contains("B2_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "The referrer has told us there have been disturbances by adults at this address and that the children have been heard crying, distressed and upset"));
                Debug.Log("B2_S2 Active");
            }

            FileName = BrendanAudio[6].ToString();

            if (FileName.Contains("B2_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I need to talk to you about this and see the children, can I come in please?"));
                Debug.Log("B2_S3 Active");
            }

            FileName = BrendanAudio[7].ToString();

            if (FileName.Contains("B3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Erm, I like dogs"));
                Debug.Log("B3_S1 Active");
            }

            FileName = BrendanAudio[8].ToString();

            if (FileName.Contains("B3_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Got one of my own in fact, but Mable here doesn't look very friendly"));
                Debug.Log("B3_S2 Active");
            }

            FileName = BrendanAudio[9].ToString();

            if (FileName.Contains("B3_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Can I ask you to move her please or does she bite?"));
                Debug.Log("B3_S3 Active");
            }

            FileName = BrendanAudio[10].ToString();

            if (FileName.Contains("B4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Could I ask if you could take her upstairs or tie her outside if that's OK, I think she is a bit overexcited and I wouldn't like her to harm anyone."));
                Debug.Log("B4_S1 Active");
            }

            FileName = BrendanAudio[11].ToString();

            if (FileName.Contains("B4_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Who does she belong to?"));
                Debug.Log("B4_S2 Active");
            }

            FileName = BrendanAudio[12].ToString();

            if (FileName.Contains("B5_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Oh, shit"));
                Debug.Log("B5_S1 Active");
            }

            FileName = BrendanAudio[13].ToString();

            if (FileName.Contains("B6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Hi, my name is Brendan, I’m from the Safeguarding Team at Maritime Social Services."));
                Debug.Log("B6_S1 Active");
            }

            FileName = BrendanAudio[14].ToString();

            if (FileName.Contains("B6_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I’m here under Section 47 of the Children’s Act to investigate an anonymous referral that the two children living here have been heard crying and thought to be extremely distressed."));
                Debug.Log("B6_S2 Active");
            }

            FileName = BrendanAudio[15].ToString();

            if (FileName.Contains("B6_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I've already met Elli and the very excitable Mable, can I ask who you are?"));
                Debug.Log("B6_S3 Active");
            }

            FileName = BrendanAudio[16].ToString();

            if (FileName.Contains("B6_S4"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Can I ask who you are"));
                Debug.Log("B6_S4 Active");
            }

            FileName = BrendanAudio[17].ToString();

            if (FileName.Contains("B7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I didn't know Brad lived around here!"));
                Debug.Log("B7_S1 Active");
            }

            FileName = BrendanAudio[18].ToString();

            if (FileName.Contains("B7_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Are you related to either of the children"));
                Debug.Log("B7_S2 Active ");
            }

            FileName = BrendanAudio[19].ToString();

            if (FileName.Contains("B8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Is that right?"));
                Debug.Log("B8_S1 Active");
            }


            FileName = BrendanAudio[20].ToString();

            if (FileName.Contains("B9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Of course not, I just need to be clear who you are"));
                Debug.Log("B9_S1 Active");

            }

            FileName = BrendanAudio[21].ToString();

            if (FileName.Contains("B10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I can't do that, as I've said we have had a referral that there have been late night parties, shouting, the sound of children crying and clearly distressed "));
                Debug.Log("B10_S1 Active");
            }

            FileName = BrendanAudio[22].ToString();

            if (FileName.Contains("B10_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I need to be clear that the children are safe"));
                Debug.Log("B10_S2 Active");
            }

            FileName = BrendanAudio[23].ToString();

            if (FileName.Contains("B10_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Now, I understand you have two children, Liam, aged 5 months, and Tara aged 4. Are you the mother, Elli"));
                Debug.Log("B10_S3 Active");
            }

            //Begin UnityEvent - Discussion and Interaction Section 

            FileName = BrendanAudio[24].ToString();

            if (FileName.Contains("B11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I can see Liam, but where's Tara?"));
                Debug.Log("B11_S1 Active");
            }

            FileName = BrendanAudio[25].ToString();

            if (FileName.Contains("B12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Really, why is that?"));
                Debug.Log("B12_S1 Active");

            }

            FileName = BrendanAudio[26].ToString();

            if (FileName.Contains("B13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Liam is very wet"));
                Debug.Log("B13_S1 Active");

            }

            FileName = BrendanAudio[27].ToString();

            if (FileName.Contains("B14_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Is that his bottle on the floor"));
                Debug.Log("B14_S1 Active");
            }

            FileName = BrendanAudio[28].ToString();

            if (FileName.Contains("B15_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I'll get it"));
                Debug.Log("B15_S1 Active");
            }

            FileName = BrendanAudio[29].ToString();

            if (FileName.Contains("B16_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I think the teat might glass or something on it"));
                Debug.Log("B16_S1 Active");
            }

            FileName = BrendanAudio[30].ToString();

            if (FileName.Contains("B16_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Maybe from the broken beer bottle on the floor?"));
                Debug.Log("B16_S2 Active");
            }

            FileName = BrendanAudio[31].ToString();

            if (FileName.Contains("B17_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "You need to consider that it is not safe having broken glass around with small children"));
                Debug.Log("B17_S1 Active");
            }

            FileName = BrendanAudio[32].ToString();

            if (FileName.Contains("B18_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "And look at this, he's red raw"));
                Debug.Log("B18_S1 Active");
            }

            FileName = BrendanAudio[33].ToString();

            if (FileName.Contains("B18_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Have you seen your GP or health visitor about this nappy rash?"));
                Debug.Log("B18_S2 Active");
            }

            FileName = BrendanAudio[34].ToString();

            if (FileName.Contains("B18_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "You really must change him, perhaps err, Brad could do it whilst you sort out his bottle Eli?"));
                Debug.Log("B18_S3 Active");
            }

            FileName = BrendanAudio[35].ToString();

            if (FileName.Contains("B19_S1)"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I thought you said you were his father"));
                Debug.Log("B19_S1 Active");
            }


            FileName = BrendanAudio[36].ToString();

            if (FileName.Contains("B20_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "You're not Liam's father then?"));
                Debug.Log("B20_S1 Active");

            }

            FileName = BrendanAudio[37].ToString();

            if (FileName.Contains("B21_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "And you have some cream now?"));
                Debug.Log("B21_S1 Active");
            }

            FileName = BrendanAudio[38].ToString();

            if (FileName.Contains("B22_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Right... and what about Tara, where did you say she was?"));
                Debug.Log("B22_S1 Active");
            }

            FileName = BrendanAudio[39].ToString();

            if (FileName.Contains("B23_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "And where's that?"));
                Debug.Log("B23_S1 Active");
            }

            FileName = BrendanAudio[40].ToString();

            if (FileName.Contains("B24_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Perhaps I could go and see Tara at her grandma's"));
                Debug.Log("B24_S1 Active");
            }

            FileName = BrendanAudio[41].ToString();

            if (FileName.Contains("B25_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "So, I can go over and see Tara at her grandma's"));
                Debug.Log("B25_S1 Active");

            }

            FileName = BrendanAudio[42].ToString();

            if (FileName.Contains("B26_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "OK, I'll go but I do need to see Tara and I am not very happy about Liam"));
                Debug.Log("B26_S1 Active");
            }

            FileName = BrendanAudio[43].ToString();

            if (FileName.Contains("B26_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I really think he should be looked at by a doctor Elli, today, can you manage that?"));
                Debug.Log("B26_S2 Active");
            }

            FileName = BrendanAudio[44].ToString();

            if (FileName.Contains("B27_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Luke there is no need to be abusive"));
                Debug.Log("B27_S1 Active");
            }

            FileName = BrendanAudio[45].ToString();

            if (FileName.Contains("B27_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I have a duty to ensure that the children are safe"));
                Debug.Log("B27_S2 Active");
            }

            FileName = BrendanAudio[46].ToString();

            if (FileName.Contains("B27_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "If I go now I'll only need to come back again later today with my senior, possibly a police officer"));
                Debug.Log("B27_S3 Active");
            }

            FileName = BrendanAudio[47].ToString();

            if (FileName.Contains("B28_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Here is my card, I am going back to my office now and will come back in an hour with a colleague to see Tara, do you understand Elli?"));
                Debug.Log("B28_S1 Active");
            }

            FileName = BrendanAudio[48].ToString();

            if (FileName.Contains("B29_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Hi Steve, it's Me"));
                Debug.Log("B29_S1 Active");

            }

            FileName = BrendanAudio[49].ToString();

            if (FileName.Contains("B29_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Err, things not too good here - no, I'm not alright. I didn't get to see Tara and Liam was in a state"));
                Debug.Log("B29_S2 Active");
            }

            FileName = BrendanAudio[50].ToString();

            if (FileName.Contains("B29_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "Yeah, I'm a bit shaken to be honest, this guy Luke seems to have moved in with a seriously scary dog, I wasn't expecting that, he was real piece of work"));
                Debug.Log("B29_S3 Active");
            }

            FileName = BrendanAudio[51].ToString();

            if (FileName.Contains("B29_S4"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Brendan, "I am going to call the Police we really need to get back in there"));
                Debug.Log("B29_S4 Active");
            }

        }

     
        // Update is called once per frame
        void Update()
        {
            //InputController

		
			gameObject.transform.position = Vector3.Lerp(GameObjectPoints[0].transform.position, GameObjectPoints[1].transform.position, Time.time / 4);
			//gameObject.transform.Rotate );


			//gameObject.transform.position = Vector3.Lerp (GameObjectPoints [1].transform.position, GameObjectPoints [2].transform.position, Time.time / 4);

            ElliController.ScriptStateID = BrendanPOVController.ScriptStateID;

            Debug.Log("If this shows this class is functional");

            Debug.Log("This is the current state of Maritime Internal Iterator for Brendan " + MaritimeInternalIterator);

			//AutomatedNavigationSystem.Walk (GameObject.FindObjectOfType<Animator> ());


			//AutomatedNavigationSystem.TravelTo (this.gameObject.transform, FrontDoor.FrontDoorGameObject.gameObject.transform, 10.0f);

        }

    

     
    }

}

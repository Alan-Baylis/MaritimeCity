using UnityEngine;
using UnityEngine.Events;
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
		public enum SceneState
		{
			Cutscene,
			Dicussion_Box,
			Conversation,
			MainMenu}

		;

		RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;


		public enum ScriptState
		{
			Elli,
			Brendan,
			Luke,
			Mable,
			NULL}

		;


		public Core ()
		{
			MaritimeRuntimePlatform = RuntimePlatform.OSXEditor;
            
		}

		[SerializeField]
		public static ScriptState ScriptStateID = ScriptState.NULL;


	   public virtual void ISystemPause (string MethodName){

			if (MethodName.Contains("Controller"))
			{
				this.StopCoroutine (MethodName);
			}
		
		}

		public virtual void ISystemPause ()
		{

			this.StopCoroutine(methodName: "DialogueIterator");

		}

		public virtual void ISystemPlay()
		{
			this.StartCoroutine (methodName: "DialogueIterator");

		}

        /*Redacted
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

					if(StructArray[a].InternalIterator == 1)
					{

						//StructCoreDialogueSystem(IDText, 1, );

					}

				}

			}

		}*/

		public static CoreDialogueSystems.ConversationState State = CoreDialogueSystems.ConversationState.Inactive;

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
		void Start ()
		{
			Debug.Log ("Core Active");

			if (MaritimeRuntimePlatform == RuntimePlatform.WindowsEditor) {

				Debug.Log ("Optimized for Windows");

			} else if (MaritimeRuntimePlatform == RuntimePlatform.WindowsPlayer) {

				Debug.Log ("Optimized for Windows");

			} else if (MaritimeRuntimePlatform == RuntimePlatform.OSXEditor) {

				Debug.Log ("Not optimized for this platform");

			}

		}


#region MaritimeListSystem
    

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

#endregion

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
				Luke}

			;

			public enum ConversationState
			{
				Active,
				Inactive

            };


			//Custom type objects
			public static ConversationState ConversationStateID = ConversationState.Inactive;


			static void Awake ()
			{
				InitializeDialogueIterator ();

			}

			public static void InitializeDialogueIterator (string[] DialogueIDSequencer)
			{

				DialogueIDSequencer [0] = "B1_S1";
				DialogueIDSequencer [1] = ("B1_S2");
				DialogueIDSequencer [2] = ("B1_S3");
				DialogueIDSequencer [3] = ("B1_S4");
				DialogueIDSequencer [4] = ("E1_S1");
				DialogueIDSequencer [5] = ("E1_S2");
				DialogueIDSequencer [6] = ("E1_S3");
				DialogueIDSequencer [7] = ("E1_S4");
				DialogueIDSequencer [8] = ("E1_S5");
				DialogueIDSequencer [9] = ("B2_S1");
				DialogueIDSequencer [10] = ("B2_S2");
				DialogueIDSequencer [11] = ("B2_S3");
				DialogueIDSequencer [12] = ("E2_S1");
				DialogueIDSequencer [13] = ("E2_S2");
				DialogueIDSequencer [14] = ("B3_S1");
				DialogueIDSequencer [15] = ("B3_S2");
				DialogueIDSequencer [16] = ("B3_S3");
				DialogueIDSequencer [17] = ("E3_S1");
				DialogueIDSequencer [18] = ("E3_S2");
				DialogueIDSequencer [19] = ("E3_S3");
				DialogueIDSequencer [20] = ("B4_S1");
				DialogueIDSequencer [21] = ("B4_S2");
				DialogueIDSequencer [22] = ("E4_S1");
				DialogueIDSequencer [23] = ("B5_S1");
				DialogueIDSequencer [24] = ("B6_S1");
				DialogueIDSequencer [25] = ("B6_S2");
				DialogueIDSequencer [26] = ("B6_S3");
				DialogueIDSequencer [27] = ("B6_S4");
				DialogueIDSequencer [28] = ("L1_T1_S1");
				DialogueIDSequencer [29] = ("B7_S1");
				DialogueIDSequencer [30] = ("B7_S2");
				DialogueIDSequencer [31] = ("E7_S1");
				DialogueIDSequencer [32] = ("B8_S1");
				DialogueIDSequencer [33] = ("E8_S1");
				DialogueIDSequencer [34] = ("L2_S1");
				DialogueIDSequencer [35] = ("B9_S1");
				DialogueIDSequencer [36] = ("L3_S1");
				DialogueIDSequencer [37] = ("B10_S1");
				DialogueIDSequencer [38] = ("B10_S2");
				DialogueIDSequencer [39] = ("B10_S3");
				DialogueIDSequencer [40] = ("B10_S4");
				DialogueIDSequencer [41] = ("E8_S1");
				DialogueIDSequencer [42] = ("B11_S1");
				DialogueIDSequencer [43] = ("E9_S1");
				DialogueIDSequencer [44] = ("B12_S1");
				DialogueIDSequencer [45] = ("E10_S1");
				DialogueIDSequencer [46] = ("E10_S2");
				DialogueIDSequencer [47] = ("E10_S3");
				DialogueIDSequencer [48] = ("B13_S1");
				DialogueIDSequencer [49] = ("E11_S1");
				DialogueIDSequencer [50] = ("E11_S1");
				DialogueIDSequencer [52] = ("B14_S1");
				DialogueIDSequencer [53] = ("E12_S1");
				DialogueIDSequencer [54] = ("E12_S2");
				DialogueIDSequencer [55] = ("B15_S1");
				DialogueIDSequencer [56] = ("E13_S1");
				DialogueIDSequencer [57] = ("B16_S1");
				DialogueIDSequencer [58] = ("B16_S2");
				DialogueIDSequencer [59] = ("L4_S1");
				DialogueIDSequencer [60] = ("B17_S1");
				DialogueIDSequencer [61] = ("E14_S1");
				DialogueIDSequencer [62] = ("E14_S2");
				DialogueIDSequencer [63] = ("L5_S1");
				DialogueIDSequencer [64] = ("B18_S1");
				DialogueIDSequencer [65] = ("B18_S2");
				DialogueIDSequencer [66] = ("B18_S3");
				DialogueIDSequencer [67] = ("L6_S1");
				DialogueIDSequencer [68] = ("B19_S1");
				DialogueIDSequencer [69] = ("L7_S1");
				DialogueIDSequencer [70] = ("B20_S1");
				DialogueIDSequencer [71] = ("L8_S1");
				DialogueIDSequencer [72] = ("E15_S1");
				DialogueIDSequencer [73] = ("E15_S2");
				DialogueIDSequencer [74] = ("E15_S3");
				DialogueIDSequencer [75] = ("B21_S1");
				DialogueIDSequencer [76] = ("E16_S1");
				DialogueIDSequencer [77] = ("B22_S1");
				DialogueIDSequencer [78] = ("E17_S1");
				DialogueIDSequencer [79] = ("B23_S1");
				DialogueIDSequencer [80] = ("E18_S1");
				DialogueIDSequencer [81] = ("E18_S2");
				DialogueIDSequencer [82] = ("L9_S1");
				DialogueIDSequencer [83] = ("L9_S2");
				DialogueIDSequencer [84] = ("L9_S3");
				DialogueIDSequencer [85] = ("L9_S4");
				DialogueIDSequencer [86] = ("L9_S5");
				DialogueIDSequencer [87] = ("B24_S1");
				DialogueIDSequencer [88] = ("L10_S1");
				DialogueIDSequencer [89] = ("B25_S1");
				DialogueIDSequencer [90] = ("L11_S1");
				DialogueIDSequencer [91] = ("E19_S1");
				DialogueIDSequencer [92] = ("E19_S2");
				DialogueIDSequencer [93] = ("E19_S3");
				DialogueIDSequencer [94] = ("B26_S1");
				DialogueIDSequencer [95] = ("B26_S2");
				DialogueIDSequencer [96] = ("L12_S1");
				DialogueIDSequencer [97] = ("B27_S1");
				DialogueIDSequencer [98] = ("B27_S2");
				DialogueIDSequencer [99] = ("B27_S3");
				DialogueIDSequencer [100] = ("L13_S1");
				DialogueIDSequencer [101] = ("E20_S1");
				DialogueIDSequencer [102] = ("B28_S1");
				DialogueIDSequencer [103] = ("E21_S1");
				DialogueIDSequencer [104] = ("B29_S1");
				DialogueIDSequencer [105] = ("B29_S2");
				DialogueIDSequencer [106] = ("B29_S3");
				DialogueIDSequencer [107] = ("B29_S4");


			}

			public static void InitializeDialogueIterator ()
			{

				DialogueIDSequencer [0] = "B1_S1";
				DialogueIDSequencer [1] = ("B1_S2");
				DialogueIDSequencer [2] = ("B1_S3");
				DialogueIDSequencer [3] = ("B1_S4");
				DialogueIDSequencer [4] = ("E1_S1");
				DialogueIDSequencer [5] = ("E1_S2");
				DialogueIDSequencer [6] = ("E1_S3");
				DialogueIDSequencer [7] = ("E1_S4");
				DialogueIDSequencer [8] = ("E1_S5");
				DialogueIDSequencer [9] = ("B2_S1");
				DialogueIDSequencer [10] = ("B2_S2");
				DialogueIDSequencer [11] = ("B2_S3");
				DialogueIDSequencer [12] = ("B2_S3");
				DialogueIDSequencer [13] = ("E2_S1");
				DialogueIDSequencer [14] = ("E2_S2");
				DialogueIDSequencer [15] = ("B3_S1");
				DialogueIDSequencer [16] = ("B3_S2");
				DialogueIDSequencer [17] = ("B3_S3");
				DialogueIDSequencer [18] = ("E3_S1");
				DialogueIDSequencer [19] = ("E3_S2");
				DialogueIDSequencer [20] = ("E3_S3");
				DialogueIDSequencer [21] = ("B4_S1");
				DialogueIDSequencer [22] = ("B4_S2");
				DialogueIDSequencer [23] = ("E4_S1");
				DialogueIDSequencer [24] = ("B5_S1");
				DialogueIDSequencer [25] = ("B6_S1");
				DialogueIDSequencer [26] = ("B6_S2");
				DialogueIDSequencer [27] = ("B6_S3");
				DialogueIDSequencer [28] = ("B6_S4");
				DialogueIDSequencer [29] = ("L1_T1_S1");
				DialogueIDSequencer [30] = ("B7_S1");
				DialogueIDSequencer [31] = ("B7_S2");
				DialogueIDSequencer [32] = ("E7_S1");
				DialogueIDSequencer [33] = ("B8_S1");
				DialogueIDSequencer [34] = ("E8_S1");
				DialogueIDSequencer [35] = ("L2_S1");
				DialogueIDSequencer [36] = ("B9_S1");
				DialogueIDSequencer [37] = ("L3_S1");
				DialogueIDSequencer [38] = ("B10_S1");
				DialogueIDSequencer [39] = ("B10_S2");
				DialogueIDSequencer [40] = ("B10_S3");
				DialogueIDSequencer [41] = ("B10_S4");
				DialogueIDSequencer [42] = ("E8_S1");
				DialogueIDSequencer [43] = ("B11_S1");
				DialogueIDSequencer [44] = ("E9_S1");
				DialogueIDSequencer [45] = ("B12_S1");
				DialogueIDSequencer [46] = ("E10_S1");
				DialogueIDSequencer [47] = ("E10_S2");
				DialogueIDSequencer [48] = ("E10_S3");
				DialogueIDSequencer [49] = ("B13_S1");
				DialogueIDSequencer [50] = ("E11_S1");
				DialogueIDSequencer [51] = ("E11_S1");
				DialogueIDSequencer [52] = ("B14_S1");
				DialogueIDSequencer [53] = ("E12_S1");
				DialogueIDSequencer [54] = ("E12_S2");
				DialogueIDSequencer [55] = ("B15_S1");
				DialogueIDSequencer [56] = ("E13_S1");
				DialogueIDSequencer [57] = ("B16_S1");
				DialogueIDSequencer [58] = ("B16_S2");
				DialogueIDSequencer [59] = ("L4_S1");
				DialogueIDSequencer [60] = ("B17_S1");
				DialogueIDSequencer [61] = ("E14_S1");
				DialogueIDSequencer [62] = ("E14_S2");
				DialogueIDSequencer [63] = ("L5_S1");
				DialogueIDSequencer [64] = ("B18_S1");
				DialogueIDSequencer [65] = ("B18_S2");
				DialogueIDSequencer [66] = ("B18_S3");
				DialogueIDSequencer [67] = ("L6_S1");
				DialogueIDSequencer [68] = ("B19_S1");
				DialogueIDSequencer [69] = ("L7_S1");
				DialogueIDSequencer [70] = ("B20_S1");
				DialogueIDSequencer [71] = ("L8_S1");
				DialogueIDSequencer [72] = ("E15_S1");
				DialogueIDSequencer [73] = ("E15_S2");
				DialogueIDSequencer [74] = ("E15_S3");
				DialogueIDSequencer [75] = ("B21_S1");
				DialogueIDSequencer [76] = ("E16_S1");
				DialogueIDSequencer [77] = ("B22_S1");
				DialogueIDSequencer [78] = ("E17_S1");
				DialogueIDSequencer [79] = ("B23_S1");
				DialogueIDSequencer [80] = ("E18_S1");
				DialogueIDSequencer [81] = ("E18_S2");
				DialogueIDSequencer [82] = ("L9_S1");
				DialogueIDSequencer [83] = ("L9_S2");
				DialogueIDSequencer [84] = ("L9_S3");
				DialogueIDSequencer [85] = ("L9_S4");
				DialogueIDSequencer [86] = ("L9_S5");
				DialogueIDSequencer [87] = ("B24_S1");
				DialogueIDSequencer [88] = ("L10_S1");
				DialogueIDSequencer [89] = ("B25_S1");
				DialogueIDSequencer [90] = ("L11_S1");
				DialogueIDSequencer [91] = ("E19_S1");
				DialogueIDSequencer [92] = ("E19_S2");
				DialogueIDSequencer [93] = ("E19_S3");
				DialogueIDSequencer [94] = ("B26_S1");
				DialogueIDSequencer [95] = ("B26_S2");
				DialogueIDSequencer [96] = ("L12_S1");
				DialogueIDSequencer [97] = ("B27_S1");
				DialogueIDSequencer [98] = ("B27_S2");
				DialogueIDSequencer [99] = ("B27_S3");
				DialogueIDSequencer [100] = ("L13_S1");
				DialogueIDSequencer [101] = ("E20_S1");
				DialogueIDSequencer [102] = ("B28_S1");
				DialogueIDSequencer [103] = ("E21_S1");
				DialogueIDSequencer [104] = ("B29_S1");
				DialogueIDSequencer [105] = ("B29_S2");
				DialogueIDSequencer [106] = ("B29_S3");
				DialogueIDSequencer [107] = ("B29_S4");

			}

			public interface IDialogueSystems
			{

				void PlayAudio (string AudioID);

				void DisplayScript (string ScriptID);

				void PopulateScript ();


			}

		}

		public class CoreInput
		{


			public AnimationClip BrendanWalk = new AnimationClip ();

			// Use this for initialization
			void Start ()
			{

				Debug.Log ("Core Input Active");

			}

			// Update is called once per frame
			void Update ()
			{

			}
		}


		public class CoreUI : MonoBehaviour
		{

			// Use this for initialization
			void Start ()
			{

				Debug.Log ("Core UI Active");

			}

			// Update is called once per frame
			void Update ()
			{

			}



			public void DialogueBoxOpen ()
			{
				GameObject DialogueBox = GameObject.Find ("Dialog Box");

				DialogueBox.gameObject.SetActive (true);

				//NewDialogueUIState = DialogueControllerState.Open;
			}

			public void DialogueBoxClose ()
			{
				GameObject DialogueBox = GameObject.Find ("Dialog Box");

				DialogueBox.gameObject.SetActive (false);

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

}
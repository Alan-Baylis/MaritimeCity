
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEditor.Events;
using UnityEditor.Callbacks;
using System.Collections.Generic;
using System.Collections;
using System;

namespace DialogueSystems
{

    public class CoreDialogueSystems : MonoBehaviour
    {

        //public List<string> DialogueIDSequencer = new List<string>();
        public string[] DialogueIDSequencer = new string[108];

		private ElliController Elli;
		private BrendanPOVController BrendanObject;
		private LukeController Luke;

        private CoreEventSystems CoreEvents;
        public enum ConversationState { Active, Inactive };
        public ConversationState ConversationStateID = ConversationState.Inactive;
        public Text DialogueText;
        public enum ScriptID { Elli, Brendan, Luke };
        static int MaritimeDialogueIterator = 0;
       

		void Start()
		{
			Debug.Log("Core Dialogue Systems Active");


		}

		void Update()
		{
			StartCoroutine(DialogueIterator());
			//PassCurrentAudio();

			//BrendanObject.Update ();
			//Elli.Update ();
			//Luke.Update ();

			//PassCurrentScript();
		}



        void Awake()
        {
			InitializeDialogueIterator();
            //DialogueIDSequencer.Capacity = MaxScript;
            //DialogueObject = GameObject.Find("Dialog Text");
            //DialogueText = GetComponent<Text>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();

			DialogueIDSequencer.Initialize ();
		    
            //Elli = GameObject.FindGameObjectWithTag(tag: "Elli").GetComponent<ElliController>();
            //Luke = GameObject.FindGameObjectWithTag(tag: "Luke").GetComponent<LukeController>();
			//BrendanObject = GameObject.FindGameObjectWithTag ("Brendan Player").GetComponent<BrendanPOVController> ();
            CoreEvents = GameObject.FindGameObjectWithTag(tag: "Core").GetComponent<CoreEventSystems>();


			if (Elli == null) {
				Debug.Log ("Elli is not working and is null");

			}

			if (Luke == null) {
				Debug.Log ("Luke is not null and not working");
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

        public IEnumerator DialogueIterator()
        {
            if (ConversationStateID == ConversationState.Active)
            {

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S1")
                {
                    //Invokes Doorbell Function
                    //CoreEvents.SceneObject.Doorbell.Invoke();
                    //CoreEvents.SceneObject.OpenDoor.Invoke();

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S2")
                {
                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S3")
                {
                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S4")
                {
                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S1")
                {
                    yield return new WaitForSeconds(2);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S2")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S3")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S4")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E1_S5")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B2_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B2_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B2_S3")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E2_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E2_S2")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B3_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B3_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B3_S3")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S2")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E3_S3")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B4_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B4_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E4_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B5_S1")
                {
                    CoreEvents.SceneObject.WalkDogUpstairs.Invoke();
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.ElliFinishedTakingDogUpstairs());

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E5_S1")
                {
                    CoreEvents.SceneObject.ComeDownstairs.Invoke();
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.ElliComesBackDownStairs());

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S1")
                {
                    CoreEvents.SceneObject.EnterLivingRoom.Invoke();
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.ElliEntersLivingRoom());
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.BrendanEntersLivingRoom());

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S3")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S4")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L1_S1_T1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    //Turns to BrendanObject and gives a smile

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B7_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B7_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E6_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B8_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E7_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L2_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B9_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L3_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);
                    yield return new WaitUntil(() => CoreEvents.AnimationObject.LukePointsFinger());

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B10_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B10_S2")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B10_S3")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E8_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B11_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E9_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Nods head

                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B12_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S1")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);



                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S2")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);



                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E10_S3")
                {
                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B13_S1")
                {
                    CoreEvents.SceneObject.CheckCot.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.BrendanChecksCotCollider());
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E11_S1")
                {
                    CoreEvents.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E11_S2")
                {
                    CoreEvents.SceneObject.ElliLukeCheckCot.Invoke();

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B14_S1")
                {
                    CoreEvents.SceneObject.BrendanChecksBottle.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E12_S1")
                {


                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B15_S1")
                {
                    CoreEvents.SceneObject.BrendanPicksBottle.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E13_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B16_S1")
                {
                    CoreEvents.SceneObject.PointsToBrokenGlass.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L4_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B17_S1")
                {
                    //CoreEvents.SceneObject.PointsToBrokenGlass.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E14_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E14_S2")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L5_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B18_S1")
                {
                    //CoreEvents.SceneObject.PointsToBrokenGlass.Invoke();

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B18_S2")
                {


                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B18_S3")
                {


                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L6_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B19_S1")
                {


                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L7_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B20_S1")
                {
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L8_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B19_S1")
                {

                    //BrendanObject checks cot
                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S2")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E15_S3")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B21_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E16_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B22_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E17_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B23_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E18_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E18_S2")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L9_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L9_S2")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L9_S3")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L9_S4")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L9_S5")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B24_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L10_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B25_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L11_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S2")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E19_S3")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);
				
                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B26_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B26_S2")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L12_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B27_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B27_S2")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B27_S3")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L13_S1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E20_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B28_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "E21_S1")
                {

                    yield return new WaitForSeconds(1);

                    Elli.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);


                    yield return new WaitUntil(() => Elli.ElliSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B29_S1")
                {
                    CoreEvents.SceneObject.BrendanLeavesHouse.Invoke();

                    yield return new WaitUntil(() => CoreEvents.ColliderObject.BrendanFrontDoor());

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B29_S1")
                {

                    yield return new WaitForSeconds(1);

                    BrendanObject.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    BrendanObject.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => BrendanObject.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }
					

            }


        }


   
     
    }


    public interface IDialogueSystems
    {

        void PlayAudio(string AudioID);

        void DisplayScript(string ScriptID);

        void PopulateScript();


    }

}


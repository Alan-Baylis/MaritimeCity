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

        public List<string> DialogueIDSequencer = new List<string>();
        public ElliController Elli;
        public BrendanPOVController Brendan;
        public LukeController Luke;
        private CoreEventSystems CoreEvents;
        public enum ConversationState { Active, Inactive };
        public ConversationState ConversationStateID = ConversationState.Inactive;
        public Text DialogueText;
        public enum ScriptID { Elli, Brendan, Luke };
        static int MaritimeDialogueIterator = 0;
  

        void Awake()
        {

            //DialogueIDSequencer.Capacity = MaxScript;
            //DialogueObject = GameObject.Find("Dialog Text");
            //DialogueText = GetComponent<Text>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();


            Brendan = GameObject.FindGameObjectWithTag(tag: "Brendan Player").GetComponent<BrendanPOVController>();
            Elli = GameObject.FindGameObjectWithTag(tag: "Elli").GetComponent<ElliController>();
            Luke = GameObject.FindGameObjectWithTag(tag: "Luke").GetComponent<LukeController>();
            CoreEvents = GameObject.FindGameObjectWithTag(tag: "Core Event").GetComponent<CoreEventSystems>();

            DialogueIDSequencer.Add("B1_S1");
            DialogueIDSequencer.Add("B1_S2");
            DialogueIDSequencer.Add("B1_S3");
            DialogueIDSequencer.Add("B1_S4");
            DialogueIDSequencer.Add("E1_S1");
            DialogueIDSequencer.Add("E1_S2");
            DialogueIDSequencer.Add("E1_S3");
            DialogueIDSequencer.Add("E1_S4");
            DialogueIDSequencer.Add("E1_S5");
            DialogueIDSequencer.Add("B2_S1");
            DialogueIDSequencer.Add("B2_S2");
            DialogueIDSequencer.Add("B2_S3");
            DialogueIDSequencer.Add("B2_S3");
            DialogueIDSequencer.Add("E2_S1");
            DialogueIDSequencer.Add("E2_S2");
            DialogueIDSequencer.Add("B3_S1");
            DialogueIDSequencer.Add("B3_S2");
            DialogueIDSequencer.Add("B3_S3");
            DialogueIDSequencer.Add("E3_S1");
            DialogueIDSequencer.Add("E3_S2");
            DialogueIDSequencer.Add("E3_S3");
            DialogueIDSequencer.Add("B4_S1");
            DialogueIDSequencer.Add("B4_S2");
            DialogueIDSequencer.Add("E4_S1");
            DialogueIDSequencer.Add("B5_S1");
            DialogueIDSequencer.Add("B6_S1");
            DialogueIDSequencer.Add("B6_S2");
            DialogueIDSequencer.Add("B6_S3");
            DialogueIDSequencer.Add("B6_S4");
            DialogueIDSequencer.Add("L1_T1_S1");
            DialogueIDSequencer.Add("B7_S1");
            DialogueIDSequencer.Add("B7_S2");
            DialogueIDSequencer.Add("E7_S1");
            DialogueIDSequencer.Add("B8_S1");
            DialogueIDSequencer.Add("E8_S1");
            DialogueIDSequencer.Add("L2_S1");
            DialogueIDSequencer.Add("B9_S1");
            DialogueIDSequencer.Add("L3_S1");
            DialogueIDSequencer.Add("B10_S1");
            DialogueIDSequencer.Add("B10_S2");
            DialogueIDSequencer.Add("B10_S3");
            DialogueIDSequencer.Add("B10_S4");
            DialogueIDSequencer.Add("E8_S1");
            DialogueIDSequencer.Add("B11_S1");
            DialogueIDSequencer.Add("E9_S1");
            DialogueIDSequencer.Add("B12_S1");
            DialogueIDSequencer.Add("E10_S1");
            DialogueIDSequencer.Add("E10_S2");
            DialogueIDSequencer.Add("E10_S3");
            DialogueIDSequencer.Add("B13_S1");
            DialogueIDSequencer.Add("E11_S1");
            DialogueIDSequencer.Add("E11_S1");
            DialogueIDSequencer.Add("B14_S1");
            DialogueIDSequencer.Add("E12_S1");
            DialogueIDSequencer.Add("E12_S2");
            DialogueIDSequencer.Add("B15_S1");
            DialogueIDSequencer.Add("E13_S1");
            DialogueIDSequencer.Add("B16_S1");
            DialogueIDSequencer.Add("B16_S2");
            DialogueIDSequencer.Add("L4_S1");
            DialogueIDSequencer.Add("B17_S1");
            DialogueIDSequencer.Add("E14_S1");
            DialogueIDSequencer.Add("E14_S2");
            DialogueIDSequencer.Add("L5_S1");
            DialogueIDSequencer.Add("B18_S1");
            DialogueIDSequencer.Add("B18_S2");
            DialogueIDSequencer.Add("B18_S3");
            DialogueIDSequencer.Add("L6_S1");
            DialogueIDSequencer.Add("B19_S1");
            DialogueIDSequencer.Add("L7_S1");
            DialogueIDSequencer.Add("B20_S1");
            DialogueIDSequencer.Add("L8_S1");
            DialogueIDSequencer.Add("E15_S1");
            DialogueIDSequencer.Add("E15_S2");
            DialogueIDSequencer.Add("E15_S3");
            DialogueIDSequencer.Add("B21_S1");
            DialogueIDSequencer.Add("E16_S1");
            DialogueIDSequencer.Add("B22_S1");
            DialogueIDSequencer.Add("E17_S1");
            DialogueIDSequencer.Add("B23_S1");
            DialogueIDSequencer.Add("E18_S1");
            DialogueIDSequencer.Add("E18_S2");
            DialogueIDSequencer.Add("L9_S1");
            DialogueIDSequencer.Add("L9_S2");
            DialogueIDSequencer.Add("L9_S3");
            DialogueIDSequencer.Add("L9_S4");
            DialogueIDSequencer.Add("L9_S5");
            DialogueIDSequencer.Add("B24_S1");
            DialogueIDSequencer.Add("L10_S1");
            DialogueIDSequencer.Add("B25_S1");
            DialogueIDSequencer.Add("L11_S1");
            DialogueIDSequencer.Add("E19_S1");
            DialogueIDSequencer.Add("E19_S2");
            DialogueIDSequencer.Add("E19_S3");
            DialogueIDSequencer.Add("B26_S1");
            DialogueIDSequencer.Add("B26_S2");
            DialogueIDSequencer.Add("L12_S1");
            DialogueIDSequencer.Add("B27_S1");
            DialogueIDSequencer.Add("B27_S2");
            DialogueIDSequencer.Add("B27_S3");
            DialogueIDSequencer.Add("L13_S1");
            DialogueIDSequencer.Add("E20_S1");
            DialogueIDSequencer.Add("B28_S1");
            DialogueIDSequencer.Add("E21_S1");
            DialogueIDSequencer.Add("B29_S1");
            DialogueIDSequencer.Add("B29_S2");
            DialogueIDSequencer.Add("B29_S3");
            DialogueIDSequencer.Add("B29_S4");


        }



        public IEnumerator DialogueIterator()
        {
            if (ConversationStateID == ConversationState.Active)
            {

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S1")
                {
                    //Invokes Doorbell Function
                    CoreEvents.SceneObject.Doorbell.Invoke();
                    CoreEvents.SceneObject.OpenDoor.Invoke();

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S2")
                {
                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S3")
                {
                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B1_S4")
                {
                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B2_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B2_S3")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B3_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B3_S3")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B4_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    //Invoke relevant Event here!

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S3")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B6_S4")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "L1_S1_T1")
                {
                    yield return new WaitForSeconds(1);

                    Luke.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Luke.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Luke.LukeSource.isPlaying == false);

                    //Turns to Brendan and gives a smile

                    MaritimeDialogueIterator++;

                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B7_S1")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B7_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B10_S2")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;

                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B10_S3")
                {
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitUntil(() => CoreEvents.ColliderObject.BrendanChecksCotCollider());
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }

                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B18_S2")
                {


                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B18_S3")
                {


                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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


                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    //Brendan checks cot
                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B26_S2")
                {

                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B27_S2")
                {

                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }


                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B27_S3")
                {

                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

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

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }



                if (DialogueIDSequencer[MaritimeDialogueIterator] == "B29_S1")
                {

                    yield return new WaitForSeconds(1);

                    Brendan.PlayAudio(AudioID: DialogueIDSequencer[MaritimeDialogueIterator]);
                    Brendan.DisplayScript(ScriptID: DialogueIDSequencer[MaritimeDialogueIterator]);

                    yield return new WaitUntil(() => Brendan.BrendanSource.isPlaying == false);

                    MaritimeDialogueIterator++;
                }
























            }


        }
            void Start()
        {

            Debug.Log("Core Dialogue Systems Active");

        }

        void Update()
        {
            StartCoroutine(DialogueIterator());
            //PassCurrentAudio();
            //PassCurrentScript();

        }

     
    }


    public interface IDialogueSystems
    {

        void PlayAudio(string AudioID);

        void DisplayScript(string ScriptID);

        void PopulateScript();


    }

}


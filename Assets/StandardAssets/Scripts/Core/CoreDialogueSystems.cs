﻿using UnityEngine;
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

        int MaxScript = 100;
        int MaritimeDialogueIterator = 0;

        public Dictionary<string, UnityAction> SequenceOfEvents;



        public enum ConversationState { Start, Active, End };

        //Defined Types
        // public ElliController Elli = new ElliController();

        // public LukeController Luke = new LukeController();

        // public BrendanPOVController Brendan = new BrendanPOVController();


        public Text DialogueText;
        public enum ScriptID { Elli, Brendan, Luke };
        enum DialogueStateID { None, Elli, Brendan, Luke };
        DialogueStateID DialogueState;
        private int SequencerIterator = 0;
        int BrendanInternalIterator = 0;
        int ElliInternalIterator = 0;
        int LukeInternalIterator = 0;



        /// <summary>
        /// Checks to see which Audio Source is playing 
        /// </summary>
        /// <returns></returns>
        /// 
        /// 
        /*
        public AudioSource QueryAudioSource()
        {

            if (BrendanSource.isPlaying == true)
            {
                return BrendanSource;

            }
            else if (LukeSource.isPlaying == true)
            {
                return LukeSource;

            }
            else if (ElliSource.isPlaying == true)
            {

                return ElliSource;
            }

            return null;
        }*/

        IEnumerator ScriptIDDefinition(List<string> DynamicDialogueScript, string Script)
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

            yield return null;

        }

        void Awake()
        {
            
            //DialogueIDSequencer.Capacity = MaxScript;
            //DialogueObject = GameObject.Find("Dialog Text");
            //DialogueText = GetComponent<Text>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();
            //DialogueObject.AddComponent<AudioSource>();

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
            //InitializeDialogueEvents();
            //Should be moved
            ConversationState ConversationStateID = ConversationState.Active;


            if (ConversationStateID == ConversationState.Start)
            {

                int Iterator = 0;

                if (DialogueIDSequencer[Iterator] == "B1_S1")
                {

                    ElliController Elli = FindObjectOfType<ElliController>();

                    //Makes sure what we are seeing is valid;
                    Elli.PlayAudio(AudioID: DialogueIDSequencer[Iterator]);
                    Elli.DisplayScript(ScriptID: DialogueIDSequencer[Iterator]);

                    //Invoke relevant Event here!

                    Iterator++;
                    yield return new WaitForSeconds(1);

                }

                if (DialogueIDSequencer[Iterator] == "E10_S3")
                {

                    //Invoke Look at Cot Event

                    yield return new WaitForSeconds(1);
                }

                if (DialogueIDSequencer[Iterator] == "L10_S1")
                {

                    ///Luke gets angry

                    yield return new WaitForSeconds(1);
                }

                if (DialogueIDSequencer[Iterator] == "E29_S4")
                {

                    //Show Tara crying 

                    yield return new WaitForSeconds(1);

                }

            }


        }

        /*Needs changing 
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

            return nu
        }
        */

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


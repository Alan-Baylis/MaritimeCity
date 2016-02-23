﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;


namespace DialogueSystems
{

    public class LukeController : CoreDialogueSystems, IDialogueSystems
    {

        private string FileName;
        
        private CoreDialogueSystems Core;
        public List<string> LukeScript = new List<string>(50);
        public AudioClip[] LukeAudio = new AudioClip[18];
        public AudioSource LukeSource;

        // Use this for initialization
        void Start()
        {
            LukeSource = GetComponent<AudioSource>();

            Core = GameObject.FindGameObjectWithTag("Core").GetComponent<CoreDialogueSystems>();
            DialogueIDSequencer = Core.DialogueIDSequencer;
            PopulateScript();

        }

        public IEnumerator ScriptIDDefinition(ScriptID ScriptIdentification, string DefineScript)
        {
            //Use logger to check conditions, use iterators for dynamic functions
            int ScriptLogger = 0;
            ScriptLogger++;

           

            print("Result for Script Logger is " + ScriptLogger);
            if (ScriptIdentification == ScriptID.Luke)
            {
                LukeScript.Add(DefineScript);
                
            }

            yield return new WaitForEndOfFrame();
        }


        public void PlayAudio(string DialogueID)
        {
            if (DialogueID == "L1_T1_S1")
            {
                LukeSource.clip = LukeAudio[1];
            }

        }

        public void DisplayScript(string ScriptID)
        {

        }

        public void PopulateScript()
        {
            FileName = LukeAudio[0].ToString();

            if (FileName.Contains("L1_S1_T1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "What's it to you?"));
            }

            FileName = LukeAudio[1].ToString();

            if (FileName.Contains("L2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Are you calling her a Liar"));
            }

            FileName = LukeAudio[2].ToString();

            if (FileName.Contains("L3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "I told ya, Brad-fucking-pitt, now piss off"));
            }

            FileName = LukeAudio[3].ToString();

            if (FileName.Contains("L4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "He's always bleedin' hungry"));
            }

            FileName = LukeAudio[4].ToString();

            if (FileName.Contains("L5_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Let him clear it up if he's so bloody worried"));
            }

            FileName = LukeAudio[5].ToString();

            if (FileName.Contains("L6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Fuck off, he's nothing to do with me"));
            }

            FileName = LukeAudio[6].ToString();

            if (FileName.Contains("L7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "No I fucking didn't"));
            }

            FileName = LukeAudio[7].ToString();

            if (FileName.Contains("L8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Just piss off and leave us alone"));
            }

            FileName = LukeAudio[8].ToString();

            if (FileName.Contains("L9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Yeah, I took her and left her with her fucking granny, just like Elli said"));
            }

            FileName = LukeAudio[9].ToString();

            if (FileName.Contains("L9_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Kid said she wanted to see granny so I took her to her granny's, satisfied Mr Supernanny"));
            }

            FileName = LukeAudio[10].ToString();

            if (FileName.Contains("L9_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "I just do what Elli and little princess asks see, got me wrapped around her little finger she has"));
            }

            FileName = LukeAudio[11].ToString();

            if (FileName.Contains("L9_S4"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "See what a great stepdad I am"));
            }

            FileName = LukeAudio[12].ToString();

            if (FileName.Contains("L9_S5"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Do anything she wants"));
            }

            FileName = LukeAudio[13].ToString();

            if (FileName.Contains("L10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Never satisfied are you, bloody social workers. Should put 'em all in a sack and drown them at Birth"));
            }

            FileName = LukeAudio[14].ToString();

            if (FileName.Contains("L11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "You leave my mum out of this you fucking nosy bastard now fuck off out of here before I throw you out"));
            }

            FileName = LukeAudio[15].ToString();

            if (FileName.Contains("L12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Oh fuck off you old woman"));
            }

            FileName = LukeAudio[16].ToString();

            if (FileName.Contains("L13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Luke, "Gonna get ya mates are ya? Fucking wimp, you ain't worth it, it would be too easy"));
            }


        }


        IEnumerator LukeDialogueController()
        {
            //yield return new WaitUntil (() => NewDialogueState == DialogueState.Luke);

            yield return null;
        }


        // Update is called once per frame
        void Update()
        {

        }
    }

}

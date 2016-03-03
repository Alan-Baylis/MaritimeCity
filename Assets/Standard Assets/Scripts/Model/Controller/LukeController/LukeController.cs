﻿using UnityEngine;
using CoreSystems;
using System.Collections.Generic;
using System.Collections;
using System;

namespace DialogueSystems
{

    public class LukeController : Core, ICommunciation
    {

		//InputController NewController;
	

		[SerializeField] private string FileName;
        int ScriptLogger = 0;
        public List<string> LukeScript = new List<string>(50);
        public AudioClip[] LukeAudio = new AudioClip[18];
        public AudioSource LukeSource;
        static int LukeDialogueIterator = 0;
        string[] DialogueIDSequencer = new string[108];

        void Awake()
        {
            PopulateScript();

            LukeDialogueIterator = CoreDialogueSystems.MaritimeDialogueIterator;
            DialogueIDSequencer = CoreDialogueSystems.DialogueIDSequencer;
        }

        // Use this for initialization
        void Start()
        {
            LukeSource = GetComponent<AudioSource>();
     
        }

        public IEnumerator ScriptIDDefinition(CoreDialogueSystems.ScriptID ScriptIdentification, string DefineScript)
        {
            //Use logger to check conditions, use iterators for dynamic functions
           
            ScriptLogger++;

            MonoBehaviour.print("Result for Luke Script Logger is " + ScriptLogger);

            if (ScriptIdentification == CoreDialogueSystems.ScriptID.Luke)
            {
                LukeScript.Add(DefineScript);
                
            }

            yield return new WaitForEndOfFrame();
        }


        public IEnumerator LukeDialogueController()
        {

            if (DialogueIDSequencer[LukeDialogueIterator] == "L1_S1_T1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                //Turns to BrendanObject and gives a smile

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L2_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }



            if (DialogueIDSequencer[LukeDialogueIterator] == "L3_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);
                yield return new WaitUntil(() => GetCoreEventSystemObject().AnimationObject.LukePointsFinger());

                LukeDialogueIterator++;

            }




            if (DialogueIDSequencer[LukeDialogueIterator] == "L4_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L5_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }



            if (DialogueIDSequencer[LukeDialogueIterator] == "L6_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L7_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L8_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }



            if (DialogueIDSequencer[LukeDialogueIterator] == "L9_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L9_S2")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L9_S3")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L9_S4")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L9_S5")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }



            if (DialogueIDSequencer[LukeDialogueIterator] == "L10_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L11_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }




            if (DialogueIDSequencer[LukeDialogueIterator] == "L12_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }


            if (DialogueIDSequencer[LukeDialogueIterator] == "L13_S1")
            {
                yield return new WaitForSeconds(1);

                PlayAudio(AudioID: DialogueIDSequencer[LukeDialogueIterator]);
                DisplayScript(ScriptID: DialogueIDSequencer[LukeDialogueIterator]);

                yield return new WaitUntil(() => LukeSource.isPlaying == false);

                LukeDialogueIterator++;

            }



        }

        public void PlayAudio(string AudioID)
        {
            if (AudioID == "L1_T1_S1")
            {
                LukeSource.clip = LukeAudio[1];
                LukeSource.PlayDelayed(1);
            }

            if(AudioID == "L2_S1")
            {
                LukeSource.clip = LukeAudio[2];
                LukeSource.PlayDelayed(1);
            }

            if(AudioID == "L3_S1")
            {
                LukeSource.clip = LukeAudio[3];
                LukeSource.PlayDelayed(1);
            }

            if(AudioID == "L4_S1")
            {
                LukeSource.clip = LukeAudio[4];
                LukeSource.PlayDelayed(1);
            }

            if(AudioID == "L5_S1")
            {
                LukeSource.clip = LukeAudio[5];
                LukeSource.PlayDelayed(1);
            }

            if(AudioID == "L6_S1")
            {
                LukeSource.clip = LukeAudio[6];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L7_S1")
            {
                LukeSource.clip = LukeAudio[7];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L8_S1")
            {
                LukeSource.clip = LukeAudio[8];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L9_S1")
            {
                LukeSource.clip = LukeAudio[9];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L9_S2")
            {
                LukeSource.clip = LukeAudio[10];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L9_S3")
            {
                LukeSource.clip = LukeAudio[11];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L9_S4")
            {
                LukeSource.clip = LukeAudio[12];
                LukeSource.PlayDelayed(1);
            }

            if (AudioID == "L9_S5")
            {
                LukeSource.clip = LukeAudio[13];
                LukeSource.PlayDelayed(1);
            }


            if (AudioID == "L10_S1")
            {
                LukeSource.clip = LukeAudio[13];
                LukeSource.PlayDelayed(1);
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
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "What's it to you?"));
            }

            FileName = LukeAudio[1].ToString();

            if (FileName.Contains("L2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Are you calling her a Liar"));
            }

            FileName = LukeAudio[2].ToString();

            if (FileName.Contains("L3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "I told ya, Brad-fucking-pitt, now piss off"));
            }

            FileName = LukeAudio[3].ToString();

            if (FileName.Contains("L4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "He's always bleedin' hungry"));
            }

            FileName = LukeAudio[4].ToString();

            if (FileName.Contains("L5_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Let him clear it up if he's so bloody worried"));
            }

            FileName = LukeAudio[5].ToString();

            if (FileName.Contains("L6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Fuck off, he's nothing to do with me"));
            }

            FileName = LukeAudio[6].ToString();

            if (FileName.Contains("L7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "No I fucking didn't"));
            }

            FileName = LukeAudio[7].ToString();

            if (FileName.Contains("L8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Just piss off and leave us alone"));
            }

            FileName = LukeAudio[8].ToString();

            if (FileName.Contains("L9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Yeah, I took her and left her with her fucking granny, just like Elli said"));
            }

            FileName = LukeAudio[9].ToString();

            if (FileName.Contains("L9_S2"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Kid said she wanted to see granny so I took her to her granny's, satisfied Mr Supernanny"));
            }

            FileName = LukeAudio[10].ToString();

            if (FileName.Contains("L9_S3"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "I just do what Elli and little princess asks see, got me wrapped around her little finger she has"));
            }

            FileName = LukeAudio[11].ToString();

            if (FileName.Contains("L9_S4"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "See what a great stepdad I am"));
            }

            FileName = LukeAudio[12].ToString();

            if (FileName.Contains("L9_S5"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Do anything she wants"));
            }

            FileName = LukeAudio[13].ToString();

            if (FileName.Contains("L10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Never satisfied are you, bloody social workers. Should put 'em all in a sack and drown them at Birth"));
            }

            FileName = LukeAudio[14].ToString();

            if (FileName.Contains("L11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "You leave my mum out of this you fucking nosy bastard now fuck off out of here before I throw you out"));
            }

            FileName = LukeAudio[15].ToString();

            if (FileName.Contains("L12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Oh fuck off you old woman"));
            }

            FileName = LukeAudio[16].ToString();

            if (FileName.Contains("L13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(CoreDialogueSystems.ScriptID.Luke, "Gonna get ya mates are ya? Fucking wimp, you ain't worth it, it would be too easy"));
            }


        }


        // Update is called once per frame
        void Update()
        {

        }

        public ICommunciation ReturnType()
        {
            throw new NotImplementedException();
        }

        new public void ReceiveResponse(ICommunciation CharacterType)
        {
            throw new NotImplementedException();
        }

        public IEnumerator DialogueIterator()
        {
            throw new NotImplementedException();
        }

        public static int GetInternalIterator()
        {
            return LukeDialogueIterator;
        }

    }

}

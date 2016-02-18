﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;




/// <summary>
/// Add the audio and script data directly into the file, makes life easier
/// Lists are a pain in the ass 
/// </summary>
public class LowLevelDialogueController : HighLevelDialogueController
{
    string FileName;
	public Text DialogueText;
	DialogueState NewDialogueState;
	bool bHasGameStarted = false;
	bool bHasCharacterKnockedDoor = false;

    Dictionary<string, UnityAction> SequenceOfEvents;
    

   public enum DefineScriptEnum { Elli, Brendan, Luke};
   DefineScriptEnum ScriptEnum;

   

    //Remember to attach AudioSources to their respective characters

    void Awake()
	{
		DialogueObject = GameObject.Find ("Dialog Text");
		DialogueText = GetComponent<Text> ();
		DialogueObject.AddComponent<AudioSource>();
		DialogueObject.AddComponent<AudioSource>();
		DialogueObject.AddComponent<AudioSource>();


        UnityAction WalkDogUpstairs;
        UnityAction LookAtWhereMableWasSitting;
        UnityAction ElliReturnsDownstairs;
        UnityAction SceneMovesTOLivingRoom;
        UnityAction LiamCrying;
        UnityAction LukeAngry;
        UnityAction LukePoints;
        UnityAction BrendanPicksUpBaby;
        UnityAction ElliandLukeMoveToTheSideofTheCot;
        UnityAction BrendanCallsManager;

		PopulateScript ();

		//UnityEvent_DialogueBoxClose.Invoke ();

		UnityEvent_DialogueBoxOpen.AddListener (DialogueBoxOpen);
		UnityEvent_DialogueBoxClose.AddListener (DialogueBoxOpen);

        //There needs to be a set list of things happening in a particular order so that we can initiate the right events
        //properly

	}

	// Use this for initialization
	void Start ()
	{
		bConversationStart = false;
		NewDialogueState = DialogueState.Brendan;
		
		PrimarySource = DialogueObject.GetComponent<AudioSource> ();
		ElliSource = DialogueObject.GetComponent<AudioSource> ();
		LukeSource = DialogueObject.GetComponent<AudioSource> ();

	    PopulateScript ();

		//StartCoroutine (_DialogueController_Audio());
		StartCoroutine (BrendanDialogueController());
	}


    public void SequencerFunction()
    {

        //Add the order of things here 
        string[] Sequencer = new string[50];
        Sequencer[0] = "B1_S1";
        Sequencer[1] = "B1_S2";
        Sequencer[2] = "B1_S3";
        Sequencer[3] = "B1_S4";
        Sequencer[4] = "E1_S1";
        Sequencer[5] = "E2_S2";

        //Add the functions to be implemented as listeners
        UnityAction ElliWalkMableUpstairs = DialogueTextModifier;
        SequenceOfEvents.Add("B4_S2", ElliWalkMableUpstairs);

    
        //Add if statements to add invoke events when it is time for them
        //template
        if (AudioIterator == 1)
        {
            UnityEvent_DogBarking.Invoke();
        }


        //Final allocation
        SequencerArray = Sequencer;

     }


    public void DialogueTextModifier()
    {

    //Modify text elements here

    }


	public void DefineScript (DefineScriptEnum _ScriptEnum, string _DefineScript)
	{
        if (_ScriptEnum == DefineScriptEnum.Brendan)
        {   
            //Use logger to check conditions, use iterators for dymanic functions
            int BrendanScriptLogger = 0;
            BrendanScriptLogger++;

            if (BrendanScript[ScriptIterator] == "")
            {
                BrendanScript[ScriptIterator] = _DefineScript;
                DialogueText.text = BrendanScript[ScriptIterator];
                //Makes sure that the entry point is in the next array
                ScriptIterator++;
            }

        } else if (_ScriptEnum == DefineScriptEnum.Elli)
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

        } 

	}

    void DialogueStateController()
    {
        //We will control the Dialogue State within this function
        if (AudioIterator > 4)
        {
            PrimarySource.Stop();
            NewDialogueState = DialogueState.Elli;
        }

    }


		
	IEnumerator BrendanDialogueController()
	{
		if (PrimarySource.isPlaying == false && NewDialogueState == DialogueState.Brendan) {
			//PrimarySource.clip.UnloadAudioData ();
			PrimarySource.clip = BrendanAudioDialogue [AudioIterator];
			PrimarySource.Play ();
			AudioIterator++;


		}

		//yield return new WaitWhile (() => PrimarySource.isPlaying == false);
        yield return new WaitForSeconds(PrimarySource.clip.length);
			
	}


	IEnumerator ElliDialogueController()
	{
		if (NewDialogueState == DialogueState.Elli && PrimarySource.isPlaying == false) 
		{
			//StopCoroutine(BrendanDialogueController());
			PrimarySource.Stop ();
			AudioIterator = 0;
			ElliSource.clip = ElliAudioDialogue [AudioIterator];
			AudioIterator++;    
		}
			
		yield return null;
	}


	IEnumerator LukeDialogueController()
    {
		//yield return new WaitUntil (() => NewDialogueState == DialogueState.Luke);

        yield return null;
	}

	public void DialogueBoxOpen()
	{
		GameObject DialogueBox = GameObject.Find("Dialog Box");

		DialogueBox.gameObject.SetActive (true);
	   
		NewDialogueUIState = DialogueControllerState.Open;
	}

	public void DialogueBoxClose()
	{
		GameObject DialogueBox = GameObject.Find("Dialog Box");

		DialogueBox.gameObject.SetActive (false);

		NewDialogueUIState = DialogueControllerState.Closed;
	}

    //Provides some sort of Sequencing and Type Safety
    public void PopulateScript()
    {
        Debug.Log("Not Active Yet");

        FileName = BrendanAudioDialogue[0].ToString();

        if (FileName.Contains("B1_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Hi name is Brendan from Maritime Children's Services Safeguarding Team");
            Debug.Log("B1_S1 Active");
        }

        //Brendan First Paragraph

        FileName = BrendanAudioDialogue[1].ToString();

        if (FileName.Contains("B1_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Are you Ms Grove...Elli?");
        }

        FileName = BrendanAudioDialogue[2].ToString();

        if (FileName.Contains("B1_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "We have had an referral from an anonymous source rasing concerns about the children living here");
        }

        FileName = BrendanAudioDialogue[3].ToString();

        if (FileName.Contains("B1_S4"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Can I come in and talk to you about this");
        }

        //Brendan Second Paragraph

        FileName = BrendanAudioDialogue[4].ToString();

        if (FileName.Contains("B2_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Erm sorry, no I can't");
        }

        FileName = BrendanAudioDialogue[5].ToString();

        if (FileName.Contains("B2_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "The refererrer has told us there have been disturbances by adults at this address and that the childrten have been heard crying, distressed and upset");
        }

        FileName = BrendanAudioDialogue[6].ToString();

        if (FileName.Contains("B2_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I need to talk to you about this and see the children, can I come in please?");
        }

        FileName = BrendanAudioDialogue[7].ToString();

        if (FileName.Contains("B3_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Erm, I like dogs");
        }

        FileName = BrendanAudioDialogue[8].ToString();

        if (FileName.Contains("B3_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Got one of my own in fact, but Mable here doesn't look very friendly");
        }

        FileName = BrendanAudioDialogue[9].ToString();

        if (FileName.Contains("B3_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Can I ask you to move her please or does she bite?");
        }

        FileName = BrendanAudioDialogue[10].ToString();

        if (FileName.Contains("B4_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Could I ask if you could take her upstairs or tie her outside if that's OK, I think she is a bit overexcited and I wouldn't like her to harm anyone.");
        }

        FileName = BrendanAudioDialogue[11].ToString();

        if (FileName.Contains("B4_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Who does she belong to?");
        }

        FileName = BrendanAudioDialogue[12].ToString();

        if (FileName.Contains("B5_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Oh, shit");
        }

        FileName = BrendanAudioDialogue[13].ToString();

        if (FileName.Contains("B6_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Hi, my name is Brendan, I’m from the Safeguarding Team at Maritime Social Services.");
        }

        FileName = BrendanAudioDialogue[14].ToString();

        if (FileName.Contains("B6_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I’m here under Section 47 of the Children’s Act to investigate an anonymous referral that the two children living here have been heard crying and thought to be extremely distressed.");
        }

        FileName = BrendanAudioDialogue[15].ToString();

        if (FileName.Contains("B6_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I've already met Elli and the very excitable Mable, can I ask who you are?");
        }

        FileName = BrendanAudioDialogue[16].ToString();

        if (FileName.Contains("B6_S4"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Can I ask who you are");
        }

        FileName = BrendanAudioDialogue[17].ToString();

        if (FileName.Contains("B7_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I didn't know Brad lived around here!");
        }

        FileName = BrendanAudioDialogue[18].ToString();

        if (FileName.Contains("B7_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Are you related to either of the children");
        }

        FileName = BrendanAudioDialogue[19].ToString();

        if (FileName.Contains("B8_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Is that right?");
        }


        FileName = BrendanAudioDialogue[20].ToString();

        if (FileName.Contains("B9_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Of course not, I just need to be clear who you are");
        }

        FileName = BrendanAudioDialogue[21].ToString();

        if (FileName.Contains("B10_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I can't do that, as I've said we have had a referral that there have been late night parties, shouting, the sound of children crying and clearly distressed ");
        }

        FileName = BrendanAudioDialogue[22].ToString();

        if (FileName.Contains("B10_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I need to be clear that the children are safe");
        }

        FileName = BrendanAudioDialogue[23].ToString();

        if (FileName.Contains("B10_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Now, I understand you have two children, Liam, aged 5 months, and Tara aged 4. Are you the mother, Elli");
        }

        //Begin UnityEvent - Discussion and Interaction Section 

        FileName = BrendanAudioDialogue[24].ToString();

        if (FileName.Contains("B11_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I can see Liam, but where's Tara?");
        }

        FileName = BrendanAudioDialogue[25].ToString();

        if (FileName.Contains("B12_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Really, why is that?");
        }

        FileName = BrendanAudioDialogue[26].ToString();

        if (FileName.Contains("B13_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Liam is very wet");
        }

        FileName = BrendanAudioDialogue[27].ToString();

        if (FileName.Contains("B14_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Is that his bottle on the floor");
        }

        FileName = BrendanAudioDialogue[28].ToString();

        if (FileName.Contains("B15_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I'll get it");
        }

        FileName = BrendanAudioDialogue[29].ToString();

        if (FileName.Contains("B16_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I think the teat might glass or something on it");
        }

        FileName = BrendanAudioDialogue[30].ToString();

        if (FileName.Contains("B16_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Maybe from the broken beer bottle on the floor?");
        }

        FileName = BrendanAudioDialogue[31].ToString();

        if (FileName.Contains("B17_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "You need to consider that it is not safe having broken glass around with small children");
        }

        FileName = BrendanAudioDialogue[32].ToString();

        if (FileName.Contains("B18_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "And look at this, he's red raw");
        }

        FileName = BrendanAudioDialogue[33].ToString();

        if (FileName.Contains("B18_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Have you seen your GP or health visitor about this nappy rash?");
        }

        FileName = BrendanAudioDialogue[34].ToString();

        if (FileName.Contains("B18_S3"))
        {

            DefineScript(DefineScriptEnum.Brendan, "You really must change him, perhaps err, Brad could do it whilst you sort out his bottle Eli?");
        }

        FileName = BrendanAudioDialogue[35].ToString();

        if (FileName.Contains("B19_S1)"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I thought you said you were his father");
        }


        FileName = BrendanAudioDialogue[36].ToString();

        if (FileName.Contains("B20_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "You're not Liam's father then?");
        }

        FileName = BrendanAudioDialogue[37].ToString();

        if (FileName.Contains("B21_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "And you have some cream now?");
        }

        FileName = BrendanAudioDialogue[38].ToString();

        if (FileName.Contains("B22_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Right... and what about Tara, where did you say she was?");
        }

        FileName = BrendanAudioDialogue[39].ToString();

        if (FileName.Contains("B23_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "And where's that?");
        }

        FileName = BrendanAudioDialogue[40].ToString();

        if (FileName.Contains("B24_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Perhaps I could go and see Tara at her grandma's");
        }

        FileName = BrendanAudioDialogue[41].ToString();

        if (FileName.Contains("B25_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "So, I can go over and see Tara at her grandma's");

        }

        FileName = BrendanAudioDialogue[42].ToString();

        if (FileName.Contains("B26_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "OK, I'll go but I do need to see Tara and I am not very happy about Liam");
        }

        FileName = BrendanAudioDialogue[43].ToString();

        if (FileName.Contains("B26_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I really think he should be looked at by a doctor Elli, today, can you manage that?");

        }

        FileName = BrendanAudioDialogue[44].ToString();

        if (FileName.Contains("B27_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Luke there is no need to be abusive");
        }

        FileName = BrendanAudioDialogue[45].ToString();

        if (FileName.Contains("B27_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I have a duty to ensure that the children are safe");
        }

        FileName = BrendanAudioDialogue[46].ToString();

        if (FileName.Contains("B27_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "If I go now I'll only need to come back again later today with my senior, possibly a police officer");
        }

        FileName = BrendanAudioDialogue[47].ToString();

        if (FileName.Contains("B28_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Here is my card, I am going back to my office now and will come back in an hor with a colleague to see Tara, do you understand Elli?");
        }

        FileName = BrendanAudioDialogue[48].ToString();

        if (FileName.Contains("B29_S1"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Hi Steve, it's Me");
        }

        FileName = BrendanAudioDialogue[49].ToString();

        if (FileName.Contains("B29_S2"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Err, things not too good here - no, I'm not alright. I didn't get to see Tara and Liam was in a state");
        }

        FileName = BrendanAudioDialogue[50].ToString();

        if (FileName.Contains("B29_S3"))
        {
            DefineScript(DefineScriptEnum.Brendan, "Yeah, I'm a bit shaken to be honest, this guy Luke seems to have moved in with a seriously scary dog, I wasn't expecting that, he was real piece of work");
        }

        FileName = BrendanAudioDialogue[51].ToString();

        if (FileName.Contains("B29_S4"))
        {
            DefineScript(DefineScriptEnum.Brendan, "I am going to call the Police we really need to get back in there");
        }


		FileName = ElliAudioDialogue [0].ToString ();

		if (FileName.Contains ("E1_S1")) 
		{
			DefineScript (DefineScriptEnum.Elli, "Yeah, I'm Elli Grove");
		}

      
			
		FileName = ElliAudioDialogue [1].ToString ();

		if (FileName.Contains ("E1_S2")) 
		{
			DefineScript (DefineScriptEnum.Elli, "Um, err, um, err, well you can hear that Liam is crying"); 

		}

		FileName = ElliAudioDialogue [2].ToString ();

		if (FileName.Contains ("E1_S3")) 
		{
			DefineScript (DefineScriptEnum.Elli, "He cries, all the time with his Belly Ache. And his teething");
		
		}

		FileName = ElliAudioDialogue [3].ToString ();

		if (FileName.Contains ("E1_S4")) 
		{
			DefineScript (DefineScriptEnum.Elli, "Erm... it's not really convenient at the moment, could you come back tomorrow");
		
		}


	}
		
	void QueryConversationState() 
	{

		do {
			
		} while(bConversationActive == true);


		do {
			PopulateScript();

		} while(bConversationStart == true);


		do {

			PurgeMemory();

		} while(bConversationEnd == true);

	}
			
	// Update is called once per frame
	void Update ()
	{

		StartCoroutine (BrendanDialogueController ());
		//StartCoroutine (ElliDialogueController ());
		//StartCoroutine (LukeDialogueController ());

		ScriptIterator = AudioIterator;
		//Commit

        DialogueStateController();


	}
}


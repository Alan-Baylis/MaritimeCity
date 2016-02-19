using UnityEngine;
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
	
	DialogueState NewDialogueState;
	bool bHasGameStarted = false;
	bool bHasCharacterKnockedDoor = false;

   
    

    //Remember to attach AudioSources to their respective characters

    void Awake()
	{
		


		PopulateScript ();
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
        

    
        //Add if statements to add invoke events when it is time for them
        //template
        if (AudioIterator == 1)
        {
            
        }

     }


    public void DialogueTextModifier()
    {

    //Modify text elements here

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


    //Provides some sort of Sequencing and Type Safety
    public void PopulateScript()
    {
        Debug.Log("Not Active Yet");

        FileName = BrendanAudioDialogue[0].ToString();

        if (FileName.Contains("B1_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Hi name is Brendan from Maritime Children's Services Safeguarding Team");
            Debug.Log("B1_S1 Active");
        }

        //Brendan First Paragraph

        FileName = BrendanAudioDialogue[1].ToString();

        if (FileName.Contains("B1_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Are you Ms Grove...Elli?");
        }

        FileName = BrendanAudioDialogue[2].ToString();

        if (FileName.Contains("B1_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "We have had an referral from an anonymous source rasing concerns about the children living here");
        }

        FileName = BrendanAudioDialogue[3].ToString();

        if (FileName.Contains("B1_S4"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Can I come in and talk to you about this");
        }

        //Brendan Second Paragraph

        FileName = BrendanAudioDialogue[4].ToString();

        if (FileName.Contains("B2_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Erm sorry, no I can't");
        }

        FileName = BrendanAudioDialogue[5].ToString();

        if (FileName.Contains("B2_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "The refererrer has told us there have been disturbances by adults at this address and that the childrten have been heard crying, distressed and upset");
        }

        FileName = BrendanAudioDialogue[6].ToString();

        if (FileName.Contains("B2_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I need to talk to you about this and see the children, can I come in please?");
        }

        FileName = BrendanAudioDialogue[7].ToString();

        if (FileName.Contains("B3_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Erm, I like dogs");
        }

        FileName = BrendanAudioDialogue[8].ToString();

        if (FileName.Contains("B3_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Got one of my own in fact, but Mable here doesn't look very friendly");
        }

        FileName = BrendanAudioDialogue[9].ToString();

        if (FileName.Contains("B3_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Can I ask you to move her please or does she bite?");
        }

        FileName = BrendanAudioDialogue[10].ToString();

        if (FileName.Contains("B4_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Could I ask if you could take her upstairs or tie her outside if that's OK, I think she is a bit overexcited and I wouldn't like her to harm anyone.");
        }

        FileName = BrendanAudioDialogue[11].ToString();

        if (FileName.Contains("B4_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Who does she belong to?");
        }

        FileName = BrendanAudioDialogue[12].ToString();

        if (FileName.Contains("B5_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Oh, shit");
        }

        FileName = BrendanAudioDialogue[13].ToString();

        if (FileName.Contains("B6_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Hi, my name is Brendan, I’m from the Safeguarding Team at Maritime Social Services.");
        }

        FileName = BrendanAudioDialogue[14].ToString();

        if (FileName.Contains("B6_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I’m here under Section 47 of the Children’s Act to investigate an anonymous referral that the two children living here have been heard crying and thought to be extremely distressed.");
        }

        FileName = BrendanAudioDialogue[15].ToString();

        if (FileName.Contains("B6_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I've already met Elli and the very excitable Mable, can I ask who you are?");
        }

        FileName = BrendanAudioDialogue[16].ToString();

        if (FileName.Contains("B6_S4"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Can I ask who you are");
        }

        FileName = BrendanAudioDialogue[17].ToString();

        if (FileName.Contains("B7_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I didn't know Brad lived around here!");
        }

        FileName = BrendanAudioDialogue[18].ToString();

        if (FileName.Contains("B7_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Are you related to either of the children");
        }

        FileName = BrendanAudioDialogue[19].ToString();

        if (FileName.Contains("B8_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Is that right?");
        }


        FileName = BrendanAudioDialogue[20].ToString();

        if (FileName.Contains("B9_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Of course not, I just need to be clear who you are");
        }

        FileName = BrendanAudioDialogue[21].ToString();

        if (FileName.Contains("B10_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I can't do that, as I've said we have had a referral that there have been late night parties, shouting, the sound of children crying and clearly distressed ");
        }

        FileName = BrendanAudioDialogue[22].ToString();

        if (FileName.Contains("B10_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I need to be clear that the children are safe");
        }

        FileName = BrendanAudioDialogue[23].ToString();

        if (FileName.Contains("B10_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Now, I understand you have two children, Liam, aged 5 months, and Tara aged 4. Are you the mother, Elli");
        }

        //Begin UnityEvent - Discussion and Interaction Section 

        FileName = BrendanAudioDialogue[24].ToString();

        if (FileName.Contains("B11_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I can see Liam, but where's Tara?");
        }

        FileName = BrendanAudioDialogue[25].ToString();

        if (FileName.Contains("B12_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Really, why is that?");
        }

        FileName = BrendanAudioDialogue[26].ToString();

        if (FileName.Contains("B13_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Liam is very wet");
        }

        FileName = BrendanAudioDialogue[27].ToString();

        if (FileName.Contains("B14_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Is that his bottle on the floor");
        }

        FileName = BrendanAudioDialogue[28].ToString();

        if (FileName.Contains("B15_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I'll get it");
        }

        FileName = BrendanAudioDialogue[29].ToString();

        if (FileName.Contains("B16_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I think the teat might glass or something on it");
        }

        FileName = BrendanAudioDialogue[30].ToString();

        if (FileName.Contains("B16_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Maybe from the broken beer bottle on the floor?");
        }

        FileName = BrendanAudioDialogue[31].ToString();

        if (FileName.Contains("B17_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "You need to consider that it is not safe having broken glass around with small children");
        }

        FileName = BrendanAudioDialogue[32].ToString();

        if (FileName.Contains("B18_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "And look at this, he's red raw");
        }

        FileName = BrendanAudioDialogue[33].ToString();

        if (FileName.Contains("B18_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Have you seen your GP or health visitor about this nappy rash?");
        }

        FileName = BrendanAudioDialogue[34].ToString();

        if (FileName.Contains("B18_S3"))
        {

            ScriptIDDefinition(ScriptID.Brendan, "You really must change him, perhaps err, Brad could do it whilst you sort out his bottle Eli?");
        }

        FileName = BrendanAudioDialogue[35].ToString();

        if (FileName.Contains("B19_S1)"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I thought you said you were his father");
        }


        FileName = BrendanAudioDialogue[36].ToString();

        if (FileName.Contains("B20_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "You're not Liam's father then?");
        }

        FileName = BrendanAudioDialogue[37].ToString();

        if (FileName.Contains("B21_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "And you have some cream now?");
        }

        FileName = BrendanAudioDialogue[38].ToString();

        if (FileName.Contains("B22_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Right... and what about Tara, where did you say she was?");
        }

        FileName = BrendanAudioDialogue[39].ToString();

        if (FileName.Contains("B23_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "And where's that?");
        }

        FileName = BrendanAudioDialogue[40].ToString();

        if (FileName.Contains("B24_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Perhaps I could go and see Tara at her grandma's");
        }

        FileName = BrendanAudioDialogue[41].ToString();

        if (FileName.Contains("B25_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "So, I can go over and see Tara at her grandma's");

        }

        FileName = BrendanAudioDialogue[42].ToString();

        if (FileName.Contains("B26_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "OK, I'll go but I do need to see Tara and I am not very happy about Liam");
        }

        FileName = BrendanAudioDialogue[43].ToString();

        if (FileName.Contains("B26_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I really think he should be looked at by a doctor Elli, today, can you manage that?");

        }

        FileName = BrendanAudioDialogue[44].ToString();

        if (FileName.Contains("B27_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Luke there is no need to be abusive");
        }

        FileName = BrendanAudioDialogue[45].ToString();

        if (FileName.Contains("B27_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I have a duty to ensure that the children are safe");
        }

        FileName = BrendanAudioDialogue[46].ToString();

        if (FileName.Contains("B27_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "If I go now I'll only need to come back again later today with my senior, possibly a police officer");
        }

        FileName = BrendanAudioDialogue[47].ToString();

        if (FileName.Contains("B28_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Here is my card, I am going back to my office now and will come back in an hor with a colleague to see Tara, do you understand Elli?");
        }

        FileName = BrendanAudioDialogue[48].ToString();

        if (FileName.Contains("B29_S1"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Hi Steve, it's Me");
        }

        FileName = BrendanAudioDialogue[49].ToString();

        if (FileName.Contains("B29_S2"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Err, things not too good here - no, I'm not alright. I didn't get to see Tara and Liam was in a state");
        }

        FileName = BrendanAudioDialogue[50].ToString();

        if (FileName.Contains("B29_S3"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "Yeah, I'm a bit shaken to be honest, this guy Luke seems to have moved in with a seriously scary dog, I wasn't expecting that, he was real piece of work");
        }

        FileName = BrendanAudioDialogue[51].ToString();

        if (FileName.Contains("B29_S4"))
        {
            ScriptIDDefinition(ScriptID.Brendan, "I am going to call the Police we really need to get back in there");
        }


        FileName = ElliAudioDialogue[0].ToString();

        if (FileName.Contains("E1_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, I'm Elli Grove");
        }

        FileName = ElliAudioDialogue[1].ToString();

        if (FileName.Contains("E1_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Um, err, um, err, well you can hear that Liam is crying");

        }

        FileName = ElliAudioDialogue[2].ToString();

        if (FileName.Contains("E1_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He cries, all the time with his Belly Ache. And his teething");

        }

        FileName = ElliAudioDialogue[3].ToString();

        if (FileName.Contains("E1_S4"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Erm... it's not really convenient at the moment, could you come back tomorrow");

        }

        FileName = ElliAudioDialogue[4].ToString();

        if (FileName.Contains("E1_S5"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Could you come back tommorow");
        }

        FileName = ElliAudioDialogue[5].ToString();

        if (FileName.Contains("E2_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Well, OK, only for a little while");
        }

        FileName = ElliAudioDialogue[6].ToString();

        if (FileName.Contains("E2_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "You'll have to get past Mable though, she don't like strangers");
        }

        FileName = ElliAudioDialogue[7].ToString();

        if (FileName.Contains("E3_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I told you, she don't like strangers");
        }

        FileName = ElliAudioDialogue[8].ToString();

        if (FileName.Contains("E3_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Anyway she ain't my dog");
        }

        FileName = ElliAudioDialogue[9].ToString();

        if (FileName.Contains("E3_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "'ere, I'll hold her while you get by");
        }

        FileName = ElliAudioDialogue[10].ToString();

        if (FileName.Contains("E4_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh, err, just a friend");
        }

        FileName = ElliAudioDialogue[11].ToString();

        if (FileName.Contains("E5_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Well, you better go into the front room now your in");

        }

        FileName = ElliAudioDialogue[12].ToString();

        if (FileName.Contains("E6_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh...yeah, he's...Liam's dad");
        }


        FileName = ElliAudioDialogue[13].ToString();

        if (FileName.Contains("E7_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah");
        }

        FileName = ElliAudioDialogue[14].ToString();

        if (FileName.Contains("E8_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, that's right");
        }

        FileName = ElliAudioDialogue[15].ToString();

        if (FileName.Contains("E9_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh, err, well, she usually goes to nursery, erm... but she's staying with...err.. Luke's mum at the moment");
        }

        FileName = ElliAudioDialogue[16].ToString();

        if (FileName.Contains("E10_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Cos of Liam's crying");
        }

        FileName = ElliAudioDialogue[17].ToString();

        if (FileName.Contains("E10_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He goes on and on, all night, I'm knackered.");
        }

        FileName = ElliAudioDialogue[18].ToString();

        if (FileName.Contains("E10_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I can't cope with him and her, it's too much");
        }

        FileName = ElliAudioDialogue[19].ToString();

        if (FileName.Contains("E11_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Is he, I only just changed him, little monkey");
        }

        FileName = ElliAudioDialogue[20].ToString();

        if (FileName.Contains("E11_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "It's all that milk");

        }

        FileName = ElliAudioDialogue[21].ToString();

        if (FileName.Contains("E12_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Most have dropped it");
        }

        FileName = ElliAudioDialogue[22].ToString();

        if (FileName.Contains("E12_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "See how tired I am");
        }

        FileName = ElliAudioDialogue[23].ToString();

        if (FileName.Contains("E13_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Thanks");
        }

        FileName = ElliAudioDialogue[24].ToString();

        if (FileName.Contains("E14_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh don't worry, I will clear it up");
        }

        FileName = ElliAudioDialogue[25].ToString();

        if (FileName.Contains("E14_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I was about to pick it up when you rang the bell");
        }

        FileName = ElliAudioDialogue[26].ToString();

        if (FileName.Contains("E15_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I'll do his nappy in a minute");
        }

        FileName = ElliAudioDialogue[27].ToString();

        if (FileName.Contains("E15_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I did ask the health visitor about the rash, said I was worried, but I ran out of cream, didn't I?");
        }

        FileName = ElliAudioDialogue[28].ToString();

        if (FileName.Contains("E15_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Nothing to worry about really");
        }

        FileName = ElliAudioDialogue[29].ToString();

        if (FileName.Contains("E16_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I was just gonna get some");
        }

        FileName = ElliAudioDialogue[30].ToString();

        if (FileName.Contains("E17_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I told you, she's with Luke's mum");
        }

        FileName = ElliAudioDialogue[31].ToString();

        if (FileName.Contains("E18_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Over near Seagulls Hospital, Luke took her yesterday");
        }

        FileName = ElliAudioDialogue[32].ToString();

        if (FileName.Contains("E19_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Luke, please");
        }

        FileName = ElliAudioDialogue[33].ToString();

        if (FileName.Contains("E19_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He don't mean it, he's had a bad head all day; and you've just rubbed him up the wrong way");
        }

        FileName = ElliAudioDialogue[34].ToString();

        if (FileName.Contains("E19_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Best if you go now, I'll ring you later and take the baby to the clinic tomorrow, just like you said.");
        }

        FileName = ElliAudioDialogue[35].ToString();

        if (FileName.Contains("E20_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I'll show you out");
        }

        FileName = ElliAudioDialogue[36].ToString();

        if (FileName.Contains("E21_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, OK");
        }

        FileName = LukeAudioDialogue[0].ToString();

        if (FileName.Contains("L1_S1_T1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "What's it to you?");
        }

        FileName = LukeAudioDialogue[1].ToString();

        if (FileName.Contains("L2_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Are you calling her a Liar");
        }

        FileName = LukeAudioDialogue[2].ToString();

        if (FileName.Contains("L3_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "I told ya, Brad-fucking-pitt, now piss off");
        }

        FileName = LukeAudioDialogue[3].ToString();

        if (FileName.Contains("L4_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "He's always bleedin' hungry");
        }

        FileName = LukeAudioDialogue[4].ToString();

        if (FileName.Contains("L5_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Let him clear it up if he's so bloody worried");
        }

        FileName = LukeAudioDialogue[5].ToString();

        if (FileName.Contains("L6_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Fuck off, he's nothing to do with me");
        }

        FileName = LukeAudioDialogue[6].ToString();

        if (FileName.Contains("L7_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "No I fucking didn't");
        }

        FileName = LukeAudioDialogue[7].ToString();

        if (FileName.Contains("L8_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Just piss off and leave us alone");
        }

        FileName = LukeAudioDialogue[8].ToString();

        if (FileName.Contains("L9_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Yeah, I took her and left her with her fucking granny, just like Elli said");
        }

        FileName = LukeAudioDialogue[9].ToString();

        if (FileName.Contains("L9_S2"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Kid said she wanted to see granny so I tooker her to her granny's, satisfied Mr Supernanny");
        }

        FileName = LukeAudioDialogue[10].ToString();

        if (FileName.Contains("L9_S3"))
        {
            ScriptIDDefinition(ScriptID.Luke, "I just do what Elli and little princess asks see, got me wrapped around her little finger she has");
        }

        FileName = LukeAudioDialogue[11].ToString();

        if (FileName.Contains("L9_S4"))
        {
            ScriptIDDefinition(ScriptID.Luke, "See what a great stepdad I am");
        }

        FileName = LukeAudioDialogue[12].ToString();

        if (FileName.Contains("L9_S5"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Do anything she wants");
        }

        FileName = LukeAudioDialogue[13].ToString();

        if (FileName.Contains("L10_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Never satisifed are you, bloody social workers. Should put 'em all in a sack and drown them at Birth");
        }

        FileName = LukeAudioDialogue[14].ToString();

        if (FileName.Contains("L11_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "You leave my mum out of this you fucking nosy bastard now fuck off out of here before I throw you out");
        }

        FileName = LukeAudioDialogue[15].ToString();

        if (FileName.Contains("L12_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Oh fuck off you old woman");
        }

        FileName = LukeAudioDialogue[16].ToString();

        if (FileName.Contains("L13_S1"))
        {
            ScriptIDDefinition(ScriptID.Luke, "Gonna get ya mates are ya? Fucking wimp, you ain't worh it, it would be too easy");
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

		//StartCoroutine (BrendanDialogueController ());
		//StartCoroutine (ElliDialogueController ());
		//StartCoroutine (LukeDialogueController ());

		ScriptIterator = AudioIterator;
        DialogueStateController();


	}
}


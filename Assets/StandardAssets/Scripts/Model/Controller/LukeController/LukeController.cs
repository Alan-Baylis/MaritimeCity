using UnityEngine;
using CoreSystems.DialogueSystem;
using System.Collections;

public class LukeController : CoreDialogueSystems, IDialogueSystems {

    string FileName;


    // Use this for initialization
    void Start ()
    {

        LukeSource = DialogueObject.GetComponent<AudioSource>();


    }

    public void PlayAudio(string DialogueID)
    {

    }

    public void DisplayScript(string ScriptID)
    {

    }

    public void PopulateScript()
    {


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


    IEnumerator LukeDialogueController()
    {
        //yield return new WaitUntil (() => NewDialogueState == DialogueState.Luke);

        yield return null;
    }


    // Update is called once per frame
    void Update ()
    {
	
	}
}

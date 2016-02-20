using UnityEngine;
using CoreSystems.DialogueSystem;
using System.Collections;

public class ElliController : CoreDialogueSystems, IDialogueSystems {

    string FileName;

    // Use this for initialization
    void Start ()
    {

        ElliSource = DialogueObject.GetComponent<AudioSource>();

    }

    public void PlayAudio (string AudioID)
    {

    }

    public void DisplayScript (string ScriptID)
    {

    }

   public void PopulateScript()
   {

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


    }



    IEnumerator ElliDialogueController()
    {
           //StopCoroutine(BrendanDialogueController());
            PrimarySource.Stop();
            MaritimeDialogueIterator = 0;
            ElliSource.clip = ElliAudioDialogue[MaritimeDialogueIterator];
            MaritimeDialogueIterator++;
        

        yield return null;
    }

    // Update is called once per frame
    void Update () {
	
	}
}

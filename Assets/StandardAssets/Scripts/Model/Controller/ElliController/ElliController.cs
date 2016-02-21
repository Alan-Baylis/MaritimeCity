using UnityEngine;
using System.Collections;

public class ElliController : CoreDialogueSystems, IDialogueSystems {

    string FileName;


    public GameObject ElliGameObject;

    // Use this for initialization
    void Start ()
    {


        PopulateScript();
    

    }

    public void PlayAudio (string AudioID)
    {

    }

    public void DisplayScript (string ScriptID)
    {
        
    }

   public void PopulateScript()
   {

        FileName = ElliAudio[0].ToString();

        if (FileName.Contains("E1_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, I'm Elli Grove");
        }

        FileName = ElliAudio[1].ToString();

        if (FileName.Contains("E1_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Um, err, um, err, well you can hear that Liam is crying");

        }

        FileName = ElliAudio[2].ToString();

        if (FileName.Contains("E1_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He cries, all the time with his Belly Ache. And his teething");

        }

        FileName = ElliAudio[3].ToString();

        if (FileName.Contains("E1_S4"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Erm... it's not really convenient at the moment, could you come back tomorrow");

        }

        FileName = ElliAudio[4].ToString();

        if (FileName.Contains("E1_S5"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Could you come back tomorrow");
        }

        FileName = ElliAudio[5].ToString();

        if (FileName.Contains("E2_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Well, OK, only for a little while");
        }

        FileName = ElliAudio[6].ToString();

        if (FileName.Contains("E2_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "You'll have to get past Mable though, she don't like strangers");
        }

        FileName = ElliAudio[7].ToString();

        if (FileName.Contains("E3_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I told you, she don't like strangers");
        }

        FileName = ElliAudio[8].ToString();

        if (FileName.Contains("E3_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Anyway she ain't my dog");
        }

        FileName = ElliAudio[9].ToString();

        if (FileName.Contains("E3_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "'ere, I'll hold her while you get by");
        }

        FileName = ElliAudio[10].ToString();

        if (FileName.Contains("E4_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh, err, just a friend");
        }

        FileName = ElliAudio[11].ToString();

        if (FileName.Contains("E5_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Well, you better go into the front room now your in");

        }

        FileName = ElliAudio[12].ToString();

        if (FileName.Contains("E6_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh...yeah, he's...Liam's dad");
        }


        FileName = ElliAudio[13].ToString();

        if (FileName.Contains("E7_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah");
        }

        FileName = ElliAudio[14].ToString();

        if (FileName.Contains("E8_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, that's right");
        }

        FileName = ElliAudio[15].ToString();

        if (FileName.Contains("E9_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh, err, well, she usually goes to nursery, erm... but she's staying with...err.. Luke's mum at the moment");
        }

        FileName = ElliAudio[16].ToString();

        if (FileName.Contains("E10_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Cos of Liam's crying");
        }

        FileName = ElliAudio[17].ToString();

        if (FileName.Contains("E10_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He goes on and on, all night, I'm knackered.");
        }

        FileName = ElliAudio[18].ToString();

        if (FileName.Contains("E10_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I can't cope with him and her, it's too much");
        }

        FileName = ElliAudio[19].ToString();

        if (FileName.Contains("E11_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Is he, I only just changed him, little monkey");
        }

        FileName = ElliAudio[20].ToString();

        if (FileName.Contains("E11_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "It's all that milk");

        }

        FileName = ElliAudio[21].ToString();

        if (FileName.Contains("E12_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Most have dropped it");
        }

        FileName = ElliAudio[22].ToString();

        if (FileName.Contains("E12_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "See how tired I am");
        }

        FileName = ElliAudio[23].ToString();

        if (FileName.Contains("E13_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Thanks");
        }

        FileName = ElliAudio[24].ToString();

        if (FileName.Contains("E14_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Oh don't worry, I will clear it up");
        }

        FileName = ElliAudio[25].ToString();

        if (FileName.Contains("E14_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I was about to pick it up when you rang the bell");
        }

        FileName = ElliAudio[26].ToString();

        if (FileName.Contains("E15_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I'll do his nappy in a minute");
        }

        FileName = ElliAudio[27].ToString();

        if (FileName.Contains("E15_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I did ask the health visitor about the rash, said I was worried, but I ran out of cream, didn't I?");
        }

        FileName = ElliAudio[28].ToString();

        if (FileName.Contains("E15_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Nothing to worry about really");
        }

        FileName = ElliAudio[29].ToString();

        if (FileName.Contains("E16_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I was just gonna get some");
        }

        FileName = ElliAudio[30].ToString();

        if (FileName.Contains("E17_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I told you, she's with Luke's mum");
        }

        FileName = ElliAudio[31].ToString();

        if (FileName.Contains("E18_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Over near Seagulls Hospital, Luke took her yesterday");
        }

        FileName = ElliAudio[32].ToString();

        if (FileName.Contains("E19_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Luke, please");
        }

        FileName = ElliAudio[33].ToString();

        if (FileName.Contains("E19_S2"))
        {
            ScriptIDDefinition(ScriptID.Elli, "He don't mean it, he's had a bad head all day; and you've just rubbed him up the wrong way");
        }

        FileName = ElliAudio[34].ToString();

        if (FileName.Contains("E19_S3"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Best if you go now, I'll ring you later and take the baby to the clinic tomorrow, just like you said.");
        }

        FileName = ElliAudio[35].ToString();

        if (FileName.Contains("E20_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "I'll show you out");
        }

        FileName = ElliAudio[36].ToString();

        if (FileName.Contains("E21_S1"))
        {
            ScriptIDDefinition(ScriptID.Elli, "Yeah, OK");
        }


    }


    // Update is called once per frame
    void Update () {
	
	}
}

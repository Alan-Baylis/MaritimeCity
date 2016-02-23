using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace DialogueSystems
{

    public class BrendanPOVController : CoreDialogueSystems, IDialogueSystems
    {

        public Camera BrendanPOV = new Camera();

        public struct Destinations
        {


        }

        public void PlayAudio(string AudioID)
        {
            if (AudioID == "B1_S1")
            {
                BrendanSource.clip = BrendanAudio[0];
                BrendanSource.PlayDelayed(1);
            }

        }

        public void DisplayScript(string ScriptID)
        {
            if (ScriptID == "B1_S1")
            {
                DialogueText.text = BrendanScript[0];
            }

        }

        static int ScriptLogger = 0;
        private CapsuleCollider BrendanCollider;
        private CoreDialogueSystems Core;
        public List<string> BrendanScript = new List<string>(50);
        public AudioClip[] BrendanAudio = new AudioClip[30];
        public AudioSource BrendanSource;
        public Destinations Destination;

        string FileName;
        Vector3 from;
        Vector3 there;
        float speed;

        // Use this for initialization
        void Start()
        {

            BrendanCollider = gameObject.GetComponent<CapsuleCollider>();
            BrendanSource = GetComponent<AudioSource>();
            DialogueText = GetComponent<Text>();

            from = BrendanPOV.transform.position;
            speed = 50;
          
        }

        void InitializeCoreDialogueIDSequencer()
        {

            Core = GameObject.FindGameObjectWithTag("Core").GetComponent<CoreDialogueSystems>();
            DialogueIDSequencer = Core.DialogueIDSequencer;


        }

        void DefineColliderParameters()
        {

            BrendanCollider.isTrigger = true;

        }

        void DefineCameraParameters()
        {

            BrendanPOV.GetComponent<Camera>();
            BrendanPOV.ViewportToScreenPoint(position: from);
            BrendanPOV.ScreenPointToRay(position: from);

        }


        public IEnumerator ScriptIDDefinition(ScriptID ScriptIdentification, string DefineScript)
        {

            int BrendanInternalIterator = 0;

            //Use logger to check conditions, use iterators for dynamic functions
            
            ScriptLogger++;

            print("Result for Script Logger is " + ScriptLogger);

            if (ScriptIdentification == ScriptID.Brendan)
            {
                BrendanScript.Add(DefineScript);
                DialogueText.text = BrendanScript[BrendanInternalIterator];
                BrendanInternalIterator++;

                yield return null;

            }

        }

        public bool BrendanFinishedTalking()
        {
            if (BrendanSource.isPlaying == false)
            {
                return true;

            } else
            {
                return false;
            }

        }

        void InputController()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Iterate through text
            }

        }

        public void PopulateScript()
        {
            FileName = BrendanAudio[0].ToString();

            if (FileName.Contains("B1_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Hi name is Brendan from Maritime Children's Services Safeguarding Team"));
                Debug.Log("B1_S1 Active");
            }

            //Brendan First Paragraph

            FileName = BrendanAudio[1].ToString();

            if (FileName.Contains("B1_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Are you Ms Grove...Elli?"));
                Debug.Log("B1_S2 Active");
            }

            FileName = BrendanAudio[2].ToString();

            if (FileName.Contains("B1_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "We have had an referral from an anonymous source raising concerns about the children living here"));
                Debug.Log("B1_S3 Active");

            }

            FileName = BrendanAudio[3].ToString();

            if (FileName.Contains("B1_S4"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Can I come in and talk to you about this"));
                Debug.Log("B1_S4 Active");
            }

            //Brendan Second Paragraph

            FileName = BrendanAudio[4].ToString();

            if (FileName.Contains("B2_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Erm sorry, no I can't"));
                Debug.Log("B2_S1 Active");
            }

            FileName = BrendanAudio[5].ToString();

            if (FileName.Contains("B2_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "The refererrer has told us there have been disturbances by adults at this address and that the childrten have been heard crying, distressed and upset"));
                Debug.Log("B2_S2 Active");
            }

            FileName = BrendanAudio[6].ToString();

            if (FileName.Contains("B2_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I need to talk to you about this and see the children, can I come in please?"));
                Debug.Log("B2_S3 Active");
            }

            FileName = BrendanAudio[7].ToString();

            if (FileName.Contains("B3_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Erm, I like dogs"));
                Debug.Log("B3_S1 Active");
            }

            FileName = BrendanAudio[8].ToString();

            if (FileName.Contains("B3_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Got one of my own in fact, but Mable here doesn't look very friendly"));
                Debug.Log("B3_S2 Active");
            }

            FileName = BrendanAudio[9].ToString();

            if (FileName.Contains("B3_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Can I ask you to move her please or does she bite?"));
                Debug.Log("B3_S3 Active");
            }

            FileName = BrendanAudio[10].ToString();

            if (FileName.Contains("B4_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Could I ask if you could take her upstairs or tie her outside if that's OK, I think she is a bit overexcited and I wouldn't like her to harm anyone."));
                Debug.Log("B4_S1 Active");
            }

            FileName = BrendanAudio[11].ToString();

            if (FileName.Contains("B4_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Who does she belong to?"));
                Debug.Log("B4_S2 Active");
            }

            FileName = BrendanAudio[12].ToString();

            if (FileName.Contains("B5_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Oh, shit"));
                Debug.Log("B5_S1 Active");
            }

            FileName = BrendanAudio[13].ToString();

            if (FileName.Contains("B6_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Hi, my name is Brendan, I’m from the Safeguarding Team at Maritime Social Services."));
                Debug.Log("B6_S1 Active");
            }

            FileName = BrendanAudio[14].ToString();

            if (FileName.Contains("B6_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I’m here under Section 47 of the Children’s Act to investigate an anonymous referral that the two children living here have been heard crying and thought to be extremely distressed."));
                Debug.Log("B6_S2 Active");
            }            

            FileName = BrendanAudio[15].ToString();

            if (FileName.Contains("B6_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I've already met Elli and the very excitable Mable, can I ask who you are?"));
                Debug.Log("B6_S3 Active");
            }

            FileName = BrendanAudio[16].ToString();

            if (FileName.Contains("B6_S4"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Can I ask who you are"));
                Debug.Log("B6_S4 Active");
            }

            FileName = BrendanAudio[17].ToString();

            if (FileName.Contains("B7_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I didn't know Brad lived around here!"));
                Debug.Log("B7_S1 Active");
            }

            FileName = BrendanAudio[18].ToString();

            if (FileName.Contains("B7_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Are you related to either of the children"));
                Debug.Log("B7_S2 Active ");
            }

            FileName = BrendanAudio[19].ToString();

            if (FileName.Contains("B8_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Is that right?"));
                Debug.Log("B8_S1 Active");
            }


            FileName = BrendanAudio[20].ToString();

            if (FileName.Contains("B9_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Of course not, I just need to be clear who you are"));
                Debug.Log("B9_S1 Active");

            }

            FileName = BrendanAudio[21].ToString();

            if (FileName.Contains("B10_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I can't do that, as I've said we have had a referral that there have been late night parties, shouting, the sound of children crying and clearly distressed "));
                Debug.Log("B10_S1 Active");
            }

            FileName = BrendanAudio[22].ToString();

            if (FileName.Contains("B10_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I need to be clear that the children are safe"));
                Debug.Log("B10_S2 Active");
            }

            FileName = BrendanAudio[23].ToString();

            if (FileName.Contains("B10_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Now, I understand you have two children, Liam, aged 5 months, and Tara aged 4. Are you the mother, Elli"));
                Debug.Log("B10_S3 Active");
            }

            //Begin UnityEvent - Discussion and Interaction Section 

            FileName = BrendanAudio[24].ToString();

            if (FileName.Contains("B11_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I can see Liam, but where's Tara?"));
                Debug.Log("B11_S1 Active");
            }

            FileName = BrendanAudio[25].ToString();

            if (FileName.Contains("B12_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Really, why is that?"));
                Debug.Log("B12_S1 Active");

            }

            FileName = BrendanAudio[26].ToString();

            if (FileName.Contains("B13_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Liam is very wet"));
                Debug.Log("B13_S1 Active");

            }

            FileName = BrendanAudio[27].ToString();

            if (FileName.Contains("B14_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Is that his bottle on the floor"));
                Debug.Log("B14_S1 Active");
            }

            FileName = BrendanAudio[28].ToString();

            if (FileName.Contains("B15_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I'll get it"));
                Debug.Log("B15_S1 Active");
            }

            FileName = BrendanAudio[29].ToString();

            if (FileName.Contains("B16_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I think the teat might glass or something on it"));
                Debug.Log("B16_S1 Active");
            }

            FileName = BrendanAudio[30].ToString();

            if (FileName.Contains("B16_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Maybe from the broken beer bottle on the floor?"));
                Debug.Log("B16_S2 Active");
            }

            FileName = BrendanAudio[31].ToString();

            if (FileName.Contains("B17_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "You need to consider that it is not safe having broken glass around with small children"));
                Debug.Log("B17_S1 Active");
            }

            FileName = BrendanAudio[32].ToString();

            if (FileName.Contains("B18_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "And look at this, he's red raw"));
                Debug.Log("B18_S1 Active");
            }

            FileName = BrendanAudio[33].ToString();

            if (FileName.Contains("B18_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Have you seen your GP or health visitor about this nappy rash?"));
                Debug.Log("B18_S2 Active");
            }

            FileName = BrendanAudio[34].ToString();

            if (FileName.Contains("B18_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "You really must change him, perhaps err, Brad could do it whilst you sort out his bottle Eli?"));
                Debug.Log("B18_S3 Active");
            }

            FileName = BrendanAudio[35].ToString();

            if (FileName.Contains("B19_S1)"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I thought you said you were his father"));
                Debug.Log("B19_S1 Active");
            }


            FileName = BrendanAudio[36].ToString();

            if (FileName.Contains("B20_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "You're not Liam's father then?"));
                Debug.Log("B20_S1 Active");

            }

            FileName = BrendanAudio[37].ToString();

            if (FileName.Contains("B21_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "And you have some cream now?"));
                Debug.Log("B21_S1 Active");
            }

            FileName = BrendanAudio[38].ToString();

            if (FileName.Contains("B22_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Right... and what about Tara, where did you say she was?"));
                Debug.Log("B22_S1 Active");
            }

            FileName = BrendanAudio[39].ToString();

            if (FileName.Contains("B23_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "And where's that?"));
                Debug.Log("B23_S1 Active");
            }

            FileName = BrendanAudio[40].ToString();

            if (FileName.Contains("B24_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Perhaps I could go and see Tara at her grandma's"));
                Debug.Log("B24_S1 Active");
            }

            FileName = BrendanAudio[41].ToString();

            if (FileName.Contains("B25_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "So, I can go over and see Tara at her grandma's"));
                Debug.Log("B25_S1 Active");

            }

            FileName = BrendanAudio[42].ToString();

            if (FileName.Contains("B26_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "OK, I'll go but I do need to see Tara and I am not very happy about Liam"));
                Debug.Log("B26_S1 Active");
            }

            FileName = BrendanAudio[43].ToString();

            if (FileName.Contains("B26_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I really think he should be looked at by a doctor Elli, today, can you manage that?"));
                Debug.Log("B26_S2 Active");
            }

            FileName = BrendanAudio[44].ToString();

            if (FileName.Contains("B27_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Luke there is no need to be abusive"));
                Debug.Log("B27_S1 Active");
            }

            FileName = BrendanAudio[45].ToString();

            if (FileName.Contains("B27_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I have a duty to ensure that the children are safe"));
                Debug.Log("B27_S2 Active");
            }

            FileName = BrendanAudio[46].ToString();

            if (FileName.Contains("B27_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "If I go now I'll only need to come back again later today with my senior, possibly a police officer"));
                Debug.Log("B27_S3 Active");
            }

            FileName = BrendanAudio[47].ToString();

            if (FileName.Contains("B28_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Here is my card, I am going back to my office now and will come back in an hour with a colleague to see Tara, do you understand Elli?"));
                Debug.Log("B28_S1 Active");
            }

            FileName = BrendanAudio[48].ToString();

            if (FileName.Contains("B29_S1"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Hi Steve, it's Me"));
                Debug.Log("B29_S1 Active");

            }

            FileName = BrendanAudio[49].ToString();

            if (FileName.Contains("B29_S2"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Err, things not too good here - no, I'm not alright. I didn't get to see Tara and Liam was in a state"));
                Debug.Log("B29_S2 Active");
            }

            FileName = BrendanAudio[50].ToString();

            if (FileName.Contains("B29_S3"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "Yeah, I'm a bit shaken to be honest, this guy Luke seems to have moved in with a seriously scary dog, I wasn't expecting that, he was real piece of work"));
                Debug.Log("B29_S3 Active");
            }

            FileName = BrendanAudio[51].ToString();

            if (FileName.Contains("B29_S4"))
            {
                StartCoroutine(ScriptIDDefinition(ScriptID.Brendan, "I am going to call the Police we really need to get back in there"));
                Debug.Log("B29_S4 Active");
            }


        }

        void Awake()
        {

            PopulateScript();

        }

        // Update is called once per frame
        void Update()
        {

            InputController();

            if (from == there)
            {
                Debug.Log("Success");
            }

            Vector3.Lerp(a: from, b: there, t: speed);

        }
    }

}

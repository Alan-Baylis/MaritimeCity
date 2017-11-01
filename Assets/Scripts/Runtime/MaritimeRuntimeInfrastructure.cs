using UnityEngine;
using CoreSystems;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using DialogueSystems;
using UnityEngine.UI;

public class MaritimeRuntimeInfrastructure : MonoBehaviour
{
    public MaritimeRuntimeInfrastructure()
    {

    }

    int BoolSetter = 0;

    #region UnityObjects

    public Transform[] LocationsWithinHouse = new Transform[10];
    //Locations Within House
    //[0] Front Door
    //[1] Back Door
    //[2] Entrance into Living Room
    //[3] Elli Position in Living Room
    //[4] Top of Stairs
    

    public Transform[] BrendanCameraTargets = new Transform[10];
    //[0] Elli_Grove
    //[1] DogPooStandard
    //[2] Dalmatian

    public GameObject MableGameObject;
    public GameObject BrendanGameObject;
    public GameObject ElliGameObject;
    public GameObject LukeGameObject;
    public Vector3 StaticElliPosition;
    public static Text DialogueText;


    Vector3 ElliUpdatePosition;
    public static Vector3 BackDoor;

    Vector3 ElliLocation;
    Vector3 MableLocation;
    Animator ElliAnimatorRuntime;

    #endregion

    #region C# Objects

    public static NavigationObject[] NavigationObjects;
    public static MaritimeRuntimeInfrastructure MaritimeCoreObject;
    public static Core[] SystemObjects = new Core[10];
    public static string[] SystemObjectNames = new string[10];
    public static string[] DialogueIDSequencer = new string[108];
    public static int MaritimeInternalIterator = 0;

    #endregion

    #region Runtime Enums
    ///////////////////////

    public enum SceneID { Start, Pause, End };

    /// <summary>
    /// This code is just to inform the Runtime of the current state
    /// </summary>
    public enum UISelectionRuntimeID_Menu {Continue, ReturnToMenu, Exit};

    /// <summary>
    /// When the pause icon flashes it means that an discussion should be begun within this particular scenario
    /// </summary>
    public enum UISelectionRuntimeID_DiscussionBox {Pause, Continue};

    enum SceneFocus { Elli, Mable, Luke, Liam, Dogshit, Bottle };
    public static ConversationState State = ConversationState.Inactive;

    public enum SceneState
    {
        Cutscene,
        Dicussion_Box,
        Conversation,
        MainMenu
    };


    public enum ScriptState
    {
        Elli,
        Brendan,
        Luke,
        Mable,
        NULL
    };

    public enum ScriptID
    {
        Elli,
        Brendan,
        Luke
    }
    ;

    public enum ConversationState
    {
        Active,
        Inactive
    };

    public enum NavigationSequences
    {
        Sequence1,
        Sequence2,
        Sequence3,
        Sequence4,
        Sequence5,
        Sequence6,
        Sequence7,
        Sequence8,
        Sequence9,
        Sequence10
    }

    #endregion

    #region Runtime Instances

    //Custom type objects
    public static ConversationState ConversationStateID = ConversationState.Inactive;
    public static RuntimePlatform MaritimeRuntimePlatform = RuntimePlatform.WindowsPlayer;

    //Enum Instances
    public static SceneID RuntimeID;
    public static UISelectionRuntimeID_Menu SelectionRuntimeID_Menu;
    public static UISelectionRuntimeID_DiscussionBox SelectionRuntime_DiscussionBox;

    #endregion
    
    enum WalkingDestination { FrontDoor, BackDoor, FrontDoor2 };
    public Vector3 tBrendanPosition = BrendanPOVController.GetPosition();

    void Awake()
    {

        tBrendanPosition.y = 0.0f;
        tBrendanPosition.x = -62.8f;

        BackDoor = LocationsWithinHouse[2].transform.position;
        InitializeDialogueIterator();
        StaticElliPosition = ElliController.GetPosition();

        NavigationObjects = FindObjectsOfType<NavigationObject>();
        MaritimeCoreObject = FindObjectOfType<MaritimeRuntimeInfrastructure>();

        MableGameObject = MableController.MableSingletonObject.gameObject;
        BrendanGameObject = BrendanPOVController.BrendanInstance.gameObject;
        LukeGameObject = LukeController.LukeInstance.gameObject;
        ElliGameObject = ElliController.ElliInstance.gameObject;
        ElliAnimatorRuntime = ElliController.ElliAnimator;

        StartCoroutine(RuntimeMovementLogic());
        StartCoroutine(mRuntimeTracking());
    }

    void Start()
    {
        ElliUpdatePosition = ElliController.GetPosition();
        SceneFocusID = SceneFocus.Elli;
    }

    void Update()
    {
        mRuntimeSceneLogic();
        mRuntimeSceneFocus();
        InputUI();
    }

    #region Runtime Logic

    public static void InitializeDialogueIterator(string[] DialogueIDSequencer)
    {
        DialogueIDSequencer[0] = "B1_S1";
        DialogueIDSequencer[1] = ("B1_S2");
        DialogueIDSequencer[2] = ("B1_S3");
        DialogueIDSequencer[3] = ("B1_S4");
        DialogueIDSequencer[4] = ("E1_S1");
        DialogueIDSequencer[5] = ("E1_S2");
        DialogueIDSequencer[6] = ("E1_S3");
        DialogueIDSequencer[7] = ("E1_S4");
        DialogueIDSequencer[8] = ("E1_S5");
        DialogueIDSequencer[9] = ("B2_S1");
        DialogueIDSequencer[10] = ("B2_S2");
        DialogueIDSequencer[11] = ("B2_S3");
        DialogueIDSequencer[12] = ("E2_S1");
        DialogueIDSequencer[13] = ("E2_S2");
        DialogueIDSequencer[14] = ("B3_S1");
        DialogueIDSequencer[15] = ("B3_S2");
        DialogueIDSequencer[16] = ("B3_S3");
        DialogueIDSequencer[17] = ("E3_S1");
        DialogueIDSequencer[18] = ("E3_S2");
        DialogueIDSequencer[19] = ("E3_S3");
        DialogueIDSequencer[20] = ("B4_S1");
        DialogueIDSequencer[21] = ("B4_S2");
        DialogueIDSequencer[22] = ("E4_S1");
        DialogueIDSequencer[23] = ("B5_S1");
        DialogueIDSequencer[24] = ("B6_S1");
        DialogueIDSequencer[25] = ("B6_S2");
        DialogueIDSequencer[26] = ("B6_S3");
        DialogueIDSequencer[27] = ("B6_S4");
        DialogueIDSequencer[28] = ("L1_T1_S1");
        DialogueIDSequencer[29] = ("B7_S1");
        DialogueIDSequencer[30] = ("B7_S2");
        DialogueIDSequencer[31] = ("E7_S1");
        DialogueIDSequencer[32] = ("B8_S1");
        DialogueIDSequencer[33] = ("E8_S1");
        DialogueIDSequencer[34] = ("L2_S1");
        DialogueIDSequencer[35] = ("B9_S1");
        DialogueIDSequencer[36] = ("L3_S1");
        DialogueIDSequencer[37] = ("B10_S1");
        DialogueIDSequencer[38] = ("B10_S2");
        DialogueIDSequencer[39] = ("B10_S3");
        DialogueIDSequencer[40] = ("B10_S4");
        DialogueIDSequencer[41] = ("E8_S1");
        DialogueIDSequencer[42] = ("B11_S1");
        DialogueIDSequencer[43] = ("E9_S1");
        DialogueIDSequencer[44] = ("B12_S1");
        DialogueIDSequencer[45] = ("E10_S1");
        DialogueIDSequencer[46] = ("E10_S2");
        DialogueIDSequencer[47] = ("E10_S3");
        DialogueIDSequencer[48] = ("B13_S1");
        DialogueIDSequencer[49] = ("E11_S1");
        DialogueIDSequencer[50] = ("E11_S1");
        DialogueIDSequencer[52] = ("B14_S1");
        DialogueIDSequencer[53] = ("E12_S1");
        DialogueIDSequencer[54] = ("E12_S2");
        DialogueIDSequencer[55] = ("B15_S1");
        DialogueIDSequencer[56] = ("E13_S1");
        DialogueIDSequencer[57] = ("B16_S1");
        DialogueIDSequencer[58] = ("B16_S2");
        DialogueIDSequencer[59] = ("L4_S1");
        DialogueIDSequencer[60] = ("B17_S1");
        DialogueIDSequencer[61] = ("E14_S1");
        DialogueIDSequencer[62] = ("E14_S2");
        DialogueIDSequencer[63] = ("L5_S1");
        DialogueIDSequencer[64] = ("B18_S1");
        DialogueIDSequencer[65] = ("B18_S2");
        DialogueIDSequencer[66] = ("B18_S3");
        DialogueIDSequencer[67] = ("L6_S1");
        DialogueIDSequencer[68] = ("B19_S1");
        DialogueIDSequencer[69] = ("L7_S1");
        DialogueIDSequencer[70] = ("B20_S1");
        DialogueIDSequencer[71] = ("L8_S1");
        DialogueIDSequencer[72] = ("E15_S1");
        DialogueIDSequencer[73] = ("E15_S2");
        DialogueIDSequencer[74] = ("E15_S3");
        DialogueIDSequencer[75] = ("B21_S1");
        DialogueIDSequencer[76] = ("E16_S1");
        DialogueIDSequencer[77] = ("B22_S1");
        DialogueIDSequencer[78] = ("E17_S1");
        DialogueIDSequencer[79] = ("B23_S1");
        DialogueIDSequencer[80] = ("E18_S1");
        DialogueIDSequencer[81] = ("E18_S2");
        DialogueIDSequencer[82] = ("L9_S1");
        DialogueIDSequencer[83] = ("L9_S2");
        DialogueIDSequencer[84] = ("L9_S3");
        DialogueIDSequencer[85] = ("L9_S4");
        DialogueIDSequencer[86] = ("L9_S5");
        DialogueIDSequencer[87] = ("B24_S1");
        DialogueIDSequencer[88] = ("L10_S1");
        DialogueIDSequencer[89] = ("B25_S1");
        DialogueIDSequencer[90] = ("L11_S1");
        DialogueIDSequencer[91] = ("E19_S1");
        DialogueIDSequencer[92] = ("E19_S2");
        DialogueIDSequencer[93] = ("E19_S3");
        DialogueIDSequencer[94] = ("B26_S1");
        DialogueIDSequencer[95] = ("B26_S2");
        DialogueIDSequencer[96] = ("L12_S1");
        DialogueIDSequencer[97] = ("B27_S1");
        DialogueIDSequencer[98] = ("B27_S2");
        DialogueIDSequencer[99] = ("B27_S3");
        DialogueIDSequencer[100] = ("L13_S1");
        DialogueIDSequencer[101] = ("E20_S1");
        DialogueIDSequencer[102] = ("B28_S1");
        DialogueIDSequencer[103] = ("E21_S1");
        DialogueIDSequencer[104] = ("B29_S1");
        DialogueIDSequencer[105] = ("B29_S2");
        DialogueIDSequencer[106] = ("B29_S3");
        DialogueIDSequencer[107] = ("B29_S4");


    }

    public static void InitializeDialogueIterator()
    {

        DialogueIDSequencer[0] = "B1_S1";
        DialogueIDSequencer[1] = ("B1_S2");
        DialogueIDSequencer[2] = ("B1_S3");
        DialogueIDSequencer[3] = ("B1_S4");
        DialogueIDSequencer[4] = ("E1_S1");
        DialogueIDSequencer[5] = ("E1_S2");
        DialogueIDSequencer[6] = ("E1_S3");
        DialogueIDSequencer[7] = ("E1_S4");
        DialogueIDSequencer[8] = ("E1_S5");
        DialogueIDSequencer[9] = ("B2_S1");
        DialogueIDSequencer[10] = ("B2_S2");
        DialogueIDSequencer[11] = ("B2_S3");
        DialogueIDSequencer[12] = ("B2_S3");
        DialogueIDSequencer[13] = ("E2_S1");
        DialogueIDSequencer[14] = ("E2_S2");
        DialogueIDSequencer[15] = ("B3_S1");
        DialogueIDSequencer[16] = ("B3_S2");
        DialogueIDSequencer[17] = ("B3_S3");
        DialogueIDSequencer[18] = ("E3_S1");
        DialogueIDSequencer[19] = ("E3_S2");
        DialogueIDSequencer[20] = ("E3_S3");
        DialogueIDSequencer[21] = ("B4_S1");
        DialogueIDSequencer[22] = ("B4_S2");
        DialogueIDSequencer[23] = ("E4_S1");
        DialogueIDSequencer[24] = ("B5_S1");
        DialogueIDSequencer[25] = ("B6_S1");
        DialogueIDSequencer[26] = ("B6_S2");
        DialogueIDSequencer[27] = ("B6_S3");
        DialogueIDSequencer[28] = ("B6_S4");
        DialogueIDSequencer[29] = ("L1_T1_S1");
        DialogueIDSequencer[30] = ("B7_S1");
        DialogueIDSequencer[31] = ("B7_S2");
        DialogueIDSequencer[32] = ("E7_S1");
        DialogueIDSequencer[33] = ("B8_S1");
        DialogueIDSequencer[34] = ("E8_S1");
        DialogueIDSequencer[35] = ("L2_S1");
        DialogueIDSequencer[36] = ("B9_S1");
        DialogueIDSequencer[37] = ("L3_S1");
        DialogueIDSequencer[38] = ("B10_S1");
        DialogueIDSequencer[39] = ("B10_S2");
        DialogueIDSequencer[40] = ("B10_S3");
        DialogueIDSequencer[41] = ("B10_S4");
        DialogueIDSequencer[42] = ("E8_S1");
        DialogueIDSequencer[43] = ("B11_S1");
        DialogueIDSequencer[44] = ("E9_S1");
        DialogueIDSequencer[45] = ("B12_S1");
        DialogueIDSequencer[46] = ("E10_S1");
        DialogueIDSequencer[47] = ("E10_S2");
        DialogueIDSequencer[48] = ("E10_S3");
        DialogueIDSequencer[49] = ("B13_S1");
        DialogueIDSequencer[50] = ("E11_S1");
        DialogueIDSequencer[51] = ("E11_S1");
        DialogueIDSequencer[52] = ("B14_S1");
        DialogueIDSequencer[53] = ("E12_S1");
        DialogueIDSequencer[54] = ("E12_S2");
        DialogueIDSequencer[55] = ("B15_S1");
        DialogueIDSequencer[56] = ("E13_S1");
        DialogueIDSequencer[57] = ("B16_S1");
        DialogueIDSequencer[58] = ("B16_S2");
        DialogueIDSequencer[59] = ("L4_S1");
        DialogueIDSequencer[60] = ("B17_S1");
        DialogueIDSequencer[61] = ("E14_S1");
        DialogueIDSequencer[62] = ("E14_S2");
        DialogueIDSequencer[63] = ("L5_S1");
        DialogueIDSequencer[64] = ("B18_S1");
        DialogueIDSequencer[65] = ("B18_S2");
        DialogueIDSequencer[66] = ("B18_S3");
        DialogueIDSequencer[67] = ("L6_S1");
        DialogueIDSequencer[68] = ("B19_S1");
        DialogueIDSequencer[69] = ("L7_S1");
        DialogueIDSequencer[70] = ("B20_S1");
        DialogueIDSequencer[71] = ("L8_S1");
        DialogueIDSequencer[72] = ("E15_S1");
        DialogueIDSequencer[73] = ("E15_S2");
        DialogueIDSequencer[74] = ("E15_S3");
        DialogueIDSequencer[75] = ("B21_S1");
        DialogueIDSequencer[76] = ("E16_S1");
        DialogueIDSequencer[77] = ("B22_S1");
        DialogueIDSequencer[78] = ("E17_S1");
        DialogueIDSequencer[79] = ("B23_S1");
        DialogueIDSequencer[80] = ("E18_S1");
        DialogueIDSequencer[81] = ("E18_S2");
        DialogueIDSequencer[82] = ("L9_S1");
        DialogueIDSequencer[83] = ("L9_S2");
        DialogueIDSequencer[84] = ("L9_S3");
        DialogueIDSequencer[85] = ("L9_S4");
        DialogueIDSequencer[86] = ("L9_S5");
        DialogueIDSequencer[87] = ("B24_S1");
        DialogueIDSequencer[88] = ("L10_S1");
        DialogueIDSequencer[89] = ("B25_S1");
        DialogueIDSequencer[90] = ("L11_S1");
        DialogueIDSequencer[91] = ("E19_S1");
        DialogueIDSequencer[92] = ("E19_S2");
        DialogueIDSequencer[93] = ("E19_S3");
        DialogueIDSequencer[94] = ("B26_S1");
        DialogueIDSequencer[95] = ("B26_S2");
        DialogueIDSequencer[96] = ("L12_S1");
        DialogueIDSequencer[97] = ("B27_S1");
        DialogueIDSequencer[98] = ("B27_S2");
        DialogueIDSequencer[99] = ("B27_S3");
        DialogueIDSequencer[100] = ("L13_S1");
        DialogueIDSequencer[101] = ("E20_S1");
        DialogueIDSequencer[102] = ("B28_S1");
        DialogueIDSequencer[103] = ("E21_S1");
        DialogueIDSequencer[104] = ("B29_S1");
        DialogueIDSequencer[105] = ("B29_S2");
        DialogueIDSequencer[106] = ("B29_S3");
        DialogueIDSequencer[107] = ("B29_S4");
    }
    
    SceneFocus SceneFocusID;
  
    bool TestMableMovement1 = false;
    bool TestMableMovement2 = false;
    bool TestMableMovement3 = false;

    IEnumerator Coroutine;
    IEnumerator Coroutine2;
    IEnumerator Coroutine3;

    public void LaunchDialogueIterator(ICommunciation Object)
    {
        Coroutine = Object.DialogueIterator();
        StartCoroutine(Coroutine);
    }

    public void LaunchDialogueIterator(ICommunciation ObjectA, ICommunciation ObjectB)
    {

        Coroutine = ObjectA.DialogueIterator();
        Coroutine2 = ObjectB.DialogueIterator();

        StartCoroutine(Coroutine);
        StartCoroutine(Coroutine2);
    }

    public void LaunchDialogueIterator(ICommunciation ObjectA, ICommunciation ObjectB, ICommunciation ObjectC)
    {
        Coroutine = ObjectA.DialogueIterator();
        Coroutine2 = ObjectB.DialogueIterator();
        Coroutine3 = ObjectC.DialogueIterator();

        StartCoroutine(Coroutine);
        StartCoroutine(Coroutine2);
        StartCoroutine(Coroutine3);
    }

    public void StopDialogueIterator(ICommunciation Object)
    {
        Coroutine = Object.DialogueIterator();
        StopCoroutine(Coroutine);
    }
    
    public void StopDialogueIterator(ICommunciation ObjectA, ICommunciation ObjectB)
    {
        Coroutine = ObjectA.DialogueIterator();
        Coroutine2 = ObjectB.DialogueIterator();
   
        StopCoroutine(Coroutine);
        StopCoroutine(Coroutine);
    }


    //@TODO Write a runtime engine that automatically calls Coroutines and stops at designated points called by the code.
    IEnumerator RuntimeMovementLogic()
    {
        if (MaritimeInternalIterator == 1)
        {
            TestMableMovement1 = true;

            if (TestMableMovement1 == true)
            {
                //Mable moves forward to Elli Position

                MableGameObject.transform.LookAt(StaticElliPosition);
               
                yield return new WaitForSeconds(3.0f);

                TestMableMovement1 = false;
                TestMableMovement2 = true;
               
            }

            if (TestMableMovement2 == true)
            {
                //Back Door
                //Mable and Elli goes towards the back door
                //Need to seperate Mable and Elli into seperate functions


                MableGameObject.transform.LookAt(LocationsWithinHouse[1].transform.position);
                ElliGameObject.transform.LookAt(LocationsWithinHouse[1].transform.position);

                ElliGameObject.GetComponent<Animator>().Play("walking");

                yield return new WaitForSeconds(10.0f);

                TestMableMovement2 = false;
                TestMableMovement3 = true;
            }


        }

        //This code is the problem
        if (MaritimeInternalIterator == 2 && BoolSetter == 0)
        {
            ElliGameObject.GetComponent<Animator>().Play("walking");
            BoolSetter++;
        }

        yield return new WaitForSeconds(8.0f);

        StartCoroutine(RuntimeMovementLogic());

    }

    

    IEnumerator mRuntimeTracking()
    {
        if (TestMableMovement2 == true)
        {
            MableGameObject.transform.LookAt(LocationsWithinHouse[1].transform.position);
            ElliGameObject.transform.LookAt(LocationsWithinHouse[1].transform.position);
        }

        if (TestMableMovement3 == true)
        {
            ElliGameObject.transform.LookAt(BrendanCameraTargets[5].transform.position);
        }

        yield return new WaitForSeconds(3);

        StartCoroutine(mRuntimeTracking());
    }

    void LateUpdate()
    {
      

    }


    public void mRuntimeSceneLogic()
    {

        ElliLocation = ElliController.GetPosition();
        MableLocation = MableController.GetPosition();

        if (TestMableMovement1 == true)
        {
            MableGameObject.transform.position = Vector3.Lerp(MableLocation, StaticElliPosition, Time.time / 1000);
        }

        else if (TestMableMovement2 == true)
        {
            MableGameObject.transform.position = Vector3.Lerp(MableLocation, LocationsWithinHouse[1].transform.position, Time.time / 2500);
        }

        //Goes to Local Street
        if (MaritimeInternalIterator == 0)
        {
            SceneFocusID = SceneFocus.Elli;

            ElliLocation.y = 2.0f;

            BrendanGameObject.transform.position = Vector3.Lerp(BrendanPOVController.GetPosition(), BrendanCameraTargets[0].transform.position, Time.time / 360);

        }

        if (MaritimeInternalIterator == 1)
        {
            ElliAnimatorRuntime.SetTrigger("AwkwardEnter");
            
            BrendanPOVController.bStopCoroutine(true);
            ElliController.bStopCoroutine(true);

            /*
            StopDialogueIterator(ElliController.ElliInstance);
            StopDialogueIterator(BrendanPOVController.BrendanInstance);
            */
        }

        if (MaritimeInternalIterator == 8)
        {
            ElliAnimatorRuntime.SetTrigger("AwkwardLeave");
        }


        if (MaritimeInternalIterator == 23)
        {
            //StopDialogueIterator(BrendanPOVController.BrendanInstance, ElliController.ElliInstance);
            BrendanPOVController.bStopCoroutine(true);
            ElliController.bStopCoroutine(true);

        }

        //Brendan looks at Dog
        if (MaritimeInternalIterator >= 15 && MaritimeInternalIterator <= 17)
        {
            SceneFocusID = SceneFocus.Mable;
        }

        //Brendan looks back at Elli
        if (MaritimeInternalIterator >= 17 && MaritimeInternalIterator < 24)
        { 
            SceneFocusID = SceneFocus.Elli;
        }

        if (MaritimeInternalIterator == 24)
        {
            //Look at Dog Poo
            SceneFocusID = SceneFocus.Dogshit;
            BrendanPOVController.bStopCoroutine(false);
            ElliController.bStopCoroutine(false);
            LaunchDialogueIterator(BrendanPOVController.BrendanInstance, ElliController.ElliInstance);
        }
                
        if (MaritimeInternalIterator == 25)
        {
            SceneFocusID = SceneFocus.Elli;

        }
                

      }

       
    public void mRuntimeSceneFocus()
    {
       
      if (SceneFocusID == SceneFocus.Elli)
      { 
            ElliLocation.y = 2.0f;

            BrendanGameObject.transform.LookAt(ElliLocation);
          
        }

      else if (SceneFocusID == SceneFocus.Mable)
      {
            MableLocation.y = 2.0f;

            BrendanGameObject.transform.LookAt(MableLocation);
      }

      else if (SceneFocusID == SceneFocus.Dogshit)
        {
            BrendanGameObject.transform.LookAt(BrendanCameraTargets[5].transform.position);
            BrendanGameObject.transform.position = Vector3.Lerp(BrendanPOVController.GetPosition(), BrendanCameraTargets[6].position, Time.time / 1000);

        }

    }

    #endregion

    #region UI Logic
    private void InputUI()
    {
        //Main Menu Code
        if (Input.GetKeyDown(KeyCode.P))
        {
            EpisodeOneMenuUI.SetGameActive();

        }
    }
    #endregion

}

public interface ICharacterSystem
{

    GameObject GetGameObject();

    Animator GetAnimator();

    Collider GetCollider();


}

public interface ICommunciation
{

    void PlayAudio(string AudioID);

    void DisplayScript(string ScriptID);

    IEnumerator DialogueIterator();

    void Internal_StopDialogueIterator();

}

public interface IDialogueSystems
{

    void PlayAudio(string AudioID);

    void DisplayScript(string ScriptID);

    void PopulateScript();


}

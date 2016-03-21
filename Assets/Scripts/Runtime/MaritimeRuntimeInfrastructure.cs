using UnityEngine;
using CoreSystems;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using DialogueSystems;


public class MaritimeRuntimeInfrastructure : MonoBehaviour
{

    public Transform[] PointsOfInterest = new Transform[20];

    MaritimeRuntimeInfrastructure MaritimeCoreObject;

    private MaritimeRuntimeInfrastructure()
    {

   

    }


	Core[] SystemObjects = new Core[10];
	public string[] SystemObjectNames = new string[10];



	Vector3 ElliLocation;

    //Runtime Begins Here
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


    //Enum Instances
    public static SceneID RuntimeID;
    public static UISelectionRuntimeID_Menu SelectionRuntimeID_Menu;
    public static UISelectionRuntimeID_DiscussionBox SelectionRuntime_DiscussionBox;

    private static int MaritimeDialogueIterator = 0;

    GameObject BrendanInstanceObject;

    // Use this for initialization
    void Start()
    {

		SystemObjects = FindObjectsOfType <Core> ();
        BrendanInstanceObject = BrendanPOVController.BrendanSingletonObjectInstance.gameObject;
        MaritimeCoreObject = FindObjectOfType<MaritimeRuntimeInfrastructure>();


		for (int a = 0; a < SystemObjects.Length; a++) 
		{
			
			SystemObjectNames [a] = SystemObjects [a].name;

		}
    }


	void mRuntimePause()
	{
		
		//If button is pressed go to next part

		for (int a = 0; a < SystemObjects.Length; a++) 
		{
			SystemObjects [a].ISystemPause();
		}

	}


	void mRuntimePlay()
	{

		for (int a = 0; a < SystemObjects.Length; a++) 
		{
			SystemObjects [a].ISystemPlay();
		}

	}

    // Update is called once per frame
    void Update()
    {

        MaritimeDialogueIterator = Core.CoreDialogueSystems.MaritimeDialogueIterator;

        mRuntimeSceneLogic();

        InputUI();

    }


	#region Master Runtime Functions
    void mLerp(Transform PointA, Transform PointB)
    {
        BrendanInstanceObject.transform.position = Vector3.LerpUnclamped(PointA.position, PointB.position, Time.time / 10);
    }


    public void mRuntimeSceneLogic()
    {
		ElliLocation = ElliController.GetPosition ();

        //Goes to Local Street
        if (MaritimeDialogueIterator == 0)
        {
			
            BrendanInstanceObject.transform.position = Vector3.Lerp(BrendanPOVController.GetPosition(), PointsOfInterest[0].position, Time.time / 20);

			ElliLocation.y = 2.0f;

			BrendanInstanceObject.transform.LookAt (ElliLocation);

        }

        if (MaritimeDialogueIterator == 16)
		{
            BrendanInstanceObject.transform.position = Vector3.Lerp(BrendanPOVController.GetPosition(), PointsOfInterest[1].position, Time.time / 20);

            BrendanInstanceObject.transform.position = Vector3.Lerp(BrendanPOVController.GetPosition(), PointsOfInterest[2].position, Time.time / 20);
        }

    }

	#endregion

    /// <summary>
    /// When the scene first starts
    /// </summary>
   public static IEnumerator cFrontDoorBell()
    {
        if (MaritimeDialogueIterator == 0)
        {
            FrontDoor.PlayDoorBell();

            yield return new WaitForSeconds(FrontDoor.FrontDoorSource.clip.length * 1.1f);

            Quaternion FrontDoorOpen = FrontDoor.FrontDoorGameObject.transform.rotation;

            FrontDoorOpen = Quaternion.FromToRotation(FrontDoor.FrontDoorGameObject.transform.parent.right, FrontDoor.FrontDoorGameObject.transform.up);

            Core.State = Core.CoreDialogueSystems.ConversationState.Active;

		

        }
    }


    private static IEnumerator cDogBarking()
    {

        if (MaritimeDialogueIterator == 5)
        {
            Vector3 ElliLookAt = ElliController.ElliInstance.transform.position;

            Quaternion.LookRotation(forward: (ElliLookAt));

            while (MaritimeDialogueIterator < 10)
            {
                MableController.MableSingletonObject.Play();

            }
      
        }

        yield return new WaitForSeconds(3.0f);
    }


    private IEnumerator cElliTakeDogupStairs()
    {
        //Destroy gameObjects

        yield return new WaitForSeconds(5);

        StartCoroutine(cStepIntoLivingRoom());
    }



    private IEnumerator cStepIntoLivingRoom()
    {
        yield return null;

    }

    private void InputUI()
    {
        //Main Menu Code
        if (Input.GetKeyDown(KeyCode.P))
        {

            EpisodeOneMenuUI.SetGameActive();

        }

    }


    public struct ColliderFunctions
    {
        public bool ElliFinishedTakingDogUpstairs()
        {
            //Do some trigger code here
            return false;
        }

        public bool ElliComesBackDownStairs()
        {
            //Do some trigger code here
            return false;
        }

        public bool ElliEntersLivingRoom()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanEntersLivingRoom()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanChecksCotCollider()
        {
            //Do some trigger code here
            return false;
        }

        public bool BrendanFrontDoor()
        {
            //Do some trigger code here
            return false;
        }

    }

    public struct AnimationFunctions
    {

        public bool LukePointsFinger()
        {
            //Do some animation code here
            return false;
        }

    }

    public struct SceneEvents
    {
        public UnityEvent DogBarking;
        public UnityEvent OpenDoor;
        public UnityEvent FrontDoor;
        public UnityEvent Doorbell;
        public UnityEvent ComeDownstairs;
        public UnityEvent WalkDogUpstairs;
        public UnityEvent EnterLivingRoom;
        public UnityEvent CheckCot;
        public UnityEvent ElliLukeCheckCot;
        public UnityEvent BrendanChecksBottle;
        public UnityEvent BrendanPicksBottle;
        public UnityEvent PointsToBrokenGlass;
        public UnityEvent BrendanLeavesHouse;


        public void StructAddPersistantListeners(UnityEventBase unityEvent, UnityAction call)
        {
			
            //UnityEventTools.AddVoidPersistentListener (unityEvent: unityEvent, call: call);
        }


    }

	public class ISystem{


		public virtual void Play(){


		}

		public virtual void Pause(){



		}

	
	}
}


using UnityEngine;
using System.Collections;

public class MableController : MonoBehaviour {


    [SerializeField] private AudioSource MableSource;
    [SerializeField] private AudioClip MableBark;
     private Animator MableAnimator;
     private AnimationClip cMableBarkAnimation;
     private AnimationClip cMableWalkAnimation;
    [SerializeField]
    private Animation MableCoreAnimation;

    private static MableController MableSingletonObjectInstance;

    private MableController()
    {

    }

    public static MableController MableSingletonObject
    {
        get { return MableSingletonObjectInstance; }
    }


    void Awake()
    {
        //Find object and assign it to instance
        MableSingletonObjectInstance = FindObjectOfType<MableController>();

        MableBark = GetComponent<AudioClip>();

        gameObject.AddComponent<AudioSource>();
        gameObject.AddComponent<Animator>();
        MableAnimator = GetComponent<Animator>();
        MableSource = GetComponent<AudioSource>();
        MableCoreAnimation = GetComponent<Animation>();


        cMableWalkAnimation = MableCoreAnimation.GetClip("Walk");
        cMableBarkAnimation = MableCoreAnimation.GetClip("Barking");
      
    }



    

  public void WalkingVectorAssignment(INavigation PointA, INavigation PointB, Animation Walking)
    {

        float Distance = 0;

        if (Walking.IsPlaying("Walking"))
        { 
          //We find the distance and we make the character walk the distance using abstractions 
          Distance = Vector3.Distance(PointA.GetPosition(), PointB.GetPosition());
          gameObject.transform.position = Vector3.MoveTowards(PointA.GetPosition(), PointB.GetPosition(), Distance);
          
        }

    }


    public void Play()
    {
        MableSource.clip = MableBark;
        MableSource.Play();

    }

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () {

        if (CoreSystems.Core.CoreDialogueSystems.MaritimeDialogueIterator == 5)
        {
           // WalkingVectorAssignment(NavigationInfrastructure.NavigationObjects[0], NavigationInfrastructure.NavigationObjects[1], cMableWalkAnimation);
        }

	}
}

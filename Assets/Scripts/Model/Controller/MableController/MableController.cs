using UnityEngine;
using System.Collections;

public class MableController : MonoBehaviour {


    [SerializeField] private AudioSource MableSource;
    [SerializeField] private AudioClip MableBark;
    [SerializeField] private Animator MableAnimator;
    [SerializeField] private Animation[] MableAnimations;
    [SerializeField] private Animation cMableBarkAnimation;
    [SerializeField] private Animation cMableWalkAnimation;

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
        MableAnimator.GetComponent<Animator>();
        MableSource.GetComponent<AudioSource>();
        MableAnimations =  new Animation[30];
        MableAnimations = GetComponents<Animation>();


        //Call essential functions
        InitializeDogAnimations();
      
    }


    void InitializeDogAnimations()
    {

        //Find Animations
        for (int a = 0; a < MableAnimations.Length; a++)
        {
            if (MableAnimations[a].name == "Barking")
            {
                cMableBarkAnimation = MableAnimations[a];
            }

            if (MableAnimations[a].name == "Walking")
            {
                cMableWalkAnimation = MableAnimations[a];

            }
        }

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
            WalkingVectorAssignment(NavigationInfrastructure.NavigationObjects[0], NavigationInfrastructure.NavigationObjects[1], cMableWalkAnimation);
        }

	}
}

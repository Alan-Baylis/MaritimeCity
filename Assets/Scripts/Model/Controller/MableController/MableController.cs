using UnityEngine;
using System.Collections;
using CoreSystems;

public class MableController : MonoBehaviour {


    [SerializeField] private AudioSource MableSource;
    [SerializeField] private AudioClip[] MableBark;
     private Animator MableAnimator;
     private AnimationClip cMableBarkAnimation;
     private AnimationClip cMableWalkAnimation;
    private AnimationClip cMableIdledAnimation;

    int DogBarkingIterator = 0;
    int BarkIterator = 0;

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

        gameObject.AddComponent<AudioSource>();
        gameObject.AddComponent<Animator>();
        MableAnimator = GetComponent<Animator>();
        MableSource = GetComponent<AudioSource>();
        MableCoreAnimation = GetComponent<Animation>();

        MableSource.clip = MableBark[0];

       

        InitializeSourceVariables();

        cMableWalkAnimation = MableCoreAnimation.GetClip("Walk");
        cMableBarkAnimation = MableCoreAnimation.GetClip("Barking");
        cMableIdledAnimation = MableCoreAnimation.GetClip("Idled");

             
    }


     private void InitializeSourceVariables()
    {

        MableSource.volume = 0.5f;

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
   

        if (Core.MaritimeInternalIterator == 4)
        {
            MableCoreAnimation.Play("Barking");

            if (MableCoreAnimation.isPlaying == false)
            {
                MableCoreAnimation.Play("Barking");
            }

        }


    }

    IEnumerator Bark()
    {

        while (Core.MaritimeInternalIterator > 4)
        {
            MableSource.clip = MableBark[BarkIterator];
            MableSource.Play();

            BarkIterator++;

            if (BarkIterator == 2)
            {

                BarkIterator = 0;
                StartCoroutine(Bark());

            }

            yield return new WaitForSeconds(5.0f);

            StartCoroutine(Bark());

        }

        yield return new WaitForSeconds(2.0f);

        StartCoroutine(Bark());

    }

	// Use this for initialization
	void Start () 
    {

        StartCoroutine(Bark());

    }
	
	// Update is called once per frame
	void Update () {

        if(Core.MaritimeInternalIterator == 0 && MableCoreAnimation.isPlaying == false)
        {
            MableCoreAnimation.Play("Idled");
        }

        if (Core.CoreDialogueSystems.MaritimeDialogueIterator == 5)
        {
           // WalkingVectorAssignment(NavigationInfrastructure.NavigationObjects[0], NavigationInfrastructure.NavigationObjects[1], cMableWalkAnimation);
        }

        Play();

	}
}

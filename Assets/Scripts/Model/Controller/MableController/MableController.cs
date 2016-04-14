using UnityEngine;
using System.Collections;
using CoreSystems;
using System;

public class MableController : MonoBehaviour {


    [SerializeField] private AudioSource MableSource;
    [SerializeField] private AudioClip[] MableBark;
    [SerializeField] private Animation MableCoreAnimation;
    private Animator MableAnimator;
    private AnimationClip cMableBarkAnimation;
    private AnimationClip cMableWalkAnimation;
    private AnimationClip cMableIdledAnimation;
    private int PlayLogger = 0;
    private int BarkIterator = 0;
    public enum MableActive {Active, Inactive };



    MableActive MableActiveID;

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

        MableActiveID = MableActive.Active;

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


    // Use this for initialization
    void Start()
    {

        StartCoroutine(Bark());

    }

    // Update is called once per frame
    void Update()
    {

        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 0 && MableCoreAnimation.isPlaying == false && MableActiveID == MableActive.Active)
        {
            StartCoroutine(Play());
        }

        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 5)
        {

        }

    }


    private void InitializeSourceVariables()
    {
        MableSource.volume = 0.5f;
    }
    
  
    public IEnumerator Play()
    {
  
        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator >= 12 && MaritimeRuntimeInfrastructure.MaritimeInternalIterator <= 16)
        {
            StartCoroutine(Bark());

            MableCoreAnimation.Play("Barking");

            yield return new WaitUntil(() => MableCoreAnimation.isPlaying == false);

            Debug.Log("Mable play works correctly and is starting again for the " + PlayLogger + " time.");

            PlayLogger++;

            StartCoroutine(Play());

        } else if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator < 12 || MaritimeRuntimeInfrastructure.MaritimeInternalIterator > 16)
        {
            MableCoreAnimation.Play("Fight Idle");

            yield return new WaitUntil(() => MableCoreAnimation.isPlaying == false);

            Debug.Log("Mable play works correctly and is starting again for the " + PlayLogger + " time.");

            PlayLogger++;

            StartCoroutine(Play());

        }

        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 24)
        {
            MableCoreAnimation.Play("Walk");

        } else if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator != 24)
        {
            StartCoroutine(Play());
        }

    }

    public IEnumerator Bark()
    {

        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator > 12 && MaritimeRuntimeInfrastructure.MaritimeInternalIterator < 18 && MableActiveID == MableActive.Active)
        {
            MableSource.clip = MableBark[BarkIterator];
            MableSource.Play();

            BarkIterator++;

            if (BarkIterator == 2)
            {
                BarkIterator = 0;
                StartCoroutine(Bark());
            }

            yield return new WaitForSeconds(3.0f);

            StartCoroutine(Bark());

        }

        if (MaritimeRuntimeInfrastructure.MaritimeInternalIterator == 18)
        {

            StopCoroutine(Bark());
            MableActiveID = MableActive.Inactive;

        }


    }

    public static Vector3 GetPosition()
    {
        return MableSingletonObject.transform.position;
    }


}

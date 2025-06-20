
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class LevelManager : MonoBehaviour
{

    
    public TentacleScript[] tentacleScripts;

    public PlayableDirector director;
    public PlayableDirector SecondDirector;
    
    public float DistanceToHideShow = 3f;

    public GameObject Character;

    public bool TentaclesShown = false;

    public static LevelManager Instance;

    bool wasPearlsPlayed = false;

    AudioSource _source;


    public AudioClip StartClip;
    public AudioClip IdleClip;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Vector2.Distance(this.transform.position, Character.transform.position) > DistanceToHideShow && TentaclesShown)
        {
            HideTentacles();
            TentaclesShown = false;
        }
    }

    public void ShowTentacles() {


        if (Vector2.Distance(this.transform.position, Character.transform.position) > DistanceToHideShow || wasPearlsPlayed)
            return;

        StartCoroutine(PlaySound());

        if (PearlsController.Instance.PearlsCount == 6) 
        {
            SecondDirector.Play();
            wasPearlsPlayed = true;
        }
        else
            director.Play();

        TentaclesShown = true;
    }

    public void HideTentacles() {

        _source.loop = false;
        _source.clip = StartClip;
        _source.Play();

        foreach (var tect in tentacleScripts) {
            tect.EndAnimation();
        }
    }

    IEnumerator PlaySound() {
        _source.clip = StartClip;
        _source.Play();
        yield return new WaitForSeconds(StartClip.length);
        _source.clip = IdleClip;
        _source.loop = true;
        _source.Play();
    }
}


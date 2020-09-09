using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Animator stampAnim;
    public GameObject lavaParticles;
    public GameObject removableThing;
    public GameObject negativeStamp;
    public bool startFill;

    // Start is called before the first frame update
    void Start()
    {
        removableThing.SetActive(true);
        negativeStamp.SetActive(false);
        lavaParticles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Stamp()
    {
        stampAnim.SetTrigger("Stamp");

        StartCoroutine(SetActiveAfterTime(negativeStamp, 1f));
        StartCoroutine(SetInActiveAfterTime(removableThing, 1f));

        StartCoroutine(SetActiveAfterTime(lavaParticles, 1.2f));
        startFill = true;


    }

    IEnumerator SetInActiveAfterTime(GameObject thing, float time)
    {
        yield return new WaitForSeconds(time);
        thing.SetActive(false);
    }

    IEnumerator SetActiveAfterTime(GameObject thing, float time)
    {
        yield return new WaitForSeconds(time);
        thing.SetActive(true);

    }
}



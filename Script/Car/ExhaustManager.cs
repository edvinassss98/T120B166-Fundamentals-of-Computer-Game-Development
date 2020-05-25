using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exhaust fumes manager
/// </summary>
public class ExhaustManager : MonoBehaviour
{
    public InputManager im; // speed variables

    public float ExhaustRate;

    public ParticleSystem Exhaust01;
    public ParticleSystem Exhaust02;

    ParticleSystem Exhaust002;
    ParticleSystem Exhaust001;

    // Start is called before the first frame update
    void Start()
    {
        Exhaust001 = Exhaust01.GetComponent<ParticleSystem>();
        Exhaust002 = Exhaust02.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        // Exhaust01.GetComponent<ParticleSystem>().emission.rateOverTime = im.throttle * ExhaustRate;
        //Exhaust02.GetComponent<ParticleSystem>().emission.rateOverTime = im.throttle * ExhaustRate;
        var emission1 = Exhaust001.emission;
        var emission2 = Exhaust002.emission;

        emission1.rateOverTime = im.throttle * ExhaustRate;
        emission2.rateOverTime = im.throttle * ExhaustRate;

        //Exhaust01.emission.rateOverTime = im.throttle * ExhaustRate;
        //Exhaust02.emissionRate = im.throttle * ExhaustRate;
    }
}

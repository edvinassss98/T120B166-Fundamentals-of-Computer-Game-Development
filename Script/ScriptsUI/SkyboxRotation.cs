using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Skybox Rotation
     */

public class SkyboxRotation : MonoBehaviour
{
    public float rotateSpeed = 0.5F;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
    }
}

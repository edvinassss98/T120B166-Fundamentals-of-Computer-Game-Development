using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject focus; //Car
    public float distance = 3f;
    public float height = 3f;
    public float dampening = 5f;
    public float h2 = 0f;
    public float d2 = 0f;
    public float l = 0f; //horizontal distance from the car
    public float rotationDamping = 10.0f;
    /*
     * 
    public float carX;
    public float carY;
    public float carZ;*/

    public bool smoothRotation = true;

    private int camMode = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            camMode = (camMode + 1) % 2; // 0 1 0 1 0 1
        }

        //camera modes 0 1
        switch(camMode) 
        {
            case 1:
                transform.position = focus.transform.position + focus.transform.TransformDirection(new Vector3(l, h2, d2));
                transform.rotation = focus.transform.rotation;
                //Camera.main.fieldOfView = 70f;
                break;
            default:


                //transform.position = focus.transform.position + focus.transform.TransformDirection(new Vector3(distance, height, dampening));
                //transform.rotation = focus.transform.rotation;
/*
                carX = focus.transform.eulerAngles.x;
                carY = focus.transform.eulerAngles.y;
                carZ = focus.transform.eulerAngles.z;

                transform.eulerAngles = new Vector3(carX - carX, carY, carZ - carZ);*/



                transform.position = Vector3.Lerp(transform.position, focus.transform.position + focus.transform.TransformDirection(new Vector3(0f, height, -distance)), dampening * Time.deltaTime);
                transform.LookAt(focus.transform);
                break;

                /*Vector3 wantedPosition = focus.transform.TransformPoint(0, height, -distance);
                transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * dampening);

                if (smoothRotation)
                {
                    Quaternion wantedRotation = Quaternion.LookRotation(transform.position - transform.position, transform.up);
                    transform.rotation = Quaternion.Slerp(transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
                }

                else
                    transform.LookAt(focus.transform);*/
                

        }
    //Debug.Log(camMode);
}
}

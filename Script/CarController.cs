using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public InputManager im;
    //public Speedometer speedometer;
    public List<WheelCollider> throttleWheels;
    public List<GameObject> steeringWheels;                 
    public List<GameObject> meshes; // contains all sub objects of wheels will handle rotation
    public float strengthcoefficient = 10000f;
    public float maxTurn = 20f;
    public Transform CenterMass;
    public Rigidbody rigidbody;
    public float brakeStrength;


    public Text SilverUIText;
    public Text FinalUIText;

    int silver = 3;

    //private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //safety
        im = GetComponent<InputManager>();
        rigidbody = GetComponent<Rigidbody>();

        //FinalUIText.gameObject.SetActive(false);

        if (CenterMass)
        {
            //rigidbody.centerOfMass = rigidbody.position;
        }

        // animator = GetComponent<Animator>();
        //speedometer.changeText(transform.InverseTransformVector(rigidbody.velocity).z);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(im.throttle);
        
        foreach (WheelCollider wheel in throttleWheels)
        {
            //cia uzkomentuota!!!
            //if(im.brake)
           // {
            //    wheel.motorTorque = 0f;
            //    wheel.brakeTorque = brakeStrength * Time.deltaTime; // because of frames
           // }
           // else //if we not braking 
           // {
            //    wheel.motorTorque = strengthcoefficient * Time.deltaTime * im.throttle;
           //     wheel.brakeTorque = 0f;
          //  }
        }
        
        foreach (GameObject wheel in steeringWheels)
        {
            wheel.GetComponent<WheelCollider>().steerAngle = maxTurn * im.steer;
            wheel.transform.localEulerAngles = new Vector3(0f, im.steer * maxTurn , 0f);
        }

        //wheel rotation
        foreach( GameObject mesh in meshes)
        {
            mesh.transform.Rotate(rigidbody.velocity.magnitude * (transform.InverseTransformDirection(rigidbody.velocity).z >= 0 ? -1 : 1) / (2 * Mathf.PI * 0.23f), 0f, 0f); // ternary operator if else
        }
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, 5, rigidbody.velocity.z);
        }*/
    }



    //----------------------------------------------------------------------------------------------------------------
    
        
    // Updates gold and silver count on cilision
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Gold_Coin") || collider.gameObject.CompareTag("Silver_Coin"))
        {
            collider.gameObject.SetActive(false);
            Destroy(collider.gameObject);
        }

        if(collider.gameObject.CompareTag("Silver_Coin"))
        {
            silver++;
            updateSilverUIText();
        }

        if (collider.gameObject.CompareTag("Gold_Coin"))
        {
            silver += 2;
            updateSilverUIText();
        }
    }

    //updates UI
    void updateSilverUIText()
    {
        SilverUIText.text = "Silver: " + silver.ToString();
    }
    

        
    //Game over UI 
    void SetFinalUIText(string text)
    {
        FinalUIText.text = text;
        FinalUIText.gameObject.SetActive(true);
    }


    //Removes all objects
    void removeAllObjects()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject ob in allObjects)
        {
            if((ob.CompareTag("Silver_Coin")) || (ob.CompareTag("Gold_Coin")) || (ob.CompareTag("Obstacle")))
            {
                Destroy(ob);
            }
        }

    }

    /*
    //Colision minus -2 silver
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Barrel_Fire"))
        {
            Debug.Log("Boom");

            //silver -= 2;
            //updateSilverUIText();

            //rigidbody.AddForce(Vector3.up * 500000);


            collision.gameObject.SetActive(false);
            //Destroy(collision.gameObject);

            if(silver <= 0)
            {
               // SetFinalUIText("Game Over");
             //   removeAllObjects();
            }
        }
    }*/
}

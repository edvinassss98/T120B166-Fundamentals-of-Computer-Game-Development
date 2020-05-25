using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public float throttle;
    public float steer;
    public float brake;

    private NewCarController m_Car;

    private void Awake()
    {
        // get the car controller
        m_Car = GetComponent<NewCarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        throttle = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
        brake = Input.GetAxis("Jump");

        m_Car.Move(steer, throttle, throttle,brake);

    }
}

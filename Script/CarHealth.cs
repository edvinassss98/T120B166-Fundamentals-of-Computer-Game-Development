using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Here we set our music volume and triggers;

public class CarHealth : MonoBehaviour
{
    public Text HealthUIText;
    public Text FinalUIText;

    //Audio
    public AudioSource Explode;
    public AudioSource healing;

    public ParticleSystem Fire;
    public ParticleSystem Fire2;
    public ParticleSystem HeartParticles;

    private Rigidbody rb;

    public int Health = 100;

    public GameObject EndGamePanel;

    public GameObject Bar;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    ///Updates Health
    IEnumerator OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("HP"))
        {
            
            Debug.Log("HP_More!!!!");

            if (Health == 100)
                Health = 100;
            else
                Health += 10;

            updateHealthUIText(Health);
            Debug.Log(Health);

            collider.gameObject.SetActive(false);
            healing.Play();

            HeartParticles.transform.position = collider.transform.position;

            HeartParticles.gameObject.SetActive(true);//Play();
            yield return new WaitForSeconds(2.0F);
            HeartParticles.gameObject.SetActive(false);
            healing.Stop();

        }
        //Maybe i will do that after several second he will be back
        if (collider.gameObject.CompareTag("Speed_Pad"))
        {
            Debug.Log("More_Speed:)");
            collider.gameObject.SetActive(false);
            rb.AddForce(rb.velocity.normalized * Time.deltaTime * 10000000);//(Vector3.forward * 1000000);

        }

    }

    //updates UI
    void updateHealthUIText(int hp)
    {
        HealthUIText.text = "HP: " + hp.ToString();

        if (hp <= 0)
        {
            Bar.transform.localScale = new Vector3(0, 1, 1);
        }
        else
        {
            Bar.transform.localScale = new Vector3(hp / 100f, 1, 1);
        }
        
        //SilverUIText.text = "Silver: " + silver.ToString();
    }



    //Game over UI 
    void SetFinalUIText(string text)
    {
        FinalUIText.text = text;
        FinalUIText.gameObject.SetActive(true);
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrel_Fire"))
        {
            Debug.Log("Boom");

            Health -= 20;

            updateHealthUIText(Health);
            Debug.Log(Health);

            GetComponent<Rigidbody>().AddForce(Vector3.back * 300000);

            collision.gameObject.SetActive(false);
            Explode.Play();

            Fire2.transform.position = collision.transform.position;

            Fire2.gameObject.SetActive(true);//Play();
            yield return new WaitForSeconds(2.0F);
            Fire2.gameObject.SetActive(false);
            Explode.Stop();

        }
    }
}

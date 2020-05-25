using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAITrack : MonoBehaviour
{
    public GameObject TheMarker;
    public int MarkTracker;

    public GameObject[] Marks;

    // Update is called once per frame
    void Update()
    {
        if(MarkTracker < 19)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
    }

    // wait for several seconds
    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "CarAi")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if(MarkTracker == 19)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            //ijungia box 
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}

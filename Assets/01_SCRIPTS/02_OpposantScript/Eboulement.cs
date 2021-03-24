using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eboulement : MonoBehaviour
{
    public GameObject RocherMaitre;
    public GameObject RocherQuiTombent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("caTombe"))
        {
            GameObject[] RockNRoll = GameObject.FindGameObjectsWithTag("RocherSoumis");
            foreach (GameObject Rock in RockNRoll)
            {
                Rock.GetComponent<Rigidbody>().useGravity = true;
                Rock.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}

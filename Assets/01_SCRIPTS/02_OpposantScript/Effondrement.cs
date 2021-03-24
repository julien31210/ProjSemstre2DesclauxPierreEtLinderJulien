using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effondrement : MonoBehaviour
{
    public GameObject rock;
    public GameObject Eboulement;
    public int nbRoche;
    // Start is called before the first frame update
    void Start()
    {
        RocherQuiTombe();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    public void RocherQuiTombe()
    {
        for (nbRoche = 0; nbRoche < 15; nbRoche++)
        {
            (Instantiate(rock, GameObject.Find("Eboulement").transform.position, Quaternion.identity) as GameObject).transform.parent = Eboulement.transform;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject DeathZone;
    public GameObject AreaLight;
    public GameObject Player;
    public GameObject Respawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider col)
    {
        Debug.Log("Salut connard!");
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Meurt fdp");
            Player.GetComponent<MeshRenderer>().enabled = false;
            Player.transform.localPosition = Respawn.transform.localPosition;
        }
        else if (Player.transform.localPosition == Respawn.transform.position)
        {
            Debug.Log("Salut enculé!");
            Player.GetComponent<MeshRenderer>().enabled = true;
        }

        if (col.gameObject.CompareTag("moveObject"))
        {
            DeathZone.GetComponent<Collider>().enabled = false;
            AreaLight.GetComponent<Light>().enabled = false;
        }
    }

}

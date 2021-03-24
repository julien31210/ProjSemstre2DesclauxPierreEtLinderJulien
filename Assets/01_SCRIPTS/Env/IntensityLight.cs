using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntensityLight : MonoBehaviour
{
    public GameObject Light;
    Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Fire()
    {
        myLight.intensity = Mathf.PingPong(Time.time, Random.Range(250, 150));
        yield return new WaitForSeconds(2f);
    }
}

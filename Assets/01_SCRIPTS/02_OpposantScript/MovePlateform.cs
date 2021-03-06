using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlateform : MonoBehaviour
{
    public GameObject child;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MovePlateformasChild(Transform newParent)
    {
        child.transform.SetParent(newParent);

        child.transform.SetParent(newParent, false);

        child.transform.SetParent(null);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MovePlateformasChild(collision.transform);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Animator animator;
    public GameObject Player;
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
        if (other.CompareTag("CameraChange"))
        {
            Debug.Log("touché");
            animator.Play("Camera 1");
        }

        if (other.CompareTag("CameraReset"))
        {
            Debug.Log("touché");
            animator.Play("Camera 2");
        }
    }
}

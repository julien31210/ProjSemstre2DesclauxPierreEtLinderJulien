using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Camera;
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
            cameraMove();
        }

        if (other.CompareTag("CameraReset"))
        {
            Debug.Log("touché");
            cameraReset();
        }
    }
    private void cameraMove()
    {
        LeanTween.moveZ(Camera, 12, 8).setEaseOutCirc();
        LeanTween.moveY(Camera, 4, 8).setEaseOutCirc();
        LeanTween.moveX(Camera, 1, 10).setEaseOutCirc();
        LeanTween.rotateZ(Camera, 90, 8).setEaseOutCirc();
        LeanTween.rotateY(Camera, 90, 8).setEaseOutCirc();
        LeanTween.rotateX(Camera, 90, 8).setEaseOutCirc();
    }

    private void cameraReset()
    {
        LeanTween.moveZ(Camera, 0, 0).setEaseOutCirc();
        LeanTween.moveZ(Camera, 0, 0).setEaseOutCirc();
        LeanTween.moveX(Camera, 0, 0).setEaseOutCirc();
        LeanTween.rotateY(Camera, 0, 0).setEaseOutCirc();
    }
}

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

        Debug.Log("Salut connard");
        if (other.CompareTag("CameraChange"))
        {
            Debug.Log("touché enculé");
            cameraMove();
        }

        if (other.CompareTag("CameraReset"))
        {
            //Debug.Log("touché");
            cameraReset();
        }
    }
    private void cameraMove()
    {
        Debug.Log("Salut trou duc");
        LeanTween.moveLocal(Camera, new Vector3(1, 4, -10), 2).setEaseOutCirc();
        LeanTween.rotateY(Camera, 360, 2).setEaseOutCirc();
    }

    private void cameraReset()
    {
        /* LeanTween.moveZ(Camera, 0, 0).setEaseOutCirc();
         LeanTween.moveZ(Camera, 0, 0).setEaseOutCirc();
         LeanTween.moveX(Camera, 0, 0).setEaseOutCirc();
         LeanTween.rotateY(Camera, 0, 0).setEaseOutCirc();*/
    }
}

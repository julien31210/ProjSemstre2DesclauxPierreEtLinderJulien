using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;

    Vector3 defaultPos;
    Vector3 defaultRot;

    Transform Cam;
    // Start is called before the first frame update
    void Start()
    {
        backupTransform();
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
            Debug.Log("touché connard");
            cameraReset();
        }
    }
    private void cameraMove()
    {
        Debug.Log("Salut trou duc");
        LeanTween.moveLocal(Camera, new Vector3(1, 6, -15), 6).setEaseOutCirc();
        LeanTween.rotateY(Camera, 360, 8).setEaseOutCirc();
    }

    private void cameraReset()
    {

        Debug.Log("Salut trou duc");
        //Restore the all the original pos, scale and rot  of each GameOBject
        LeanTween.moveLocal(Camera, defaultPos, 8).setEaseOutCirc();
        LeanTween.rotateY(Camera, 90, 8).setEaseOutCirc();
        Cam.localPosition = defaultPos;
        Cam.localEulerAngles = defaultRot;

    }
    private void backupTransform()
    {
        GameObject tempModels = GameObject.FindGameObjectWithTag("MainCamera");

        defaultPos = tempModels.transform.localPosition;
        defaultRot = tempModels.transform.localEulerAngles;

        Cam = gameObject.transform.GetChild(0).transform;
    }
}

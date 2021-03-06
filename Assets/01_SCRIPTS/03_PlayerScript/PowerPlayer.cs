using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlayer : MonoBehaviour
{
    //private GameObject objLevit;
    private Vector3 mOffset;
    private float mZCoord;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerBlocked();
    }

    /*private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }*/


    void OnMouseOver()
    {
        //Debug.Log("OnMouseDown fonctionne");
        Debug.Log(gameObject.name);
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        //Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    private void OnMouseExit()
    {
        var temp = gameObject.GetComponent<Renderer>();
        if (GameObject.FindGameObjectWithTag("moveObject"))
        {
            //Debug.Log("coucou");
            temp.material.SetColor("_Color", Color.clear);
        }
    }
    private Vector3 GetMouseWorldPos()
    {
        LevitationFeedback();
        //pixel coordinate (x, y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    public void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

    private void PlayerBlocked()
    {
        DeplacementJoueur deplacementJoueur = Player.GetComponent<DeplacementJoueur>();
        if (Input.GetMouseButton(0))
        {
            Debug.Log("va crever salle merde");
            deplacementJoueur.enabled = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Va mourrir sale fils de pute");
            deplacementJoueur.enabled = true;
        }
    }
    public void LevitationFeedback()
    {
        var temp = gameObject.GetComponent<Renderer>();
        if (GameObject.FindGameObjectWithTag("moveObject"))
        {
            //Debug.Log("coucou");
            temp.material.SetColor("_Color", Color.green);
        }
    }

}
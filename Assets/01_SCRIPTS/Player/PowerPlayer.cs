using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlayer : MonoBehaviour
{
    //Objet à cibler
    //Sélectionner l'objet à la souris
    //Click droit prendre l'objet
    //Bouger la souris, le déplacer
    private Vector3 mOffset;
    private float mZCoord;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSecond());
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        //pixel coordinate (x, y)
        Vector3 mousePoint = Input.mousePosition;

        // z coordinate of game object on screen
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    public void OnMouseDrag()
    {

        transform.position = GetMouseWorldPos() + mOffset;

        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, 100))
        {
            Debug.Log(this.gameObject + "hit something");
        }*/

    }

    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(1);
    }
}

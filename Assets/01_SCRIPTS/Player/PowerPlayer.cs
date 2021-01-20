using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlayer : MonoBehaviour
{
    //Objet à cibler
    //Sélectionner l'objet à la souris
    //Click droit prendre l'objet
    //Bouger la souris, le déplacer

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSecond());
        MouseSee();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void MouseSee()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, 100))
        {
            Debug.Log(this.gameObject + "hit something");
        }

    }
    IEnumerator WaitForSecond()
    {
        yield return new WaitForSeconds(1);
    }
}

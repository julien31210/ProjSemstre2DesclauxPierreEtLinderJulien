using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementJoueur : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();

    }

    public void PlayerMove()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = transform.right * moveHorizontal;
        transform.position += movement * speed * Time.deltaTime;
    }


}

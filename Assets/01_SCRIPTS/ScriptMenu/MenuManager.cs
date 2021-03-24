using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayButton();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PlayButton()
    {
        if (true)
        {
            SceneManager.LoadScene("Proto3", LoadSceneMode.Additive);
        }
    }
}

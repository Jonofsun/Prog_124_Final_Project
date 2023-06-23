using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideCanvus : MonoBehaviour
{
    private Canvas menuSystem;
    public GameObject PauseMenuCanvus;
    // Start is called before the first frame update
    void Start()
    {

        menuSystem = GetComponent<Canvas>();
        menuSystem.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuSystem.enabled =! menuSystem.enabled;
        }
    }
}

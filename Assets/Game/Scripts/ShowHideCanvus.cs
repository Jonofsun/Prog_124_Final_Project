using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideCanvus : MonoBehaviour
{
    private Canvas menuSystem;
    // Start is called before the first frame update
    void Start()
    {
        menuSystem = GetComponent<Canvas>();
        menuSystem.enabled =! menuSystem.enabled;
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

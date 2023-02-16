using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//temp class to start game
public class StartTest : MonoBehaviour
{
    public GameObject RedBird;
    public GameObject Menu;
    public GameObject pipeSpawner;
    public GameObject scoreControl;
    
    public bool OnStart = false;
    // Start is called before the first frame update

    void Start()
    {
        OnStart = true;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && OnStart == true)
        {
            RedBird.SetActive(true);
            Menu.SetActive(false);
            pipeSpawner.SetActive(true);
            scoreControl.SetActive(true);
            OnStart = false;
        }
    }
}

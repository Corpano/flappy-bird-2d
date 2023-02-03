using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    public GameObject RedBird;
    // Start is called before the first frame update
    void Start()
    {
        RedBird.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject UIPrefab;

    void Start()
    {
        Instantiate(UIPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class UIOption : MonoBehaviour
{
    private PlayerContoller controller;
    public GameObject OptionWindow;

    private void Start()
    {
        OptionWindow.SetActive(false);
        controller = CharacterManager.Instance.Player.controller;
        controller.option += OptionToggle;
    }

    public void OptionToggle()
    {
        if (isOpen())
        {
            OptionWindow.SetActive(false);
        }
        else
        {
            OptionWindow.SetActive(true);
        }
    }

    public bool isOpen()
    {
        return OptionWindow.activeInHierarchy;
    }
}

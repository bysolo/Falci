using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_Manager : MonoBehaviour {
    public GameObject panel;

    public void Info()
    {
        panel.SetActive(true);
    }
    public void ExitButton()
    {
        panel.SetActive(false);
    }
}

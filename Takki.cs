using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Takki : MonoBehaviour
{
    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Byrja()
    {
        SceneManager.LoadScene(1);
        Ovinur.health = 30;
    }

    public void Endir()
    {
        SceneManager.LoadScene(0);
        Ovinur.health = 30;
    }
}

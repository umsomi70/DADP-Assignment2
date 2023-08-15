using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the active state of the object
            panel.SetActive(false);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Pause()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        panel.SetActive(true);
    }
}

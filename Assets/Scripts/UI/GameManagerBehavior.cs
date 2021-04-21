using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

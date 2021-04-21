using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerBehavior : MonoBehaviour
{
    [Tooltip("The refernece to a canvas in the scene")]
    [SerializeField]
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Quits the game when called
    public void QuitGame()
    {
        Application.Quit();
    }

    // Restarts the Game when called
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private AudioSource start;
    private void Start()
    {
        start = GetComponent<AudioSource>();
        start.Play();
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToStart()
    {
        SceneManager.LoadScene(0);
    }
}

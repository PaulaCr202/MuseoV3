using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] private int newLevel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //cargar escena principal del juego ya que este es el menu principal
    public void EscenaJuego()
    {
        SceneManager.LoadScene(newLevel);
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;

public class PressForInfo: MonoBehaviour
{

    [SerializeField] private GameObject uiElement;
    [SerializeField] private GameObject InfoText;
    //se coloca el sonido del cuadro en especifico como componente del trigger(objeto) y luego, se agrega a la variable creada dentro de este script
    //(tambien agregado como componente en el trigger) llamada "sound"
    public AudioSource sound;
    [SerializeField] private GameObject uiElement2;
    [SerializeField] private GameObject puntito;
    private bool activa = false;

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (activa == false)
            {
                uiElement2.SetActive(true);
                puntito.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                activa = true;
                puntito.SetActive(false);
                uiElement2.SetActive(false);
                uiElement.SetActive(activa);
                InfoText.SetActive(activa);
                sound.Play();

            }
            
            if (Input.GetKeyDown(KeyCode.Q) && activa == true) 
            {
                puntito.SetActive(true);
                activa = false;
                uiElement.SetActive(activa);
                InfoText.SetActive(activa);
            }
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntito.SetActive(true);
            uiElement2.SetActive(false);
            uiElement.SetActive(false);
            InfoText.SetActive(false);
        }
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;

public class KeyPressScene : MonoBehaviour
{
    //objetos que se ven en la interfaz de unity 
    [SerializeField] private int newLevel;
    [SerializeField] private GameObject uiElement;

    //cuando entra al trigger
    private void OnTriggerStay(Collider other)
    {
        //si mi objeto con el tag de player colisiona con el objeto con tag player
        if (other.CompareTag("Player"))
        {
            //MAKE UI APPEAR
            //BUTTON PRESS
            uiElement.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) //si se presiona la letra E
            {
                SceneManager.LoadScene(newLevel); //carga un nuevo nivel
            }
        }
    }

    //cuando salga del trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
        }
    }
}

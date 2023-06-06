using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UNLOCK CURSOR FOR ´TRIVIA´
public class unlockCursor : MonoBehaviour
{
    void Start()
    {

        UnlockCursor();
    }
    void Update()
    {
        
    }

    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

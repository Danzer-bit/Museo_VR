using UnityEngine;

public class ButtonExit : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Uscita dal gioco");
        Application.Quit();
    }
}
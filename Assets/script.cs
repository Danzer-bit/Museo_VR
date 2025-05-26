using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("NomeDellaScena"); //nome corretto della scena
    }
}
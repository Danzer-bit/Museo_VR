using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTutorial : MonoBehaviour
{
    public void ShowTutorial()
    {
        SceneManager.LoadScene("Tutorial"); // nome della scena di tutorial
    }
}
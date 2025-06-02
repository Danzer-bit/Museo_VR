using UnityEngine;

public class InteractUI : MonoBehaviour
{
    [Header("Interaction Settings")]
    public GameObject interactionPrompt; // GameObject che avvisa il player della possibile interazione
    public GameObject canvasMenu; // Menu che viene attivato con l'interazione

    private bool canInteract = false; // Booleana che controlla se l'oggetto è interagibile

    void Update()
    {
        // Controlla se viene premuto il tasto "E" e se l'interazione è possibile
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            // Attiva il menu
            if (canvasMenu != null)
            {
                canvasMenu.SetActive(true);
                SetCursorFree();
            }
        }
    }

    public void SetCursorFree()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    
    public void SetCursorLocked()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Controlla se l'oggetto che è entrato nel trigger ha il tag "Player"
        if (other.CompareTag("Player"))
        {
            // Attiva la possibilità di interazione
            canInteract = true;
            print("can interact");
            // Attiva il prompt di interazione
            if (interactionPrompt != null)
            {
                interactionPrompt.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Controlla se l'oggetto che è uscito dal trigger ha il tag "Player"
        if (other.CompareTag("Player"))
        {
            // Disattiva la possibilità di interazione
            canInteract = false;

            // Disattiva il prompt di interazione
            if (interactionPrompt != null)
            {
                interactionPrompt.SetActive(false);
            }
        }
    }
}

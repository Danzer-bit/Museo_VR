using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public float delayCambioScena;
    public UnityEvent alCambioScena = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CaricaSchermataPrincipale()
    {
        alCambioScena.Invoke();
        Invoke("SchermataPrincipale", delayCambioScena);
    }

    public void Gioco1()
    {
        alCambioScena.Invoke();
        Invoke("Gioco", delayCambioScena);
    }

    public void SchermataInizioTechDemo()
    {
        alCambioScena.Invoke();
        Invoke("TechDemo", delayCambioScena);
    }

    public void SchermataFineTechDemo()
    {
        alCambioScena.Invoke();
        Invoke("FineTechDemo", delayCambioScena);
    }


    public void SchermataPrincipale()
    {
        SceneManager.LoadScene("Mappa");
    }

    public void Gioco()
    {
        SceneManager.LoadScene("Gioco");

    }

    public void TechDemo()
    {
        SceneManager.LoadScene("Scena Inizio Tech Demo");

    }

    public void FineTechDemo()
    {
        SceneManager.LoadScene("Scena Fine Tech Demo");

    }

    public void Ricordo() {
        alCambioScena.Invoke();
        Invoke("RicordoDelay", delayCambioScena);

    }
    private void RicordoDelay() {
        SceneManager.LoadScene("VideoPlayer");

    }

    public void NewGame()
    {
       
    }

    public void CambioScena(string scena) {
        alCambioScena.Invoke();
        StartCoroutine(CambioScenaDelay(delayCambioScena, scena));

    }
    private IEnumerator CambioScenaDelay(float delay, string scena) {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(scena);
    }
}   

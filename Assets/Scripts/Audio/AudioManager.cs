using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    //istanza del'audio manager esistente al momento (null se non c'è un'audio manager)
    private static AudioManager _instance;
    public static AudioManager Instance { get => _instance; }


    public AudioSource click;
    public AudioSource clickBack;

    public AudioSource musica;

    private AudioSource traccia01Attiva;
    private float volumeAttivo;

    /*
    public AudioMixer mixer;

    public Slider sliderMusica;
    public Slider sliderEffetti;
    public Slider sliderMaster;*/

    //quando viene creato l'audio manager, segnalo come l'istanza corrente
    private void Awake() {
        if (_instance != this)
            _instance = this;

        traccia01Attiva = musica;
        volumeAttivo = musica.volume;
    }

    //quando viene distrutto, se è ancora l'istanza corrente rimuovila come istanza corrente
    private void OnDestroy() {
        if (_instance == this)
            _instance = null;
    }

    /*private void Start()
    {
        if (sliderMusica != null)
        {
            sliderMusica.value = ES3.Load<float>("floatMusica", defaultValue: 0.6f);
            sliderEffetti.value = ES3.Load<float>("floatEffetti", defaultValue: 0.6f);
            sliderMaster.value = ES3.Load<float>("floatMaster", defaultValue: 0.6f);
        }
        
    }


    public void SetMusicaLevel(float audio)
    {
        mixer.SetFloat("VolumeMusica", Mathf.Log10(audio) * 20);
        ES3.Save("floatMusica", audio);
    }

    public void SetEffettiLevel(float audio)
    {
        mixer.SetFloat("VolumeEffetti", Mathf.Log10(audio) * 20);
        ES3.Save("floatEffetti", audio);
    }

    public void SetMasterLevel(float audio)
    {
        mixer.SetFloat("MasterVol", Mathf.Log10(audio) * 20);
        ES3.Save("floatMaster", audio);
    }*/


    //metodi suoni interfacce

    public void PlayClick() {

        click.Play();

    }

    public void PlayClickBack() {

        clickBack.Play();

    }


    //metodi generici

    public void SwapMusic(AudioSource newMusic)
    {
        StopAllCoroutines();
        StartCoroutine(FadeMusicLento(newMusic));
    }


    public void PlayMusic(AudioSource music)
    {
        if (music == null) {
            music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        }

        music.Play();
        traccia01Attiva = music;
    }

    public void StopMusic(AudioSource music)
    {
        if (music == null) {
            music = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        }

        music.Stop();

    }

    public void PlaySound(AudioSource audio) {

        audio.Play();

    }

    AudioSource[] audioSourceList;
    public void PlaySound(string audioSourceName) {

        if (audioSourceList == null)
            audioSourceList = gameObject.GetComponentsInChildren<AudioSource>();

        //trova l'audiosource in base al nome (non conta le differenze tra minuscole e maiuscole per convenienza)
        AudioSource audioSourceToPlay = System.Array.Find(audioSourceList, audioSource => 
            audioSource.gameObject.name.Equals(audioSourceName,System.StringComparison.InvariantCultureIgnoreCase));

        if (audioSourceToPlay != null)
            audioSourceToPlay.Play();
        else
            Debug.LogWarning("AudioSource di nome " + audioSourceName + " non trovato dentro l'AudioManager.");
    }


    private IEnumerator FadeMusic(AudioSource music)
    {
        if (music == traccia01Attiva)
            yield break;

        float timeToFade = 3f;
        float timeElapsed = 0;
        float volumeMusic = music.volume;

        while (timeElapsed<timeToFade)
        {
            traccia01Attiva.volume = Mathf.Lerp(volumeAttivo, 0, timeElapsed / timeToFade);
            music.volume = Mathf.Lerp(0, volumeMusic, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;

            yield return null;

            Debug.Log("timeToFade " + timeToFade + ", timeElapsed " + timeElapsed);
        }

        traccia01Attiva.Stop();
        traccia01Attiva.volume = volumeAttivo;
        music.volume = volumeMusic;

        traccia01Attiva = music;
        volumeAttivo = music.volume;
    }

    private IEnumerator FadeMusicLento(AudioSource music)
    {
        if (music == traccia01Attiva)
            yield break;

        float timeToFade = 2f;
        float timeElapsed = 0;
        float volumeMusic = music.volume;

        while (timeElapsed < timeToFade)
        {
            traccia01Attiva.volume = Mathf.Lerp(volumeAttivo, 0, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;

            yield return null;
            
        }

        timeElapsed = 0;
        music.Play();

        while (timeElapsed < timeToFade)
        {
            music.volume = Mathf.Lerp(0, volumeMusic, timeElapsed / timeToFade);
            timeElapsed += Time.deltaTime;

            yield return null;
            
        }

        traccia01Attiva.Stop();
        traccia01Attiva.volume = volumeAttivo;
        music.volume = volumeMusic;

        traccia01Attiva = music;
        volumeAttivo = music.volume;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnFunctions : MonoBehaviour
{

    public void quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void cambiarEscenaDelay(string nombreEscena)
    {
        StartCoroutine(WaitForSecondsDo(0.5f, nombreEscena));
    }

    IEnumerator WaitForSecondsDo(float secToWait, string nombreEscena)
    {
        yield return new WaitForSeconds(secToWait);
        if(nombreEscena == "Credits")
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<MusicaEntreScenes>().StopMusic();           
        }
        SceneManager.LoadScene(nombreEscena);
    }


}

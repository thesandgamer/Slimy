using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public void GoToLevel(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }


    public void AffichePannel(GameObject pannel)
    {
        pannel.SetActive(true);
    }

    public void CachePannel(GameObject pannel)
    {
        pannel.SetActive(false);
    }





}

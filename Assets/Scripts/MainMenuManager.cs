using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    /*
    void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }
    */

    public void GoToLevel(string scene)
    {
        SceneManager.LoadScene(scene);
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

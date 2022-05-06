using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class survivalLoader : MonoBehaviour
{
    public void getScenec()
    {
        Debug.Log(SceneManager.sceneCount); 
        SceneManager.LoadScene("Level01");
    }
}

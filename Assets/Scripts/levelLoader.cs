using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    List<Scene> scenes = new List<Scene>();
    Animation animation;
    // void Start()
    // {
    //     getScenec();
    //     //for (int i = 0; i < SceneManager.sceneCount; i++)
    //     //{
    //     //    Debug.Log("In cycle");
    //     //    if(SceneManager.GetSceneAt(i).name == "Level01")
    //     //    {
    //     //        Debug.Log("On the right scene");
    //     //        SceneManager.LoadScene(SceneManager.GetSceneAt(i).ToString());
    //     //    }
    //     //}
    // }

    public void getScenec()
    {
        //Debug.Log(SceneManager.GetSceneAt(0).name.ToString());
        //SceneManager.LoadScene("Level01");
        //for (int i = 0; i < 1; i++)
        //{
        //   scenes.Add(SceneManager.GetSceneAt(i));//todo: 
        //   // Debug.Log(SceneManager.GetSceneAt(i));
        //}

        //for (int i = 0; i < SceneManager.sceneCount; i++)
        //{
        //    Debug.Log("In cycle");
        //    if(SceneManager.GetSceneAt(i).name == "Level01")
        //    {
        //        Debug.Log("On the right scene");
        //        SceneManager.LoadScene(SceneManager.GetSceneAt(i).ToString());
        //    }
        //}
        
        //gameObject.GetComponent<Animator>().enabled = false;
        Debug.Log(SceneManager.sceneCount); //TODO: Why I get only 1 scene. I have two added in build.
        SceneManager.LoadScene("StoryMode_lv1");
        Time.timeScale = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void ManageScene()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void ManageSceneB()
    {
        SceneManager.LoadScene("Scene2");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DebugSceneManagement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("DebugLevel");
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("MiniBossTesting");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("FinalBossTest");
        }
    }
}

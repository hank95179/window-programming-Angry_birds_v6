using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Parameter_4_script : MonoBehaviour
{

    public static int birds_counts = 3;
    public GameObject basic_panel_object;
    public GameObject nextlevel_panel_object;
    // Update is called once per frame
    void Update()
    {
        if (Enemy_4_controller.Enemy_count <= 0)
        {//check the Enemy is 0 , if yes end the scene
            StartCoroutine(End());
        }
    }
    IEnumerator End()
    {//end the game and reset the birds counts
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0f;
        nextlevel_panel_object.SetActive(true);
        basic_panel_object.SetActive(false);
    }
}

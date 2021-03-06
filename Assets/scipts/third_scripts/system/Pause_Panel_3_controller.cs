using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Pause_Panel_3_controller : MonoBehaviour
{

    public GameObject pause_panel_object;
    public GameObject basic_panel_object;
    public GameObject nextlevel_panel_object;

    public void Pause()
    {
        Time.timeScale = 0f;
        pause_panel_object.SetActive(true);
        basic_panel_object.SetActive(false);
    }
    public void Pause_Continue()
    {
        Time.timeScale = 1.0f;
        pause_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
    }
    public void Pause_Restart()
    {
        Time.timeScale = 1.0f;
        pause_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
        Parameter_3_script.birds_counts = 3;
        Enemy_3_controller.Enemy_count = 0;
        SceneManager.LoadScene(4);
    }
    public void Pause_Menu()
    {
        Time.timeScale = 1.0f;
        pause_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
        Parameter_3_script.birds_counts = 3;
        Enemy_3_controller.Enemy_count = 0;
        SceneManager.LoadScene(0);
    }
    public void Next_Restart()
    {
        Time.timeScale = 1.0f;
        nextlevel_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
        Parameter_3_script.birds_counts = 3;
        Enemy_3_controller.Enemy_count = 0;
        SceneManager.LoadScene(4);
    }
    public void Next_Menu()
    {
        Time.timeScale = 1.0f;
        nextlevel_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
        Parameter_3_script.birds_counts = 3;
        Enemy_3_controller.Enemy_count = 0;
        SceneManager.LoadScene(0);
    }
    public void Next_NextLevel()
    {
        Time.timeScale = 1;
        nextlevel_panel_object.SetActive(false);
        basic_panel_object.SetActive(true);
        Parameter_3_script.birds_counts = 3;
        Enemy_3_controller.Enemy_count = 0;
        SceneManager.LoadScene(5);///////////
    }
}

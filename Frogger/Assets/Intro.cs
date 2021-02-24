using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{

    public Dropdown dropDown;
    public InputField inputfield;
    public Slider slider;
    public void DropDownInput(int val)
    {
        if(dropDown.value == 0)
        {
            Frog.NumberofLives = 1;
        }
        else if(dropDown.value == 1)
        {
            Frog.NumberofLives = 2;
        }
        else if (dropDown.value == 2)
        {
            Frog.NumberofLives = 3;
        }
    }
    public void Slider(float val)
    {
        Car.speed = val;
        Debug.Log(val);
    }
    public void InputField(string val)
    {
        Frog.Name = val;
        Debug.Log(Frog.Name);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

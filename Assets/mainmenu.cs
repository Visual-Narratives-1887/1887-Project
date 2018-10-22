using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour {
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton;

    void Start()
    {
        if (m_YourFirstButton)
        {
            Button btn1 = m_YourFirstButton.GetComponent<Button>();
            btn1.onClick.AddListener(TaskOnClick);
        }
        if (m_YourSecondButton)
        {
            Button btn2 = m_YourSecondButton.GetComponent<Button>();
            btn2.onClick.AddListener(DontKnow);
        }

        //Calls the TaskOnClick/TaskWithParameters method when you click the Buttons
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("Maptest");
    }

    void DontKnow()
    {
        //Output this to console when the Button is clicked
        SceneManager.LoadScene("cradleSample");
    }

    void TaskWithParameters(string message)
    {
        //Output this to console when the Button is clicked
        Debug.Log(message);
    }

}

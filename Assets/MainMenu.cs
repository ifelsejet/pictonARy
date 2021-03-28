using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    string groupCode;
    InputField groupInputField;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void JoinGroup()
    {
        string code = groupInputField.textComponent.text;
        Debug.Log("Code = " + code);
    }

    public void onGroupCodeChange()
    {

    }
}

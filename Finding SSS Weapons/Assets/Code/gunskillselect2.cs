using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gunskillselect2 : MonoBehaviour
{
    public void SkillSelectButtonClicked()
    {
        PlayerPrefs.SetFloat("GunIndex", 2);
        ChangeToGameScene();
    }

    void ChangeToGameScene()
    {
        SceneManager.LoadScene("GameScens");
    }
}

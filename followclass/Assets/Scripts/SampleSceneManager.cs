using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SampleSceneManager : MonoBehaviour
{
    public Text uiTextCoin;
    public int coinCount = 0;
    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void SetTextCoin(int amount)
    {
        uiTextCoin.text = amount.ToString();
    }
}

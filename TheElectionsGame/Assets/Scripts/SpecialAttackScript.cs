using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SpecialAttackScript : MonoBehaviour
{
    public Slider slider;
    public int currentProgress;

    [SerializeField]
    private int playerIndex;

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    public void Start()
    {
        SetProgress(0);
    }

    private void Update()
    {
        Debug.Log(currentProgress);
    }

    public void SetMaxProgress(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetProgress(int progress)
    {
        slider.value = progress;
    }
    public void AddSpecialBarPoints(int points)
    {
        currentProgress += points;
        SetProgress(currentProgress);
    }
}

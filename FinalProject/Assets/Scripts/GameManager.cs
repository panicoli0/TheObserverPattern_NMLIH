﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject win;
    [SerializeField] Text hpUI;

    private void FixedUpdate()
    {
        HPUI();
    }

    private void HPUI()
    {
        hpUI.GetComponent<Text>().text = FindObjectOfType<PlayerHealth>().PlayerHP.ToString();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        OnStopGame();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game");
    }

    public void WinRule()
    {
        win.gameObject.SetActive(true);
        OnStopGame();
    }

    private static void OnStopGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

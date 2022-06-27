using BerkTerek3DProje1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.UIs
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.activeSelf)              // eðer gameOverPanel açýk ise onu kapatýyoruz
            {
                _gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnGameOver;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnGameOver;
        }

        private void HandleOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)              // eðer gameOverPanel kapalý ise onu açýyoruz
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}



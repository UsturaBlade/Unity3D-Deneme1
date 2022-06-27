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
            if (_gameOverPanel.activeSelf)              // e�er gameOverPanel a��k ise onu kapat�yoruz
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
            if (!_gameOverPanel.activeSelf)              // e�er gameOverPanel kapal� ise onu a��yoruz
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}



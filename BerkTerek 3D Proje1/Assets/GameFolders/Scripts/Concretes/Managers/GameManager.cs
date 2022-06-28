using BerkTerek3DProje1.Abstracts.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BerkTerek3DProje1.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucced;

        private void Awake()
        {
            SingletonThisGameObject(this);
        }

        public void GameOver()
        {
            //if(OnGameOver != null)
            //{
            //    GameOver();
            //}
            OnGameOver?.Invoke();
        }

        public void MissionSucced()
        {
            OnMissionSucced?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            SoundManager.Instance.StopSound(2);
            StartCoroutine(LoadMenuSceneAsync());
            SoundManager.Instance.PlaySound(1);
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }



        public void Exit()
        {
            Debug.Log("Exit process on triggered");
            Application.Quit();
        }
    }
}



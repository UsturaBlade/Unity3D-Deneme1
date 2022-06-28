using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BerkTerek3DProje1.Managers;

namespace BerkTerek3DProje1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _finishFireWork;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;

            if(other.GetContact(0).normal.y == -1)
            {
                
                _finishFireWork.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //GAMEOVER
                GameManager.Instance.GameOver();
            }
        }

    }
}


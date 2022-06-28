using BerkTerek3DProje1.Controllers;
using BerkTerek3DProje1.Managers;
using UnityEngine;

namespace BerkTerek3DProje1.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }

        }

        
    }
}


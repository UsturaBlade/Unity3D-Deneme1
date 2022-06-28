using BerkTerek3DProje1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.UIs
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void YesClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}



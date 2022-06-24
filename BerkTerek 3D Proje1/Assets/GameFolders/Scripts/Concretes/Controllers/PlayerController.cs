using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.Controllers
{
    
    public class PlayerController : MonoBehaviour
    {
        Rigidbody _rigitBody;
        
        
        private void Awake()
        {
            _rigitBody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            
        }

        private void FixedUpdate()
        {
            
        }

    }
}

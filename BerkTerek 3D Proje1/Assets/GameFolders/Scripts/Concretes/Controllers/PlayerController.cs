using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BerkTerek3DProje1.Inputs;

namespace BerkTerek3DProje1.Controllers
{
    
    
    public class PlayerController : MonoBehaviour
    {
        Rigidbody _rigitBody;
        DefaultInput _input;

        bool _isForceUp;
        [SerializeField] float _force;
        
         
        
        private void Awake()
        {
            _rigitBody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }

        private void Update()
        {
            if (_input.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
            
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _rigitBody.AddForce(Vector3.up * Time.fixedDeltaTime * _force);
            }
        }

    }
}

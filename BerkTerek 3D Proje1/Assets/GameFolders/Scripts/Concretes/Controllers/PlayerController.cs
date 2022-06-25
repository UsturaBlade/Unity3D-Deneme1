using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BerkTerek3DProje1.Inputs;
using BerkTerek3DProje1.Movements;

namespace BerkTerek3DProje1.Controllers
{
    
    
    public class PlayerController : MonoBehaviour
    {
        DefaultInput _input;
        Mover _mover;

        bool _isForceUp;
        
        
         
        
        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(rigidbody:GetComponent<Rigidbody>());
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
                _mover.FixedTick();
            }
        }

    }
}

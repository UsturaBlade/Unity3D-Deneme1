using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BerkTerek3DProje1.Inputs;
using BerkTerek3DProje1.Movements;

namespace BerkTerek3DProje1.Controllers
{
    
    
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 55f;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;




        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(playerController:this);
            _rotator = new Rotator(playerController:this);
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

            _leftRight = _input.LeftRight;
            
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
            }

            _rotator.FixedTick(_leftRight);
        }

    }
}

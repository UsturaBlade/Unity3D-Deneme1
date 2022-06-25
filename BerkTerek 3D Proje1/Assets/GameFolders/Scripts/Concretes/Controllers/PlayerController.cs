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
        Fuel _fuel;

        bool _canForceUp;
        float _leftRight;
        

        public float TurnSpeed => _turnSpeed;
        public float Force => _force;




        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(playerController:this);
            _rotator = new Rotator(playerController:this);
            _fuel = GetComponent<Fuel>();
        }

        private void Update()
        {
            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }

            _leftRight = _input.LeftRight;
            
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }

    }
}

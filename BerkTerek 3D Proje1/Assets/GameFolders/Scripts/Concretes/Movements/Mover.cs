using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BerkTerek3DProje1.Controllers;

namespace BerkTerek3DProje1.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;
        PlayerController _playerController;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.fixedDeltaTime * _playerController.Force);
        }
    }
}
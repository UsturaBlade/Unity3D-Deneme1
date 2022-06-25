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
            Debug.Log("movers fixed tick");
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
        }
    }
}
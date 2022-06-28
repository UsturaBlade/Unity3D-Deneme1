using BerkTerek3DProje1.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.Controllers
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;  // duvarýn gideceði yer

        [Range(0f, 1f)]
        [SerializeField] float _factor;

        Vector3 _startPosition;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;
        }
    }
}


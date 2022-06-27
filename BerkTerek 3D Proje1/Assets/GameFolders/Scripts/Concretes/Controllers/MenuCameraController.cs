using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.Controllers
{
    public class MenuCameraController : MonoBehaviour
    {
        [SerializeField] float _rotationSpeed;
        Vector3 _currentEulerAngles;
        Quaternion _currentRotation;
        private void Awake()
        {
            _rotationSpeed = 1.5f;
            _currentEulerAngles = new Vector3(0, 225, 0);
            _currentRotation.eulerAngles = _currentEulerAngles;
            this.gameObject.transform.rotation = _currentRotation;


        }

        private void FixedUpdate()
        {
            if(_currentRotation.eulerAngles.y < 135)
            {
                _rotationSpeed = -1 * _rotationSpeed;
            }
            else if(_currentRotation.eulerAngles.y > 225)
            {
                _rotationSpeed = -1 * _rotationSpeed;
            }
            

            _currentEulerAngles += new Vector3(0, 1, 0) * Time.deltaTime * _rotationSpeed;
            _currentRotation.eulerAngles = _currentEulerAngles;
            this.gameObject.transform.rotation = _currentRotation;


        }


    }
}


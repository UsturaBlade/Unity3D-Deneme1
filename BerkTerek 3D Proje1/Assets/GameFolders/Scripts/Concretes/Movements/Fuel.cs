using BerkTerek3DProje1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BerkTerek3DProje1.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel = 100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particle;


        public bool IsEmpty => _currentFuel < 1f;

        public float CurrentFuel => _currentFuel / _maxFuel;  // bu property Slider i�in current fuelimizin 0 ile 1 aras�ndaki de�erini g�nderir ( mesela 90 fuelimiz kald� diyeli 90 / 100 = 0.9)

        private void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);

            if (_particle.isPlaying)
            {
                _particle.Stop();
            }

            SoundManager.Instance.StopSound(0);
        }

        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0f);

            if (_particle.isStopped)
            {
                _particle.Play();
            }

            SoundManager.Instance.PlaySound(0);
        }
    }
}


using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;

namespace Akular
{
    public class ARMovementBehaviour : MonoBehaviour
    {
        [SerializeField]
        private ARSessionOrigin _arSessionOrigin = null;

        [SerializeField]
        private float _movementSpeed = 0.1f;

        private bool _isEnabled = false;

        private void Awake()
        {
            Assert.IsNotNull(_arSessionOrigin);
        }

        public void Move(Vector3 direction)
        {
            if (_isEnabled)
            {
                _arSessionOrigin.transform.position += _movementSpeed * direction * Time.deltaTime * Constants.TARGET_FPS;
            }
        }

        public void EnableMovement()
        {
            _isEnabled = true;
        }
    }
}
using UnityEngine;
using UnityEngine.EventSystems;

namespace Akular
{
    public abstract class ARMovementButtonBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private bool _isDown = false;
        private ARMovementBehaviour _arMovement;

        private void Awake()
        {
            _arMovement = transform.root.GetComponentInChildren<ARMovementBehaviour>();
        }

        private void Update()
        {
            if (_isDown)
            {
                _arMovement.Move(GetMovementDirection());
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _isDown = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isDown = false;
        }

        public abstract Vector3 GetMovementDirection();
    }
}
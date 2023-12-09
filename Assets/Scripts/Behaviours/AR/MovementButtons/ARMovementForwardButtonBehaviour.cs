using UnityEngine;

namespace Akular
{
    public class ARMovementForwardButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return Camera.main.transform.forward;
        }
    }
}
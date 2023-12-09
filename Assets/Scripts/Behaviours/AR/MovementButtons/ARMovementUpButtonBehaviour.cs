using UnityEngine;

namespace Akular
{
    public class ARMovementUpButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return Camera.main.transform.up;
        }
    }
}

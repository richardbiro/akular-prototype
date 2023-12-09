using UnityEngine;

namespace Akular
{
    public class ARMovementRightButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return Camera.main.transform.right;
        }
    }
}

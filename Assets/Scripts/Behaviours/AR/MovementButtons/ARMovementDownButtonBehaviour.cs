using UnityEngine;

namespace Akular
{
    public class ARMovementDownButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return -Camera.main.transform.up;
        }
    }
}

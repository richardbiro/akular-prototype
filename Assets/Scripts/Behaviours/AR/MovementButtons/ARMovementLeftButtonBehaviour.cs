using UnityEngine;

namespace Akular
{
    public class ARMovementLeftButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return -Camera.main.transform.right;
        }
    }
}
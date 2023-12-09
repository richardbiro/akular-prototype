using UnityEngine;

namespace Akular
{
    public class ARMovementBackButtonBehaviour : ARMovementButtonBehaviour
    {
        public override Vector3 GetMovementDirection()
        {
            return -Camera.main.transform.forward;
        }
    }
}

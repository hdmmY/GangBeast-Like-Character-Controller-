using UnityEngine;

public static class ApplyForceUtils
{
    /// <summary>
    /// Drag two body to different direction to straighten the body
    /// </summary>
    /// <param name="direction">straighten direction</param>
    public static void Straighten (PlayerCore.BodyInfo bodyA, PlayerCore.BodyInfo bodyB, Vector3 direction, float force, ForceMode forceMode)
    {
        if (bodyA.BodyRigid != null && bodyB.BodyRigid != null)
        {
            bodyA.BodyRigid.AddForce (direction * force, forceMode);
            bodyB.BodyRigid.AddForce (-direction * force, forceMode);
        }
    }

    /// <summary>
    /// Aligh body's forward direction to desire direction
    /// </summary>
    public static void AlignToVector (Rigidbody rig, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed, bool showForce = false)
    {
        if (rig == null) return;

        Vector3 torque = Vector3.Cross (
            Quaternion.AngleAxis (rig.angularVelocity.magnitude * 57 * stability / speed, rig.angularVelocity) * alignmentVector,
            targetVector * 10f);

        if (!float.IsNaN (torque.x) && !float.IsNaN (torque.y) && !float.IsNaN (torque.z))
        {
            rig.AddTorque (torque * speed * speed);

            if (showForce)
            {
                Debug.DrawRay (rig.position, alignmentVector * 0.2f, Color.red, 0f, false);
                Debug.DrawRay (rig.position, targetVector * 0.2f, Color.green, 0f, false);
            }
        }
    }

    /// <summary>
    /// Aligh body's forward direction to desire direction
    /// </summary>
    public static void AlignToVector (PlayerCore.BodyInfo body, Vector3 alignmentVector, Vector3 targetVector, float stability, float speed, bool showForce = false)
    {
        if (body == null) return;

        AlignToVector (body.BodyRigid, alignmentVector, targetVector, stability, speed, showForce);
    }
}
using BaseX;
using static FrooxEngine.CommonAvatar.AvatarRawEyeData;

namespace FrooxEngine
{
    [Category("Input/Mockup Devices")]
    public class MockupEyeDataSource : Component, IEyeDataSourceComponent
    {
        public readonly EyeData LeftEye;
        public readonly EyeData RightEye;
        public readonly EyeData CombinedEye;
        public bool IsEyeTrackingActive => LeftEye.IsTracking || RightEye.IsTracking;

        [Range(0f, 10f)]
        public readonly Sync<float> ConvergenceDistance;
        float IEyeDataSource.ConvergenceDistance => ConvergenceDistance.Value;

        public float3 GetDirection(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.Direction;
                case EyeSide.Right:
                    return RightEye.Direction;
                default:
                    return CombinedEye.Direction;
            }
        }

        public float GetFrown(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.Frown;
                case EyeSide.Right:
                    return RightEye.Frown;
                default:
                    return CombinedEye.Frown;
            }
        }

        public bool GetIsTracking(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.IsTracking;
                case EyeSide.Right:
                    return RightEye.IsTracking;
                default:
                    return CombinedEye.IsTracking;
            }
        }

        public float GetOpenness(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.Openness;
                case EyeSide.Right:
                    return RightEye.Openness;
                default:
                    return CombinedEye.Openness;
            }
        }

        public float3 GetPosition(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.Origin;
                case EyeSide.Right:
                    return RightEye.Origin;
                default:
                    return CombinedEye.Origin;
            }
        }

        public float GetPupilDiameter(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.PupilDiameter;
                case EyeSide.Right:
                    return RightEye.PupilDiameter;
                default:
                    return CombinedEye.PupilDiameter;
            }
        }

        public float GetSqueeze(EyeSide side)
        {
            switch (side)
            {
                case EyeSide.Left:
                    return LeftEye.Squeeze;
                case EyeSide.Right:
                    return RightEye.Squeeze;
                default:
                    return CombinedEye.Squeeze;
            }
        }

        public float GetWiden(EyeSide side)
        {
            return -1;
        }
    }
}

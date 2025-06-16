using UnityEngine;

public class WirelessEarPhone2 : WirelessEarPhone
{
    public bool isNoiseCancelling;

    public virtual void NoiseCancelling()
    {
        isNoiseCancelling = !isNoiseCancelling;

        string msg = isNoiseCancelling ? "노이즈 캔슬링 On" : "노이즈 캔슬링 Off";
        Debug.Log(msg);
    }
}

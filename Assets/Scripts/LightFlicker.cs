using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light lightToFlicker;
    public float flickerSpeed = 1.0f;
    public float minIntensity = 0.0f;
    public float maxIntensity = 1.0f; 
    
    private float _initialIntensity;

    void Start()
    {
        if (lightToFlicker == null)
        {
            lightToFlicker = GetComponent<Light>();
        }
        
        _initialIntensity = lightToFlicker.intensity;
        maxIntensity = _initialIntensity;
    }

    void Update()
    {
        float newIntensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PingPong(Time.time * flickerSpeed, 1.0f));
        
        lightToFlicker.intensity = newIntensity;
    }
}
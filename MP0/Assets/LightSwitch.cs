using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    private Light pointLight;

    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            float r = Random.Range(0.2f, 1f);
            float g = Random.Range(0.2f, 1f);
            float b = Random.Range(0.2f, 1f);

            pointLight.color = new Color(r, g, b);
        }
    }
}

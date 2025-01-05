using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.VFX;

public class VFXController : MonoBehaviour
{
    private VisualEffect visualEffect;

    [SerializeField]
    [Range(0, 100)]
    private Vector2 xScaleRange;
    [SerializeField] private PlayerMovement playerMovement;

    private void Start()
    {
        visualEffect = GetComponent<VisualEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        xScaleRange = new Vector2(playerMovement.speed, playerMovement.speed);
        visualEffect.SetVector2("XScaleRange(Large)", xScaleRange);
    }
}

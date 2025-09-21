using UnityEngine;
using UnityEngine.UI;

public class NPCEnergyLevel : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private float energyLevel;
    private float fillSpeed = 0.01f;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <energyLevel)
        {
            slider.value -= fillSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress (float reduceEnergy)
    {
        energyLevel = slider.value - reduceEnergy;
    }

}

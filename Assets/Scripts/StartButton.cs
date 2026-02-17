using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RawImage))]
[RequireComponent(typeof(AudioSource))]
public class StartButtonWithSound : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [Header("Scene")]
    public string sceneToLoad;

    [Header("Colors")]
    public Color normalColor = Color.white;
    public Color hoverColor = Color.gray;
    public Color clickColor = Color.green;

    [Header("Audio")]
    public AudioClip hoverSound;
    public AudioClip clickSound;

    private RawImage rawImage;
    private AudioSource audioSource;

    void Start()
    {
        rawImage = GetComponent<RawImage>();
        audioSource = GetComponent<AudioSource>();

        rawImage.color = normalColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        rawImage.color = hoverColor;

        if (hoverSound != null)
            audioSource.PlayOneShot(hoverSound);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        rawImage.color = normalColor;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        rawImage.color = clickColor;

        if (clickSound != null)
            audioSource.PlayOneShot(clickSound);

        // Small delay so click sound can be heard
        Invoke(nameof(LoadScene), 0.15f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}




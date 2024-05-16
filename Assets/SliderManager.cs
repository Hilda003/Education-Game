using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderManager : MonoBehaviour
{

    public Slider volumeSlider;
    private float volumeLevel = 0.5f; // Volume awal
    // Start is called before the first frame update
    void Start()
    {
        // Load volume yang disimpan sebelumnya
        if (PlayerPrefs.HasKey("VolumeLevel"))
        {
            volumeLevel = PlayerPrefs.GetFloat("VolumeLevel");
        }
        else
        {
            PlayerPrefs.SetFloat("VolumeLevel", volumeLevel);
        }

        // Atur nilai slider ke nilai volume yang disimpan
        volumeSlider.value = volumeLevel;

        // Pasang listener untuk mengubah volume saat slider diubah
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });

        // Terapkan volume awal
        ChangeVolume();
    }

    // Update is called once per frame
   void ChangeVolume()
    {
        // Ambil nilai dari slider
        volumeLevel = volumeSlider.value;

        // Terapkan volume ke semua sumber audio di game
        AudioListener.volume = volumeLevel;

        // Simpan nilai volume
        PlayerPrefs.SetFloat("VolumeLevel", volumeLevel);
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class ReklamScritp : MonoBehaviour
{
    private static ReklamScritp instance;
    public static ReklamScritp Instance { get { return instance; } }

    [SerializeField] string gameID = "33675";

    public void Awake()
    {
        Advertisement.Initialize(gameID, true);
        instance = this;
    }

    public void ShowAd(string zone = "")
    {
#if UNITY_EDITOR
        StartCoroutine(WaitForAd());
#endif

        if (string.Equals(zone, ""))
            zone = null;

        ShowOptions options = new ShowOptions();
        options.resultCallback = AdCallbackhandler;

        if (Advertisement.IsReady(zone))
            Advertisement.Show(zone, options);
    }

    public void AdCallbackhandler(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Ad Finished. Rewarding player...");
                //SceneManager.LoadScene("Game");
                break;
            case ShowResult.Skipped:
                Debug.Log("Ad skipped. Son, I am dissapointed in you");
                // Oyun kaldığı yerden devam etsin
                break;
            case ShowResult.Failed:
                Debug.Log("I swear this has never happened to me before");
                // Oyunu yeniden başlat(Kaldığı yerden başlamasıns)
                break;
        }
    }

    IEnumerator WaitForAd()
    {
        float currentTimeScale = Time.timeScale;
        Time.timeScale = 0f;
        yield return null;

        while (Advertisement.isShowing)
            yield return null;

        Time.timeScale = currentTimeScale;
    }
}

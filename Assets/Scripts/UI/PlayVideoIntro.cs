using UnityEngine;
using UnityEngine.Video;

public class PlayVideoIntro : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer; // ������ �� ��� Video Player

    void Start()
    {
        // ������������� �� ������� ��������� �����
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // ��������� ��������� ����� ����� ��������� �����
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}

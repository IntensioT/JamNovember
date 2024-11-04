using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoIntro : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer; // ������ �� ��� Video Player
    
    void Start()
    {
        // ������������� �� ������� ��������� �����
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void Update()
    {
        // ���������, ���� �� ������ ����� �������
        if (Input.anyKeyDown)
        {
            SkipVideo();
        }
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // ��������� ��������� ����� ����� ��������� �����
        LoadNextScene();
    }

    void SkipVideo()
    {
        // ������������� �����
        videoPlayer.Pause();

        // ��������� ��������� �����
        LoadNextScene();
    }

    void LoadNextScene()
    {
        // ��������� ��������� �����
        SceneManager.LoadScene(1);
    }
}

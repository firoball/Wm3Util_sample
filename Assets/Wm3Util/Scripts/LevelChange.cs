using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

namespace Wm3Util
{
    public class LevelChange : MonoBehaviour
    {
        private static int s_nextId = -1;
        private static GameObject s_player = null;
        private static string s_loadedScene = null;

        [SerializeField]
        private int m_id;
        [SerializeField]
        private int m_targetId;
        [SerializeField]
        private string m_targetSceneName;

        private bool m_activated = false;

        private void OnTriggerEnter(Collider other)
        {
            if (s_loadedScene != null)
            {
                s_loadedScene = null;
                return;
            }

            if (other.gameObject == s_player)
            {
                s_nextId = m_targetId;
                s_player = null;
                s_loadedScene = m_targetSceneName;
                SceneManager.LoadScene(m_targetSceneName);
            }
        }

        private void Start()
        {
            FindPlayer();
            if (s_nextId == m_id)
            {
                s_nextId = -1;
                SetupPlayer();
            }
        }

        private void FindPlayer()
        {
            if (s_player == null)
            {
                FirstPersonController controller = FindObjectOfType<FirstPersonController>();
                if (controller != null)
                {
                    s_player = controller.gameObject;
                }
                else
                {
                    Debug.LogError("player object not found.");
                }
            }
        }

        private void SetupPlayer()
        {
            s_player.transform.position = transform.position;
            s_player.transform.rotation = transform.rotation;
        }
    }
}

using UnityEngine;

namespace Bounds.Musica {

	public class MusicaDeFondo : MonoBehaviour {

		public AudioSource audioOBJ;

		public void Inicializar(string direccionRecursos, float volumen = 0.5f) {
			AudioClip audioClip = Resources.Load<AudioClip>(direccionRecursos);

			if (audioClip == null) {
				Debug.LogError($"No se encontró cargar el audio en '{direccionRecursos}'");
				return;
			}

			audioOBJ.clip = audioClip;
			audioOBJ.loop = true;
			audioOBJ.volume = volumen;
			audioOBJ.Play();
		}

	}

}
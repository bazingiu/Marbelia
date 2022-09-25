using UnityEngine;

public class GunManager : MonoBehaviour
{
    public Gun gun;
	public Gun mp5;
    public void disableShoot ()
    {
        gun.disableShoot();
		mp5.disableShoot();
    }

    public void enableShoot ()
    {
        gun.enableShoot();
		mp5.enableShoot();
    }
}

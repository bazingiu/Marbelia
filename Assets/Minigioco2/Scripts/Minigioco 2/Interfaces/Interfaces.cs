using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{ 
    public interface IKillable<T>
    {
        void Kill();
        void Hit(T damageTaken);
    }
}
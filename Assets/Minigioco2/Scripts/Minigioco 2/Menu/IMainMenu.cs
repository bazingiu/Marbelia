using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigioco2
{
    public interface IMainMenu { 
        void ExitButton();
        void SetVolume(float volume);
        void VolumeApply();
        void resetButton(string MenuType);
        void RestartButton();
    }
}

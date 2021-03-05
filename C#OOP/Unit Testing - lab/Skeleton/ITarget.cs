using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton
{
    public interface ITarget
    {
        bool IsDead();

        int GiveExperience();
        void TakeAttack(int damage);
    }
}

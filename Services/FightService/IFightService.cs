using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet7rpg_prep.Dtos.Fight;

namespace dotnet7rpg_prep.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    }
}
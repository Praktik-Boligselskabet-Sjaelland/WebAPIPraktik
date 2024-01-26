﻿using WebApp.Models;

namespace WebApp.Services.Interfaces
{
    public interface IPowerUseService
    {
        PowerUse GetPowerUseFromId(int Id);

        List<PowerUse> GetPowerUseFromUserId(int userId);

        bool CreatePowerUse(PowerUse powerUse);
    }
}
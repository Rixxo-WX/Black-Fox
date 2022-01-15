using System.Diagnostics;
using WeAreDevs_API;

namespace BlackFox
{
    public class Logic
    {
        bool fireActive,smokeActive,foreActive,sparklesActive,toolsActive = false;



        readonly ExploitAPI api = new ExploitAPI();
        public void Launch()
        {
            
            Debug.WriteLine("Starting Exploit");
            api.LaunchExploit();

            if (!(api.isAPIAttached()))
            {
                Debug.WriteLine("API not attached");
            }
        }
        public bool validation()
        {
            if (api.isAPIAttached())
                return true;
            else return false;
        }
        public void Fire()
        {
            if (!fireActive)
            {
                api.AddFire();
                fireActive = true;
            }
            else
            {
                api.RemoveFire();
                fireActive = false;
            }
        }
        public void Smoke()
        {
            if (!smokeActive)
            {
                api.AddSmoke();
                smokeActive = true;
            }
            else
            {
                api.RemoveSmoke();
                smokeActive = false;
            }
        }
        public void Sparkles()
        {
            if (!sparklesActive)
            {
                api.AddSparkles();
                sparklesActive = true;
            }
            else
            {
                api.RemoveSparkles();
                sparklesActive = false;
            }
        }
        public void ForceField()
        {
            if (!foreActive)
            {
                api.AddForcefield();
                foreActive = true;
            }
            else
            {
                api.RemoveForceField();
                foreActive = false;
            }
        }
        public void BuilderTools()
        {
            if (!toolsActive)
            {
                api.DoBTools();
                toolsActive = true;
            }
            else
                api.ConsoleWarn("Builder Tools already active");

        }
        public void Suicide()
        {
            api.Suicide();
        }
        public void TeleportToPlayer()
        {
        }
        public void RunLuaScript(string luaScript)
        {
            api.SendLuaScript(luaScript);
        }
        public void SuperSpeed(string speedValue)
        {
            api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=" + speedValue);
        }
    }
}

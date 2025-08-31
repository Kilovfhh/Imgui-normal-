using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using ImGuiNET;

namespace HackMenu
{
    public class Renderer : Overlay
    {
        // features 
        public bool godMod = false;
        public bool unlimitedAmmo = false;


        protected override void Render() // here we render stuff 
        {
            ImGui.Begin("Menu");

            ImGui.Checkbox("Godmode", ref godMod);
            ImGui.Checkbox("UnlimitedAmmo", ref  unlimitedAmmo);

            ImGui.End(); // This is required!


        }
    }
}
